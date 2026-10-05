using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LEVELS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILEVELSService : IService<LEVELSDto, CreateLEVELSDto, UpdateLEVELSDto, string>
{
    Task<IEnumerable<LEVELSDto>> FindAsync(Expression<Func<LEVELS, bool>> predicate);
}
