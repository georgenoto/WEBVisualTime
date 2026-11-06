using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5641;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5641Service : CrudService<TABLE5641, TABLE5641Dto, CreateTABLE5641Dto, UpdateTABLE5641Dto, int>, ITABLE5641Service
{
    public TABLE5641Service(IRepository<TABLE5641> repository)
        : base(repository, TABLE5641MappingExtensions.ToDto, TABLE5641MappingExtensions.ToEntity, TABLE5641MappingExtensions.UpdateEntity) { }
}
