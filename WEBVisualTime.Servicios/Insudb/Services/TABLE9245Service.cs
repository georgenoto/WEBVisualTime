using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9245;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9245Service : CrudService<TABLE9245, TABLE9245Dto, CreateTABLE9245Dto, UpdateTABLE9245Dto, int>, ITABLE9245Service
{
    public TABLE9245Service(IRepository<TABLE9245> repository)
        : base(repository, TABLE9245MappingExtensions.ToDto, TABLE9245MappingExtensions.ToEntity, TABLE9245MappingExtensions.UpdateEntity) { }
}
