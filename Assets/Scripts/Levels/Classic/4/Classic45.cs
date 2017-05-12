// 01,12,23,32,41,30,04,15,25,34,43
namespace Assets.Scripts.Levels
{
    class Classic45 : GameLevel
    {
        public Classic45()
            : base("Classic45")
        {
            Initialize(6, 11);
            MapButtons = new int[,]
            {
                {LIT, OFF, LIT, LIT, OFF, OFF},
                {LIT, OFF, OFF, LIT, LIT, LIT},
                {OFF, LIT, LIT, LIT, LIT, OFF},
                {LIT, OFF, LIT, OFF, LIT, LIT},
                {LIT, OFF, LIT, LIT, OFF, OFF},
                {OFF, OFF, OFF, OFF, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic46();
            }
        }
    }
}
