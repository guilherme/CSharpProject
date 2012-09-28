using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroProjetoCSharp
{
    public class User
    {
        int age;
        string name;
        string surname;

        #region Constructors
        public User(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        #endregion

        #region Methods
        public string fullName() {
            return name + " " + surname;
        }
        #endregion

    }
}
