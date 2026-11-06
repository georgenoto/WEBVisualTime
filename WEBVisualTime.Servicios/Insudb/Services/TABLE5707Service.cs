using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5707;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5707Service : CrudService<TABLE5707, TABLE5707Dto, CreateTABLE5707Dto, UpdateTABLE5707Dto, int>, ITABLE5707Service
{
    public TABLE5707Service(IRepository<TABLE5707> repository)
        : base(repository, TABLE5707MappingExtensions.ToDto, TABLE5707MappingExtensions.ToEntity, TABLE5707MappingExtensions.UpdateEntity) { }
}
