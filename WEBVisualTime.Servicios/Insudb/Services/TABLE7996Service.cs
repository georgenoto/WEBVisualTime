using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7996;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7996Service : CrudService<TABLE7996, TABLE7996Dto, CreateTABLE7996Dto, UpdateTABLE7996Dto, int>, ITABLE7996Service
{
    public TABLE7996Service(IRepository<TABLE7996> repository)
        : base(repository, TABLE7996MappingExtensions.ToDto, TABLE7996MappingExtensions.ToEntity, TABLE7996MappingExtensions.UpdateEntity) { }
}
