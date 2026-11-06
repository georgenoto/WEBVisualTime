using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5574;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5574Service : CrudService<TABLE5574, TABLE5574Dto, CreateTABLE5574Dto, UpdateTABLE5574Dto, int>, ITABLE5574Service
{
    public TABLE5574Service(IRepository<TABLE5574> repository)
        : base(repository, TABLE5574MappingExtensions.ToDto, TABLE5574MappingExtensions.ToEntity, TABLE5574MappingExtensions.UpdateEntity) { }
}
