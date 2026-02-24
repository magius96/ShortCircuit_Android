

namespace Assets.Scripts.Levels
{
    class Classic21 : GameLevel
    {
        public Classic21()
            : base("Classic21", "2-1")
        {
            Initialize(4, 4);
            MapButtons = new int[,]
            {
                {OFF, LIT, LIT, OFF},
                {LIT, LIT, LIT, LIT},
                {LIT, LIT, LIT, LIT},
                {OFF, LIT, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic22();
            }
        }
    }
}
