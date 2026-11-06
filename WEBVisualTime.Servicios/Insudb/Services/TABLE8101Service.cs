using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8101;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8101Service : CrudService<TABLE8101, TABLE8101Dto, CreateTABLE8101Dto, UpdateTABLE8101Dto, int>, ITABLE8101Service
{
    public TABLE8101Service(IRepository<TABLE8101> repository)
        : base(repository, TABLE8101MappingExtensions.ToDto, TABLE8101MappingExtensions.ToEntity, TABLE8101MappingExtensions.UpdateEntity) { }
}
