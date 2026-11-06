using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3019;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE3019Service : CrudService<TABLE3019, TABLE3019Dto, CreateTABLE3019Dto, UpdateTABLE3019Dto, int>, ITABLE3019Service
{
    public TABLE3019Service(IRepository<TABLE3019> repository)
        : base(repository, TABLE3019MappingExtensions.ToDto, TABLE3019MappingExtensions.ToEntity, TABLE3019MappingExtensions.UpdateEntity) { }
}
