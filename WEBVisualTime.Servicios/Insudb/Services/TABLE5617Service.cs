using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5617;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5617Service : CrudService<TABLE5617, TABLE5617Dto, CreateTABLE5617Dto, UpdateTABLE5617Dto, int>, ITABLE5617Service
{
    public TABLE5617Service(IRepository<TABLE5617> repository)
        : base(repository, TABLE5617MappingExtensions.ToDto, TABLE5617MappingExtensions.ToEntity, TABLE5617MappingExtensions.UpdateEntity) { }
}
