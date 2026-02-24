// 01,12,23,34,22,31,40
namespace Assets.Scripts.Levels
{
    class Advanced34 : GameLevel
    {
        public Advanced34()
            : base("Advanced34", "3-4")
        {
            Initialize(5, 7);
            MapButtons = new int[,]
            {
                {LIT, RED, OFF, OFF, LIT},
                {LIT, OFF, GRN, LIT, OFF},
                {OFF, OFF, RED, GRN, OFF},
                {OFF, GRN, OFF, OFF, RED},
                {RED, OFF, OFF, LIT, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced35();
            }
        }
    }
}
