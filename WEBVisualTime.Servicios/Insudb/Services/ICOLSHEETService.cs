using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COLSHEET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOLSHEETService : IService<COLSHEETDto, CreateCOLSHEETDto, UpdateCOLSHEETDto, int>
{
    Task<IEnumerable<COLSHEETDto>> FindAsync(Expression<Func<COLSHEET, bool>> predicate);
}
