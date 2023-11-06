using System.Collections.Generic;
using System.Linq;
using MusicCatalog.Models.Interfaces;

namespace MusicCatalog.Models.InterfaceImplementations
{
    public class FilterByName<T> : IFilter<T> where T : IName
    {
        private readonly string name;

        public FilterByName(string name)
        {
            this.name = name;
        }

        public IEnumerable<T> Filter(IEnumerable<T> items)
        {
            return items.Where(a => a.Name.ToLower().Contains(name.ToLower()));
        }
    }
}
