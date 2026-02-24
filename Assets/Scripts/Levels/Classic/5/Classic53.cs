

namespace Assets.Scripts.Levels
{
    class Classic53 : GameLevel
    {
        public Classic53()
            : base("Classic53", "5-3")
        {
            Initialize(8, 16);
            MapButtons = new int[,]
            {
                {OFF, LIT, LIT, OFF, OFF, OFF, OFF, LIT},
                {OFF, OFF, OFF, LIT, OFF, OFF, LIT, OFF},
                {OFF, OFF, OFF, OFF, LIT, LIT, OFF, OFF},
                {OFF, OFF, OFF, LIT, LIT, LIT, OFF, OFF},
                {OFF, OFF, LIT, OFF, LIT, OFF, LIT, OFF},
                {OFF, OFF, LIT, LIT, OFF, OFF, OFF, LIT},
                {OFF, LIT, OFF, OFF, OFF, OFF, OFF, LIT},
                {LIT, OFF, OFF, OFF, OFF, OFF, OFF, OFF}
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic54();
            }
        }
    }
}
