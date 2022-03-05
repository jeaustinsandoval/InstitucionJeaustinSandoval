using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BD
{
    public interface IDataAccess
    {
        Task<DBEntity> ExecuteAsync(string sp, object param = null, int? Timeout = null);
        Task<IEnumerable<dynamic>> QueryAsync(string sp, object param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C, D, E, F, G>(string sp, string split, object param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C, D, E, F>(string sp, string split, object param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C, D, E>(string sp, string split, object param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C, D>(string sp, string split, object param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C>(string sp, string split, object param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B>(string sp, string split, object param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T>(string sp, object param = null, int? Timeout = null);
        Task<T> QueryFirstAstnc<T>(string sp, object param = null, int? Timeout = null);
    }
}
