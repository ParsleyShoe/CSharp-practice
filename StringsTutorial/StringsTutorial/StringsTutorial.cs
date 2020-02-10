using System;
using System.Collections.Generic;
using System.Text;

namespace StringsTutorial {
    class StringsTutorial {
        public string FirstName;
        public string LastName;
        //Constructor almost always used to initialize class instance with data - can have more than one
        /*
        public StringsTutorial() {
            FirstName = "Parsley";
            LastName = "Wint";
        }
        */
        public StringsTutorial(string firstname, string lastname) {
            FirstName = firstname;
            LastName = lastname;
        }
        public string Fullname() {
            return $"{FirstName} {LastName}";
        }
    }
}
