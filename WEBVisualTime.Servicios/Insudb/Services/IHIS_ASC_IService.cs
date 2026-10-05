using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HIS_ASC_I;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IHIS_ASC_IService : IService<HIS_ASC_IDto, CreateHIS_ASC_IDto, UpdateHIS_ASC_IDto, int>
{
    Task<IEnumerable<HIS_ASC_IDto>> FindAsync(Expression<Func<HIS_ASC_I, bool>> predicate);
}
