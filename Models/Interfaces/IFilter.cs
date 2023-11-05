using System.Collections.Generic;

namespace MusicCatalog.Models.Interfaces
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items);
    }
}
