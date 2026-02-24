

// 03,12,21,30,21,21,12,12
namespace Assets.Scripts.Levels
{
    class Advanced25 : GameLevel
    {
        public Advanced25()
            : base("Advanced25", "2-5")
        {
            Initialize(4, 8);
            MapButtons = new int[,]
            {
                {OFF, OFF, OFF, YLW},
                {OFF, RED, LIT, OFF},
                {OFF, LIT, RED, OFF},
                {YLW, OFF, OFF, OFF},
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Advanced26();
            }
        }
    }
}
