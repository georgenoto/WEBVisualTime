using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE90;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE90Service : CrudService<TABLE90, TABLE90Dto, CreateTABLE90Dto, UpdateTABLE90Dto, string>, ITABLE90Service
{
    public TABLE90Service(IRepository<TABLE90> repository)
        : base(repository, TABLE90MappingExtensions.ToDto, TABLE90MappingExtensions.ToEntity, TABLE90MappingExtensions.UpdateEntity) { }
}
