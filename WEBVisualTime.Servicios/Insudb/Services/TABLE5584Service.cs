using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5584;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5584Service : CrudService<TABLE5584, TABLE5584Dto, CreateTABLE5584Dto, UpdateTABLE5584Dto, int>, ITABLE5584Service
{
    public TABLE5584Service(IRepository<TABLE5584> repository)
        : base(repository, TABLE5584MappingExtensions.ToDto, TABLE5584MappingExtensions.ToEntity, TABLE5584MappingExtensions.UpdateEntity) { }
}
