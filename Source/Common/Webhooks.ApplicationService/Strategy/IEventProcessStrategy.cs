using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webhooks.ApplicationService.Strategy
{
    public interface IEventProcessStrategy
    {
        void Process(object data);
    }
}
