

namespace Assets.Scripts.Levels
{
    class Classic37 : GameLevel
    {
        public Classic37()
            : base("Classic37")
        {
            Initialize(5, 5);
            MapButtons = new int[,]
            {
                {OFF, OFF, LIT, LIT, LIT},
                {LIT, LIT, LIT, LIT, LIT},
                {LIT, OFF, LIT, OFF, LIT},
                {OFF, LIT, LIT, LIT, LIT},
                {OFF, LIT, OFF, OFF, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic41();
            }
        }
    }
}
