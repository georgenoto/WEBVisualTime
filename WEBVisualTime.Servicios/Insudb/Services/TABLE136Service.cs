using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE136;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE136Service : CrudService<TABLE136, TABLE136Dto, CreateTABLE136Dto, UpdateTABLE136Dto, int>, ITABLE136Service
{
    public TABLE136Service(IRepository<TABLE136> repository)
        : base(repository, TABLE136MappingExtensions.ToDto, TABLE136MappingExtensions.ToEntity, TABLE136MappingExtensions.UpdateEntity) { }
}
