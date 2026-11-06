using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE901;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE901Service : CrudService<TABLE901, TABLE901Dto, CreateTABLE901Dto, UpdateTABLE901Dto, long>, ITABLE901Service
{
    public TABLE901Service(IRepository<TABLE901> repository)
        : base(repository, TABLE901MappingExtensions.ToDto, TABLE901MappingExtensions.ToEntity, TABLE901MappingExtensions.UpdateEntity) { }
}
