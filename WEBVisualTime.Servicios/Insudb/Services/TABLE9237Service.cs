using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9237;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9237Service : CrudService<TABLE9237, TABLE9237Dto, CreateTABLE9237Dto, UpdateTABLE9237Dto, int>, ITABLE9237Service
{
    public TABLE9237Service(IRepository<TABLE9237> repository)
        : base(repository, TABLE9237MappingExtensions.ToDto, TABLE9237MappingExtensions.ToEntity, TABLE9237MappingExtensions.UpdateEntity) { }
}
