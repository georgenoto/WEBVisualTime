using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5500;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5500Service : CrudService<TABLE5500, TABLE5500Dto, CreateTABLE5500Dto, UpdateTABLE5500Dto, int>, ITABLE5500Service
{
    public TABLE5500Service(IRepository<TABLE5500> repository)
        : base(repository, TABLE5500MappingExtensions.ToDto, TABLE5500MappingExtensions.ToEntity, TABLE5500MappingExtensions.UpdateEntity) { }
}
