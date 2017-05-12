

namespace Assets.Scripts.Levels
{
    class Classic22 : GameLevel
    {
        public Classic22()
            : base("Classic22")
        {
            Initialize(4, 4);
            MapButtons = new int[,]
            {
                {OFF, LIT, LIT, OFF},
                {OFF, OFF, OFF, LIT},
                {OFF, OFF, LIT, OFF},
                {OFF, LIT, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic23();
            }
        }
    }
}
