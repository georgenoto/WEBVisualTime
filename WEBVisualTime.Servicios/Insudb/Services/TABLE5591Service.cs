using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5591;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5591Service : CrudService<TABLE5591, TABLE5591Dto, CreateTABLE5591Dto, UpdateTABLE5591Dto, int>, ITABLE5591Service
{
    public TABLE5591Service(IRepository<TABLE5591> repository)
        : base(repository, TABLE5591MappingExtensions.ToDto, TABLE5591MappingExtensions.ToEntity, TABLE5591MappingExtensions.UpdateEntity) { }
}
