using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5650;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5650Service : CrudService<TABLE5650, TABLE5650Dto, CreateTABLE5650Dto, UpdateTABLE5650Dto, int>, ITABLE5650Service
{
    public TABLE5650Service(IRepository<TABLE5650> repository)
        : base(repository, TABLE5650MappingExtensions.ToDto, TABLE5650MappingExtensions.ToEntity, TABLE5650MappingExtensions.UpdateEntity) { }
}
