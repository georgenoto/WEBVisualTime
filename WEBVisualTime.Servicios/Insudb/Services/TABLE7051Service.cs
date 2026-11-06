using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7051;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7051Service : CrudService<TABLE7051, TABLE7051Dto, CreateTABLE7051Dto, UpdateTABLE7051Dto, long>, ITABLE7051Service
{
    public TABLE7051Service(IRepository<TABLE7051> repository)
        : base(repository, TABLE7051MappingExtensions.ToDto, TABLE7051MappingExtensions.ToEntity, TABLE7051MappingExtensions.UpdateEntity) { }
}
