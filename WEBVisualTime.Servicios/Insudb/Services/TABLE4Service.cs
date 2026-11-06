using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE4;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE4Service : CrudService<TABLE4, TABLE4Dto, CreateTABLE4Dto, UpdateTABLE4Dto, int>, ITABLE4Service
{
    public TABLE4Service(IRepository<TABLE4> repository)
        : base(repository, TABLE4MappingExtensions.ToDto, TABLE4MappingExtensions.ToEntity, TABLE4MappingExtensions.UpdateEntity) { }
}
