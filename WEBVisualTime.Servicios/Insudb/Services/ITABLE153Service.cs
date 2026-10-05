using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE153;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE153Service : IService<TABLE153Dto, CreateTABLE153Dto, UpdateTABLE153Dto, string>
{
    Task<IEnumerable<TABLE153Dto>> FindAsync(Expression<Func<TABLE153, bool>> predicate);
}
