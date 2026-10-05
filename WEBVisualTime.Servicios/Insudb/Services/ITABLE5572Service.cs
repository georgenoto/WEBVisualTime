using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5572;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5572Service : IService<TABLE5572Dto, CreateTABLE5572Dto, UpdateTABLE5572Dto, int>
{
    Task<IEnumerable<TABLE5572Dto>> FindAsync(Expression<Func<TABLE5572, bool>> predicate);
}
