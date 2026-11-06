using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9214;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9214Service : CrudService<TABLE9214, TABLE9214Dto, CreateTABLE9214Dto, UpdateTABLE9214Dto, int>, ITABLE9214Service
{
    public TABLE9214Service(IRepository<TABLE9214> repository)
        : base(repository, TABLE9214MappingExtensions.ToDto, TABLE9214MappingExtensions.ToEntity, TABLE9214MappingExtensions.UpdateEntity) { }
}
