using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DIR_DEBIT_CLI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDIR_DEBIT_CLIService : IService<DIR_DEBIT_CLIDto, CreateDIR_DEBIT_CLIDto, UpdateDIR_DEBIT_CLIDto, string>
{
    Task<IEnumerable<DIR_DEBIT_CLIDto>> FindAsync(Expression<Func<DIR_DEBIT_CLI, bool>> predicate);
}
