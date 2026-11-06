using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2000;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE2000Service : CrudService<TABLE2000, TABLE2000Dto, CreateTABLE2000Dto, UpdateTABLE2000Dto, long>, ITABLE2000Service
{
    public TABLE2000Service(IRepository<TABLE2000> repository)
        : base(repository, TABLE2000MappingExtensions.ToDto, TABLE2000MappingExtensions.ToEntity, TABLE2000MappingExtensions.UpdateEntity) { }
}
