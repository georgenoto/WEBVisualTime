using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6805;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6805Service : CrudService<TABLE6805, TABLE6805Dto, CreateTABLE6805Dto, UpdateTABLE6805Dto, int>, ITABLE6805Service
{
    public TABLE6805Service(IRepository<TABLE6805> repository)
        : base(repository, TABLE6805MappingExtensions.ToDto, TABLE6805MappingExtensions.ToEntity, TABLE6805MappingExtensions.UpdateEntity) { }
}
