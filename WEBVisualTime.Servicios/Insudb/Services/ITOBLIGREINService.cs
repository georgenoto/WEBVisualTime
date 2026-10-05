using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TOBLIGREIN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITOBLIGREINService : IService<TOBLIGREINDto, CreateTOBLIGREINDto, UpdateTOBLIGREINDto, int>
{
    Task<IEnumerable<TOBLIGREINDto>> FindAsync(Expression<Func<TOBLIGREIN, bool>> predicate);
}
