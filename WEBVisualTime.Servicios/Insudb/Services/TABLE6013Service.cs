using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6013;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6013Service : CrudService<TABLE6013, TABLE6013Dto, CreateTABLE6013Dto, UpdateTABLE6013Dto, int>, ITABLE6013Service
{
    public TABLE6013Service(IRepository<TABLE6013> repository)
        : base(repository, TABLE6013MappingExtensions.ToDto, TABLE6013MappingExtensions.ToEntity, TABLE6013MappingExtensions.UpdateEntity) { }
}
