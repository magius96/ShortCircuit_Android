namespace Assets.Scripts.Levels
{
    class Advanced13 : GameLevel
    {
        public Advanced13()
            : base("Advanced13", "1-3")
        {
            Initialize(3, 3);
            MapButtons = new int[,]
            {
                {LIT, OFF, OFF},
                {RED, YLW, YLW},
                {LIT, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced14();
            }
        }
    }
}
