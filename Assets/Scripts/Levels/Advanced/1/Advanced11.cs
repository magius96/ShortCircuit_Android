namespace Assets.Scripts.Levels
{
    class Advanced11 : GameLevel
    {
        public Advanced11()
            : base("Advanced11")
        {
            Initialize(3, 1);
            MapButtons = new int[,]
            {
                {OFF, LIT, OFF},
                {LIT, LIT, LIT},
                {OFF, LIT, OFF}
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced12(); }
        }
    }
}
