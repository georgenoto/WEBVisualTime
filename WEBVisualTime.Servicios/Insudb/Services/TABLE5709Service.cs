using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5709;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5709Service : CrudService<TABLE5709, TABLE5709Dto, CreateTABLE5709Dto, UpdateTABLE5709Dto, long>, ITABLE5709Service
{
    public TABLE5709Service(IRepository<TABLE5709> repository)
        : base(repository, TABLE5709MappingExtensions.ToDto, TABLE5709MappingExtensions.ToEntity, TABLE5709MappingExtensions.UpdateEntity) { }
}
