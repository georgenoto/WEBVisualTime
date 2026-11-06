using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE40;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE40Service : CrudService<TABLE40, TABLE40Dto, CreateTABLE40Dto, UpdateTABLE40Dto, long>, ITABLE40Service
{
    public TABLE40Service(IRepository<TABLE40> repository)
        : base(repository, TABLE40MappingExtensions.ToDto, TABLE40MappingExtensions.ToEntity, TABLE40MappingExtensions.UpdateEntity) { }
}
