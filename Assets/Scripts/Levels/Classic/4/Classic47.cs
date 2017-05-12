

namespace Assets.Scripts.Levels
{
    class Classic47 : GameLevel
    {
        public Classic47()
            : base("Classic47")
        {
            Initialize(6, 10);
            MapButtons = new int[,]
            {
                {OFF, OFF, LIT, LIT, OFF, OFF},
                {OFF, OFF, LIT, OFF, OFF, OFF},
                {LIT, LIT, LIT, OFF, OFF, LIT},
                {LIT, OFF, OFF, LIT, LIT, LIT},
                {OFF, OFF, OFF, LIT, OFF, OFF},
                {OFF, OFF, LIT, LIT, OFF, OFF}
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic51();
            }
        }
    }
}
