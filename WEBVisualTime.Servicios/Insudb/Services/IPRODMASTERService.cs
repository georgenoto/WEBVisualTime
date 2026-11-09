using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODMASTER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPRODMASTERService : IService<PRODMASTERDto, CreatePRODMASTERDto, UpdatePRODMASTERDto, string>
{
    Task<IEnumerable<PRODMASTERDto>> FindAsync(Expression<Func<PRODMASTER, bool>> predicate);
}
