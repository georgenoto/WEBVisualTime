using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE298;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE298Service : CrudService<TABLE298, TABLE298Dto, CreateTABLE298Dto, UpdateTABLE298Dto, int>, ITABLE298Service
{
    public TABLE298Service(IRepository<TABLE298> repository)
        : base(repository, TABLE298MappingExtensions.ToDto, TABLE298MappingExtensions.ToEntity, TABLE298MappingExtensions.UpdateEntity) { }
}
