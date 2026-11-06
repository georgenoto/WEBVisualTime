using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE180;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE180Service : CrudService<TABLE180, TABLE180Dto, CreateTABLE180Dto, UpdateTABLE180Dto, long>, ITABLE180Service
{
    public TABLE180Service(IRepository<TABLE180> repository)
        : base(repository, TABLE180MappingExtensions.ToDto, TABLE180MappingExtensions.ToEntity, TABLE180MappingExtensions.UpdateEntity) { }
}
