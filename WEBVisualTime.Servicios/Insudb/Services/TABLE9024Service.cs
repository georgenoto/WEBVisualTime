using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9024;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9024Service : CrudService<TABLE9024, TABLE9024Dto, CreateTABLE9024Dto, UpdateTABLE9024Dto, int>, ITABLE9024Service
{
    public TABLE9024Service(IRepository<TABLE9024> repository)
        : base(repository, TABLE9024MappingExtensions.ToDto, TABLE9024MappingExtensions.ToEntity, TABLE9024MappingExtensions.UpdateEntity) { }
}
