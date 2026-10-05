using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERSHEET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASTERSHEETService : IService<MASTERSHEETDto, CreateMASTERSHEETDto, UpdateMASTERSHEETDto, int>
{
    Task<IEnumerable<MASTERSHEETDto>> FindAsync(Expression<Func<MASTERSHEET, bool>> predicate);
}
