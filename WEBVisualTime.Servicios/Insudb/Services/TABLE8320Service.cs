using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8320;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8320Service : CrudService<TABLE8320, TABLE8320Dto, CreateTABLE8320Dto, UpdateTABLE8320Dto, int>, ITABLE8320Service
{
    public TABLE8320Service(IRepository<TABLE8320> repository)
        : base(repository, TABLE8320MappingExtensions.ToDto, TABLE8320MappingExtensions.ToEntity, TABLE8320MappingExtensions.UpdateEntity) { }
}
