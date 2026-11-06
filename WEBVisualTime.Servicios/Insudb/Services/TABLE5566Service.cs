using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5566;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5566Service : CrudService<TABLE5566, TABLE5566Dto, CreateTABLE5566Dto, UpdateTABLE5566Dto, int>, ITABLE5566Service
{
    public TABLE5566Service(IRepository<TABLE5566> repository)
        : base(repository, TABLE5566MappingExtensions.ToDto, TABLE5566MappingExtensions.ToEntity, TABLE5566MappingExtensions.UpdateEntity) { }
}
