using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6070;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6070Service : CrudService<TABLE6070, TABLE6070Dto, CreateTABLE6070Dto, UpdateTABLE6070Dto, string>, ITABLE6070Service
{
    public TABLE6070Service(IRepository<TABLE6070> repository)
        : base(repository, TABLE6070MappingExtensions.ToDto, TABLE6070MappingExtensions.ToEntity, TABLE6070MappingExtensions.UpdateEntity) { }
}
