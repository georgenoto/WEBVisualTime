using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5578;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5578Service : CrudService<TABLE5578, TABLE5578Dto, CreateTABLE5578Dto, UpdateTABLE5578Dto, int>, ITABLE5578Service
{
    public TABLE5578Service(IRepository<TABLE5578> repository)
        : base(repository, TABLE5578MappingExtensions.ToDto, TABLE5578MappingExtensions.ToEntity, TABLE5578MappingExtensions.UpdateEntity) { }
}
