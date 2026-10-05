using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3012;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE3012Service : IService<TABLE3012Dto, CreateTABLE3012Dto, UpdateTABLE3012Dto, int>
{
    Task<IEnumerable<TABLE3012Dto>> FindAsync(Expression<Func<TABLE3012, bool>> predicate);
}
