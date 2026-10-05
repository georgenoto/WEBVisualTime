using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HEALTHCLAIMFORM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IHEALTHCLAIMFORMService : IService<HEALTHCLAIMFORMDto, CreateHEALTHCLAIMFORMDto, UpdateHEALTHCLAIMFORMDto, string>
{
    Task<IEnumerable<HEALTHCLAIMFORMDto>> FindAsync(Expression<Func<HEALTHCLAIMFORM, bool>> predicate);
}
