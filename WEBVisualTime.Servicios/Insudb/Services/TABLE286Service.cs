using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE286;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE286Service : CrudService<TABLE286, TABLE286Dto, CreateTABLE286Dto, UpdateTABLE286Dto, long>, ITABLE286Service
{
    public TABLE286Service(IRepository<TABLE286> repository)
        : base(repository, TABLE286MappingExtensions.ToDto, TABLE286MappingExtensions.ToEntity, TABLE286MappingExtensions.UpdateEntity) { }
}
