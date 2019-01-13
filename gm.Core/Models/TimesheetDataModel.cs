using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace gm.Core.Models
{
    [Table("TimeSheets")]
    public class TimesheetDataModel
    {
        public Guid Uuid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(255)]
        public string Client { get; set; }

        [Required]
        [StringLength(255)]
        public string Project { get; set; }

        [Required]
        [StringLength(255)]
        public string ProjectCode { get; set; }

        [Required]
        [StringLength(255)]
        public string Task { get; set; }

        public double Hours { get; set; } = 0.0;
        public double HoursRounded { get; set; } = 0.0;

        public bool IsBillable { get; set; } = false;
        public bool Invoiced { get; set; } = false;
        public bool Approved { get; set; } = false;

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        public string Department { get; set; } = string.Empty;
        public bool IsEmployee { get; set; } = true;

        public decimal BillableRate { get; set; } = 0.0M;
        public decimal CostRate { get; set; } = 0.0M;
        public decimal CostAmount { get; set; } = 0.0M;
        public string Currency { get; set; } = "United States Dollar - USD";
        public string ExternalReferenceURL { get; set; } = string.Empty;
    }
}
