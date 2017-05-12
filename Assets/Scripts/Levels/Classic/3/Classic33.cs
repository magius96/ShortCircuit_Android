

namespace Assets.Scripts.Levels
{
    class Classic33 : GameLevel
    {
        public Classic33()
            : base("Classic33")
        {
            Initialize(5, 5);
            MapButtons = new int[,]
            {
                {LIT, LIT, LIT, LIT, LIT},
                {LIT, LIT, OFF, LIT, LIT},
                {LIT, LIT, OFF, LIT, LIT},
                {OFF, OFF, LIT, LIT, LIT},
                {OFF, OFF, LIT, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic34();
            }
        }
    }
}
