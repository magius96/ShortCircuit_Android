

namespace Assets.Scripts.Levels
{
    class Classic42 : GameLevel
    {
        public Classic42()
            : base("Classic42")
        {
            Initialize(6, 8);
            MapButtons = new int[,]
            {
                {OFF, LIT, OFF, OFF, LIT, OFF},
                {LIT, LIT, OFF, OFF, LIT, LIT},
                {OFF, OFF, LIT, LIT, OFF, OFF},
                {OFF, OFF, LIT, LIT, OFF, OFF},
                {LIT, LIT, OFF, OFF, LIT, LIT},
                {OFF, LIT, OFF, OFF, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic43();
            }
        }
    }
}
