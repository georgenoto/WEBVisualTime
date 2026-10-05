using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PART_CONTR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPART_CONTRService : IService<PART_CONTRDto, CreatePART_CONTRDto, UpdatePART_CONTRDto, int>
{
    Task<IEnumerable<PART_CONTRDto>> FindAsync(Expression<Func<PART_CONTR, bool>> predicate);
}
