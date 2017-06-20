using System;

namespace StatePattern
{
    /// <summary>
    /// 加速可以减速或停车
    /// </summary>
    public class SpeedUpState : ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine("正在行驶");
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("减速");
            car.CurrentCarState = Car.SpeedDownState;
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("加速");
        }

        public void Stop(Car car)
        {
            Console.WriteLine("停止");
            car.CurrentCarState = Car.StopSate;            
        }
    }
}
