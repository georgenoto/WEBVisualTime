using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9235;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9235Service : CrudService<TABLE9235, TABLE9235Dto, CreateTABLE9235Dto, UpdateTABLE9235Dto, string>, ITABLE9235Service
{
    public TABLE9235Service(IRepository<TABLE9235> repository)
        : base(repository, TABLE9235MappingExtensions.ToDto, TABLE9235MappingExtensions.ToEntity, TABLE9235MappingExtensions.UpdateEntity) { }
}
