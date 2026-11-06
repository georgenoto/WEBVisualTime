using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE89;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE89Service : CrudService<TABLE89, TABLE89Dto, CreateTABLE89Dto, UpdateTABLE89Dto, long>, ITABLE89Service
{
    public TABLE89Service(IRepository<TABLE89> repository)
        : base(repository, TABLE89MappingExtensions.ToDto, TABLE89MappingExtensions.ToEntity, TABLE89MappingExtensions.UpdateEntity) { }
}
