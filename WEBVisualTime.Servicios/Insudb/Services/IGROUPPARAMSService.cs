using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPPARAMS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IGROUPPARAMSService : IService<GROUPPARAMSDto, CreateGROUPPARAMSDto, UpdateGROUPPARAMSDto, int>
{
    Task<IEnumerable<GROUPPARAMSDto>> FindAsync(Expression<Func<GROUPPARAMS, bool>> predicate);
}
