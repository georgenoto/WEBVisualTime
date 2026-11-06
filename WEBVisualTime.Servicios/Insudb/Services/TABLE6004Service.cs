using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6004;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6004Service : CrudService<TABLE6004, TABLE6004Dto, CreateTABLE6004Dto, UpdateTABLE6004Dto, int>, ITABLE6004Service
{
    public TABLE6004Service(IRepository<TABLE6004> repository)
        : base(repository, TABLE6004MappingExtensions.ToDto, TABLE6004MappingExtensions.ToEntity, TABLE6004MappingExtensions.UpdateEntity) { }
}
