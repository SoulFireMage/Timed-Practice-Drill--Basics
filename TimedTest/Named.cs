using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedTest
    {
    public abstract class Named
        {
        private string _name; //check this access, likely to need to be internal!
        public string Name
            {
            get { return _name; }
            set { _name = _name ?? value; }
            }

        public Named(string name) {
            _name = name;
            }
        }

    public class country : Named
        {
        private List<City> _cities;
        public List<City> Cities { get { return _cities; }
            set { _cities = value ?? new List<City>(); }  //must double check this idiom! 
            }
        public country(string name) : base(name) { }
        public country(string name, List<City> cities) :base(name)
            {
            _cities = cities;
            }

        }

    public class City : Named
        {
        private List<Person> _people;
        public List<Person> People { get { return _people; } set { _people = value ?? new List<Person>(); } }

        public City(string name) : base(name) { }
        public City(string name, List<Person> people) :base(name)
            {
            _people = people;
            }
        }


    public class Person : Named
        {
        private string _firstname;
        public string FirstName { get { return _firstname; } set { _firstname = value ?? _firstname; } }
        private string _surname;
        public string SurName { get { return SurName; } set { _surname = value ?? _surname; } } 
        public Person(string name) :base(name)  {
            _firstname = name.Split(' ')[0];
            _surname = name.Split(' ')[1];
            }
        }
    }
