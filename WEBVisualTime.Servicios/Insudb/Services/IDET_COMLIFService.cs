using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DET_COMLIF;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDET_COMLIFService : IService<DET_COMLIFDto, CreateDET_COMLIFDto, UpdateDET_COMLIFDto, string>
{
    Task<IEnumerable<DET_COMLIFDto>> FindAsync(Expression<Func<DET_COMLIF, bool>> predicate);
}
