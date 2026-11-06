using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5607;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5607Service : CrudService<TABLE5607, TABLE5607Dto, CreateTABLE5607Dto, UpdateTABLE5607Dto, int>, ITABLE5607Service
{
    public TABLE5607Service(IRepository<TABLE5607> repository)
        : base(repository, TABLE5607MappingExtensions.ToDto, TABLE5607MappingExtensions.ToEntity, TABLE5607MappingExtensions.UpdateEntity) { }
}
