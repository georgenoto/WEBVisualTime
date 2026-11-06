using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6023;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6023Service : CrudService<TABLE6023, TABLE6023Dto, CreateTABLE6023Dto, UpdateTABLE6023Dto, int>, ITABLE6023Service
{
    public TABLE6023Service(IRepository<TABLE6023> repository)
        : base(repository, TABLE6023MappingExtensions.ToDto, TABLE6023MappingExtensions.ToEntity, TABLE6023MappingExtensions.UpdateEntity) { }
}
