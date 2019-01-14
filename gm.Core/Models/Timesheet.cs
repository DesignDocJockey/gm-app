using System;

namespace gm.Core.Models
{
    public class Timesheet : Entity
    {
        public Timesheet()
        { }

        public DateTime Date { get; set; }
        public string Client { get; set; }
        public string Project { get; set; }
        public string ProjectCode { get; set; }
        public string Task { get; set; }
        public double Hours { get; set; }
        public double HoursRounded {get;set;}
        public bool IsBillable { get; set; }
        public bool Invoiced { get; set; }
        public bool Approved { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public bool IsEmployee { get; set; }
        public decimal BillableRate { get; set; }
        public decimal CostRate { get; set; }
        public decimal CostAmount { get; set; }
        public string Currency { get; set; }
        public string ExternalReferenceURL { get; set; }
    }
}
