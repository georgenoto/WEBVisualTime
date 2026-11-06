using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5800;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5800Service : CrudService<TABLE5800, TABLE5800Dto, CreateTABLE5800Dto, UpdateTABLE5800Dto, int>, ITABLE5800Service
{
    public TABLE5800Service(IRepository<TABLE5800> repository)
        : base(repository, TABLE5800MappingExtensions.ToDto, TABLE5800MappingExtensions.ToEntity, TABLE5800MappingExtensions.UpdateEntity) { }
}
