using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.OUT_PREMIU;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IOUT_PREMIUService : IService<OUT_PREMIUDto, CreateOUT_PREMIUDto, UpdateOUT_PREMIUDto, string>
{
    Task<IEnumerable<OUT_PREMIUDto>> FindAsync(Expression<Func<OUT_PREMIU, bool>> predicate);
}
