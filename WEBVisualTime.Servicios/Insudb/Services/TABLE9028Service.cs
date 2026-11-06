using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9028;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9028Service : CrudService<TABLE9028, TABLE9028Dto, CreateTABLE9028Dto, UpdateTABLE9028Dto, int>, ITABLE9028Service
{
    public TABLE9028Service(IRepository<TABLE9028> repository)
        : base(repository, TABLE9028MappingExtensions.ToDto, TABLE9028MappingExtensions.ToEntity, TABLE9028MappingExtensions.UpdateEntity) { }
}
