using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE33;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE33Service : CrudService<TABLE33, TABLE33Dto, CreateTABLE33Dto, UpdateTABLE33Dto, string>, ITABLE33Service
{
    public TABLE33Service(IRepository<TABLE33> repository)
        : base(repository, TABLE33MappingExtensions.ToDto, TABLE33MappingExtensions.ToEntity, TABLE33MappingExtensions.UpdateEntity) { }
}
