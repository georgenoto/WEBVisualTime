using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8202;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8202Service : CrudService<TABLE8202, TABLE8202Dto, CreateTABLE8202Dto, UpdateTABLE8202Dto, long>, ITABLE8202Service
{
    public TABLE8202Service(IRepository<TABLE8202> repository)
        : base(repository, TABLE8202MappingExtensions.ToDto, TABLE8202MappingExtensions.ToEntity, TABLE8202MappingExtensions.UpdateEntity) { }
}
