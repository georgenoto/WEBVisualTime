using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9017;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9017Service : IService<TABLE9017Dto, CreateTABLE9017Dto, UpdateTABLE9017Dto, int>
{
    Task<IEnumerable<TABLE9017Dto>> FindAsync(Expression<Func<TABLE9017, bool>> predicate);
}
