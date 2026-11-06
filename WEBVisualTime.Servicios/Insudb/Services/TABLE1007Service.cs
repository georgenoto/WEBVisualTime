using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1007;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE1007Service : CrudService<TABLE1007, TABLE1007Dto, CreateTABLE1007Dto, UpdateTABLE1007Dto, long>, ITABLE1007Service
{
    public TABLE1007Service(IRepository<TABLE1007> repository)
        : base(repository, TABLE1007MappingExtensions.ToDto, TABLE1007MappingExtensions.ToEntity, TABLE1007MappingExtensions.UpdateEntity) { }
}
