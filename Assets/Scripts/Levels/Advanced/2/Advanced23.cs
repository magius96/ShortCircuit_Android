namespace Assets.Scripts.Levels
{
    class Advanced23 : GameLevel
    {
        public Advanced23()
            : base("Advanced23", "2-3")
        {
            Initialize(4, 8);
            MapButtons = new int[,]
            {
                {GRN, OFF, OFF, GRN},
                {OFF, GRN, GRN, OFF},
                {OFF, GRN, GRN, OFF},
                {GRN, OFF, OFF, GRN},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced24();
            }
        }
    }
}
