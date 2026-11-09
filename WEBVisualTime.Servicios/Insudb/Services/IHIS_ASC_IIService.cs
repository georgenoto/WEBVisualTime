using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HIS_ASC_II;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IHIS_ASC_IIService : IService<HIS_ASC_IIDto, CreateHIS_ASC_IIDto, UpdateHIS_ASC_IIDto, string>
{
    Task<IEnumerable<HIS_ASC_IIDto>> FindAsync(Expression<Func<HIS_ASC_II, bool>> predicate);
}
