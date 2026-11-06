using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9215Service : CrudService<TABLE9215, TABLE9215Dto, CreateTABLE9215Dto, UpdateTABLE9215Dto, int>, ITABLE9215Service
{
    public TABLE9215Service(IRepository<TABLE9215> repository)
        : base(repository, TABLE9215MappingExtensions.ToDto, TABLE9215MappingExtensions.ToEntity, TABLE9215MappingExtensions.UpdateEntity) { }
}
