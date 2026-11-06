using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5713;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5713Service : CrudService<TABLE5713, TABLE5713Dto, CreateTABLE5713Dto, UpdateTABLE5713Dto, int>, ITABLE5713Service
{
    public TABLE5713Service(IRepository<TABLE5713> repository)
        : base(repository, TABLE5713MappingExtensions.ToDto, TABLE5713MappingExtensions.ToEntity, TABLE5713MappingExtensions.UpdateEntity) { }
}
