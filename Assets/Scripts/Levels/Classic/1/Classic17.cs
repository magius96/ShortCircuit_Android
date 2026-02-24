namespace Assets.Scripts.Levels
{
    class Classic17 : GameLevel
    {
        public Classic17()
            : base("Classic17", "1-7")
        {
            Initialize(3, 4);
            MapButtons = new int[,]
            {
                {OFF, OFF, OFF},
                {OFF, OFF, LIT},
                {OFF, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic21();
            }
        }
    }
}
