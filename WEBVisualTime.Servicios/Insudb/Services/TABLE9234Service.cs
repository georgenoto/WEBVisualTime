using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9234;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9234Service : CrudService<TABLE9234, TABLE9234Dto, CreateTABLE9234Dto, UpdateTABLE9234Dto, int>, ITABLE9234Service
{
    public TABLE9234Service(IRepository<TABLE9234> repository)
        : base(repository, TABLE9234MappingExtensions.ToDto, TABLE9234MappingExtensions.ToEntity, TABLE9234MappingExtensions.UpdateEntity) { }
}
