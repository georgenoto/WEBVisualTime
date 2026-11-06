using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE1Service : CrudService<TABLE1, TABLE1Dto, CreateTABLE1Dto, UpdateTABLE1Dto, long>, ITABLE1Service
{
    public TABLE1Service(IRepository<TABLE1> repository)
        : base(repository, TABLE1MappingExtensions.ToDto, TABLE1MappingExtensions.ToEntity, TABLE1MappingExtensions.UpdateEntity) { }
}
