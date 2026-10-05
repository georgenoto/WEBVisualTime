using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE34;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE34Service : IService<TABLE34Dto, CreateTABLE34Dto, UpdateTABLE34Dto, long>
{
    Task<IEnumerable<TABLE34Dto>> FindAsync(Expression<Func<TABLE34, bool>> predicate);
}
