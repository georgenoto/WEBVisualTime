using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_PART_CONDITIONS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASSIVE_PART_CONDITIONSService : IService<MASSIVE_PART_CONDITIONSDto, CreateMASSIVE_PART_CONDITIONSDto, UpdateMASSIVE_PART_CONDITIONSDto, string>
{
    Task<IEnumerable<MASSIVE_PART_CONDITIONSDto>> FindAsync(Expression<Func<MASSIVE_PART_CONDITIONS, bool>> predicate);
}
