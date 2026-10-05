using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODUCT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPRODUCTService : IService<PRODUCTDto, CreatePRODUCTDto, UpdatePRODUCTDto, int>
{
    Task<IEnumerable<PRODUCTDto>> FindAsync(Expression<Func<PRODUCT, bool>> predicate);
}
