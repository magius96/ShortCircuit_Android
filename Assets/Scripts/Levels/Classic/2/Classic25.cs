namespace Assets.Scripts.Levels
{
    class Classic25 : GameLevel
    {
        public Classic25()
            : base("Classic25")
        {
            Initialize(4, 4);
            MapButtons = new int[,]
            {
                {LIT, LIT, LIT, LIT},
                {LIT, LIT, LIT, LIT},
                {LIT, LIT, LIT, LIT},
                {LIT, LIT, LIT, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic26();
            }
        }
    }
}
