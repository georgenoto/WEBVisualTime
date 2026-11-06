using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6034;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6034Service : CrudService<TABLE6034, TABLE6034Dto, CreateTABLE6034Dto, UpdateTABLE6034Dto, int>, ITABLE6034Service
{
    public TABLE6034Service(IRepository<TABLE6034> repository)
        : base(repository, TABLE6034MappingExtensions.ToDto, TABLE6034MappingExtensions.ToEntity, TABLE6034MappingExtensions.UpdateEntity) { }
}
