using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7000;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7000Service : CrudService<TABLE7000, TABLE7000Dto, CreateTABLE7000Dto, UpdateTABLE7000Dto, int>, ITABLE7000Service
{
    public TABLE7000Service(IRepository<TABLE7000> repository)
        : base(repository, TABLE7000MappingExtensions.ToDto, TABLE7000MappingExtensions.ToEntity, TABLE7000MappingExtensions.UpdateEntity) { }
}
