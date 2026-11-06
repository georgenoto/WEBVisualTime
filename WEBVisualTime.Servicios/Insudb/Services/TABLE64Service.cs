using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE64;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE64Service : CrudService<TABLE64, TABLE64Dto, CreateTABLE64Dto, UpdateTABLE64Dto, string>, ITABLE64Service
{
    public TABLE64Service(IRepository<TABLE64> repository)
        : base(repository, TABLE64MappingExtensions.ToDto, TABLE64MappingExtensions.ToEntity, TABLE64MappingExtensions.UpdateEntity) { }
}
