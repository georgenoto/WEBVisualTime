using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WORKSHEET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IWORKSHEETService : IService<WORKSHEETDto, CreateWORKSHEETDto, UpdateWORKSHEETDto, int>
{
    Task<IEnumerable<WORKSHEETDto>> FindAsync(Expression<Func<WORKSHEET, bool>> predicate);
}
