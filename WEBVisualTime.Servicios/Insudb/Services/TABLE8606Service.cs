using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8606;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8606Service : CrudService<TABLE8606, TABLE8606Dto, CreateTABLE8606Dto, UpdateTABLE8606Dto, int>, ITABLE8606Service
{
    public TABLE8606Service(IRepository<TABLE8606> repository)
        : base(repository, TABLE8606MappingExtensions.ToDto, TABLE8606MappingExtensions.ToEntity, TABLE8606MappingExtensions.UpdateEntity) { }
}
