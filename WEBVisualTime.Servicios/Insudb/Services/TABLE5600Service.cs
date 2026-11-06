using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5600;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5600Service : CrudService<TABLE5600, TABLE5600Dto, CreateTABLE5600Dto, UpdateTABLE5600Dto, int>, ITABLE5600Service
{
    public TABLE5600Service(IRepository<TABLE5600> repository)
        : base(repository, TABLE5600MappingExtensions.ToDto, TABLE5600MappingExtensions.ToEntity, TABLE5600MappingExtensions.UpdateEntity) { }
}
