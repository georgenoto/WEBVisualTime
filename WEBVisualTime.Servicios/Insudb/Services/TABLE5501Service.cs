using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5501;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5501Service : CrudService<TABLE5501, TABLE5501Dto, CreateTABLE5501Dto, UpdateTABLE5501Dto, int>, ITABLE5501Service
{
    public TABLE5501Service(IRepository<TABLE5501> repository)
        : base(repository, TABLE5501MappingExtensions.ToDto, TABLE5501MappingExtensions.ToEntity, TABLE5501MappingExtensions.UpdateEntity) { }
}
