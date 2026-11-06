using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5532;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5532Service : CrudService<TABLE5532, TABLE5532Dto, CreateTABLE5532Dto, UpdateTABLE5532Dto, int>, ITABLE5532Service
{
    public TABLE5532Service(IRepository<TABLE5532> repository)
        : base(repository, TABLE5532MappingExtensions.ToDto, TABLE5532MappingExtensions.ToEntity, TABLE5532MappingExtensions.UpdateEntity) { }
}
