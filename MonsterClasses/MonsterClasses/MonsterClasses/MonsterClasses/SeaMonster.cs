using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SeaMonster
    {
        public enum EmotionalState
        {
            Happy,
            Sad,
            Angry
        }



        private string _name;
        private double weight;
        private bool canUseFreshWater;
        private EmotionalState _currentEmotionalState;
        private string _homeSea;

        public string HomeSea
        {
            get { return _homeSea; }
            set { _homeSea = value; }
        }


        public  EmotionalState CurrentEmotionalState
        {
            get { return _currentEmotionalState; }
            set { _currentEmotionalState = value; }
        }




        public bool CanUseFreshWater
        {
            get { return canUseFreshWater; }
            set { canUseFreshWater = value; }
        }


        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public SeaMonster()
        {

        }

        public SeaMonster(string name)
        {
            _name = name;
        }


        public string SeaMonsterAttitude()
        {
            return _name + " is " + _currentEmotionalState;
        }
    }
}
