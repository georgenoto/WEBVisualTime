using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5556Service : CrudService<TABLE5556, TABLE5556Dto, CreateTABLE5556Dto, UpdateTABLE5556Dto, int>, ITABLE5556Service
{
    public TABLE5556Service(IRepository<TABLE5556> repository)
        : base(repository, TABLE5556MappingExtensions.ToDto, TABLE5556MappingExtensions.ToEntity, TABLE5556MappingExtensions.UpdateEntity) { }
}
