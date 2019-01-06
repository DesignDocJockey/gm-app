using System;

namespace gm.api.Core.Models
{
    public class Timesheet : Entity
    {
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public string Project { get; set; }
        public string ProjectCode { get; set; }
        public string Task { get; set; }
        public float Hours { get; set; }
        public int HoursRounded {get;set;}
        public bool IsBillable { get; set; }
        public bool Invoiced { get; set; }
        public bool Approved { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public bool IsEmployee { get; set; }
        public double BillableRate { get; set; }
        public double CostRate { get; set; }
        public double CostAmount { get; set; }
        public double Currency { get; set; }
        public string ExternalReferenceURL { get; set; }
    }
}
