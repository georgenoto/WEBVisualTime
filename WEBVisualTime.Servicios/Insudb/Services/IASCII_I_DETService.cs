using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_DET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IASCII_I_DETService : IService<ASCII_I_DETDto, CreateASCII_I_DETDto, UpdateASCII_I_DETDto, string>
{
    Task<IEnumerable<ASCII_I_DETDto>> FindAsync(Expression<Func<ASCII_I_DET, bool>> predicate);
}
