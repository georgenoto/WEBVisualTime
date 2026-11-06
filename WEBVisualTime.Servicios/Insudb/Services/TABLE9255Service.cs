using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9255;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9255Service : CrudService<TABLE9255, TABLE9255Dto, CreateTABLE9255Dto, UpdateTABLE9255Dto, int>, ITABLE9255Service
{
    public TABLE9255Service(IRepository<TABLE9255> repository)
        : base(repository, TABLE9255MappingExtensions.ToDto, TABLE9255MappingExtensions.ToEntity, TABLE9255MappingExtensions.UpdateEntity) { }
}
