

namespace Assets.Scripts.Levels
{
    class Classic31 : GameLevel
    {
        public Classic31()
            : base("Classic31")
        {
            Initialize(5, 5);
            MapButtons = new int[,]
            {
                {OFF, LIT, OFF, LIT, OFF},
                {LIT, LIT, LIT, LIT, LIT},
                {OFF, LIT, LIT, LIT, OFF},
                {LIT, LIT, LIT, LIT, LIT},
                {OFF, LIT, OFF, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic32();
            }
        }
    }
}
