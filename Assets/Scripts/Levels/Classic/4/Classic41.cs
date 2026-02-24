

namespace Assets.Scripts.Levels
{
    class Classic41 : GameLevel
    {
        public Classic41()
            : base("Classic41", "4-1")
        {
            Initialize(6, 6);
            MapButtons = new int[,]
            {
                {OFF, LIT, OFF, OFF, LIT, OFF},
                {LIT, LIT, LIT, LIT, LIT, LIT},
                {OFF, OFF, OFF, OFF, OFF, OFF},
                {LIT, LIT, OFF, OFF, LIT, LIT},
                {OFF, OFF, OFF, OFF, OFF, OFF},
                {OFF, OFF, LIT, LIT, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic42();
            }
        }
    }
}
