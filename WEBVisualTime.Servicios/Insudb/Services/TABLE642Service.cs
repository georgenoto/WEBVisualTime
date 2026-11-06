using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE642;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE642Service : CrudService<TABLE642, TABLE642Dto, CreateTABLE642Dto, UpdateTABLE642Dto, int>, ITABLE642Service
{
    public TABLE642Service(IRepository<TABLE642> repository)
        : base(repository, TABLE642MappingExtensions.ToDto, TABLE642MappingExtensions.ToEntity, TABLE642MappingExtensions.UpdateEntity) { }
}
