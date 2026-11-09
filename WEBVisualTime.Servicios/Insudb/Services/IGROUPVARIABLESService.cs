using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPVARIABLES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IGROUPVARIABLESService : IService<GROUPVARIABLESDto, CreateGROUPVARIABLESDto, UpdateGROUPVARIABLESDto, string>
{
    Task<IEnumerable<GROUPVARIABLESDto>> FindAsync(Expression<Func<GROUPVARIABLES, bool>> predicate);
}
