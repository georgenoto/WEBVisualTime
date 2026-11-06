using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_DENTITION;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TAB_DENTITIONService : CrudService<TAB_DENTITION, TAB_DENTITIONDto, CreateTAB_DENTITIONDto, UpdateTAB_DENTITIONDto, int>, ITAB_DENTITIONService
{
    public TAB_DENTITIONService(IRepository<TAB_DENTITION> repository)
        : base(repository, TAB_DENTITIONMappingExtensions.ToDto, TAB_DENTITIONMappingExtensions.ToEntity, TAB_DENTITIONMappingExtensions.UpdateEntity) { }
}
