using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE903;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE903Service : CrudService<TABLE903, TABLE903Dto, CreateTABLE903Dto, UpdateTABLE903Dto, int>, ITABLE903Service
{
    public TABLE903Service(IRepository<TABLE903> repository)
        : base(repository, TABLE903MappingExtensions.ToDto, TABLE903MappingExtensions.ToEntity, TABLE903MappingExtensions.UpdateEntity) { }
}
