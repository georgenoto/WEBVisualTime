using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9006;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9006Service : CrudService<TABLE9006, TABLE9006Dto, CreateTABLE9006Dto, UpdateTABLE9006Dto, int>, ITABLE9006Service
{
    public TABLE9006Service(IRepository<TABLE9006> repository)
        : base(repository, TABLE9006MappingExtensions.ToDto, TABLE9006MappingExtensions.ToEntity, TABLE9006MappingExtensions.UpdateEntity) { }
}
