using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9013;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9013Service : CrudService<TABLE9013, TABLE9013Dto, CreateTABLE9013Dto, UpdateTABLE9013Dto, int>, ITABLE9013Service
{
    public TABLE9013Service(IRepository<TABLE9013> repository)
        : base(repository, TABLE9013MappingExtensions.ToDto, TABLE9013MappingExtensions.ToEntity, TABLE9013MappingExtensions.UpdateEntity) { }
}
