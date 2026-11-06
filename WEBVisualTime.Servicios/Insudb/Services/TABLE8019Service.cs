using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8019;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8019Service : CrudService<TABLE8019, TABLE8019Dto, CreateTABLE8019Dto, UpdateTABLE8019Dto, int>, ITABLE8019Service
{
    public TABLE8019Service(IRepository<TABLE8019> repository)
        : base(repository, TABLE8019MappingExtensions.ToDto, TABLE8019MappingExtensions.ToEntity, TABLE8019MappingExtensions.UpdateEntity) { }
}
