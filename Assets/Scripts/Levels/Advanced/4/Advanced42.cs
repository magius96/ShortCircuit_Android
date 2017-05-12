

// 11,00,40,31,23,32,55,44,15,24
namespace Assets.Scripts.Levels
{
    class Advanced42 : GameLevel
    {
        public Advanced42()
            : base("Advanced42")
        {
            Initialize(6, 10);
            MapButtons = new int[,]
            {
                {LIT, GRN, OFF, GRN, LIT, LIT},
                {GRN, LIT, OFF, OFF, GRN, OFF},
                {OFF, LIT, GRN, OFF, LIT, OFF},
                {OFF, LIT, OFF, GRN, LIT, OFF},
                {OFF, GRN, OFF, OFF, LIT, GRN},
                {LIT, LIT, GRN, OFF, GRN, LIT},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced43(); }
        }
    }
}
