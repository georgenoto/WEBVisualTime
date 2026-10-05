using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.APPUSER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IAPPUSERService : IService<APPUSERDto, CreateAPPUSERDto, UpdateAPPUSERDto, int>
{
    Task<IEnumerable<APPUSERDto>> FindAsync(Expression<Func<APPUSER, bool>> predicate);
}
