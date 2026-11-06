using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE526;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE526Service : CrudService<TABLE526, TABLE526Dto, CreateTABLE526Dto, UpdateTABLE526Dto, int>, ITABLE526Service
{
    public TABLE526Service(IRepository<TABLE526> repository)
        : base(repository, TABLE526MappingExtensions.ToDto, TABLE526MappingExtensions.ToEntity, TABLE526MappingExtensions.UpdateEntity) { }
}
