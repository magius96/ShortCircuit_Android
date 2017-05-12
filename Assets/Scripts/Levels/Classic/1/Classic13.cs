

namespace Assets.Scripts.Levels
{
    class Classic13 : GameLevel
    {
        public Classic13()
            : base("Classic13")
        {
            Initialize(3, 2);
            MapButtons = new int[,]
            {
                {OFF, LIT, LIT},
                {LIT, OFF, LIT},
                {LIT, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic14();
            }
        }
    }
}
