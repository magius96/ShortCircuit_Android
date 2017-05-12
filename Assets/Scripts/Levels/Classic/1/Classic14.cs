

namespace Assets.Scripts.Levels
{
    class Classic14 : GameLevel
    {
        public Classic14()
            : base("Classic14")
        {
            Initialize(3, 3);
            MapButtons = new int[,]
            {
                {OFF, LIT, OFF},
                {LIT, OFF, LIT},
                {OFF, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic15();
            }
        }
    }
}
