using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5550;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5550Service : CrudService<TABLE5550, TABLE5550Dto, CreateTABLE5550Dto, UpdateTABLE5550Dto, int>, ITABLE5550Service
{
    public TABLE5550Service(IRepository<TABLE5550> repository)
        : base(repository, TABLE5550MappingExtensions.ToDto, TABLE5550MappingExtensions.ToEntity, TABLE5550MappingExtensions.UpdateEntity) { }
}
