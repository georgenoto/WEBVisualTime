using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7001;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7001Service : CrudService<TABLE7001, TABLE7001Dto, CreateTABLE7001Dto, UpdateTABLE7001Dto, int>, ITABLE7001Service
{
    public TABLE7001Service(IRepository<TABLE7001> repository)
        : base(repository, TABLE7001MappingExtensions.ToDto, TABLE7001MappingExtensions.ToEntity, TABLE7001MappingExtensions.UpdateEntity) { }
}
