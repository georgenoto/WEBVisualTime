using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TARIF_COLUMN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITARIF_COLUMNService : IService<TARIF_COLUMNDto, CreateTARIF_COLUMNDto, UpdateTARIF_COLUMNDto, int>
{
    Task<IEnumerable<TARIF_COLUMNDto>> FindAsync(Expression<Func<TARIF_COLUMN, bool>> predicate);
}
