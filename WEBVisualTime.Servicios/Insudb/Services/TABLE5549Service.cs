using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5549;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5549Service : CrudService<TABLE5549, TABLE5549Dto, CreateTABLE5549Dto, UpdateTABLE5549Dto, int>, ITABLE5549Service
{
    public TABLE5549Service(IRepository<TABLE5549> repository)
        : base(repository, TABLE5549MappingExtensions.ToDto, TABLE5549MappingExtensions.ToEntity, TABLE5549MappingExtensions.UpdateEntity) { }
}
