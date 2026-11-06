using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5536;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5536Service : CrudService<TABLE5536, TABLE5536Dto, CreateTABLE5536Dto, UpdateTABLE5536Dto, int>, ITABLE5536Service
{
    public TABLE5536Service(IRepository<TABLE5536> repository)
        : base(repository, TABLE5536MappingExtensions.ToDto, TABLE5536MappingExtensions.ToEntity, TABLE5536MappingExtensions.UpdateEntity) { }
}
