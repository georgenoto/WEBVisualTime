using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE314;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE314Service : CrudService<TABLE314, TABLE314Dto, CreateTABLE314Dto, UpdateTABLE314Dto, int>, ITABLE314Service
{
    public TABLE314Service(IRepository<TABLE314> repository)
        : base(repository, TABLE314MappingExtensions.ToDto, TABLE314MappingExtensions.ToEntity, TABLE314MappingExtensions.UpdateEntity) { }
}
