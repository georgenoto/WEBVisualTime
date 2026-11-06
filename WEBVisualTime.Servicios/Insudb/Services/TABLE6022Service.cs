using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6022;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6022Service : CrudService<TABLE6022, TABLE6022Dto, CreateTABLE6022Dto, UpdateTABLE6022Dto, int>, ITABLE6022Service
{
    public TABLE6022Service(IRepository<TABLE6022> repository)
        : base(repository, TABLE6022MappingExtensions.ToDto, TABLE6022MappingExtensions.ToEntity, TABLE6022MappingExtensions.UpdateEntity) { }
}
