

namespace Assets.Scripts.Levels
{
    class Classic43 : GameLevel
    {
        public Classic43()
            : base("Classic43")
        {
            Initialize(6, 10);
            MapButtons = new int[,]
            {
                {LIT, LIT, OFF, OFF, LIT, LIT},
                {OFF, OFF, LIT, LIT, OFF, OFF},
                {OFF, OFF, LIT, LIT, OFF, OFF},
                {LIT, OFF, OFF, OFF, OFF, LIT},
                {LIT, OFF, LIT, LIT, OFF, LIT},
                {OFF, LIT, OFF, OFF, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic44();
            }
        }
    }
}
