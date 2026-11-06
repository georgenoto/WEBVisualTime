using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5506;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5506Service : CrudService<TABLE5506, TABLE5506Dto, CreateTABLE5506Dto, UpdateTABLE5506Dto, int>, ITABLE5506Service
{
    public TABLE5506Service(IRepository<TABLE5506> repository)
        : base(repository, TABLE5506MappingExtensions.ToDto, TABLE5506MappingExtensions.ToEntity, TABLE5506MappingExtensions.UpdateEntity) { }
}
