using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.PIE_ELEMENT_TYPES;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class PIE_ELEMENT_TYPESService : CrudService<PIE_ELEMENT_TYPES, PIE_ELEMENT_TYPESDto, CreatePIE_ELEMENT_TYPESDto, UpdatePIE_ELEMENT_TYPESDto, string>, IPIE_ELEMENT_TYPESService
{
    public PIE_ELEMENT_TYPESService(IRepository<PIE_ELEMENT_TYPES> repository)
        : base(repository, PIE_ELEMENT_TYPESMappingExtensions.ToDto, PIE_ELEMENT_TYPESMappingExtensions.ToEntity, PIE_ELEMENT_TYPESMappingExtensions.UpdateEntity) { }
}
