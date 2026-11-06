using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5660;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5660Service : CrudService<TABLE5660, TABLE5660Dto, CreateTABLE5660Dto, UpdateTABLE5660Dto, int>, ITABLE5660Service
{
    public TABLE5660Service(IRepository<TABLE5660> repository)
        : base(repository, TABLE5660MappingExtensions.ToDto, TABLE5660MappingExtensions.ToEntity, TABLE5660MappingExtensions.UpdateEntity) { }
}
