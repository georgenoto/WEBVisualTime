using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7027;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7027Service : IService<TABLE7027Dto, CreateTABLE7027Dto, UpdateTABLE7027Dto, int>
{
    Task<IEnumerable<TABLE7027Dto>> FindAsync(Expression<Func<TABLE7027, bool>> predicate);
}
