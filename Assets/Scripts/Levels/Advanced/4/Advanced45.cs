

// 01,10,30,05,14,23,32,43,52,03,12,21,32,41,50,25,34,45,54
namespace Assets.Scripts.Levels
{
    class Advanced45 : GameLevel
    {
        public Advanced45()
            : base("Advanced45", "4-5")
        {
            Initialize(6, 19);
            MapButtons = new int[,]
            {
                {OFF, LIT, RED, LIT, RED, LIT},
                {LIT, YLW, LIT, GRN, LIT, LIT},
                {RED, LIT, LIT, OFF, LIT, LIT},
                {LIT, OFF, LIT, GRN, LIT, RED},
                {LIT, LIT, YLW, LIT, YLW, LIT},
                {LIT, RED, LIT, LIT, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced46(); }
        }
    }
}
