using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9264;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9264Service : CrudService<TABLE9264, TABLE9264Dto, CreateTABLE9264Dto, UpdateTABLE9264Dto, int>, ITABLE9264Service
{
    public TABLE9264Service(IRepository<TABLE9264> repository)
        : base(repository, TABLE9264MappingExtensions.ToDto, TABLE9264MappingExtensions.ToEntity, TABLE9264MappingExtensions.UpdateEntity) { }
}
