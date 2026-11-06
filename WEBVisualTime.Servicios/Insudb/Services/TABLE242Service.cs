using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE242;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE242Service : CrudService<TABLE242, TABLE242Dto, CreateTABLE242Dto, UpdateTABLE242Dto, int>, ITABLE242Service
{
    public TABLE242Service(IRepository<TABLE242> repository)
        : base(repository, TABLE242MappingExtensions.ToDto, TABLE242MappingExtensions.ToEntity, TABLE242MappingExtensions.UpdateEntity) { }
}
