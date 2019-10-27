using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechnicalTestProject.Models
{
    public class CallSteps
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Call")]
        public int ParentId { get; set; }
        public Call Call { get; set; }
        public DateTime Insert_date{ get; set; }
        public string Value{ get; set; }
    }
}