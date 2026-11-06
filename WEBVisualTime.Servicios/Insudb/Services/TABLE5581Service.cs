using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5581;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5581Service : CrudService<TABLE5581, TABLE5581Dto, CreateTABLE5581Dto, UpdateTABLE5581Dto, int>, ITABLE5581Service
{
    public TABLE5581Service(IRepository<TABLE5581> repository)
        : base(repository, TABLE5581MappingExtensions.ToDto, TABLE5581MappingExtensions.ToEntity, TABLE5581MappingExtensions.UpdateEntity) { }
}
