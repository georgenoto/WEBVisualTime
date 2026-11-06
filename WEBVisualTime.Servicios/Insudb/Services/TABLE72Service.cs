using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE72;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE72Service : CrudService<TABLE72, TABLE72Dto, CreateTABLE72Dto, UpdateTABLE72Dto, int>, ITABLE72Service
{
    public TABLE72Service(IRepository<TABLE72> repository)
        : base(repository, TABLE72MappingExtensions.ToDto, TABLE72MappingExtensions.ToEntity, TABLE72MappingExtensions.UpdateEntity) { }
}
