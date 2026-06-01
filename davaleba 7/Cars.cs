using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba7
{
    internal class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        private int _year;
        private int _price;


        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > 1885 && value <= DateTime.Now.Year)
                {
                    _year = value;
                }

            }
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }



    }
}
