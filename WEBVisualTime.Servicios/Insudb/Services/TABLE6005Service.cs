using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6005;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6005Service : CrudService<TABLE6005, TABLE6005Dto, CreateTABLE6005Dto, UpdateTABLE6005Dto, int>, ITABLE6005Service
{
    public TABLE6005Service(IRepository<TABLE6005> repository)
        : base(repository, TABLE6005MappingExtensions.ToDto, TABLE6005MappingExtensions.ToEntity, TABLE6005MappingExtensions.UpdateEntity) { }
}
