using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COLLECTOR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOLLECTORService : IService<COLLECTORDto, CreateCOLLECTORDto, UpdateCOLLECTORDto, long>
{
    Task<IEnumerable<COLLECTORDto>> FindAsync(Expression<Func<COLLECTOR, bool>> predicate);
}
