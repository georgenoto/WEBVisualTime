using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE253;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE253Service : CrudService<TABLE253, TABLE253Dto, CreateTABLE253Dto, UpdateTABLE253Dto, int>, ITABLE253Service
{
    public TABLE253Service(IRepository<TABLE253> repository)
        : base(repository, TABLE253MappingExtensions.ToDto, TABLE253MappingExtensions.ToEntity, TABLE253MappingExtensions.UpdateEntity) { }
}
