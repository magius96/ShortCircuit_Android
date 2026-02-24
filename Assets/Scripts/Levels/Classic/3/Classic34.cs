namespace Assets.Scripts.Levels
{
    class Classic34 : GameLevel
    {
        public Classic34()
            : base("Classic34", "3-4")
        {
            Initialize(5, 5);
            MapButtons = new int[,]
            {
                {OFF, OFF, OFF, LIT, OFF},
                {LIT, LIT, OFF, LIT, LIT},
                {OFF, LIT, OFF, LIT, OFF},
                {LIT, LIT, OFF, LIT, LIT},
                {OFF, OFF, OFF, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic35();
            }
        }
    }
}
