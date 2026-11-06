using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE113;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE113Service : CrudService<TABLE113, TABLE113Dto, CreateTABLE113Dto, UpdateTABLE113Dto, int>, ITABLE113Service
{
    public TABLE113Service(IRepository<TABLE113> repository)
        : base(repository, TABLE113MappingExtensions.ToDto, TABLE113MappingExtensions.ToEntity, TABLE113MappingExtensions.UpdateEntity) { }
}
