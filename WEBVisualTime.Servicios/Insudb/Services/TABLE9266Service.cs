using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9266;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9266Service : CrudService<TABLE9266, TABLE9266Dto, CreateTABLE9266Dto, UpdateTABLE9266Dto, int>, ITABLE9266Service
{
    public TABLE9266Service(IRepository<TABLE9266> repository)
        : base(repository, TABLE9266MappingExtensions.ToDto, TABLE9266MappingExtensions.ToEntity, TABLE9266MappingExtensions.UpdateEntity) { }
}
