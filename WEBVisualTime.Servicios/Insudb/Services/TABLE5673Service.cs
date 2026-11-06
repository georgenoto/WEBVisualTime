using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5673;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5673Service : CrudService<TABLE5673, TABLE5673Dto, CreateTABLE5673Dto, UpdateTABLE5673Dto, int>, ITABLE5673Service
{
    public TABLE5673Service(IRepository<TABLE5673> repository)
        : base(repository, TABLE5673MappingExtensions.ToDto, TABLE5673MappingExtensions.ToEntity, TABLE5673MappingExtensions.UpdateEntity) { }
}
