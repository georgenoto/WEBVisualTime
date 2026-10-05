using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DIR_DEBIT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDIR_DEBITService : IService<DIR_DEBITDto, CreateDIR_DEBITDto, UpdateDIR_DEBITDto, string>
{
    Task<IEnumerable<DIR_DEBITDto>> FindAsync(Expression<Func<DIR_DEBIT, bool>> predicate);
}
