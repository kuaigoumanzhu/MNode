using System;

namespace StatePattern
{
    /// <summary>
    /// 停车状态只能切换到启动状态
    /// </summary>
    public class StopState : ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine($"{car.Name}正在行驶");
            car.CurrentCarState = Car.RunState;
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("减速");
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("加速");
        }

        public void Stop(Car car)
        {
            Console.WriteLine("停止");
        }
    }
}
