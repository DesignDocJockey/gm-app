using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using gm.api.Core.Commands;
using gm.api.Core.Models;
using gm.api.Core.Queries;
using gm.api.Core.Repository;
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

        public IEnumerable<Timesheet> GetTimeSheetByClientId(string clientName)
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

            if (hoursFieldValidator.IsFieldValid(lineValues[5]))
            {
                timeSheet.Hours = hoursFieldValidator.HoursField;
                timeSheet.HoursRounded = hoursFieldValidator.HoursRounded;
            }
            
            //public bool IsBillable { get; set; }
            //public bool Invoiced { get; set; }
            //public bool Approved { get; set; }
            //public string FirstName { get; set; }
            //public string LastName { get; set; }
            //public string Department { get; set; }
            //public bool IsEmployee { get; set; }
            //public double BillableRate { get; set; }
            //public double CostRate { get; set; }
            //public double CostAmount { get; set; }
            //public double Currency { get; set; }
            //public string ExternalReferenceURL { get; set; }

            return timeSheet;
        }
    }
}
