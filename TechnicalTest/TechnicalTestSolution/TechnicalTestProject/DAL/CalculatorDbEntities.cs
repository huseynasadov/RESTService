using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TechnicalTestProject.Models;

namespace TechnicalTestProject.DAL
{
    public class CalculatorDbEntities : DbContext
    {
        public CalculatorDbEntities() : base("CalculatorConnection")
        {

        }
        public DbSet<Call> Calls { get; set; }
        public DbSet<CallSteps> CallSteps { get; set; }
    }
}