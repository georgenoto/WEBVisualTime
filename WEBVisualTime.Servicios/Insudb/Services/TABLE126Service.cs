using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE126;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE126Service : CrudService<TABLE126, TABLE126Dto, CreateTABLE126Dto, UpdateTABLE126Dto, long>, ITABLE126Service
{
    public TABLE126Service(IRepository<TABLE126> repository)
        : base(repository, TABLE126MappingExtensions.ToDto, TABLE126MappingExtensions.ToEntity, TABLE126MappingExtensions.UpdateEntity) { }
}
