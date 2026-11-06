using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE259;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE259Service : CrudService<TABLE259, TABLE259Dto, CreateTABLE259Dto, UpdateTABLE259Dto, long>, ITABLE259Service
{
    public TABLE259Service(IRepository<TABLE259> repository)
        : base(repository, TABLE259MappingExtensions.ToDto, TABLE259MappingExtensions.ToEntity, TABLE259MappingExtensions.UpdateEntity) { }
}
