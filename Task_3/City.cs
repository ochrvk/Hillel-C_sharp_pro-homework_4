namespace Task_3
{
    public class City
    {
        private string _name;
        private int _population;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Population
        {
            get { return _population; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("City must contains at least 1 resident");
                }
                else
                {
                    _population = value;
                }
            }
        }

        public City(string name, int population)
        {
            _name = name;
            _population = population;
        }

        public static City operator +(City city, int amount)
        {
            city._population += amount;
            return city;
        }

        public static City operator -(City city, int amount)
        {
            city._population -= amount;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            if (ReferenceEquals(city1, null) || ReferenceEquals(city2, null))
                return false;
            return city1._population == city2._population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return !(city1 == city2);
        }

        public static bool operator <(City city1, City city2)
        {
            if (ReferenceEquals(city1, null) || ReferenceEquals(city2, null))
                throw new ArgumentException("Objects must not be null");

            return city1._population < city2._population;
        }

        public static bool operator >(City city1, City city2)
        {
            if (ReferenceEquals(city1, null) || ReferenceEquals(city2, null))
                throw new ArgumentException("Objects must not be null");

            return city1._population > city2._population;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            City other = (City)obj;
            return Name == other.Name && Population == other._population;
        }
    }
}
