using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_WIN_BACKUP_254176;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPOLICY_WIN_BACKUP_254176Service : IService<POLICY_WIN_BACKUP_254176Dto, CreatePOLICY_WIN_BACKUP_254176Dto, UpdatePOLICY_WIN_BACKUP_254176Dto, string>
{
    Task<IEnumerable<POLICY_WIN_BACKUP_254176Dto>> FindAsync(Expression<Func<POLICY_WIN_BACKUP_254176, bool>> predicate);
}
