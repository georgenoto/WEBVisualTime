using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5743;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5743Service : CrudService<TABLE5743, TABLE5743Dto, CreateTABLE5743Dto, UpdateTABLE5743Dto, int>, ITABLE5743Service
{
    public TABLE5743Service(IRepository<TABLE5743> repository)
        : base(repository, TABLE5743MappingExtensions.ToDto, TABLE5743MappingExtensions.ToEntity, TABLE5743MappingExtensions.UpdateEntity) { }
}
