

namespace Assets.Scripts.Levels
{
    class Classic35 : GameLevel
    {
        public Classic35()
            : base("Classic35")
        {
            Initialize(5, 5);
            MapButtons = new int[,]
            {
                {LIT, OFF, LIT, OFF, LIT},
                {LIT, OFF, LIT, OFF, LIT},
                {LIT, LIT, LIT, LIT, LIT},
                {LIT, LIT, OFF, LIT, LIT},
                {OFF, LIT, OFF, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic36();
            }
        }
    }
}
