using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5749;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5749Service : CrudService<TABLE5749, TABLE5749Dto, CreateTABLE5749Dto, UpdateTABLE5749Dto, int>, ITABLE5749Service
{
    public TABLE5749Service(IRepository<TABLE5749> repository)
        : base(repository, TABLE5749MappingExtensions.ToDto, TABLE5749MappingExtensions.ToEntity, TABLE5749MappingExtensions.UpdateEntity) { }
}
