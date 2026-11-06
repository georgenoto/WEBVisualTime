using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9781;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9781Service : CrudService<TABLE9781, TABLE9781Dto, CreateTABLE9781Dto, UpdateTABLE9781Dto, int>, ITABLE9781Service
{
    public TABLE9781Service(IRepository<TABLE9781> repository)
        : base(repository, TABLE9781MappingExtensions.ToDto, TABLE9781MappingExtensions.ToEntity, TABLE9781MappingExtensions.UpdateEntity) { }
}
