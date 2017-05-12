

namespace Assets.Scripts.Levels
{
    class Classic27 : GameLevel
    {
        public Classic27()
            : base("Classic27")
        {
            Initialize(4, 8);
            MapButtons = new int[,]
            {
                {LIT, OFF, OFF, LIT},
                {LIT, OFF, OFF, LIT},
                {LIT, LIT, LIT, LIT},
                {OFF, OFF, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic31();
            }
        }
    }
}
