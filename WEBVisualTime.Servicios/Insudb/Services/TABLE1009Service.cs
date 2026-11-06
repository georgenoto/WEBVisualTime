using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1009;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE1009Service : CrudService<TABLE1009, TABLE1009Dto, CreateTABLE1009Dto, UpdateTABLE1009Dto, long>, ITABLE1009Service
{
    public TABLE1009Service(IRepository<TABLE1009> repository)
        : base(repository, TABLE1009MappingExtensions.ToDto, TABLE1009MappingExtensions.ToEntity, TABLE1009MappingExtensions.UpdateEntity) { }
}
