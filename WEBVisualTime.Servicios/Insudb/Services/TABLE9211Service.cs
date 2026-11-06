using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9211;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9211Service : CrudService<TABLE9211, TABLE9211Dto, CreateTABLE9211Dto, UpdateTABLE9211Dto, int>, ITABLE9211Service
{
    public TABLE9211Service(IRepository<TABLE9211> repository)
        : base(repository, TABLE9211MappingExtensions.ToDto, TABLE9211MappingExtensions.ToEntity, TABLE9211MappingExtensions.UpdateEntity) { }
}
