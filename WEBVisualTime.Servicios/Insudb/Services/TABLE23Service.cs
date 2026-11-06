using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE23;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE23Service : CrudService<TABLE23, TABLE23Dto, CreateTABLE23Dto, UpdateTABLE23Dto, long>, ITABLE23Service
{
    public TABLE23Service(IRepository<TABLE23> repository)
        : base(repository, TABLE23MappingExtensions.ToDto, TABLE23MappingExtensions.ToEntity, TABLE23MappingExtensions.UpdateEntity) { }
}
