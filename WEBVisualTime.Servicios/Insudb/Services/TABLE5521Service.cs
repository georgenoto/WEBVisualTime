using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5521;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5521Service : CrudService<TABLE5521, TABLE5521Dto, CreateTABLE5521Dto, UpdateTABLE5521Dto, int>, ITABLE5521Service
{
    public TABLE5521Service(IRepository<TABLE5521> repository)
        : base(repository, TABLE5521MappingExtensions.ToDto, TABLE5521MappingExtensions.ToEntity, TABLE5521MappingExtensions.UpdateEntity) { }
}
