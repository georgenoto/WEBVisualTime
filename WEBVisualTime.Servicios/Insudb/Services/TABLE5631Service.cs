using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5631;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5631Service : CrudService<TABLE5631, TABLE5631Dto, CreateTABLE5631Dto, UpdateTABLE5631Dto, int>, ITABLE5631Service
{
    public TABLE5631Service(IRepository<TABLE5631> repository)
        : base(repository, TABLE5631MappingExtensions.ToDto, TABLE5631MappingExtensions.ToEntity, TABLE5631MappingExtensions.UpdateEntity) { }
}
