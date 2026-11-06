using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE226;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE226Service : CrudService<TABLE226, TABLE226Dto, CreateTABLE226Dto, UpdateTABLE226Dto, int>, ITABLE226Service
{
    public TABLE226Service(IRepository<TABLE226> repository)
        : base(repository, TABLE226MappingExtensions.ToDto, TABLE226MappingExtensions.ToEntity, TABLE226MappingExtensions.UpdateEntity) { }
}
