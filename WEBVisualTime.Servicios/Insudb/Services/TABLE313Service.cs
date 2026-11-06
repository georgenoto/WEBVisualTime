using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE313;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE313Service : CrudService<TABLE313, TABLE313Dto, CreateTABLE313Dto, UpdateTABLE313Dto, int>, ITABLE313Service
{
    public TABLE313Service(IRepository<TABLE313> repository)
        : base(repository, TABLE313MappingExtensions.ToDto, TABLE313MappingExtensions.ToEntity, TABLE313MappingExtensions.UpdateEntity) { }
}
