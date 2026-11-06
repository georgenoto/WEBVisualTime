using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7007;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7007Service : CrudService<TABLE7007, TABLE7007Dto, CreateTABLE7007Dto, UpdateTABLE7007Dto, long>, ITABLE7007Service
{
    public TABLE7007Service(IRepository<TABLE7007> repository)
        : base(repository, TABLE7007MappingExtensions.ToDto, TABLE7007MappingExtensions.ToEntity, TABLE7007MappingExtensions.UpdateEntity) { }
}
