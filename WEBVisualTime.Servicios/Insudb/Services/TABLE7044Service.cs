using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7044;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7044Service : CrudService<TABLE7044, TABLE7044Dto, CreateTABLE7044Dto, UpdateTABLE7044Dto, int>, ITABLE7044Service
{
    public TABLE7044Service(IRepository<TABLE7044> repository)
        : base(repository, TABLE7044MappingExtensions.ToDto, TABLE7044MappingExtensions.ToEntity, TABLE7044MappingExtensions.UpdateEntity) { }
}
