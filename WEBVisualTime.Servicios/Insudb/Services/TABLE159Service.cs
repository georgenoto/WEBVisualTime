using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE159;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE159Service : CrudService<TABLE159, TABLE159Dto, CreateTABLE159Dto, UpdateTABLE159Dto, int>, ITABLE159Service
{
    public TABLE159Service(IRepository<TABLE159> repository)
        : base(repository, TABLE159MappingExtensions.ToDto, TABLE159MappingExtensions.ToEntity, TABLE159MappingExtensions.UpdateEntity) { }
}
