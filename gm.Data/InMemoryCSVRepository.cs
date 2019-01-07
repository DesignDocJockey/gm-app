using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using gm.api.Core.Commands;
using gm.api.Core.Models;
using gm.api.Core.Repository;
using gm.Core.Services;
using gm.Core.Services.FieldValidators;

namespace gm.Data.Repository
{
    public class InMemoryCSVRepository : ITimesheetRepository
    {
        private string _CSVFilePath;
        private List<Timesheet> _InMemoryTimeSheet;

        public InMemoryCSVRepository(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException();

            _CSVFilePath = filePath ?? throw new ArgumentNullException(nameof(filePath), $"cannot have null/ empty value for ${nameof(filePath)}");
            _InMemoryTimeSheet = File.ReadAllLines(filePath)
                                        .ToList()
                                        .Skip(1)
                                        .Select(i => MapLineItemToModel(i))
                                        .Where(j => j != null)
                                        .ToList();
        }

        public IEnumerable<Timesheet> GetAllTimeSheets() => _InMemoryTimeSheet;

        public Timesheet GetTimeSheetById(string timeSheetId)
        {
            if (!_InMemoryTimeSheet.Any(i => i.Uuid.ToString().Equals(timeSheetId.Trim())))
                return null;

            return _InMemoryTimeSheet.Find(i => i.Uuid.ToString().Equals(timeSheetId.Trim()));
        }

        public IEnumerable<Timesheet> GetTimeSheetByClientName(string clientName)
        {
            return _InMemoryTimeSheet.Where(i => i.Client.ToUpper().ToString().Equals(clientName.ToUpper().Trim()));
        }
    
        public CommandResponse UpdateTimeSheet(ITimesheetCommand command)
        {
            throw new NotImplementedException();
        }

        public CommandResponse CreateTimeSheet(ITimesheetCommand command)
        {
            throw new NotImplementedException();
        }


        private Timesheet MapLineItemToModel(string lineItem)
        {
            if (lineItem.Equals(string.Empty) || lineItem.Equals(",,,,,,,,,,,,,,,,,,"))
                return null;

            var lineValues = lineItem.Split(',');
            var timeSheet = new Timesheet();

            var dateFieldValidator = new DateFieldValidator();
            var clientFieldValidator = new ClientFieldValidator();
            var projFieldValidator = new ProjectFieldValidator();
            var projCodeValidator = new ProjectCodeFieldValidator();
            var taskFieldValidator = new TaskFieldValdidator();
            var hoursFieldValidator = new HoursFieldValdiator();
            var nameFieldValidator = new NameFieldValidator();
            var currencyFieldValidator = new CurrencyFieldValidator();
            var departmentValidator = new DepartmentFieldValidator();

            if (dateFieldValidator.IsFieldValid(lineValues[0]))
                timeSheet.Date = dateFieldValidator.DateField;

            if (clientFieldValidator.IsFieldValid(lineValues[1]))
                timeSheet.Client = clientFieldValidator.ClientField;

            if (projFieldValidator.IsFieldValid(lineValues[2]))
                timeSheet.Project = projFieldValidator.ProjectField;

            if (projFieldValidator.IsFieldValid(lineValues[3]))
                timeSheet.ProjectCode = projCodeValidator.ProjectCode;

            if (taskFieldValidator.IsFieldValid(lineValues[4]))
                timeSheet.Task = taskFieldValidator.TaskField;

            if (hoursFieldValidator.IsFieldValid(lineValues[5])) {
                timeSheet.Hours = hoursFieldValidator.HoursField;
                timeSheet.HoursRounded = hoursFieldValidator.HoursRounded;
            }

            timeSheet.IsBillable = CommonFieldValidator.ValidateYesNoField(lineValues[7]);
            timeSheet.Invoiced = CommonFieldValidator.ValidateYesNoField(lineValues[8]);
            timeSheet.Approved = CommonFieldValidator.ValidateYesNoField(lineValues[9]);

            if (nameFieldValidator.IsFieldValid(lineValues[10])) {
                timeSheet.FirstName = lineValues[10].Trim();
            }

            if (nameFieldValidator.IsFieldValid(lineValues[11])) {
                timeSheet.LastName = lineValues[11].Trim();
            }
 
            if (departmentValidator.IsFieldValid(lineValues[12])) {
                timeSheet.Department = lineValues[12].Trim();
            }

            timeSheet.IsEmployee = CommonFieldValidator.ValidateYesNoField(lineValues[13]);

            CommonFieldValidator.ValidateMonetaryAmount(lineValues[14],  out var billableRate);
            timeSheet.BillableRate = billableRate;

            CommonFieldValidator.ValidateMonetaryAmount(lineValues[15], out var costRate);
            timeSheet.CostRate = costRate;

            CommonFieldValidator.ValidateMonetaryAmount(lineValues[16], out var costAmt);
            timeSheet.CostAmount = costAmt;

            if (currencyFieldValidator.IsFieldValid(lineValues[17]))
                timeSheet.Currency = currencyFieldValidator.CurrencyField;

            timeSheet.ExternalReferenceURL = string.IsNullOrEmpty(lineValues[18]) ? string.Empty : lineValues[18];

            return timeSheet;
        }
    }
}
