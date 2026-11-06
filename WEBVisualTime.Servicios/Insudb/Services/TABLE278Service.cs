using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE278;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE278Service : CrudService<TABLE278, TABLE278Dto, CreateTABLE278Dto, UpdateTABLE278Dto, int>, ITABLE278Service
{
    public TABLE278Service(IRepository<TABLE278> repository)
        : base(repository, TABLE278MappingExtensions.ToDto, TABLE278MappingExtensions.ToEntity, TABLE278MappingExtensions.UpdateEntity) { }
}
