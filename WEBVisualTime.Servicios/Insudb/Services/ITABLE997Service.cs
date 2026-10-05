using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE997;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE997Service : IService<TABLE997Dto, CreateTABLE997Dto, UpdateTABLE997Dto, int>
{
    Task<IEnumerable<TABLE997Dto>> FindAsync(Expression<Func<TABLE997, bool>> predicate);
}
