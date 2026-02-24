namespace Assets.Scripts.Levels
{
    class Advanced33 : GameLevel
    {
        public Advanced33()
            : base("Advanced33", "3-3")
        {
            Initialize(5, 8);
            MapButtons = new int[,]
            {
                {OFF, LIT, YLW, LIT, OFF},
                {OFF, GRN, LIT, GRN, OFF},
                {LIT, RED, OFF, RED, LIT},
                {OFF, GRN, LIT, GRN, OFF},
                {OFF, LIT, YLW, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced34();
            }
        }
    }
}
