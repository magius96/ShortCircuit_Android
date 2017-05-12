// 03,12,21,30,00,11,22,33
namespace Assets.Scripts.Levels
{
    class Advanced24 : GameLevel
    {
        public Advanced24() : base("Advanced24")
        {
            Initialize(4, 8);
            MapButtons = new int[,]
            {
                {LIT, GRN, OFF, LIT},
                {OFF, LIT, RED, OFF},
                {GRN, LIT, LIT, GRN},
                {LIT, GRN, OFF, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced25();
            }
        }
    }
}
