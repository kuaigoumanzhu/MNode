using System;

namespace StatePattern
{
    /// <summary>
    /// 减速可以加速或停车
    /// </summary>
    public class SpeedDownState : ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine("正在行驶");
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("减速");
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("加速");
            car.CurrentCarState = Car.SpeedUpState;
        }

        public void Stop(Car car)
        {
            Console.WriteLine("停止");
            car.CurrentCarState = Car.StopSate;            
        }
    }
}
