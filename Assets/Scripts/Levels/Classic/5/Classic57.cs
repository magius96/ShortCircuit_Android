

namespace Assets.Scripts.Levels
{
    class Classic57 : GameLevel
    {
        public Classic57()
            : base("Classic57")
        {
            Initialize(10, 20);
            MapButtons = new int[,]
            {
                {OFF, LIT, LIT, OFF, OFF, OFF, OFF, LIT, LIT, OFF},
                {LIT, LIT, OFF, LIT, OFF, OFF, LIT, OFF, LIT, LIT},
                {LIT, OFF, OFF, LIT, OFF, OFF, LIT, OFF, OFF, LIT},
                {OFF, LIT, LIT, LIT, OFF, OFF, LIT, LIT, LIT, OFF},
                {OFF, OFF, OFF, OFF, LIT, LIT, OFF, OFF, OFF, OFF},
                {OFF, OFF, OFF, OFF, LIT, LIT, OFF, OFF, OFF, OFF},
                {OFF, LIT, LIT, LIT, OFF, OFF, LIT, LIT, LIT, OFF},
                {LIT, OFF, OFF, LIT, OFF, OFF, LIT, OFF, OFF, LIT},
                {LIT, LIT, OFF, LIT, OFF, OFF, LIT, OFF, LIT, LIT},
                {OFF, LIT, LIT, OFF, OFF, OFF, OFF, LIT, LIT, OFF}
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new TestLevel();
            }
        }
    }
}
