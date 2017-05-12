

namespace Assets.Scripts.Levels
{
    class Classic24 : GameLevel
    {
        public Classic24()
            : base("Classic24")
        {
            Initialize(4, 5);
            MapButtons = new int[,]
            {
                {LIT, OFF, OFF, LIT},
                {LIT, LIT, LIT, LIT},
                {LIT, LIT, LIT, OFF},
                {LIT, OFF, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic25();
            }
        }
    }
}
