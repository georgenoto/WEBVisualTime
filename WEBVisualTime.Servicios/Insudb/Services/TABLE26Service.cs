using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE26;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE26Service : CrudService<TABLE26, TABLE26Dto, CreateTABLE26Dto, UpdateTABLE26Dto, long>, ITABLE26Service
{
    public TABLE26Service(IRepository<TABLE26> repository)
        : base(repository, TABLE26MappingExtensions.ToDto, TABLE26MappingExtensions.ToEntity, TABLE26MappingExtensions.UpdateEntity) { }
}
