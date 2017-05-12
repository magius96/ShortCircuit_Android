

namespace Assets.Scripts.Levels
{
    class Classic15 : GameLevel
    {
        public Classic15()
            : base("Classic15")
        {
            Initialize(3, 3);
            MapButtons = new int[,]
            {
                {LIT, OFF, LIT},
                {OFF, OFF, LIT},
                {LIT, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic16();
            }
        }
    }
}
