using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5546;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5546Service : CrudService<TABLE5546, TABLE5546Dto, CreateTABLE5546Dto, UpdateTABLE5546Dto, int>, ITABLE5546Service
{
    public TABLE5546Service(IRepository<TABLE5546> repository)
        : base(repository, TABLE5546MappingExtensions.ToDto, TABLE5546MappingExtensions.ToEntity, TABLE5546MappingExtensions.UpdateEntity) { }
}
