using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE215;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE215Service : CrudService<TABLE215, TABLE215Dto, CreateTABLE215Dto, UpdateTABLE215Dto, int>, ITABLE215Service
{
    public TABLE215Service(IRepository<TABLE215> repository)
        : base(repository, TABLE215MappingExtensions.ToDto, TABLE215MappingExtensions.ToEntity, TABLE215MappingExtensions.UpdateEntity) { }
}
