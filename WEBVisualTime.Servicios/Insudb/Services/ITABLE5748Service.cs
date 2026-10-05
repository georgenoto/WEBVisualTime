using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5748;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5748Service : IService<TABLE5748Dto, CreateTABLE5748Dto, UpdateTABLE5748Dto, int>
{
    Task<IEnumerable<TABLE5748Dto>> FindAsync(Expression<Func<TABLE5748, bool>> predicate);
}
