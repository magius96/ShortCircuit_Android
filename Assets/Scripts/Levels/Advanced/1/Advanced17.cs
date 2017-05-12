namespace Assets.Scripts.Levels
{
    class Advanced17 : GameLevel
    {
        public Advanced17()
            : base("Advanced17")
        {
            Initialize(3, 5);
            MapButtons = new int[,]
            {
                {YLW, GRN, YLW},
                {OFF, LIT, OFF},
                {GRN, LIT, GRN},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced21();
            }
        }
    }
}
