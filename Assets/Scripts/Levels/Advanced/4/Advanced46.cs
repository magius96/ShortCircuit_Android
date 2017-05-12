

// 11,12,13,14,24,34,44,43,42,41,31,21
namespace Assets.Scripts.Levels
{
    class Advanced46 : GameLevel
    {
        public Advanced46()
            : base("Advanced46")
        {
            Initialize(6, 12);
            MapButtons = new int[,]
            {
                {RED, YLW, YLW, LIT, LIT, OFF},
                {YLW, LIT, RED, LIT, LIT, LIT},
                {YLW, RED, GRN, OFF, LIT, LIT},
                {YLW, RED, GRN, OFF, LIT, LIT},
                {YLW, RED, RED, LIT, RED, LIT},
                {RED, YLW, YLW, LIT, LIT, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get { return new Advanced47(); }
        }
    }
}
