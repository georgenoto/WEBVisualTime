using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9221;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9221Service : CrudService<TABLE9221, TABLE9221Dto, CreateTABLE9221Dto, UpdateTABLE9221Dto, int>, ITABLE9221Service
{
    public TABLE9221Service(IRepository<TABLE9221> repository)
        : base(repository, TABLE9221MappingExtensions.ToDto, TABLE9221MappingExtensions.ToEntity, TABLE9221MappingExtensions.UpdateEntity) { }
}
