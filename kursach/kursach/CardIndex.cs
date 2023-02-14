using System;

namespace kursach
{
    struct CardIndex
    {
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", phone, name);
        }
    }
}
