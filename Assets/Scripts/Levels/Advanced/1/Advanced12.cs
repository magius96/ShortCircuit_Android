namespace Assets.Scripts.Levels
{
    class Advanced12 : GameLevel
    {
        public Advanced12()
            : base("Advanced12")
        {
            Initialize(3, 2);
            MapButtons = new int[,]
            {
                {OFF, LIT, YLW},
                {LIT, GRN, OFF},
                {RED, LIT, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced13();
            }
        }
    }
}
