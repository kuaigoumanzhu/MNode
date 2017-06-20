namespace StatePattern
{
    public class Car
    {
        public string Name { get; set; }

        public Car()
        {
            this.CurrentCarState = StopSate;//初始状态为停车状态    
        }
        /*
         * 预先申明并实例化了几种状态并暴露设置当前状态的属性
         * 以及提供了状态对应的行为方法，并委托给具体的状态去执行
         */
        internal static ICarState StopSate = new StopState();
        internal static ICarState RunState = new RuningState();
        internal static ICarState SpeedDownState = new SpeedDownState();
        internal static ICarState SpeedUpState = new SpeedUpState();

        public ICarState CurrentCarState { get; set; }

        public void Run()
        {
            this.CurrentCarState.Drive(this);
        }

        public void Stop()
        {
            this.CurrentCarState.Stop(this);
        }

        public void SpeedUp()
        {
            this.CurrentCarState.SpeedUp(this);
        }

        public void SpeedDown()
        {
            this.CurrentCarState.SpeedDown(this);
        }
    }
}
