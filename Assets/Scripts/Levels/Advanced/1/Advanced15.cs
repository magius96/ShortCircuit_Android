namespace Assets.Scripts.Levels
{
    class Advanced15 : GameLevel
    {
        public Advanced15()
            : base("Advanced15", "1-5")
        {
            Initialize(3, 4);
            MapButtons = new int[,]
            {
                {YLW, OFF, YLW},
                {OFF, RED, OFF},
                {YLW, OFF, YLW},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced16();
            }
        }
    }
}
