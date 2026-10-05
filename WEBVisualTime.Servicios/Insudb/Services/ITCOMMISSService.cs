using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCOMMISS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITCOMMISSService : IService<TCOMMISSDto, CreateTCOMMISSDto, UpdateTCOMMISSDto, string>
{
    Task<IEnumerable<TCOMMISSDto>> FindAsync(Expression<Func<TCOMMISS, bool>> predicate);
}
