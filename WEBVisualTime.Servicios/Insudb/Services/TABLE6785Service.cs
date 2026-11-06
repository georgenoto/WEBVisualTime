using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6785;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6785Service : CrudService<TABLE6785, TABLE6785Dto, CreateTABLE6785Dto, UpdateTABLE6785Dto, int>, ITABLE6785Service
{
    public TABLE6785Service(IRepository<TABLE6785> repository)
        : base(repository, TABLE6785MappingExtensions.ToDto, TABLE6785MappingExtensions.ToEntity, TABLE6785MappingExtensions.UpdateEntity) { }
}
