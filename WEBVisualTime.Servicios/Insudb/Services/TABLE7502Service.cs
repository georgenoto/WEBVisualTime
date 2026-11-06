using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7502;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7502Service : CrudService<TABLE7502, TABLE7502Dto, CreateTABLE7502Dto, UpdateTABLE7502Dto, string>, ITABLE7502Service
{
    public TABLE7502Service(IRepository<TABLE7502> repository)
        : base(repository, TABLE7502MappingExtensions.ToDto, TABLE7502MappingExtensions.ToEntity, TABLE7502MappingExtensions.UpdateEntity) { }
}
