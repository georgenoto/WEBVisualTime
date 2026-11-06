using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE645;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE645Service : CrudService<TABLE645, TABLE645Dto, CreateTABLE645Dto, UpdateTABLE645Dto, long>, ITABLE645Service
{
    public TABLE645Service(IRepository<TABLE645> repository)
        : base(repository, TABLE645MappingExtensions.ToDto, TABLE645MappingExtensions.ToEntity, TABLE645MappingExtensions.UpdateEntity) { }
}
