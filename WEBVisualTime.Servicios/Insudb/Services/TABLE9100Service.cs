using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9100;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9100Service : CrudService<TABLE9100, TABLE9100Dto, CreateTABLE9100Dto, UpdateTABLE9100Dto, int>, ITABLE9100Service
{
    public TABLE9100Service(IRepository<TABLE9100> repository)
        : base(repository, TABLE9100MappingExtensions.ToDto, TABLE9100MappingExtensions.ToEntity, TABLE9100MappingExtensions.UpdateEntity) { }
}
