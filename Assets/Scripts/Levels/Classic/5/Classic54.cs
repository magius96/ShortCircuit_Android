

namespace Assets.Scripts.Levels
{
    class Classic54 : GameLevel
    {
        public Classic54()
            : base("Classic54")
        {
            Initialize(8, 14);
            MapButtons = new int[,]
            {
                {LIT, LIT, LIT, OFF, LIT, OFF, LIT, LIT},
                {OFF, OFF, LIT, OFF, LIT, OFF, OFF, LIT},
                {LIT, OFF, OFF, LIT, OFF, LIT, OFF, LIT},
                {OFF, LIT, LIT, OFF, OFF, LIT, OFF, OFF},
                {LIT, OFF, OFF, OFF, OFF, LIT, LIT, OFF},
                {LIT, OFF, OFF, OFF, LIT, LIT, OFF, OFF},
                {OFF, LIT, OFF, LIT, LIT, OFF, LIT, LIT},
                {OFF, LIT, OFF, LIT, LIT, OFF, OFF, LIT}
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic55();
            }
        }
    }
}
