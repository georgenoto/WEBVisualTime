using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5524;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5524Service : IService<TABLE5524Dto, CreateTABLE5524Dto, UpdateTABLE5524Dto, long>
{
    Task<IEnumerable<TABLE5524Dto>> FindAsync(Expression<Func<TABLE5524, bool>> predicate);
}
