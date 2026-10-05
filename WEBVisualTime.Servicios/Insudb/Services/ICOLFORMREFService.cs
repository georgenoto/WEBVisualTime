using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOLFORMREFService : IService<COLFORMREFDto, CreateCOLFORMREFDto, UpdateCOLFORMREFDto, long>
{
    Task<IEnumerable<COLFORMREFDto>> FindAsync(Expression<Func<COLFORMREF, bool>> predicate);
}
