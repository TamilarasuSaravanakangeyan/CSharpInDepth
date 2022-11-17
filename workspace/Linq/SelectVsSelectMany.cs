using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workspace.Linq
{
    class Consumer
    {
        public string? Name { get; set; }
        public List<string>? Skills { get; set; }
    }
    internal class SelectVsSelectMany
    {
        public void ReturnResponse()
        {
            List<Consumer> consumers = new List<Consumer>() { 
                new Consumer(){ Name="Tamil", Skills= new List<string>(){ ".net","Java"} },
                new Consumer(){ Name="Swathi", Skills= new List<string>(){ ".net","UI/UX"} }
            };
            IEnumerable<List<string>> consumers1 = consumers.Select(x => x.Skills);
            foreach (var item in consumers1)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
            }

            IEnumerable<string> consumers2 = consumers.SelectMany(x => x.Skills);
            foreach (var item in consumers2)
            {
                Console.WriteLine(item);

            }
        }

    }
}
