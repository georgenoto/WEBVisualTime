using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HOMOLOG_TABLE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IHOMOLOG_TABLEService : IService<HOMOLOG_TABLEDto, CreateHOMOLOG_TABLEDto, UpdateHOMOLOG_TABLEDto, int>
{
    Task<IEnumerable<HOMOLOG_TABLEDto>> FindAsync(Expression<Func<HOMOLOG_TABLE, bool>> predicate);
}
