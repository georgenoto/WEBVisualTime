using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9267;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9267Service : CrudService<TABLE9267, TABLE9267Dto, CreateTABLE9267Dto, UpdateTABLE9267Dto, int>, ITABLE9267Service
{
    public TABLE9267Service(IRepository<TABLE9267> repository)
        : base(repository, TABLE9267MappingExtensions.ToDto, TABLE9267MappingExtensions.ToEntity, TABLE9267MappingExtensions.UpdateEntity) { }
}
