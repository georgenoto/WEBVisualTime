using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE285;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE285Service : CrudService<TABLE285, TABLE285Dto, CreateTABLE285Dto, UpdateTABLE285Dto, long>, ITABLE285Service
{
    public TABLE285Service(IRepository<TABLE285> repository)
        : base(repository, TABLE285MappingExtensions.ToDto, TABLE285MappingExtensions.ToEntity, TABLE285MappingExtensions.UpdateEntity) { }
}
