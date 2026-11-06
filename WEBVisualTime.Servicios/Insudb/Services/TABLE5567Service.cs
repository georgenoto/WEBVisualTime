using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5567;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5567Service : CrudService<TABLE5567, TABLE5567Dto, CreateTABLE5567Dto, UpdateTABLE5567Dto, int>, ITABLE5567Service
{
    public TABLE5567Service(IRepository<TABLE5567> repository)
        : base(repository, TABLE5567MappingExtensions.ToDto, TABLE5567MappingExtensions.ToEntity, TABLE5567MappingExtensions.UpdateEntity) { }
}
