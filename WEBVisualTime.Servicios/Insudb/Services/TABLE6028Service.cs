using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6028;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6028Service : CrudService<TABLE6028, TABLE6028Dto, CreateTABLE6028Dto, UpdateTABLE6028Dto, int>, ITABLE6028Service
{
    public TABLE6028Service(IRepository<TABLE6028> repository)
        : base(repository, TABLE6028MappingExtensions.ToDto, TABLE6028MappingExtensions.ToEntity, TABLE6028MappingExtensions.UpdateEntity) { }
}
