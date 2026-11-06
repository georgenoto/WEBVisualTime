using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9248;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9248Service : CrudService<TABLE9248, TABLE9248Dto, CreateTABLE9248Dto, UpdateTABLE9248Dto, int>, ITABLE9248Service
{
    public TABLE9248Service(IRepository<TABLE9248> repository)
        : base(repository, TABLE9248MappingExtensions.ToDto, TABLE9248MappingExtensions.ToEntity, TABLE9248MappingExtensions.UpdateEntity) { }
}
