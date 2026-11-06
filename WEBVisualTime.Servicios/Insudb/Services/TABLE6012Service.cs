using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6012;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6012Service : CrudService<TABLE6012, TABLE6012Dto, CreateTABLE6012Dto, UpdateTABLE6012Dto, int>, ITABLE6012Service
{
    public TABLE6012Service(IRepository<TABLE6012> repository)
        : base(repository, TABLE6012MappingExtensions.ToDto, TABLE6012MappingExtensions.ToEntity, TABLE6012MappingExtensions.UpdateEntity) { }
}
