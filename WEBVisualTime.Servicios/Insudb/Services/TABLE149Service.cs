using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE149;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE149Service : CrudService<TABLE149, TABLE149Dto, CreateTABLE149Dto, UpdateTABLE149Dto, int>, ITABLE149Service
{
    public TABLE149Service(IRepository<TABLE149> repository)
        : base(repository, TABLE149MappingExtensions.ToDto, TABLE149MappingExtensions.ToEntity, TABLE149MappingExtensions.UpdateEntity) { }
}
