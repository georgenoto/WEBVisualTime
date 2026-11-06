using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE17;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE17Service : CrudService<TABLE17, TABLE17Dto, CreateTABLE17Dto, UpdateTABLE17Dto, long>, ITABLE17Service
{
    public TABLE17Service(IRepository<TABLE17> repository)
        : base(repository, TABLE17MappingExtensions.ToDto, TABLE17MappingExtensions.ToEntity, TABLE17MappingExtensions.UpdateEntity) { }
}
