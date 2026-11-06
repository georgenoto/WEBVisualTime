using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5647;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5647Service : CrudService<TABLE5647, TABLE5647Dto, CreateTABLE5647Dto, UpdateTABLE5647Dto, int>, ITABLE5647Service
{
    public TABLE5647Service(IRepository<TABLE5647> repository)
        : base(repository, TABLE5647MappingExtensions.ToDto, TABLE5647MappingExtensions.ToEntity, TABLE5647MappingExtensions.UpdateEntity) { }
}
