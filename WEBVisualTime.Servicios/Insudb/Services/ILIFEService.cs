using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILIFEService : IService<LIFEDto, CreateLIFEDto, UpdateLIFEDto, string>
{
    Task<IEnumerable<LIFEDto>> FindAsync(Expression<Func<LIFE, bool>> predicate);
}
