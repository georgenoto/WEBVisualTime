using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6071;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6071Service : CrudService<TABLE6071, TABLE6071Dto, CreateTABLE6071Dto, UpdateTABLE6071Dto, int>, ITABLE6071Service
{
    public TABLE6071Service(IRepository<TABLE6071> repository)
        : base(repository, TABLE6071MappingExtensions.ToDto, TABLE6071MappingExtensions.ToEntity, TABLE6071MappingExtensions.UpdateEntity) { }
}
