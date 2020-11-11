using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonEksempel
{
    public class PersonCatalog // Der skal kun være et objekt af PersonCatalog
    {
        private static PersonCatalog _instance;
        
        private List<Person> persons;

        private PersonCatalog()
        {
            persons = new List<Person>();
        }

        public void Add(Person p)
        {
            persons.Add(p);
        }

        public static PersonCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PersonCatalog();
                }

                return _instance;
            }
        }


    }
}
