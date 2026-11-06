using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5744;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5744Service : CrudService<TABLE5744, TABLE5744Dto, CreateTABLE5744Dto, UpdateTABLE5744Dto, int>, ITABLE5744Service
{
    public TABLE5744Service(IRepository<TABLE5744> repository)
        : base(repository, TABLE5744MappingExtensions.ToDto, TABLE5744MappingExtensions.ToEntity, TABLE5744MappingExtensions.UpdateEntity) { }
}
