using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5623;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5623Service : IService<TABLE5623Dto, CreateTABLE5623Dto, UpdateTABLE5623Dto, long>
{
    Task<IEnumerable<TABLE5623Dto>> FindAsync(Expression<Func<TABLE5623, bool>> predicate);
}
