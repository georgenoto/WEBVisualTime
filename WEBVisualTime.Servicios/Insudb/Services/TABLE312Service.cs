using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE312;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE312Service : CrudService<TABLE312, TABLE312Dto, CreateTABLE312Dto, UpdateTABLE312Dto, int>, ITABLE312Service
{
    public TABLE312Service(IRepository<TABLE312> repository)
        : base(repository, TABLE312MappingExtensions.ToDto, TABLE312MappingExtensions.ToEntity, TABLE312MappingExtensions.UpdateEntity) { }
}
