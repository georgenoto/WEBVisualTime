using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5576;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5576Service : CrudService<TABLE5576, TABLE5576Dto, CreateTABLE5576Dto, UpdateTABLE5576Dto, int>, ITABLE5576Service
{
    public TABLE5576Service(IRepository<TABLE5576> repository)
        : base(repository, TABLE5576MappingExtensions.ToDto, TABLE5576MappingExtensions.ToEntity, TABLE5576MappingExtensions.UpdateEntity) { }
}
