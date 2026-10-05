using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TLEDAUTREJECTM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITLEDAUTREJECTMService : IService<TLEDAUTREJECTMDto, CreateTLEDAUTREJECTMDto, UpdateTLEDAUTREJECTMDto, int>
{
    Task<IEnumerable<TLEDAUTREJECTMDto>> FindAsync(Expression<Func<TLEDAUTREJECTM, bool>> predicate);
}
