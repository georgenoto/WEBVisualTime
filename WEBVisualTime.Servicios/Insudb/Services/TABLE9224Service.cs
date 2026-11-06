using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9224;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9224Service : CrudService<TABLE9224, TABLE9224Dto, CreateTABLE9224Dto, UpdateTABLE9224Dto, int>, ITABLE9224Service
{
    public TABLE9224Service(IRepository<TABLE9224> repository)
        : base(repository, TABLE9224MappingExtensions.ToDto, TABLE9224MappingExtensions.ToEntity, TABLE9224MappingExtensions.UpdateEntity) { }
}
