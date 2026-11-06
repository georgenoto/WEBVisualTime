using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE224;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE224Service : CrudService<TABLE224, TABLE224Dto, CreateTABLE224Dto, UpdateTABLE224Dto, long>, ITABLE224Service
{
    public TABLE224Service(IRepository<TABLE224> repository)
        : base(repository, TABLE224MappingExtensions.ToDto, TABLE224MappingExtensions.ToEntity, TABLE224MappingExtensions.UpdateEntity) { }
}
