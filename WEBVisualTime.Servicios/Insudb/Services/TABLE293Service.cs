using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE293;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE293Service : CrudService<TABLE293, TABLE293Dto, CreateTABLE293Dto, UpdateTABLE293Dto, int>, ITABLE293Service
{
    public TABLE293Service(IRepository<TABLE293> repository)
        : base(repository, TABLE293MappingExtensions.ToDto, TABLE293MappingExtensions.ToEntity, TABLE293MappingExtensions.UpdateEntity) { }
}
