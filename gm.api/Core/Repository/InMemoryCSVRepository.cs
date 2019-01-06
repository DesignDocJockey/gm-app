﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using gm.api.Core.Commands;
using gm.api.Core.Models;
using gm.api.Core.Queries;

namespace gm.api.Core.Repository
{
    public class InMemoryCSVRepository : ITimesheetRepository
    {
        private string _CSVFilePath;
        private List<Timesheet> _InMemoryTimeSheet;

        private Timesheet MapLineItemToModel(string lineItem) {
            return new Timesheet();
        }

        public InMemoryCSVRepository(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException();

            _CSVFilePath = filePath ?? throw new ArgumentNullException(nameof(filePath), $"cannot have null/ empty value for ${nameof(filePath)}");
            _InMemoryTimeSheet = File.ReadAllLines(filePath)
                                        .ToList()
                                        .Skip(1)
                                        .Select(i => MapLineItemToModel(i))
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
    }
}