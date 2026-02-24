

namespace Assets.Scripts.Levels
{
    class Classic46 : GameLevel
    {
        public Classic46()
            : base("Classic46", "4-6")
        {
            Initialize(6, 8);
            MapButtons = new int[,]
            {
                {OFF, OFF, OFF, LIT, LIT, OFF},
                {OFF, OFF, OFF, OFF, OFF, OFF},
                {OFF, OFF, LIT, OFF, OFF, OFF},
                {LIT, OFF, OFF, LIT, OFF, OFF},
                {LIT, OFF, OFF, OFF, LIT, OFF},
                {OFF, OFF, OFF, OFF, OFF, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic47();
            }
        }
    }
}
