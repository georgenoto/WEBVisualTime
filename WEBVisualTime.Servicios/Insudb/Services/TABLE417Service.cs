using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE417;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE417Service : CrudService<TABLE417, TABLE417Dto, CreateTABLE417Dto, UpdateTABLE417Dto, long>, ITABLE417Service
{
    public TABLE417Service(IRepository<TABLE417> repository)
        : base(repository, TABLE417MappingExtensions.ToDto, TABLE417MappingExtensions.ToEntity, TABLE417MappingExtensions.UpdateEntity) { }
}
