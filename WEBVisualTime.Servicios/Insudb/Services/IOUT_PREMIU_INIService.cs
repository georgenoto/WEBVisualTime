using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.OUT_PREMIU_INI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IOUT_PREMIU_INIService : IService<OUT_PREMIU_INIDto, CreateOUT_PREMIU_INIDto, UpdateOUT_PREMIU_INIDto, string>
{
    Task<IEnumerable<OUT_PREMIU_INIDto>> FindAsync(Expression<Func<OUT_PREMIU_INI, bool>> predicate);
}
