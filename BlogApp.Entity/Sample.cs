using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectManagement.Entity
{
    public class Sample
    {
        public int SampleId { get; set; }

        public string Customer { get; set; }

        public string Size { get; set; }

        public string SampleState { get; set; }

        public string SampleType { get; set; }

        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
