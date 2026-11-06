using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5611;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5611Service : CrudService<TABLE5611, TABLE5611Dto, CreateTABLE5611Dto, UpdateTABLE5611Dto, int>, ITABLE5611Service
{
    public TABLE5611Service(IRepository<TABLE5611> repository)
        : base(repository, TABLE5611MappingExtensions.ToDto, TABLE5611MappingExtensions.ToEntity, TABLE5611MappingExtensions.UpdateEntity) { }
}
