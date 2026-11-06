using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7002;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7002Service : CrudService<TABLE7002, TABLE7002Dto, CreateTABLE7002Dto, UpdateTABLE7002Dto, int>, ITABLE7002Service
{
    public TABLE7002Service(IRepository<TABLE7002> repository)
        : base(repository, TABLE7002MappingExtensions.ToDto, TABLE7002MappingExtensions.ToEntity, TABLE7002MappingExtensions.UpdateEntity) { }
}
