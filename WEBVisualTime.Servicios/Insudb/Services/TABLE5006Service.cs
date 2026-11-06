using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5006;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5006Service : CrudService<TABLE5006, TABLE5006Dto, CreateTABLE5006Dto, UpdateTABLE5006Dto, int>, ITABLE5006Service
{
    public TABLE5006Service(IRepository<TABLE5006> repository)
        : base(repository, TABLE5006MappingExtensions.ToDto, TABLE5006MappingExtensions.ToEntity, TABLE5006MappingExtensions.UpdateEntity) { }
}
