using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5538;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5538Service : CrudService<TABLE5538, TABLE5538Dto, CreateTABLE5538Dto, UpdateTABLE5538Dto, int>, ITABLE5538Service
{
    public TABLE5538Service(IRepository<TABLE5538> repository)
        : base(repository, TABLE5538MappingExtensions.ToDto, TABLE5538MappingExtensions.ToEntity, TABLE5538MappingExtensions.UpdateEntity) { }
}
