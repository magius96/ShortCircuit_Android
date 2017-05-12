namespace Assets.Scripts.Levels
{
    class Classic23 : GameLevel
    {
        public Classic23()
            : base("Classic23")
        {
            Initialize(4, 5);
            MapButtons = new int[,]
            {
                {OFF, LIT, LIT, LIT},
                {LIT, LIT, OFF, LIT},
                {OFF, LIT, LIT, OFF},
                {LIT, LIT, LIT, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic24();
            }
        }
    }
}
