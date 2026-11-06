using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE2Service : CrudService<TABLE2, TABLE2Dto, CreateTABLE2Dto, UpdateTABLE2Dto, long>, ITABLE2Service
{
    public TABLE2Service(IRepository<TABLE2> repository)
        : base(repository, TABLE2MappingExtensions.ToDto, TABLE2MappingExtensions.ToEntity, TABLE2MappingExtensions.UpdateEntity) { }
}
