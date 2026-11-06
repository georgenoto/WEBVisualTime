using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5518;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5518Service : CrudService<TABLE5518, TABLE5518Dto, CreateTABLE5518Dto, UpdateTABLE5518Dto, int>, ITABLE5518Service
{
    public TABLE5518Service(IRepository<TABLE5518> repository)
        : base(repository, TABLE5518MappingExtensions.ToDto, TABLE5518MappingExtensions.ToEntity, TABLE5518MappingExtensions.UpdateEntity) { }
}
