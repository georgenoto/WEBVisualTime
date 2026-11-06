using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5642;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5642Service : CrudService<TABLE5642, TABLE5642Dto, CreateTABLE5642Dto, UpdateTABLE5642Dto, int>, ITABLE5642Service
{
    public TABLE5642Service(IRepository<TABLE5642> repository)
        : base(repository, TABLE5642MappingExtensions.ToDto, TABLE5642MappingExtensions.ToEntity, TABLE5642MappingExtensions.UpdateEntity) { }
}
