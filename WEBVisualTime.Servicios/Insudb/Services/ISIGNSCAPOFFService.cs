using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SIGNSCAPOFF;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISIGNSCAPOFFService : IService<SIGNSCAPOFFDto, CreateSIGNSCAPOFFDto, UpdateSIGNSCAPOFFDto, int>
{
    Task<IEnumerable<SIGNSCAPOFFDto>> FindAsync(Expression<Func<SIGNSCAPOFF, bool>> predicate);
}
