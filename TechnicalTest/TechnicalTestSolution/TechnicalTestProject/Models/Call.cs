using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechnicalTestProject.Models
{
    public class Call
    {
        public int Id { get; set; }
        public DateTime Insert_date { get; set; }
        public List<CallSteps> CallSteps { get; set; }
    }
}