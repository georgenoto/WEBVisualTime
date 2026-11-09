using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LOGBILLS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILOGBILLSService : IService<LOGBILLSDto, CreateLOGBILLSDto, UpdateLOGBILLSDto, string>
{
    Task<IEnumerable<LOGBILLSDto>> FindAsync(Expression<Func<LOGBILLS, bool>> predicate);
}
