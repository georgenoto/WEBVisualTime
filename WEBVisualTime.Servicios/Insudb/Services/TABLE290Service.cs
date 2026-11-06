using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE290;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE290Service : CrudService<TABLE290, TABLE290Dto, CreateTABLE290Dto, UpdateTABLE290Dto, long>, ITABLE290Service
{
    public TABLE290Service(IRepository<TABLE290> repository)
        : base(repository, TABLE290MappingExtensions.ToDto, TABLE290MappingExtensions.ToEntity, TABLE290MappingExtensions.UpdateEntity) { }
}
