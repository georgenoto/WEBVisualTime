using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MUNICIPALITY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMUNICIPALITYService : IService<MUNICIPALITYDto, CreateMUNICIPALITYDto, UpdateMUNICIPALITYDto, int>
{
    Task<IEnumerable<MUNICIPALITYDto>> FindAsync(Expression<Func<MUNICIPALITY, bool>> predicate);
}
