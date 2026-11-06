using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE219;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE219Service : CrudService<TABLE219, TABLE219Dto, CreateTABLE219Dto, UpdateTABLE219Dto, long>, ITABLE219Service
{
    public TABLE219Service(IRepository<TABLE219> repository)
        : base(repository, TABLE219MappingExtensions.ToDto, TABLE219MappingExtensions.ToEntity, TABLE219MappingExtensions.UpdateEntity) { }
}
