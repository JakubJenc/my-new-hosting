using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForFoxes.Models
{
    public interface IFox
    {
        List<Fox> ListOfFoxes { get; set; }
        List<Fox> AddFox(string name);
        Fox GetFoxByName(string name);
    }
}
