using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE950;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE950Service : CrudService<TABLE950, TABLE950Dto, CreateTABLE950Dto, UpdateTABLE950Dto, long>, ITABLE950Service
{
    public TABLE950Service(IRepository<TABLE950> repository)
        : base(repository, TABLE950MappingExtensions.ToDto, TABLE950MappingExtensions.ToEntity, TABLE950MappingExtensions.UpdateEntity) { }
}
