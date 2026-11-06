using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9207;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9207Service : CrudService<TABLE9207, TABLE9207Dto, CreateTABLE9207Dto, UpdateTABLE9207Dto, int>, ITABLE9207Service
{
    public TABLE9207Service(IRepository<TABLE9207> repository)
        : base(repository, TABLE9207MappingExtensions.ToDto, TABLE9207MappingExtensions.ToEntity, TABLE9207MappingExtensions.UpdateEntity) { }
}
