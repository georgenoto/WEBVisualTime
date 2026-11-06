using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5747;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5747Service : CrudService<TABLE5747, TABLE5747Dto, CreateTABLE5747Dto, UpdateTABLE5747Dto, int>, ITABLE5747Service
{
    public TABLE5747Service(IRepository<TABLE5747> repository)
        : base(repository, TABLE5747MappingExtensions.ToDto, TABLE5747MappingExtensions.ToEntity, TABLE5747MappingExtensions.UpdateEntity) { }
}
