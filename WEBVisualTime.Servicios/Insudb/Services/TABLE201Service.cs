using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE201;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE201Service : CrudService<TABLE201, TABLE201Dto, CreateTABLE201Dto, UpdateTABLE201Dto, int>, ITABLE201Service
{
    public TABLE201Service(IRepository<TABLE201> repository)
        : base(repository, TABLE201MappingExtensions.ToDto, TABLE201MappingExtensions.ToEntity, TABLE201MappingExtensions.UpdateEntity) { }
}
