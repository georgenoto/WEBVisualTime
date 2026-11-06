using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE273;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE273Service : CrudService<TABLE273, TABLE273Dto, CreateTABLE273Dto, UpdateTABLE273Dto, int>, ITABLE273Service
{
    public TABLE273Service(IRepository<TABLE273> repository)
        : base(repository, TABLE273MappingExtensions.ToDto, TABLE273MappingExtensions.ToEntity, TABLE273MappingExtensions.UpdateEntity) { }
}
