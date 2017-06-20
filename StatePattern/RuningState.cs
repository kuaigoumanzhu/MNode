using System;

namespace StatePattern
{
    /// <summary>
    /// 运行状态下可以切换到其他三种状态
    /// </summary>
    public class RuningState : ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine("正在行驶");
        }
        public void Stop(Car car)
        {
            Console.WriteLine("加速");
            car.CurrentCarState = Car.StopSate;
        }
        public void SpeedDown(Car car)
        {
            Console.WriteLine("停止");
            car.CurrentCarState = Car.SpeedUpState;
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("减速");
            car.CurrentCarState = Car.SpeedDownState;
        }        
    }
}
