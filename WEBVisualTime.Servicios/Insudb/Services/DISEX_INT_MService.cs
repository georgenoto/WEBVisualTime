using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.DISEX_INT_M;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class DISEX_INT_MService : CrudService<DISEX_INT_M, DISEX_INT_MDto, CreateDISEX_INT_MDto, UpdateDISEX_INT_MDto, int>, IDISEX_INT_MService
{
    public DISEX_INT_MService(IRepository<DISEX_INT_M> repository)
        : base(repository, DISEX_INT_MMappingExtensions.ToDto, DISEX_INT_MMappingExtensions.ToEntity, DISEX_INT_MMappingExtensions.UpdateEntity) { }
}
