using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.H_ASSIGNMENT_PART;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IH_ASSIGNMENT_PARTService : IService<H_ASSIGNMENT_PARTDto, CreateH_ASSIGNMENT_PARTDto, UpdateH_ASSIGNMENT_PARTDto, long>
{
    Task<IEnumerable<H_ASSIGNMENT_PARTDto>> FindAsync(Expression<Func<H_ASSIGNMENT_PART, bool>> predicate);
}
