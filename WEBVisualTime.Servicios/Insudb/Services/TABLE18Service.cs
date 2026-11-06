using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE18Service : CrudService<TABLE18, TABLE18Dto, CreateTABLE18Dto, UpdateTABLE18Dto, string>, ITABLE18Service
{
    public TABLE18Service(IRepository<TABLE18> repository)
        : base(repository, TABLE18MappingExtensions.ToDto, TABLE18MappingExtensions.ToEntity, TABLE18MappingExtensions.UpdateEntity) { }
}
