using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMPANYService : IService<COMPANYDto, CreateCOMPANYDto, UpdateCOMPANYDto, int>
{
    Task<IEnumerable<COMPANYDto>> FindAsync(Expression<Func<COMPANY, bool>> predicate);
}
