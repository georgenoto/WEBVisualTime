using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE174;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE174Service : CrudService<TABLE174, TABLE174Dto, CreateTABLE174Dto, UpdateTABLE174Dto, int>, ITABLE174Service
{
    public TABLE174Service(IRepository<TABLE174> repository)
        : base(repository, TABLE174MappingExtensions.ToDto, TABLE174MappingExtensions.ToEntity, TABLE174MappingExtensions.UpdateEntity) { }
}
