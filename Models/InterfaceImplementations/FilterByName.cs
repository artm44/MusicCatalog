using System.Collections.Generic;
using System.Linq;
using MusicCatalog.Models.Interfaces;

namespace MusicCatalog.Models.InterfaceImplementations
{
    public class FilterByName<T> : IFilter<T> where T : IMyName
    {
        private readonly string _name;

        public FilterByName(string name)
        {
            _name = name;
        }

        public IEnumerable<T> Filter(IEnumerable<T> items)
        {
            return items.Where(a => a.Name.ToLower().Contains(_name.ToLower()));
        }
    }
}
