using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Name = "汽车A" };
            car.Run();
            car.SpeedDown();
            car.SpeedUp();
            car.Stop();
        }
    }
}
