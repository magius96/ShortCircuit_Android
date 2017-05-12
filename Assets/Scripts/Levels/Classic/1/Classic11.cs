

namespace Assets.Scripts.Levels
{
    class Classic11 : GameLevel
    {
        public Classic11()
            : base("Classic11")
        {
            Initialize(3, 1);
            MapButtons = new int[,]
            {
                {OFF, LIT, OFF},
                {LIT, LIT, LIT},
                {OFF, LIT, OFF},
            };
        }

        public override GameLevel NextLevel
        {
            get
            {
                return new Classic12();
            }
        }
    }
}
