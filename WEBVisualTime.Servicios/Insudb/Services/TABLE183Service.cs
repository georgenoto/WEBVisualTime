using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE183;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE183Service : CrudService<TABLE183, TABLE183Dto, CreateTABLE183Dto, UpdateTABLE183Dto, int>, ITABLE183Service
{
    public TABLE183Service(IRepository<TABLE183> repository)
        : base(repository, TABLE183MappingExtensions.ToDto, TABLE183MappingExtensions.ToEntity, TABLE183MappingExtensions.UpdateEntity) { }
}
