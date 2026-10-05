using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9200;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9200Service : IService<TABLE9200Dto, CreateTABLE9200Dto, UpdateTABLE9200Dto, int>
{
    Task<IEnumerable<TABLE9200Dto>> FindAsync(Expression<Func<TABLE9200, bool>> predicate);
}
