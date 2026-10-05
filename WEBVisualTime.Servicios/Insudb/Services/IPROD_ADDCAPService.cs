using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROD_ADDCAP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPROD_ADDCAPService : IService<PROD_ADDCAPDto, CreatePROD_ADDCAPDto, UpdatePROD_ADDCAPDto, int>
{
    Task<IEnumerable<PROD_ADDCAPDto>> FindAsync(Expression<Func<PROD_ADDCAP, bool>> predicate);
}
