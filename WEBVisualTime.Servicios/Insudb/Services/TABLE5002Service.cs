using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5002Service : CrudService<TABLE5002, TABLE5002Dto, CreateTABLE5002Dto, UpdateTABLE5002Dto, int>, ITABLE5002Service
{
    public TABLE5002Service(IRepository<TABLE5002> repository)
        : base(repository, TABLE5002MappingExtensions.ToDto, TABLE5002MappingExtensions.ToEntity, TABLE5002MappingExtensions.UpdateEntity) { }
}
