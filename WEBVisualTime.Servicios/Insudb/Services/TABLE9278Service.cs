using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9278;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9278Service : CrudService<TABLE9278, TABLE9278Dto, CreateTABLE9278Dto, UpdateTABLE9278Dto, int>, ITABLE9278Service
{
    public TABLE9278Service(IRepository<TABLE9278> repository)
        : base(repository, TABLE9278MappingExtensions.ToDto, TABLE9278MappingExtensions.ToEntity, TABLE9278MappingExtensions.UpdateEntity) { }
}
