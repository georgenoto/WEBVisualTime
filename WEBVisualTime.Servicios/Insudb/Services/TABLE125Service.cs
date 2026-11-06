using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE125;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE125Service : CrudService<TABLE125, TABLE125Dto, CreateTABLE125Dto, UpdateTABLE125Dto, long>, ITABLE125Service
{
    public TABLE125Service(IRepository<TABLE125> repository)
        : base(repository, TABLE125MappingExtensions.ToDto, TABLE125MappingExtensions.ToEntity, TABLE125MappingExtensions.UpdateEntity) { }
}
