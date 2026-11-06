using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE160;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE160Service : CrudService<TABLE160, TABLE160Dto, CreateTABLE160Dto, UpdateTABLE160Dto, int>, ITABLE160Service
{
    public TABLE160Service(IRepository<TABLE160> repository)
        : base(repository, TABLE160MappingExtensions.ToDto, TABLE160MappingExtensions.ToEntity, TABLE160MappingExtensions.UpdateEntity) { }
}
