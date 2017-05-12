namespace Assets.Scripts.Levels
{
    class Advanced32 : GameLevel
    {
        public Advanced32()
            : base("Advanced32")
        {
            Initialize(5, 13);
            MapButtons = new int[,]
            {
                {OFF, GRN, GRN, GRN, OFF},
                {GRN, RED, LIT, RED, GRN},
                {GRN, LIT, YLW, LIT, GRN},
                {GRN, RED, LIT, RED, GRN},
                {OFF, GRN, GRN, GRN, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced33();
            }
        }
    }
}
