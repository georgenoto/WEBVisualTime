using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9210;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9210Service : CrudService<TABLE9210, TABLE9210Dto, CreateTABLE9210Dto, UpdateTABLE9210Dto, int>, ITABLE9210Service
{
    public TABLE9210Service(IRepository<TABLE9210> repository)
        : base(repository, TABLE9210MappingExtensions.ToDto, TABLE9210MappingExtensions.ToEntity, TABLE9210MappingExtensions.UpdateEntity) { }
}
