using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9015;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9015Service : CrudService<TABLE9015, TABLE9015Dto, CreateTABLE9015Dto, UpdateTABLE9015Dto, int>, ITABLE9015Service
{
    public TABLE9015Service(IRepository<TABLE9015> repository)
        : base(repository, TABLE9015MappingExtensions.ToDto, TABLE9015MappingExtensions.ToEntity, TABLE9015MappingExtensions.UpdateEntity) { }
}
