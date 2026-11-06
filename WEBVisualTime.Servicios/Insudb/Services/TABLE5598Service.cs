using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5598;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5598Service : CrudService<TABLE5598, TABLE5598Dto, CreateTABLE5598Dto, UpdateTABLE5598Dto, int>, ITABLE5598Service
{
    public TABLE5598Service(IRepository<TABLE5598> repository)
        : base(repository, TABLE5598MappingExtensions.ToDto, TABLE5598MappingExtensions.ToEntity, TABLE5598MappingExtensions.UpdateEntity) { }
}
