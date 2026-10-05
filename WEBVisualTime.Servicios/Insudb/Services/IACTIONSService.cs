using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ACTIONS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IACTIONSService : IService<ACTIONSDto, CreateACTIONSDto, UpdateACTIONSDto, int>
{
    Task<IEnumerable<ACTIONSDto>> FindAsync(Expression<Func<ACTIONS, bool>> predicate);
}
