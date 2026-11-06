using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE233;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE233Service : CrudService<TABLE233, TABLE233Dto, CreateTABLE233Dto, UpdateTABLE233Dto, int>, ITABLE233Service
{
    public TABLE233Service(IRepository<TABLE233> repository)
        : base(repository, TABLE233MappingExtensions.ToDto, TABLE233MappingExtensions.ToEntity, TABLE233MappingExtensions.UpdateEntity) { }
}
