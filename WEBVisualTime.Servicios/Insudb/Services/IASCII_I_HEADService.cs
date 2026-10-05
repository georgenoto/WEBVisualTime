using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_HEAD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IASCII_I_HEADService : IService<ASCII_I_HEADDto, CreateASCII_I_HEADDto, UpdateASCII_I_HEADDto, string>
{
    Task<IEnumerable<ASCII_I_HEADDto>> FindAsync(Expression<Func<ASCII_I_HEAD, bool>> predicate);
}
