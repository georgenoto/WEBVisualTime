using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6100;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6100Service : CrudService<TABLE6100, TABLE6100Dto, CreateTABLE6100Dto, UpdateTABLE6100Dto, int>, ITABLE6100Service
{
    public TABLE6100Service(IRepository<TABLE6100> repository)
        : base(repository, TABLE6100MappingExtensions.ToDto, TABLE6100MappingExtensions.ToEntity, TABLE6100MappingExtensions.UpdateEntity) { }
}
