using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9003;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9003Service : CrudService<TABLE9003, TABLE9003Dto, CreateTABLE9003Dto, UpdateTABLE9003Dto, int>, ITABLE9003Service
{
    public TABLE9003Service(IRepository<TABLE9003> repository)
        : base(repository, TABLE9003MappingExtensions.ToDto, TABLE9003MappingExtensions.ToEntity, TABLE9003MappingExtensions.UpdateEntity) { }
}
