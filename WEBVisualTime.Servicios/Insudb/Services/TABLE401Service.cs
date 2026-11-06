using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE401;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE401Service : CrudService<TABLE401, TABLE401Dto, CreateTABLE401Dto, UpdateTABLE401Dto, int>, ITABLE401Service
{
    public TABLE401Service(IRepository<TABLE401> repository)
        : base(repository, TABLE401MappingExtensions.ToDto, TABLE401MappingExtensions.ToEntity, TABLE401MappingExtensions.UpdateEntity) { }
}
