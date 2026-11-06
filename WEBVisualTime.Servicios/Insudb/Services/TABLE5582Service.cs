using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5582;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5582Service : CrudService<TABLE5582, TABLE5582Dto, CreateTABLE5582Dto, UpdateTABLE5582Dto, int>, ITABLE5582Service
{
    public TABLE5582Service(IRepository<TABLE5582> repository)
        : base(repository, TABLE5582MappingExtensions.ToDto, TABLE5582MappingExtensions.ToEntity, TABLE5582MappingExtensions.UpdateEntity) { }
}
