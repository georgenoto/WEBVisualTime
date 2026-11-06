using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1000;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE1000Service : CrudService<TABLE1000, TABLE1000Dto, CreateTABLE1000Dto, UpdateTABLE1000Dto, int>, ITABLE1000Service
{
    public TABLE1000Service(IRepository<TABLE1000> repository)
        : base(repository, TABLE1000MappingExtensions.ToDto, TABLE1000MappingExtensions.ToEntity, TABLE1000MappingExtensions.UpdateEntity) { }
}
