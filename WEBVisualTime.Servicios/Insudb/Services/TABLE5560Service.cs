using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5560;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5560Service : CrudService<TABLE5560, TABLE5560Dto, CreateTABLE5560Dto, UpdateTABLE5560Dto, int>, ITABLE5560Service
{
    public TABLE5560Service(IRepository<TABLE5560> repository)
        : base(repository, TABLE5560MappingExtensions.ToDto, TABLE5560MappingExtensions.ToEntity, TABLE5560MappingExtensions.UpdateEntity) { }
}
