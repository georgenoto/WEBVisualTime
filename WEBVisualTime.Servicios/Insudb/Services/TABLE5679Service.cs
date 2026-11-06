using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5679;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5679Service : CrudService<TABLE5679, TABLE5679Dto, CreateTABLE5679Dto, UpdateTABLE5679Dto, int>, ITABLE5679Service
{
    public TABLE5679Service(IRepository<TABLE5679> repository)
        : base(repository, TABLE5679MappingExtensions.ToDto, TABLE5679MappingExtensions.ToEntity, TABLE5679MappingExtensions.UpdateEntity) { }
}
