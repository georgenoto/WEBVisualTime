using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5606;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5606Service : CrudService<TABLE5606, TABLE5606Dto, CreateTABLE5606Dto, UpdateTABLE5606Dto, int>, ITABLE5606Service
{
    public TABLE5606Service(IRepository<TABLE5606> repository)
        : base(repository, TABLE5606MappingExtensions.ToDto, TABLE5606MappingExtensions.ToEntity, TABLE5606MappingExtensions.UpdateEntity) { }
}
