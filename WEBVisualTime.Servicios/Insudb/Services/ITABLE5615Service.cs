using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5615;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5615Service : IService<TABLE5615Dto, CreateTABLE5615Dto, UpdateTABLE5615Dto, long>
{
    Task<IEnumerable<TABLE5615Dto>> FindAsync(Expression<Func<TABLE5615, bool>> predicate);
}
