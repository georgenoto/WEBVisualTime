using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9262;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9262Service : CrudService<TABLE9262, TABLE9262Dto, CreateTABLE9262Dto, UpdateTABLE9262Dto, int>, ITABLE9262Service
{
    public TABLE9262Service(IRepository<TABLE9262> repository)
        : base(repository, TABLE9262MappingExtensions.ToDto, TABLE9262MappingExtensions.ToEntity, TABLE9262MappingExtensions.UpdateEntity) { }
}
