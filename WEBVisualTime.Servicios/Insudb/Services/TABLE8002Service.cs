using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8002;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8002Service : CrudService<TABLE8002, TABLE8002Dto, CreateTABLE8002Dto, UpdateTABLE8002Dto, int>, ITABLE8002Service
{
    public TABLE8002Service(IRepository<TABLE8002> repository)
        : base(repository, TABLE8002MappingExtensions.ToDto, TABLE8002MappingExtensions.ToEntity, TABLE8002MappingExtensions.UpdateEntity) { }
}
