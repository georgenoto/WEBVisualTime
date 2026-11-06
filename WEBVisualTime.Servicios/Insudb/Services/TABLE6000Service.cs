using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6000;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6000Service : CrudService<TABLE6000, TABLE6000Dto, CreateTABLE6000Dto, UpdateTABLE6000Dto, int>, ITABLE6000Service
{
    public TABLE6000Service(IRepository<TABLE6000> repository)
        : base(repository, TABLE6000MappingExtensions.ToDto, TABLE6000MappingExtensions.ToEntity, TABLE6000MappingExtensions.UpdateEntity) { }
}
