using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5577;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5577Service : IService<TABLE5577Dto, CreateTABLE5577Dto, UpdateTABLE5577Dto, int>
{
    Task<IEnumerable<TABLE5577Dto>> FindAsync(Expression<Func<TABLE5577, bool>> predicate);
}
