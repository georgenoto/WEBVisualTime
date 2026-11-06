using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5553;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5553Service : CrudService<TABLE5553, TABLE5553Dto, CreateTABLE5553Dto, UpdateTABLE5553Dto, int>, ITABLE5553Service
{
    public TABLE5553Service(IRepository<TABLE5553> repository)
        : base(repository, TABLE5553MappingExtensions.ToDto, TABLE5553MappingExtensions.ToEntity, TABLE5553MappingExtensions.UpdateEntity) { }
}
