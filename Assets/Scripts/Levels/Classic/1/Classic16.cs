

namespace Assets.Scripts.Levels
{
    class Classic16 : GameLevel
    {
        public Classic16()
            : base("Classic16")
        {
            Initialize(3, 3);
            MapButtons = new int[,]
            {
                {OFF, LIT, OFF},
                {LIT, LIT, LIT},
                {LIT, OFF, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic17();
            }
        }
    }
}
