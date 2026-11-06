using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5675;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5675Service : CrudService<TABLE5675, TABLE5675Dto, CreateTABLE5675Dto, UpdateTABLE5675Dto, int>, ITABLE5675Service
{
    public TABLE5675Service(IRepository<TABLE5675> repository)
        : base(repository, TABLE5675MappingExtensions.ToDto, TABLE5675MappingExtensions.ToEntity, TABLE5675MappingExtensions.UpdateEntity) { }
}
