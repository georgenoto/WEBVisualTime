using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7Service : CrudService<TABLE7, TABLE7Dto, CreateTABLE7Dto, UpdateTABLE7Dto, long>, ITABLE7Service
{
    public TABLE7Service(IRepository<TABLE7> repository)
        : base(repository, TABLE7MappingExtensions.ToDto, TABLE7MappingExtensions.ToEntity, TABLE7MappingExtensions.UpdateEntity) { }
}
