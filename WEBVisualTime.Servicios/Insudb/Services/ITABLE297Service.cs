using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE297;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE297Service : IService<TABLE297Dto, CreateTABLE297Dto, UpdateTABLE297Dto, long>
{
    Task<IEnumerable<TABLE297Dto>> FindAsync(Expression<Func<TABLE297, bool>> predicate);
}
