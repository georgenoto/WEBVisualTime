using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MODUL_INSURED;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMODUL_INSUREDService : IService<MODUL_INSUREDDto, CreateMODUL_INSUREDDto, UpdateMODUL_INSUREDDto, string>
{
    Task<IEnumerable<MODUL_INSUREDDto>> FindAsync(Expression<Func<MODUL_INSURED, bool>> predicate);
}
