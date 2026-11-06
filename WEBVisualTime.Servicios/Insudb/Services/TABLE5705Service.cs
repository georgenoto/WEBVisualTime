using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5705;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5705Service : CrudService<TABLE5705, TABLE5705Dto, CreateTABLE5705Dto, UpdateTABLE5705Dto, int>, ITABLE5705Service
{
    public TABLE5705Service(IRepository<TABLE5705> repository)
        : base(repository, TABLE5705MappingExtensions.ToDto, TABLE5705MappingExtensions.ToEntity, TABLE5705MappingExtensions.UpdateEntity) { }
}
