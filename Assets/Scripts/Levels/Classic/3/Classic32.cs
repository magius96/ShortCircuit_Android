

namespace Assets.Scripts.Levels
{
    class Classic32 : GameLevel
    {
        public Classic32()
            : base("Classic32", "3-2")
        {
            Initialize(5, 5);
            MapButtons = new int[,]
            {
                {LIT, OFF, OFF, OFF, LIT},
                {LIT, LIT, LIT, LIT, LIT},
                {OFF, LIT, LIT, LIT, OFF},
                {LIT, LIT, LIT, LIT, LIT},
                {LIT, OFF, OFF, OFF, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic33();
            }
        }
    }
}
