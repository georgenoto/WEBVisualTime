using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE561;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE561Service : CrudService<TABLE561, TABLE561Dto, CreateTABLE561Dto, UpdateTABLE561Dto, int>, ITABLE561Service
{
    public TABLE561Service(IRepository<TABLE561> repository)
        : base(repository, TABLE561MappingExtensions.ToDto, TABLE561MappingExtensions.ToEntity, TABLE561MappingExtensions.UpdateEntity) { }
}
