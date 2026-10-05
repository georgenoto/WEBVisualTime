using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_QUOTA;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOVER_QUOTAService : IService<COVER_QUOTADto, CreateCOVER_QUOTADto, UpdateCOVER_QUOTADto, string>
{
    Task<IEnumerable<COVER_QUOTADto>> FindAsync(Expression<Func<COVER_QUOTA, bool>> predicate);
}
