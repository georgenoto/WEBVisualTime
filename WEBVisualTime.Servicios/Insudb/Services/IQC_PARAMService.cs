using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.QC_PARAM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IQC_PARAMService : IService<QC_PARAMDto, CreateQC_PARAMDto, UpdateQC_PARAMDto, string>
{
    Task<IEnumerable<QC_PARAMDto>> FindAsync(Expression<Func<QC_PARAM, bool>> predicate);
}
