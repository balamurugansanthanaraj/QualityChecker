using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Webhooks.Models.Events;

namespace Webhooks.Handlers
{
    public class GithubWebookHandler : WebHookHandler
    {        
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            if (!receiver.Equals("GitHub", StringComparison.CurrentCultureIgnoreCase)) return Task.FromResult(true);
            var action = context.Actions.First();
            //JObject data = context.GetDataOrDefault<JObject>();
            //var dataAsString = Newtonsoft.Json.JsonConvert.SerializeObject(data);                
            var createEvent= context.GetDataOrDefault<CreateEvent>();
            return Task.FromResult(true);
        }
    }
}