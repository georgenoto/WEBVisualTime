using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7505;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7505Service : CrudService<TABLE7505, TABLE7505Dto, CreateTABLE7505Dto, UpdateTABLE7505Dto, string>, ITABLE7505Service
{
    public TABLE7505Service(IRepository<TABLE7505> repository)
        : base(repository, TABLE7505MappingExtensions.ToDto, TABLE7505MappingExtensions.ToEntity, TABLE7505MappingExtensions.UpdateEntity) { }
}
