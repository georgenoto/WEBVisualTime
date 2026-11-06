using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5719;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5719Service : CrudService<TABLE5719, TABLE5719Dto, CreateTABLE5719Dto, UpdateTABLE5719Dto, int>, ITABLE5719Service
{
    public TABLE5719Service(IRepository<TABLE5719> repository)
        : base(repository, TABLE5719MappingExtensions.ToDto, TABLE5719MappingExtensions.ToEntity, TABLE5719MappingExtensions.UpdateEntity) { }
}
