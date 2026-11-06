using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5700;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5700Service : CrudService<TABLE5700, TABLE5700Dto, CreateTABLE5700Dto, UpdateTABLE5700Dto, int>, ITABLE5700Service
{
    public TABLE5700Service(IRepository<TABLE5700> repository)
        : base(repository, TABLE5700MappingExtensions.ToDto, TABLE5700MappingExtensions.ToEntity, TABLE5700MappingExtensions.UpdateEntity) { }
}
