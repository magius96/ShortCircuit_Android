

namespace Assets.Scripts.Levels
{
    class Classic36 : GameLevel
    {
        public Classic36()
            : base("Classic36")
        {
            Initialize(5, 7);
            MapButtons = new int[,]
            {
                {LIT, LIT, OFF, LIT, LIT},
                {OFF, OFF, LIT, OFF, OFF},
                {LIT, OFF, LIT, OFF, LIT},
                {OFF, OFF, LIT, OFF, OFF},
                {LIT, LIT, OFF, LIT, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic37();
            }
        }
    }
}
