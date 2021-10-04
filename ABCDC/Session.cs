using System;
using System.Collections.Generic;
using System.Text;

namespace ABCDC
{
    class Session
    {
        public string playerList
        {
            get { return _playerlist; }
            set { _playerlist = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _playerlist;

        private DateTime _date;
    }
}
