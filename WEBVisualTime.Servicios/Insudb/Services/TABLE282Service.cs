using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE282;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE282Service : CrudService<TABLE282, TABLE282Dto, CreateTABLE282Dto, UpdateTABLE282Dto, int>, ITABLE282Service
{
    public TABLE282Service(IRepository<TABLE282> repository)
        : base(repository, TABLE282MappingExtensions.ToDto, TABLE282MappingExtensions.ToEntity, TABLE282MappingExtensions.UpdateEntity) { }
}
