using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9040;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9040Service : CrudService<TABLE9040, TABLE9040Dto, CreateTABLE9040Dto, UpdateTABLE9040Dto, int>, ITABLE9040Service
{
    public TABLE9040Service(IRepository<TABLE9040> repository)
        : base(repository, TABLE9040MappingExtensions.ToDto, TABLE9040MappingExtensions.ToEntity, TABLE9040MappingExtensions.UpdateEntity) { }
}
