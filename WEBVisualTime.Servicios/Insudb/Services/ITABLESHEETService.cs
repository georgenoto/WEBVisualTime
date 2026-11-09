using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLESHEET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLESHEETService : IService<TABLESHEETDto, CreateTABLESHEETDto, UpdateTABLESHEETDto, string>
{
    Task<IEnumerable<TABLESHEETDto>> FindAsync(Expression<Func<TABLESHEET, bool>> predicate);
}
