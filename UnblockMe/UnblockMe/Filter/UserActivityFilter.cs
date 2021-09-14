using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Filter
{
    public class UserActivityFilter : IActionFilter
    {
        private readonly UnblockMeContext _context;
        public UserActivityFilter(UnblockMeContext context)
        {
            _context = context;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var data = "";
            var controllerName = context.RouteData.Values["controller"];
            var actionName = context.RouteData.Values["action"];

            var url = $"{controllerName}/{actionName}";

            if (!string.IsNullOrEmpty(context.HttpContext.Request.QueryString.Value))
            {
                data = context.HttpContext.Request.QueryString.Value;
            }
            else
            {
                KeyValuePair<string, object> userData = context.ActionArguments.FirstOrDefault();
                var stringUserData = userData.Equals(default(KeyValuePair<string, object>)) ? "" : JsonConvert.SerializeObject(userData);
                data = stringUserData;
            }

            var userName = context.HttpContext.User.Identity.Name;

            var ipAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();

            StoreUserActivity(data, url, userName, ipAddress);
        }

        public void StoreUserActivity(string data, string url, string userName, string ipAddress)
        {
            var userActivity = new UserActivity
            {
                Id = Guid.NewGuid().ToString(),
                Data = data,
                Url = url,
                UserName = userName,
                IpAddress = ipAddress
            };

            _context.UserActivities.Add(userActivity);
            _context.SaveChanges();
        }
    }
}
