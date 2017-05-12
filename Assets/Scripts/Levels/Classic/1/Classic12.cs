

namespace Assets.Scripts.Levels
{
    class Classic12 : GameLevel
    {
        public Classic12()
            : base("Classic12")
        {
            Initialize(3, 1);
            MapButtons = new int[,]
            {
                {OFF, LIT, LIT},
                {OFF, OFF, LIT},
                {OFF, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic13();
            }
        }
    }
}
