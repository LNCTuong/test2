using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2.services
{
    public class HelloService
    {
        public string GetHelloMessage(string name)
        {
            return $"Xin chào {name}, đây là message từ Service!";
        }
    }
}
