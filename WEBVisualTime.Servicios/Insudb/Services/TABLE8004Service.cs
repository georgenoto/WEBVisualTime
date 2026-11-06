using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8004;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8004Service : CrudService<TABLE8004, TABLE8004Dto, CreateTABLE8004Dto, UpdateTABLE8004Dto, int>, ITABLE8004Service
{
    public TABLE8004Service(IRepository<TABLE8004> repository)
        : base(repository, TABLE8004MappingExtensions.ToDto, TABLE8004MappingExtensions.ToEntity, TABLE8004MappingExtensions.UpdateEntity) { }
}
