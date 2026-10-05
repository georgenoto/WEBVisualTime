using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSURAN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREINSURANService : IService<REINSURANDto, CreateREINSURANDto, UpdateREINSURANDto, string>
{
    Task<IEnumerable<REINSURANDto>> FindAsync(Expression<Func<REINSURAN, bool>> predicate);
}
