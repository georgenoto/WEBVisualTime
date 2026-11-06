using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE269;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE269Service : CrudService<TABLE269, TABLE269Dto, CreateTABLE269Dto, UpdateTABLE269Dto, int>, ITABLE269Service
{
    public TABLE269Service(IRepository<TABLE269> repository)
        : base(repository, TABLE269MappingExtensions.ToDto, TABLE269MappingExtensions.ToEntity, TABLE269MappingExtensions.UpdateEntity) { }
}
