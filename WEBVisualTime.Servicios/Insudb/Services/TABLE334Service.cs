using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE334;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE334Service : CrudService<TABLE334, TABLE334Dto, CreateTABLE334Dto, UpdateTABLE334Dto, int>, ITABLE334Service
{
    public TABLE334Service(IRepository<TABLE334> repository)
        : base(repository, TABLE334MappingExtensions.ToDto, TABLE334MappingExtensions.ToEntity, TABLE334MappingExtensions.UpdateEntity) { }
}
