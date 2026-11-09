using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DOC_REQ_CLI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDOC_REQ_CLIService : IService<DOC_REQ_CLIDto, CreateDOC_REQ_CLIDto, UpdateDOC_REQ_CLIDto, string>
{
    Task<IEnumerable<DOC_REQ_CLIDto>> FindAsync(Expression<Func<DOC_REQ_CLI, bool>> predicate);
}
