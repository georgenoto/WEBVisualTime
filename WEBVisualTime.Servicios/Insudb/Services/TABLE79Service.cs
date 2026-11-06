using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE79;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE79Service : CrudService<TABLE79, TABLE79Dto, CreateTABLE79Dto, UpdateTABLE79Dto, string>, ITABLE79Service
{
    public TABLE79Service(IRepository<TABLE79> repository)
        : base(repository, TABLE79MappingExtensions.ToDto, TABLE79MappingExtensions.ToEntity, TABLE79MappingExtensions.UpdateEntity) { }
}
