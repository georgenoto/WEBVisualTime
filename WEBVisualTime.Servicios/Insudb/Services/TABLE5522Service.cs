using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5522;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5522Service : CrudService<TABLE5522, TABLE5522Dto, CreateTABLE5522Dto, UpdateTABLE5522Dto, int>, ITABLE5522Service
{
    public TABLE5522Service(IRepository<TABLE5522> repository)
        : base(repository, TABLE5522MappingExtensions.ToDto, TABLE5522MappingExtensions.ToEntity, TABLE5522MappingExtensions.UpdateEntity) { }
}
