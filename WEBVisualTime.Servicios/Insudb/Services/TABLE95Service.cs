using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE95;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE95Service : CrudService<TABLE95, TABLE95Dto, CreateTABLE95Dto, UpdateTABLE95Dto, int>, ITABLE95Service
{
    public TABLE95Service(IRepository<TABLE95> repository)
        : base(repository, TABLE95MappingExtensions.ToDto, TABLE95MappingExtensions.ToEntity, TABLE95MappingExtensions.UpdateEntity) { }
}
