using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS_CONFIG;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IADDRESS_CONFIGService : IService<ADDRESS_CONFIGDto, CreateADDRESS_CONFIGDto, UpdateADDRESS_CONFIGDto, int>
{
    Task<IEnumerable<ADDRESS_CONFIGDto>> FindAsync(Expression<Func<ADDRESS_CONFIG, bool>> predicate);
}
