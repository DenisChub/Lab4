using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Subscriber
    {
        public Subscriber(EventBus eventBus, int priority)
        {
            eventBus.Subscribe(priority, CustomEventHandler);
        }

        private void CustomEventHandler(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Оборблення події '{e.Name}' з пріоритетом {e.Priority}: {e.Data}");
        }
    }
}
