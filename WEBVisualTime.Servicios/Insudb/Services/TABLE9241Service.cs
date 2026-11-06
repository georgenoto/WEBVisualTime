using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9241;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9241Service : CrudService<TABLE9241, TABLE9241Dto, CreateTABLE9241Dto, UpdateTABLE9241Dto, int>, ITABLE9241Service
{
    public TABLE9241Service(IRepository<TABLE9241> repository)
        : base(repository, TABLE9241MappingExtensions.ToDto, TABLE9241MappingExtensions.ToEntity, TABLE9241MappingExtensions.UpdateEntity) { }
}
