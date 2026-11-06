using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9222;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9222Service : CrudService<TABLE9222, TABLE9222Dto, CreateTABLE9222Dto, UpdateTABLE9222Dto, int>, ITABLE9222Service
{
    public TABLE9222Service(IRepository<TABLE9222> repository)
        : base(repository, TABLE9222MappingExtensions.ToDto, TABLE9222MappingExtensions.ToEntity, TABLE9222MappingExtensions.UpdateEntity) { }
}
