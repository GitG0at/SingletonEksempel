using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonEksempel
{
    public class PresidentTheOneAndOnly  // der må kun laves et objekt
    {
        private static PresidentTheOneAndOnly _instance; // Eager  = new PresidentTheOneAndOnly();
        public string Name { get; set; }
        public string Party { get; set; }

        private PresidentTheOneAndOnly()
        {
            
        }

        public static PresidentTheOneAndOnly Instance
        {
            get
            {
                if (_instance == null) //Lazy
                    _instance = new PresidentTheOneAndOnly();
                return _instance;
            }
        }
    }
}
