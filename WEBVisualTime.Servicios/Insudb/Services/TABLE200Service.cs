using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE200;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE200Service : CrudService<TABLE200, TABLE200Dto, CreateTABLE200Dto, UpdateTABLE200Dto, int>, ITABLE200Service
{
    public TABLE200Service(IRepository<TABLE200> repository)
        : base(repository, TABLE200MappingExtensions.ToDto, TABLE200MappingExtensions.ToEntity, TABLE200MappingExtensions.UpdateEntity) { }
}
