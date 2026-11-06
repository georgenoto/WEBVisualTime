using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5742;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5742Service : CrudService<TABLE5742, TABLE5742Dto, CreateTABLE5742Dto, UpdateTABLE5742Dto, int>, ITABLE5742Service
{
    public TABLE5742Service(IRepository<TABLE5742> repository)
        : base(repository, TABLE5742MappingExtensions.ToDto, TABLE5742MappingExtensions.ToEntity, TABLE5742MappingExtensions.UpdateEntity) { }
}
