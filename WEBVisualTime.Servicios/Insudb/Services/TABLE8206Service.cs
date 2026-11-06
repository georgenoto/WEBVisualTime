using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8206;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8206Service : CrudService<TABLE8206, TABLE8206Dto, CreateTABLE8206Dto, UpdateTABLE8206Dto, int>, ITABLE8206Service
{
    public TABLE8206Service(IRepository<TABLE8206> repository)
        : base(repository, TABLE8206MappingExtensions.ToDto, TABLE8206MappingExtensions.ToEntity, TABLE8206MappingExtensions.UpdateEntity) { }
}
