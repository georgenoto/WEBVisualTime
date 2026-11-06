using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE525;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE525Service : CrudService<TABLE525, TABLE525Dto, CreateTABLE525Dto, UpdateTABLE525Dto, int>, ITABLE525Service
{
    public TABLE525Service(IRepository<TABLE525> repository)
        : base(repository, TABLE525MappingExtensions.ToDto, TABLE525MappingExtensions.ToEntity, TABLE525MappingExtensions.UpdateEntity) { }
}
