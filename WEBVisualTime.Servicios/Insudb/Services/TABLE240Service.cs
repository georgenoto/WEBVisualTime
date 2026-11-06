using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE240;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE240Service : CrudService<TABLE240, TABLE240Dto, CreateTABLE240Dto, UpdateTABLE240Dto, int>, ITABLE240Service
{
    public TABLE240Service(IRepository<TABLE240> repository)
        : base(repository, TABLE240MappingExtensions.ToDto, TABLE240MappingExtensions.ToEntity, TABLE240MappingExtensions.UpdateEntity) { }
}
