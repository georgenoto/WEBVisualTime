using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5539;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5539Service : CrudService<TABLE5539, TABLE5539Dto, CreateTABLE5539Dto, UpdateTABLE5539Dto, int>, ITABLE5539Service
{
    public TABLE5539Service(IRepository<TABLE5539> repository)
        : base(repository, TABLE5539MappingExtensions.ToDto, TABLE5539MappingExtensions.ToEntity, TABLE5539MappingExtensions.UpdateEntity) { }
}
