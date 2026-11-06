using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5516;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5516Service : CrudService<TABLE5516, TABLE5516Dto, CreateTABLE5516Dto, UpdateTABLE5516Dto, int>, ITABLE5516Service
{
    public TABLE5516Service(IRepository<TABLE5516> repository)
        : base(repository, TABLE5516MappingExtensions.ToDto, TABLE5516MappingExtensions.ToEntity, TABLE5516MappingExtensions.UpdateEntity) { }
}
