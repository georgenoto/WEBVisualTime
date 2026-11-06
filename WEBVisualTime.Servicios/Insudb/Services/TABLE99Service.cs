using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE99;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE99Service : CrudService<TABLE99, TABLE99Dto, CreateTABLE99Dto, UpdateTABLE99Dto, int>, ITABLE99Service
{
    public TABLE99Service(IRepository<TABLE99> repository)
        : base(repository, TABLE99MappingExtensions.ToDto, TABLE99MappingExtensions.ToEntity, TABLE99MappingExtensions.UpdateEntity) { }
}
