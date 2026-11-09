using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_ADDITIONALS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLORDER_ADDITIONALSService : IService<CLORDER_ADDITIONALSDto, CreateCLORDER_ADDITIONALSDto, UpdateCLORDER_ADDITIONALSDto, string>
{
    Task<IEnumerable<CLORDER_ADDITIONALSDto>> FindAsync(Expression<Func<CLORDER_ADDITIONALS, bool>> predicate);
}
