using System;
using System.Collections.Generic;
using System.Text;

namespace ABCDC
{
    class Person
    {
        public override string ToString()
        {
            return "NOM: " + LastName + "Prenom: " + FirstName;
        }

        #region Properties 

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public int BeginYear
        {
            get { return _beginYear; }
            set { _beginYear = value; }
        }

        public string Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public string Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        #endregion

        #region Attributes

        private string _firstName;

        private string _lastName;

        private int _weight;

        private int _beginYear;

        private string _weapon;

        private string _armor;

        #endregion

        public Person()
        {

        }
    }
}
