using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPREMIUMService : IService<PREMIUMDto, CreatePREMIUMDto, UpdatePREMIUMDto, string>
{
    Task<IEnumerable<PREMIUMDto>> FindAsync(Expression<Func<PREMIUM, bool>> predicate);
}
