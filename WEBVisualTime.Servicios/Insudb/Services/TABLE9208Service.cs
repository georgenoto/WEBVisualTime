using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9208;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9208Service : CrudService<TABLE9208, TABLE9208Dto, CreateTABLE9208Dto, UpdateTABLE9208Dto, int>, ITABLE9208Service
{
    public TABLE9208Service(IRepository<TABLE9208> repository)
        : base(repository, TABLE9208MappingExtensions.ToDto, TABLE9208MappingExtensions.ToEntity, TABLE9208MappingExtensions.UpdateEntity) { }
}
