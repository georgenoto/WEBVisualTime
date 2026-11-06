using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE237;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE237Service : CrudService<TABLE237, TABLE237Dto, CreateTABLE237Dto, UpdateTABLE237Dto, int>, ITABLE237Service
{
    public TABLE237Service(IRepository<TABLE237> repository)
        : base(repository, TABLE237MappingExtensions.ToDto, TABLE237MappingExtensions.ToEntity, TABLE237MappingExtensions.UpdateEntity) { }
}
