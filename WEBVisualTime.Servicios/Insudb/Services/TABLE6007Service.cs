using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6007;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6007Service : CrudService<TABLE6007, TABLE6007Dto, CreateTABLE6007Dto, UpdateTABLE6007Dto, int>, ITABLE6007Service
{
    public TABLE6007Service(IRepository<TABLE6007> repository)
        : base(repository, TABLE6007MappingExtensions.ToDto, TABLE6007MappingExtensions.ToEntity, TABLE6007MappingExtensions.UpdateEntity) { }
}
