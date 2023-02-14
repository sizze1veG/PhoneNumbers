using System;

namespace kursach
{
    struct CodePhone
    {
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", code, price);
        }
    }
}
