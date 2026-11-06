using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8100;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8100Service : CrudService<TABLE8100, TABLE8100Dto, CreateTABLE8100Dto, UpdateTABLE8100Dto, int>, ITABLE8100Service
{
    public TABLE8100Service(IRepository<TABLE8100> repository)
        : base(repository, TABLE8100MappingExtensions.ToDto, TABLE8100MappingExtensions.ToEntity, TABLE8100MappingExtensions.UpdateEntity) { }
}
