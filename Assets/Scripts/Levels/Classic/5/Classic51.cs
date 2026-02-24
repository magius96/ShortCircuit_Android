namespace Assets.Scripts.Levels
{
    class Classic51 : GameLevel
    {
        public Classic51()
            : base("Classic51", "5-1")
        {
            Initialize(7, 13);
            MapButtons = new int[,]
            {
                {OFF, LIT, LIT, LIT, LIT, OFF, OFF},
                {LIT, LIT, LIT, LIT, OFF, LIT, OFF},
                {OFF, OFF, OFF, OFF, OFF, OFF, LIT},
                {OFF, OFF, OFF, LIT, OFF, OFF, OFF},
                {OFF, OFF, OFF, OFF, OFF, LIT, OFF},
                {OFF, OFF, LIT, OFF, OFF, OFF, OFF},
                {OFF, OFF, LIT, OFF, LIT, OFF, OFF}
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic52();
            }
        }
    }
}
