using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_Wimmer
{
    public class Person
    {
        private int _month = 7;  // Backing store

        public int Month
        {
            get => _month;
            set
            {
                if ((value > 0) && (value < 13))
                {
                    _month = value;
                }
            }
        }
        private int persnr;
        public int PersNr
        {
            get { PersNr = persnr; }
            set { value = persnr; }
        }
        public string PersNachname
        {
            get 
        }
    }
}
