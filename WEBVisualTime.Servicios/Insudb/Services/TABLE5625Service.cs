using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5625;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5625Service : CrudService<TABLE5625, TABLE5625Dto, CreateTABLE5625Dto, UpdateTABLE5625Dto, int>, ITABLE5625Service
{
    public TABLE5625Service(IRepository<TABLE5625> repository)
        : base(repository, TABLE5625MappingExtensions.ToDto, TABLE5625MappingExtensions.ToEntity, TABLE5625MappingExtensions.UpdateEntity) { }
}
