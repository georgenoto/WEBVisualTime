using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE16;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE16Service : CrudService<TABLE16, TABLE16Dto, CreateTABLE16Dto, UpdateTABLE16Dto, long>, ITABLE16Service
{
    public TABLE16Service(IRepository<TABLE16> repository)
        : base(repository, TABLE16MappingExtensions.ToDto, TABLE16MappingExtensions.ToEntity, TABLE16MappingExtensions.UpdateEntity) { }
}
