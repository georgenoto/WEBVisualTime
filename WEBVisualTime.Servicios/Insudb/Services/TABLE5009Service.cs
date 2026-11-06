using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5009;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5009Service : CrudService<TABLE5009, TABLE5009Dto, CreateTABLE5009Dto, UpdateTABLE5009Dto, int>, ITABLE5009Service
{
    public TABLE5009Service(IRepository<TABLE5009> repository)
        : base(repository, TABLE5009MappingExtensions.ToDto, TABLE5009MappingExtensions.ToEntity, TABLE5009MappingExtensions.UpdateEntity) { }
}
