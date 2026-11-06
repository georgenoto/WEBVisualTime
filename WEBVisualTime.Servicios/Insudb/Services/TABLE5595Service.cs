using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5595;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5595Service : CrudService<TABLE5595, TABLE5595Dto, CreateTABLE5595Dto, UpdateTABLE5595Dto, int>, ITABLE5595Service
{
    public TABLE5595Service(IRepository<TABLE5595> repository)
        : base(repository, TABLE5595MappingExtensions.ToDto, TABLE5595MappingExtensions.ToEntity, TABLE5595MappingExtensions.UpdateEntity) { }
}
