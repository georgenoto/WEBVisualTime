using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE185;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE185Service : IService<TABLE185Dto, CreateTABLE185Dto, UpdateTABLE185Dto, int>
{
    Task<IEnumerable<TABLE185Dto>> FindAsync(Expression<Func<TABLE185, bool>> predicate);
}
