using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IGreetable
    {
        string SayHello();
    }

    public class Client : IGreetable
    {
        public string Name { get; set; }

        public string SayHello()
        {
            return $"Hello {Name}";
        }
    }

    public class VIPClient : IGreetable
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public string SayHello()
        {
            return $"Hello VIP ({Status}) {Name}";
        }
    }
}
