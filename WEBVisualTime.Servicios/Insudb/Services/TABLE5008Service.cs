using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5008;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5008Service : CrudService<TABLE5008, TABLE5008Dto, CreateTABLE5008Dto, UpdateTABLE5008Dto, long>, ITABLE5008Service
{
    public TABLE5008Service(IRepository<TABLE5008> repository)
        : base(repository, TABLE5008MappingExtensions.ToDto, TABLE5008MappingExtensions.ToEntity, TABLE5008MappingExtensions.UpdateEntity) { }
}
