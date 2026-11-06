using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE146;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE146Service : CrudService<TABLE146, TABLE146Dto, CreateTABLE146Dto, UpdateTABLE146Dto, int>, ITABLE146Service
{
    public TABLE146Service(IRepository<TABLE146> repository)
        : base(repository, TABLE146MappingExtensions.ToDto, TABLE146MappingExtensions.ToEntity, TABLE146MappingExtensions.UpdateEntity) { }
}
