using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IADDRESSService : IService<ADDRESSDto, CreateADDRESSDto, UpdateADDRESSDto, string>
{
    Task<IEnumerable<ADDRESSDto>> FindAsync(Expression<Func<ADDRESS, bool>> predicate);
}
