using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE252;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE252Service : CrudService<TABLE252, TABLE252Dto, CreateTABLE252Dto, UpdateTABLE252Dto, long>, ITABLE252Service
{
    public TABLE252Service(IRepository<TABLE252> repository)
        : base(repository, TABLE252MappingExtensions.ToDto, TABLE252MappingExtensions.ToEntity, TABLE252MappingExtensions.UpdateEntity) { }
}
