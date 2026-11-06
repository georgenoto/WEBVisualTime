using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5597;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5597Service : CrudService<TABLE5597, TABLE5597Dto, CreateTABLE5597Dto, UpdateTABLE5597Dto, int>, ITABLE5597Service
{
    public TABLE5597Service(IRepository<TABLE5597> repository)
        : base(repository, TABLE5597MappingExtensions.ToDto, TABLE5597MappingExtensions.ToEntity, TABLE5597MappingExtensions.UpdateEntity) { }
}
