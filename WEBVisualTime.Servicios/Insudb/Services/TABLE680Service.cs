using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE680;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE680Service : CrudService<TABLE680, TABLE680Dto, CreateTABLE680Dto, UpdateTABLE680Dto, int>, ITABLE680Service
{
    public TABLE680Service(IRepository<TABLE680> repository)
        : base(repository, TABLE680MappingExtensions.ToDto, TABLE680MappingExtensions.ToEntity, TABLE680MappingExtensions.UpdateEntity) { }
}
