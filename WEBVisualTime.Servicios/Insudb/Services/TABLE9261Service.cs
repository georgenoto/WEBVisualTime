using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9261;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9261Service : CrudService<TABLE9261, TABLE9261Dto, CreateTABLE9261Dto, UpdateTABLE9261Dto, int>, ITABLE9261Service
{
    public TABLE9261Service(IRepository<TABLE9261> repository)
        : base(repository, TABLE9261MappingExtensions.ToDto, TABLE9261MappingExtensions.ToEntity, TABLE9261MappingExtensions.UpdateEntity) { }
}
