using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SELLCHANNEL_PROD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISELLCHANNEL_PRODService : IService<SELLCHANNEL_PRODDto, CreateSELLCHANNEL_PRODDto, UpdateSELLCHANNEL_PRODDto, DateTime>
{
    Task<IEnumerable<SELLCHANNEL_PRODDto>> FindAsync(Expression<Func<SELLCHANNEL_PROD, bool>> predicate);
}
