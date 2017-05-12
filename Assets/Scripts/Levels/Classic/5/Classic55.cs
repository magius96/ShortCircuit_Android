

// 11,43,06,37,56,74,61,30,21,64,45,26,72,34,27
namespace Assets.Scripts.Levels
{
    class Classic55 : GameLevel
    {
        public Classic55()
            : base("Classic55")
        {
            Initialize(9, 15);
            MapButtons = new int[,]
            {
                {OFF, LIT, OFF, LIT, LIT, OFF, LIT, OFF, OFF},
                {LIT, OFF, OFF, OFF, OFF, LIT, LIT, OFF, OFF},
                {OFF, LIT, LIT, OFF, LIT, OFF, OFF, LIT, LIT},
                {OFF, OFF, OFF, OFF, LIT, LIT, LIT, OFF, OFF},
                {OFF, OFF, LIT, LIT, LIT, LIT, OFF, OFF, LIT},
                {LIT, OFF, LIT, OFF, LIT, OFF, LIT, LIT, OFF},
                {LIT, OFF, OFF, OFF, OFF, LIT, LIT, OFF, OFF},
                {LIT, LIT, LIT, OFF, LIT, LIT, OFF, OFF, OFF},
                {OFF, OFF, LIT, LIT, OFF, OFF, OFF, OFF, OFF}
            };
        }
        public override GameLevel NextLevel
        {
            get
            {
                return new Classic56();
            }
        }
    }
}
