using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6014;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6014Service : CrudService<TABLE6014, TABLE6014Dto, CreateTABLE6014Dto, UpdateTABLE6014Dto, int>, ITABLE6014Service
{
    public TABLE6014Service(IRepository<TABLE6014> repository)
        : base(repository, TABLE6014MappingExtensions.ToDto, TABLE6014MappingExtensions.ToEntity, TABLE6014MappingExtensions.UpdateEntity) { }
}
