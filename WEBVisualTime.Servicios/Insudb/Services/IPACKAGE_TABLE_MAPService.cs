using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PACKAGE_TABLE_MAP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPACKAGE_TABLE_MAPService : IService<PACKAGE_TABLE_MAPDto, CreatePACKAGE_TABLE_MAPDto, UpdatePACKAGE_TABLE_MAPDto, string>
{
    Task<IEnumerable<PACKAGE_TABLE_MAPDto>> FindAsync(Expression<Func<PACKAGE_TABLE_MAP, bool>> predicate);
}
