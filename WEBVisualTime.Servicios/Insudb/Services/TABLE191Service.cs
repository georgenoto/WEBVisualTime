using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE191;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE191Service : CrudService<TABLE191, TABLE191Dto, CreateTABLE191Dto, UpdateTABLE191Dto, string>, ITABLE191Service
{
    public TABLE191Service(IRepository<TABLE191> repository)
        : base(repository, TABLE191MappingExtensions.ToDto, TABLE191MappingExtensions.ToEntity, TABLE191MappingExtensions.UpdateEntity) { }
}
