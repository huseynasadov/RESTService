using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnicalTestProject.DAL;
using TechnicalTestProject.Models;
using TechnicalTestProject.UnitCalculator;

namespace TechnicalTestProject.Controllers
{
    public class CalculatorController : ApiController
    {
        private readonly CalculatorDbEntities db = new CalculatorDbEntities();
        Logger Logger = LogManager.GetCurrentClassLogger();
        // Add 
        [HttpGet]
        [Route("api/calculator/add")]
        public IHttpActionResult Add(int intA, int intB)
        {
            if (!ModelState.IsValid)
            {
                Logger.Error(BadRequest());
                return BadRequest();
            }

            Call call = new Call
            {
                Insert_date = DateTime.Now
            };
            db.Calls.Add(call);
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {

                Logger.Error(e);
            }
           
            CallSteps step = new CallSteps()
            {
                ParentId = call.Id,
                Insert_date = DateTime.Now,
                Value = DateTime.Now.ToString("dd.MM HH:mm:ss") + " - Call " + call.Id + ". Request to JSON"
            };

            Logger.Info(step.Value);

            db.CallSteps.Add(step);

            step = new CallSteps();
            step.ParentId = call.Id;
            step.Insert_date = DateTime.Now;
            step.Value = step.Insert_date.ToString("dd.MM HH:mm:ss") + " - Call " + call.Id + ". Request to SOAP";
            db.CallSteps.Add(step);
            Logger.Info(step.Value);
            int res = 0;

            CalculatorSoapClient calc = new CalculatorSoapClient();

            step = new CallSteps();
            step.ParentId = call.Id;
            step.Insert_date = DateTime.Now;
            step.Value = step.Insert_date.ToString("dd.MM HH:mm:ss") + " - Call Id : " + call.Id + ". Response from SOAP";
            db.CallSteps.Add(step);
            Logger.Info(step.Value);
            try
            {
                res = calc.Add(intA, intB);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
            }

            return Json(res);
        }

        // Divide
        [HttpGet]
        [Route("api/calculator/divide")]
        public IHttpActionResult Divide(int intA, int intB)
        {
            if (!ModelState.IsValid)
            {
                Logger.Error(BadRequest());
                return BadRequest();
            }

            Call call = new Call
            {
                Insert_date = DateTime.Now
            };
            db.Calls.Add(call);
            try
            {
            db.SaveChanges();
            }
            catch (Exception e)
            {
                Logger.Error(e);
            }

            CallSteps step = new CallSteps()
            {
                ParentId = call.Id,
                Insert_date = DateTime.Now,
                Value = DateTime.Now.ToString("dd.MM HH:mm:ss") + " - CallDivide " + call.Id + ". Request to JSON"
            };
            Logger.Info(step.Value);
            db.CallSteps.Add(step);

            step = new CallSteps();
            step.ParentId = call.Id;
            step.Insert_date = DateTime.Now;
            step.Value = step.Insert_date.ToString("dd.MM HH:mm:ss") + " - CallDivide " + call.Id + ". Request to SOAP";
            Logger.Info(step.Value);
            db.CallSteps.Add(step);

            CalculatorSoapClient calc = new CalculatorSoapClient();
            step = new CallSteps();
            step.ParentId = call.Id;
            step.Insert_date = DateTime.Now;
            step.Value = step.Insert_date.ToString("dd.MM HH:mm:ss") + " - CallDivide " + call.Id + ". Response from SOAP";
            Logger.Info(step.Value);
            db.CallSteps.Add(step);
            double res = 0;
            try
            {
                res = calc.Divide(intA, intB);

                db.SaveChanges();
            }
            catch (Exception e)
            {

                Logger.Error(e);
            }
          
            return Json(res);
        }

        // Multiply
        [HttpGet]
        [Route("api/calculator/multiply")]
        public IHttpActionResult Multiply(int intA, int intB)
        {
            if (!ModelState.IsValid)
            {
                Logger.Error(BadRequest());
                return BadRequest();
            }

            Call call = new Call
            {
                Insert_date = DateTime.Now
            };
            db.Calls.Add(call);
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Logger.Error(e);
            }
            
            CallSteps step = new CallSteps()
            {
                ParentId = call.Id,
                Insert_date = DateTime.Now,
                Value = DateTime.Now.ToString("dd.MM HH:mm:ss") + " - CallMultiply " + call.Id + ". Request to JSON"
            };
            Logger.Info(step.Value);
            db.CallSteps.Add(step);

            step = new CallSteps();
            step.ParentId = call.Id;
            step.Insert_date = DateTime.Now;
            step.Value = step.Insert_date.ToString("dd.MM HH:mm:ss") + " - CallMultiply " + call.Id + ". Request to SOAP";
            Logger.Info(step.Value);
            db.CallSteps.Add(step);

            CalculatorSoapClient calc = new CalculatorSoapClient();

            step = new CallSteps();
            step.ParentId = call.Id;
            step.Insert_date = DateTime.Now;
            step.Value = step.Insert_date.ToString("dd.MM HH:mm:ss") + " - CallMultiply " + call.Id + ". Response from SOAP";
            Logger.Info(step.Value);
            db.CallSteps.Add(step);
            double res = 0;
            try
            {
                res = calc.Multiply(intA, intB);

                db.SaveChanges();
            }
            catch (Exception e)
            {
                Logger.Error(e);
            }
            

            return Json(res);
        }

        //Subtract
        [HttpGet]
        [Route("api/calculator/subtract")]
        public IHttpActionResult Subtract(int intA, int intB)
        {
            if (!ModelState.IsValid)
            {
                Logger.Error(BadRequest());
                return BadRequest();
            }

            Call call = new Call
            {
                Insert_date = DateTime.Now
            };
            db.Calls.Add(call);
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Logger.Error(e);
            }

            CallSteps step = new CallSteps()
            {
                ParentId = call.Id,
                Insert_date = DateTime.Now,
                Value = DateTime.Now.ToString("dd.MM HH:mm:ss") + " - CallSubtract " + call.Id + ". Request to JSON"
            };
            Logger.Info(step.Value);
            db.CallSteps.Add(step);

            step = new CallSteps();
            step.ParentId = call.Id;
            step.Insert_date = DateTime.Now;
            step.Value = step.Insert_date.ToString("dd.MM HH:mm:ss") + " - CallSubtract " + call.Id + ". Request to SOAP";
            Logger.Info(step.Value);
            db.CallSteps.Add(step);

            CalculatorSoapClient calc = new CalculatorSoapClient();

            step = new CallSteps();
            step.ParentId = call.Id;
            step.Insert_date = DateTime.Now;
            step.Value = step.Insert_date.ToString("dd.MM HH:mm:ss") + " - CallSubtract " + call.Id + ". Response from SOAP";
            Logger.Info(step.Value);
            db.CallSteps.Add(step);
            double res = 0;
            try
            {
                res = calc.Subtract(intA, intB);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Logger.Error(e);
            }
            return Json(res);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
