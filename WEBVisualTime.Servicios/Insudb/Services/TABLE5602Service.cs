using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5602;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5602Service : CrudService<TABLE5602, TABLE5602Dto, CreateTABLE5602Dto, UpdateTABLE5602Dto, string>, ITABLE5602Service
{
    public TABLE5602Service(IRepository<TABLE5602> repository)
        : base(repository, TABLE5602MappingExtensions.ToDto, TABLE5602MappingExtensions.ToEntity, TABLE5602MappingExtensions.UpdateEntity) { }
}
