using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE692Service : CrudService<TABLE692, TABLE692Dto, CreateTABLE692Dto, UpdateTABLE692Dto, int>, ITABLE692Service
{
    public TABLE692Service(IRepository<TABLE692> repository)
        : base(repository, TABLE692MappingExtensions.ToDto, TABLE692MappingExtensions.ToEntity, TABLE692MappingExtensions.UpdateEntity) { }
}
