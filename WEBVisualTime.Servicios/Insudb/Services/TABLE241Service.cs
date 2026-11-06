using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE241;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE241Service : CrudService<TABLE241, TABLE241Dto, CreateTABLE241Dto, UpdateTABLE241Dto, int>, ITABLE241Service
{
    public TABLE241Service(IRepository<TABLE241> repository)
        : base(repository, TABLE241MappingExtensions.ToDto, TABLE241MappingExtensions.ToEntity, TABLE241MappingExtensions.UpdateEntity) { }
}
