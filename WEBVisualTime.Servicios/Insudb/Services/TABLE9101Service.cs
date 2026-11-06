using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9101;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9101Service : CrudService<TABLE9101, TABLE9101Dto, CreateTABLE9101Dto, UpdateTABLE9101Dto, int>, ITABLE9101Service
{
    public TABLE9101Service(IRepository<TABLE9101> repository)
        : base(repository, TABLE9101MappingExtensions.ToDto, TABLE9101MappingExtensions.ToEntity, TABLE9101MappingExtensions.UpdateEntity) { }
}
