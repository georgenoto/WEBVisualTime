using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.OFFICE_ALLOW_PROD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IOFFICE_ALLOW_PRODService : IService<OFFICE_ALLOW_PRODDto, CreateOFFICE_ALLOW_PRODDto, UpdateOFFICE_ALLOW_PRODDto, string>
{
    Task<IEnumerable<OFFICE_ALLOW_PRODDto>> FindAsync(Expression<Func<OFFICE_ALLOW_PROD, bool>> predicate);
}
