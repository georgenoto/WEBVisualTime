using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPEND_STATUSES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISDD_DEPEND_STATUSESService : IService<SDD_DEPEND_STATUSESDto, CreateSDD_DEPEND_STATUSESDto, UpdateSDD_DEPEND_STATUSESDto, string>
{
    Task<IEnumerable<SDD_DEPEND_STATUSESDto>> FindAsync(Expression<Func<SDD_DEPEND_STATUSES, bool>> predicate);
}
