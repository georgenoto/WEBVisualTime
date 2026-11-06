using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.H_ASSIGNMENT_PART;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class H_ASSIGNMENT_PARTService : CrudService<H_ASSIGNMENT_PART, H_ASSIGNMENT_PARTDto, CreateH_ASSIGNMENT_PARTDto, UpdateH_ASSIGNMENT_PARTDto, long>, IH_ASSIGNMENT_PARTService
{
    public H_ASSIGNMENT_PARTService(IRepository<H_ASSIGNMENT_PART> repository)
        : base(repository, H_ASSIGNMENT_PARTMappingExtensions.ToDto, H_ASSIGNMENT_PARTMappingExtensions.ToEntity, H_ASSIGNMENT_PARTMappingExtensions.UpdateEntity) { }
}
