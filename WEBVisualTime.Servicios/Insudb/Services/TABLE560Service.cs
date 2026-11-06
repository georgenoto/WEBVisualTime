using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE560;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE560Service : CrudService<TABLE560, TABLE560Dto, CreateTABLE560Dto, UpdateTABLE560Dto, int>, ITABLE560Service
{
    public TABLE560Service(IRepository<TABLE560> repository)
        : base(repository, TABLE560MappingExtensions.ToDto, TABLE560MappingExtensions.ToEntity, TABLE560MappingExtensions.UpdateEntity) { }
}
