using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5520;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5520Service : CrudService<TABLE5520, TABLE5520Dto, CreateTABLE5520Dto, UpdateTABLE5520Dto, int>, ITABLE5520Service
{
    public TABLE5520Service(IRepository<TABLE5520> repository)
        : base(repository, TABLE5520MappingExtensions.ToDto, TABLE5520MappingExtensions.ToEntity, TABLE5520MappingExtensions.UpdateEntity) { }
}
