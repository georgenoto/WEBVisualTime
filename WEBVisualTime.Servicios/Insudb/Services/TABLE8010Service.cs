using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8010;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8010Service : CrudService<TABLE8010, TABLE8010Dto, CreateTABLE8010Dto, UpdateTABLE8010Dto, long>, ITABLE8010Service
{
    public TABLE8010Service(IRepository<TABLE8010> repository)
        : base(repository, TABLE8010MappingExtensions.ToDto, TABLE8010MappingExtensions.ToEntity, TABLE8010MappingExtensions.UpdateEntity) { }
}
