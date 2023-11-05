using System.Data;

namespace MusicCatalog.Models.Interfaces
{
    public interface IDataProvider
    {
        DataTable GetData();
    }
}
