namespace Assets.Scripts.Levels
{
    class Classic52 : GameLevel
    {
        public Classic52()
            : base("Classic52")
        {
            Initialize(7, 11);
            MapButtons = new int[,]
            {
                {OFF, OFF, LIT, OFF, LIT, OFF, OFF},
                {OFF, LIT, LIT, OFF, LIT, LIT, OFF},
                {LIT, LIT, OFF, LIT, OFF, LIT, LIT},
                {OFF, OFF, LIT, LIT, LIT, OFF, OFF},
                {OFF, LIT, OFF, LIT, OFF, LIT, OFF},
                {LIT, LIT, OFF, LIT, OFF, LIT, LIT},
                {OFF, OFF, LIT, OFF, LIT, OFF, OFF}
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic53();
            }
        }
    }
}
