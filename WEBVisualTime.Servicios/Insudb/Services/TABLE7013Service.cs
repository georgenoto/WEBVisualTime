using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7013;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7013Service : CrudService<TABLE7013, TABLE7013Dto, CreateTABLE7013Dto, UpdateTABLE7013Dto, long>, ITABLE7013Service
{
    public TABLE7013Service(IRepository<TABLE7013> repository)
        : base(repository, TABLE7013MappingExtensions.ToDto, TABLE7013MappingExtensions.ToEntity, TABLE7013MappingExtensions.UpdateEntity) { }
}
