using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MODULES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMODULESService : IService<MODULESDto, CreateMODULESDto, UpdateMODULESDto, string>
{
    Task<IEnumerable<MODULESDto>> FindAsync(Expression<Func<MODULES, bool>> predicate);
}
