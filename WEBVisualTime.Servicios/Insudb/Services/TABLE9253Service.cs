using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9253;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9253Service : CrudService<TABLE9253, TABLE9253Dto, CreateTABLE9253Dto, UpdateTABLE9253Dto, int>, ITABLE9253Service
{
    public TABLE9253Service(IRepository<TABLE9253> repository)
        : base(repository, TABLE9253MappingExtensions.ToDto, TABLE9253MappingExtensions.ToEntity, TABLE9253MappingExtensions.UpdateEntity) { }
}
