using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9012;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9012Service : CrudService<TABLE9012, TABLE9012Dto, CreateTABLE9012Dto, UpdateTABLE9012Dto, int>, ITABLE9012Service
{
    public TABLE9012Service(IRepository<TABLE9012> repository)
        : base(repository, TABLE9012MappingExtensions.ToDto, TABLE9012MappingExtensions.ToEntity, TABLE9012MappingExtensions.UpdateEntity) { }
}
