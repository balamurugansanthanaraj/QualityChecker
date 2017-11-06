using System;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;

namespace Github.Webhook.Handler
{
    public class GithubWebookHandler : WebHookHandler
    {        
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            if (!receiver.Equals("GitHub", StringComparison.CurrentCultureIgnoreCase)) return Task.FromResult(true);

            var eventProcesser=new EventProcessService();
            eventProcesser.Process(context.Actions, context.Data);

            return Task.FromResult(true);
        }
    }
  
}