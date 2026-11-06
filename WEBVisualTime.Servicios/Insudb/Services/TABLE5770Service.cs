using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5770;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5770Service : CrudService<TABLE5770, TABLE5770Dto, CreateTABLE5770Dto, UpdateTABLE5770Dto, int>, ITABLE5770Service
{
    public TABLE5770Service(IRepository<TABLE5770> repository)
        : base(repository, TABLE5770MappingExtensions.ToDto, TABLE5770MappingExtensions.ToEntity, TABLE5770MappingExtensions.UpdateEntity) { }
}
