using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5589Service : CrudService<TABLE5589, TABLE5589Dto, CreateTABLE5589Dto, UpdateTABLE5589Dto, int>, ITABLE5589Service
{
    public TABLE5589Service(IRepository<TABLE5589> repository)
        : base(repository, TABLE5589MappingExtensions.ToDto, TABLE5589MappingExtensions.ToEntity, TABLE5589MappingExtensions.UpdateEntity) { }
}
