using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5534;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5534Service : CrudService<TABLE5534, TABLE5534Dto, CreateTABLE5534Dto, UpdateTABLE5534Dto, int>, ITABLE5534Service
{
    public TABLE5534Service(IRepository<TABLE5534> repository)
        : base(repository, TABLE5534MappingExtensions.ToDto, TABLE5534MappingExtensions.ToEntity, TABLE5534MappingExtensions.UpdateEntity) { }
}
