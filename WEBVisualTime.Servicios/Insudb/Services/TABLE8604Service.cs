using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8604Service : CrudService<TABLE8604, TABLE8604Dto, CreateTABLE8604Dto, UpdateTABLE8604Dto, string>, ITABLE8604Service
{
    public TABLE8604Service(IRepository<TABLE8604> repository)
        : base(repository, TABLE8604MappingExtensions.ToDto, TABLE8604MappingExtensions.ToEntity, TABLE8604MappingExtensions.UpdateEntity) { }
}
