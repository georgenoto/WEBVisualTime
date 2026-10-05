using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE323;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE323Service : IService<TABLE323Dto, CreateTABLE323Dto, UpdateTABLE323Dto, int>
{
    Task<IEnumerable<TABLE323Dto>> FindAsync(Expression<Func<TABLE323, bool>> predicate);
}
