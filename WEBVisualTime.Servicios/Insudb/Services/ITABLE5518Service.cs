using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5518;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5518Service : IService<TABLE5518Dto, CreateTABLE5518Dto, UpdateTABLE5518Dto, int>
{
    Task<IEnumerable<TABLE5518Dto>> FindAsync(Expression<Func<TABLE5518, bool>> predicate);
}
