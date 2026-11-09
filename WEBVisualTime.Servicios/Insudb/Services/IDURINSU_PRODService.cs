using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DURINSU_PROD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDURINSU_PRODService : IService<DURINSU_PRODDto, CreateDURINSU_PRODDto, UpdateDURINSU_PRODDto, string>
{
    Task<IEnumerable<DURINSU_PRODDto>> FindAsync(Expression<Func<DURINSU_PROD, bool>> predicate);
}
