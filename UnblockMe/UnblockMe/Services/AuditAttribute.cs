using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;


namespace UnblockMe.Services
{
    public class AuditAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Stores the Request in an Accessible object
            var request = filterContext.HttpContext.Request;
            //Generate an audit
            Audit audit = new Audit()
            {
                //Your Audit Identifier     
                AuditID = Guid.NewGuid(),
                //Our Username (if available)
                UserName = filterContext.HttpContext.User.Identity.Name,
                //The IP Address of the Request
                //IPAddress = request.ServerVariables["HTTP_X_FORWARDED_FOR"] ?? request.UserHostAddress,
                //The URL that was accessed
                //AreaAccessed = request.RawUrl,

                //Creates our Timestamp
                TimeAccessed = DateTime.UtcNow
            };

            //Stores the Audit in the Database
            var _context = new AuditingContext();
            _context.AuditRecords.Add(audit);
            _context.SaveChanges();

            //Finishes executing the Action as normal 
            base.OnActionExecuting(filterContext);
        }
    }
    //Example AuditingContext 
    public class AuditingContext : UnblockMeContext
    {

    }
}
