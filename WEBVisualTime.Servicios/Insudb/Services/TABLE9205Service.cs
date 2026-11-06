using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9205;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9205Service : CrudService<TABLE9205, TABLE9205Dto, CreateTABLE9205Dto, UpdateTABLE9205Dto, int>, ITABLE9205Service
{
    public TABLE9205Service(IRepository<TABLE9205> repository)
        : base(repository, TABLE9205MappingExtensions.ToDto, TABLE9205MappingExtensions.ToEntity, TABLE9205MappingExtensions.UpdateEntity) { }
}
