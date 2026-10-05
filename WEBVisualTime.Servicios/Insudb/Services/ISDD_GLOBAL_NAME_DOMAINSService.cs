using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_GLOBAL_NAME_DOMAINS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISDD_GLOBAL_NAME_DOMAINSService : IService<SDD_GLOBAL_NAME_DOMAINSDto, CreateSDD_GLOBAL_NAME_DOMAINSDto, UpdateSDD_GLOBAL_NAME_DOMAINSDto, int>
{
    Task<IEnumerable<SDD_GLOBAL_NAME_DOMAINSDto>> FindAsync(Expression<Func<SDD_GLOBAL_NAME_DOMAINS, bool>> predicate);
}
