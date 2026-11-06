using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9030;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9030Service : CrudService<TABLE9030, TABLE9030Dto, CreateTABLE9030Dto, UpdateTABLE9030Dto, int>, ITABLE9030Service
{
    public TABLE9030Service(IRepository<TABLE9030> repository)
        : base(repository, TABLE9030MappingExtensions.ToDto, TABLE9030MappingExtensions.ToEntity, TABLE9030MappingExtensions.UpdateEntity) { }
}
