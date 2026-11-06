using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8300;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8300Service : CrudService<TABLE8300, TABLE8300Dto, CreateTABLE8300Dto, UpdateTABLE8300Dto, int>, ITABLE8300Service
{
    public TABLE8300Service(IRepository<TABLE8300> repository)
        : base(repository, TABLE8300MappingExtensions.ToDto, TABLE8300MappingExtensions.ToEntity, TABLE8300MappingExtensions.UpdateEntity) { }
}
