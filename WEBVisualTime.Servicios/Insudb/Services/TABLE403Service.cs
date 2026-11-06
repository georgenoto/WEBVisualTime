using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE403;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE403Service : CrudService<TABLE403, TABLE403Dto, CreateTABLE403Dto, UpdateTABLE403Dto, long>, ITABLE403Service
{
    public TABLE403Service(IRepository<TABLE403> repository)
        : base(repository, TABLE403MappingExtensions.ToDto, TABLE403MappingExtensions.ToEntity, TABLE403MappingExtensions.UpdateEntity) { }
}
