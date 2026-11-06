using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6031;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6031Service : CrudService<TABLE6031, TABLE6031Dto, CreateTABLE6031Dto, UpdateTABLE6031Dto, int>, ITABLE6031Service
{
    public TABLE6031Service(IRepository<TABLE6031> repository)
        : base(repository, TABLE6031MappingExtensions.ToDto, TABLE6031MappingExtensions.ToEntity, TABLE6031MappingExtensions.UpdateEntity) { }
}
