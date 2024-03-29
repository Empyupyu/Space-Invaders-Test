using System;
using Supyrb;

namespace EGameSystems
{
    [Serializable]
    public class SaveData
    {
        public int LevelIndex;
        public float Money;

        public float SetMoney
        {
            get
            {
                return Money;
            }
            set
            {
                Money = value;
                //Signals.Get<UpdateMoneySignal>().Dispatch(Money);
            }
        }
    }
}

