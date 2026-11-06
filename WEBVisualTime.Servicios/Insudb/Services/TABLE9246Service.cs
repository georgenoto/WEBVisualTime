using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9246;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9246Service : CrudService<TABLE9246, TABLE9246Dto, CreateTABLE9246Dto, UpdateTABLE9246Dto, int>, ITABLE9246Service
{
    public TABLE9246Service(IRepository<TABLE9246> repository)
        : base(repository, TABLE9246MappingExtensions.ToDto, TABLE9246MappingExtensions.ToEntity, TABLE9246MappingExtensions.UpdateEntity) { }
}
