using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5644;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5644Service : CrudService<TABLE5644, TABLE5644Dto, CreateTABLE5644Dto, UpdateTABLE5644Dto, int>, ITABLE5644Service
{
    public TABLE5644Service(IRepository<TABLE5644> repository)
        : base(repository, TABLE5644MappingExtensions.ToDto, TABLE5644MappingExtensions.ToEntity, TABLE5644MappingExtensions.UpdateEntity) { }
}
