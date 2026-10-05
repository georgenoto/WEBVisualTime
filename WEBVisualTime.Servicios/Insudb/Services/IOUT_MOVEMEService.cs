using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.OUT_MOVEME;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IOUT_MOVEMEService : IService<OUT_MOVEMEDto, CreateOUT_MOVEMEDto, UpdateOUT_MOVEMEDto, string>
{
    Task<IEnumerable<OUT_MOVEMEDto>> FindAsync(Expression<Func<OUT_MOVEME, bool>> predicate);
}
