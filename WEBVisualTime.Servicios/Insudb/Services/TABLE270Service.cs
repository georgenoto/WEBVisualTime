using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE270;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE270Service : CrudService<TABLE270, TABLE270Dto, CreateTABLE270Dto, UpdateTABLE270Dto, int>, ITABLE270Service
{
    public TABLE270Service(IRepository<TABLE270> repository)
        : base(repository, TABLE270MappingExtensions.ToDto, TABLE270MappingExtensions.ToEntity, TABLE270MappingExtensions.UpdateEntity) { }
}
