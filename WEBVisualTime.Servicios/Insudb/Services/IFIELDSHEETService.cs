using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FIELDSHEET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IFIELDSHEETService : IService<FIELDSHEETDto, CreateFIELDSHEETDto, UpdateFIELDSHEETDto, string>
{
    Task<IEnumerable<FIELDSHEETDto>> FindAsync(Expression<Func<FIELDSHEET, bool>> predicate);
}
