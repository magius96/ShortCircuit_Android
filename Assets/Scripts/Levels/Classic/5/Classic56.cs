

namespace Assets.Scripts.Levels
{
    class Classic56 : GameLevel
    {
        public Classic56()
            : base("Classic56")
        {
            Initialize(9, 39);
            MapButtons = new int[,]
            {
                {LIT, LIT, LIT, LIT, LIT, LIT, LIT, OFF, OFF},
                {LIT, LIT, OFF, LIT, OFF, LIT, OFF, LIT, OFF},
                {LIT, OFF, LIT, OFF, LIT, OFF, LIT, OFF, LIT},
                {LIT, LIT, OFF, LIT, OFF, LIT, OFF, LIT, LIT},
                {LIT, OFF, LIT, OFF, LIT, OFF, LIT, OFF, LIT},
                {LIT, LIT, OFF, LIT, OFF, LIT, OFF, LIT, LIT},
                {LIT, OFF, LIT, OFF, LIT, OFF, LIT, OFF, LIT},
                {OFF, LIT, OFF, LIT, OFF, LIT, OFF, LIT, LIT},
                {OFF, OFF, LIT, LIT, LIT, LIT, LIT, LIT, LIT}
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic57();
            }
        }
    }
}
