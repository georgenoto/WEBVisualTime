using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8204;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8204Service : CrudService<TABLE8204, TABLE8204Dto, CreateTABLE8204Dto, UpdateTABLE8204Dto, string>, ITABLE8204Service
{
    public TABLE8204Service(IRepository<TABLE8204> repository)
        : base(repository, TABLE8204MappingExtensions.ToDto, TABLE8204MappingExtensions.ToEntity, TABLE8204MappingExtensions.UpdateEntity) { }
}
