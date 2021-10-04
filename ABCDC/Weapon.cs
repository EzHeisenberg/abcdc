using System;
namespace ABCDC
{
    public class Weapon
    {
        #region Properties 

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }


        #endregion

        #region Attributes

        private string _name;

        #endregion



        public Weapon()
        {
        }
    }
}
