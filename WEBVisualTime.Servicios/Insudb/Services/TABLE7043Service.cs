using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7043;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7043Service : CrudService<TABLE7043, TABLE7043Dto, CreateTABLE7043Dto, UpdateTABLE7043Dto, long>, ITABLE7043Service
{
    public TABLE7043Service(IRepository<TABLE7043> repository)
        : base(repository, TABLE7043MappingExtensions.ToDto, TABLE7043MappingExtensions.ToEntity, TABLE7043MappingExtensions.UpdateEntity) { }
}
