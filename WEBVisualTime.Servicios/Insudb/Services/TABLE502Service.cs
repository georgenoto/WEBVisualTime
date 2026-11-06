using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE502;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE502Service : CrudService<TABLE502, TABLE502Dto, CreateTABLE502Dto, UpdateTABLE502Dto, long>, ITABLE502Service
{
    public TABLE502Service(IRepository<TABLE502> repository)
        : base(repository, TABLE502MappingExtensions.ToDto, TABLE502MappingExtensions.ToEntity, TABLE502MappingExtensions.UpdateEntity) { }
}
