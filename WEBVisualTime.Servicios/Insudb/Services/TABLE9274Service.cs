using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9274;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9274Service : CrudService<TABLE9274, TABLE9274Dto, CreateTABLE9274Dto, UpdateTABLE9274Dto, int>, ITABLE9274Service
{
    public TABLE9274Service(IRepository<TABLE9274> repository)
        : base(repository, TABLE9274MappingExtensions.ToDto, TABLE9274MappingExtensions.ToEntity, TABLE9274MappingExtensions.UpdateEntity) { }
}
