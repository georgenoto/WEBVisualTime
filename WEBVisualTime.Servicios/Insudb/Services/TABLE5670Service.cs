using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5670;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5670Service : CrudService<TABLE5670, TABLE5670Dto, CreateTABLE5670Dto, UpdateTABLE5670Dto, int>, ITABLE5670Service
{
    public TABLE5670Service(IRepository<TABLE5670> repository)
        : base(repository, TABLE5670MappingExtensions.ToDto, TABLE5670MappingExtensions.ToEntity, TABLE5670MappingExtensions.UpdateEntity) { }
}
