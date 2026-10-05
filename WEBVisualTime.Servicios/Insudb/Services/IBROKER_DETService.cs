using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BROKER_DET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBROKER_DETService : IService<BROKER_DETDto, CreateBROKER_DETDto, UpdateBROKER_DETDto, int>
{
    Task<IEnumerable<BROKER_DETDto>> FindAsync(Expression<Func<BROKER_DET, bool>> predicate);
}
