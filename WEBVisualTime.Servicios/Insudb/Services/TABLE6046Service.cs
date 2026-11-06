using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6046;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6046Service : CrudService<TABLE6046, TABLE6046Dto, CreateTABLE6046Dto, UpdateTABLE6046Dto, int>, ITABLE6046Service
{
    public TABLE6046Service(IRepository<TABLE6046> repository)
        : base(repository, TABLE6046MappingExtensions.ToDto, TABLE6046MappingExtensions.ToEntity, TABLE6046MappingExtensions.UpdateEntity) { }
}
