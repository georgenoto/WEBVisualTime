using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5525;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5525Service : CrudService<TABLE5525, TABLE5525Dto, CreateTABLE5525Dto, UpdateTABLE5525Dto, int>, ITABLE5525Service
{
    public TABLE5525Service(IRepository<TABLE5525> repository)
        : base(repository, TABLE5525MappingExtensions.ToDto, TABLE5525MappingExtensions.ToEntity, TABLE5525MappingExtensions.UpdateEntity) { }
}
