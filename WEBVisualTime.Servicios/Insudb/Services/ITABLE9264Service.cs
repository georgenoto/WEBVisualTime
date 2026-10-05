using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9264;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9264Service : IService<TABLE9264Dto, CreateTABLE9264Dto, UpdateTABLE9264Dto, int>
{
    Task<IEnumerable<TABLE9264Dto>> FindAsync(Expression<Func<TABLE9264, bool>> predicate);
}
