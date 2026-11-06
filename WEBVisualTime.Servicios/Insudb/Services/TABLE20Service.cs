using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE20;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE20Service : CrudService<TABLE20, TABLE20Dto, CreateTABLE20Dto, UpdateTABLE20Dto, long>, ITABLE20Service
{
    public TABLE20Service(IRepository<TABLE20> repository)
        : base(repository, TABLE20MappingExtensions.ToDto, TABLE20MappingExtensions.ToEntity, TABLE20MappingExtensions.UpdateEntity) { }
}
