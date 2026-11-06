using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5812;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5812Service : CrudService<TABLE5812, TABLE5812Dto, CreateTABLE5812Dto, UpdateTABLE5812Dto, int>, ITABLE5812Service
{
    public TABLE5812Service(IRepository<TABLE5812> repository)
        : base(repository, TABLE5812MappingExtensions.ToDto, TABLE5812MappingExtensions.ToEntity, TABLE5812MappingExtensions.UpdateEntity) { }
}
