using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE235;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE235Service : CrudService<TABLE235, TABLE235Dto, CreateTABLE235Dto, UpdateTABLE235Dto, string>, ITABLE235Service
{
    public TABLE235Service(IRepository<TABLE235> repository)
        : base(repository, TABLE235MappingExtensions.ToDto, TABLE235MappingExtensions.ToEntity, TABLE235MappingExtensions.UpdateEntity) { }
}
