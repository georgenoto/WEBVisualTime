using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_GOALS;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TAB_GOALSService : CrudService<TAB_GOALS, TAB_GOALSDto, CreateTAB_GOALSDto, UpdateTAB_GOALSDto, int>, ITAB_GOALSService
{
    public TAB_GOALSService(IRepository<TAB_GOALS> repository)
        : base(repository, TAB_GOALSMappingExtensions.ToDto, TAB_GOALSMappingExtensions.ToEntity, TAB_GOALSMappingExtensions.UpdateEntity) { }
}
