using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE311;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE311Service : CrudService<TABLE311, TABLE311Dto, CreateTABLE311Dto, UpdateTABLE311Dto, int>, ITABLE311Service
{
    public TABLE311Service(IRepository<TABLE311> repository)
        : base(repository, TABLE311MappingExtensions.ToDto, TABLE311MappingExtensions.ToEntity, TABLE311MappingExtensions.UpdateEntity) { }
}
