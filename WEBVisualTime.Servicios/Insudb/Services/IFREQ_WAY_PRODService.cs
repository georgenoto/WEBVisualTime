using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FREQ_WAY_PROD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IFREQ_WAY_PRODService : IService<FREQ_WAY_PRODDto, CreateFREQ_WAY_PRODDto, UpdateFREQ_WAY_PRODDto, string>
{
    Task<IEnumerable<FREQ_WAY_PRODDto>> FindAsync(Expression<Func<FREQ_WAY_PROD, bool>> predicate);
}
