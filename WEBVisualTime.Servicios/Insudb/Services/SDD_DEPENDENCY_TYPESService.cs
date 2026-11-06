using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPENDENCY_TYPES;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SDD_DEPENDENCY_TYPESService : CrudService<SDD_DEPENDENCY_TYPES, SDD_DEPENDENCY_TYPESDto, CreateSDD_DEPENDENCY_TYPESDto, UpdateSDD_DEPENDENCY_TYPESDto, int>, ISDD_DEPENDENCY_TYPESService
{
    public SDD_DEPENDENCY_TYPESService(IRepository<SDD_DEPENDENCY_TYPES> repository)
        : base(repository, SDD_DEPENDENCY_TYPESMappingExtensions.ToDto, SDD_DEPENDENCY_TYPESMappingExtensions.ToEntity, SDD_DEPENDENCY_TYPESMappingExtensions.UpdateEntity) { }
}
