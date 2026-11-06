using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5635;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5635Service : CrudService<TABLE5635, TABLE5635Dto, CreateTABLE5635Dto, UpdateTABLE5635Dto, int>, ITABLE5635Service
{
    public TABLE5635Service(IRepository<TABLE5635> repository)
        : base(repository, TABLE5635MappingExtensions.ToDto, TABLE5635MappingExtensions.ToEntity, TABLE5635MappingExtensions.UpdateEntity) { }
}
