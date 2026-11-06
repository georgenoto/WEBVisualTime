using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE32;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE32Service : CrudService<TABLE32, TABLE32Dto, CreateTABLE32Dto, UpdateTABLE32Dto, int>, ITABLE32Service
{
    public TABLE32Service(IRepository<TABLE32> repository)
        : base(repository, TABLE32MappingExtensions.ToDto, TABLE32MappingExtensions.ToEntity, TABLE32MappingExtensions.UpdateEntity) { }
}
