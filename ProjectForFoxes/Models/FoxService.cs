using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForFoxes.Models
{
    public class FoxService : IFox
    {
        public List<Fox> ListOfFoxes { get; set; }
        public Fox LoggedFox { get; set; }

        public FoxService()
        {
            ListOfFoxes = new List<Fox>();
        }

        public List<Fox> AddFox(string name)
        {
            ListOfFoxes.Add(new Fox(name));
            return ListOfFoxes;
        }

        public Fox GetFoxByName(string name)
        {
            return ListOfFoxes.Find(f => f.Name == name);
        }

        public Fox GetLoggedFox()
        {
            return LoggedFox;
        }

        public void SetLoggedFox(string name)
        {
            LoggedFox = ListOfFoxes.First(f => name == f.Name);
        }


    }
}
