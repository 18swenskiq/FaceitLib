using System.Collections.Generic;

namespace FaceitLib.Models
{
    public class GenericContainer<T>
    {
        public int End { get; set; }

        public List<T> Items { get; set; }
        public int Start { get; set; }
    }
}
