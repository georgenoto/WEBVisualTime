using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE114;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE114Service : CrudService<TABLE114, TABLE114Dto, CreateTABLE114Dto, UpdateTABLE114Dto, long>, ITABLE114Service
{
    public TABLE114Service(IRepository<TABLE114> repository)
        : base(repository, TABLE114MappingExtensions.ToDto, TABLE114MappingExtensions.ToEntity, TABLE114MappingExtensions.UpdateEntity) { }
}
