using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7203;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7203Service : CrudService<TABLE7203, TABLE7203Dto, CreateTABLE7203Dto, UpdateTABLE7203Dto, long>, ITABLE7203Service
{
    public TABLE7203Service(IRepository<TABLE7203> repository)
        : base(repository, TABLE7203MappingExtensions.ToDto, TABLE7203MappingExtensions.ToEntity, TABLE7203MappingExtensions.UpdateEntity) { }
}
