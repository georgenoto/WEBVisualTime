using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5704;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5704Service : CrudService<TABLE5704, TABLE5704Dto, CreateTABLE5704Dto, UpdateTABLE5704Dto, int>, ITABLE5704Service
{
    public TABLE5704Service(IRepository<TABLE5704> repository)
        : base(repository, TABLE5704MappingExtensions.ToDto, TABLE5704MappingExtensions.ToEntity, TABLE5704MappingExtensions.UpdateEntity) { }
}
