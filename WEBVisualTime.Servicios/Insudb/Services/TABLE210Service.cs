using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE210;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE210Service : CrudService<TABLE210, TABLE210Dto, CreateTABLE210Dto, UpdateTABLE210Dto, int>, ITABLE210Service
{
    public TABLE210Service(IRepository<TABLE210> repository)
        : base(repository, TABLE210MappingExtensions.ToDto, TABLE210MappingExtensions.ToEntity, TABLE210MappingExtensions.UpdateEntity) { }
}
