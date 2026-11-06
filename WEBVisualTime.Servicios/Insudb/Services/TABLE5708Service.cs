using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5708;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5708Service : CrudService<TABLE5708, TABLE5708Dto, CreateTABLE5708Dto, UpdateTABLE5708Dto, long>, ITABLE5708Service
{
    public TABLE5708Service(IRepository<TABLE5708> repository)
        : base(repository, TABLE5708MappingExtensions.ToDto, TABLE5708MappingExtensions.ToEntity, TABLE5708MappingExtensions.UpdateEntity) { }
}
