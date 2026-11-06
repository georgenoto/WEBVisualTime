using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE36Service : CrudService<TABLE36, TABLE36Dto, CreateTABLE36Dto, UpdateTABLE36Dto, int>, ITABLE36Service
{
    public TABLE36Service(IRepository<TABLE36> repository)
        : base(repository, TABLE36MappingExtensions.ToDto, TABLE36MappingExtensions.ToEntity, TABLE36MappingExtensions.UpdateEntity) { }
}
