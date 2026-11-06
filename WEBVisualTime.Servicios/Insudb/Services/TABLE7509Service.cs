using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7509;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7509Service : CrudService<TABLE7509, TABLE7509Dto, CreateTABLE7509Dto, UpdateTABLE7509Dto, int>, ITABLE7509Service
{
    public TABLE7509Service(IRepository<TABLE7509> repository)
        : base(repository, TABLE7509MappingExtensions.ToDto, TABLE7509MappingExtensions.ToEntity, TABLE7509MappingExtensions.UpdateEntity) { }
}
