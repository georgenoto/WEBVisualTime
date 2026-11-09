using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SEQFOLDER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISEQFOLDERService : IService<SEQFOLDERDto, CreateSEQFOLDERDto, UpdateSEQFOLDERDto, string>
{
    Task<IEnumerable<SEQFOLDERDto>> FindAsync(Expression<Func<SEQFOLDER, bool>> predicate);
}
