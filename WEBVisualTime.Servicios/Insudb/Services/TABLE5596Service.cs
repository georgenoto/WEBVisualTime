using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5596;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5596Service : CrudService<TABLE5596, TABLE5596Dto, CreateTABLE5596Dto, UpdateTABLE5596Dto, int>, ITABLE5596Service
{
    public TABLE5596Service(IRepository<TABLE5596> repository)
        : base(repository, TABLE5596MappingExtensions.ToDto, TABLE5596MappingExtensions.ToEntity, TABLE5596MappingExtensions.UpdateEntity) { }
}
