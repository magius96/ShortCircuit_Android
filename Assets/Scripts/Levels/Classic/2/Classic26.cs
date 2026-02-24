namespace Assets.Scripts.Levels
{
    class Classic26 : GameLevel
    {
        public Classic26()
            : base("Classic26", "2-6")
        {
            Initialize(4, 8);
            MapButtons = new int[,]
            {
                {LIT, OFF, OFF, LIT},
                {OFF, LIT, LIT, OFF},
                {OFF, LIT, LIT, OFF},
                {LIT, OFF, OFF, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic27();
            }
        }
    }
}
