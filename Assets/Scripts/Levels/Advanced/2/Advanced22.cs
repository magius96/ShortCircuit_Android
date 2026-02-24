namespace Assets.Scripts.Levels
{
    class Advanced22 : GameLevel
    {
        public Advanced22()
            : base("Advanced22", "2-2")
        {
            Initialize(4, 8);
            MapButtons = new int[,]
            {
                {YLW, LIT, LIT, OFF},
                {LIT, YLW, YLW, YLW},
                {LIT, YLW, YLW, RED},
                {GRN, LIT, LIT, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced23();
            }
        }
    }
}
