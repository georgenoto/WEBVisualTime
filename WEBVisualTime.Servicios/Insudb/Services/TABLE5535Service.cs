using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5535;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5535Service : CrudService<TABLE5535, TABLE5535Dto, CreateTABLE5535Dto, UpdateTABLE5535Dto, int>, ITABLE5535Service
{
    public TABLE5535Service(IRepository<TABLE5535> repository)
        : base(repository, TABLE5535MappingExtensions.ToDto, TABLE5535MappingExtensions.ToEntity, TABLE5535MappingExtensions.UpdateEntity) { }
}
