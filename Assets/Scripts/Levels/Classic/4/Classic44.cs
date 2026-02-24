namespace Assets.Scripts.Levels
{
    class Classic44 : GameLevel
    {
        public Classic44()
            : base("Classic44", "4-4")
        {
            Initialize(6, 13);
            MapButtons = new int[,]
            {
                {LIT, LIT, LIT, LIT, LIT, LIT},
                {OFF, OFF, LIT, LIT, OFF, OFF},
                {LIT, LIT, OFF, OFF, LIT, OFF},
                {OFF, LIT, LIT, OFF, LIT, LIT},
                {LIT, LIT, LIT, OFF, LIT, LIT},
                {OFF, OFF, OFF, LIT, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic45();
            }
        }
    }
}
