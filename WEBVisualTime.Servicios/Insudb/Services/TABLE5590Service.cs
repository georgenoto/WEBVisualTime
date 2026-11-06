using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5590;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5590Service : CrudService<TABLE5590, TABLE5590Dto, CreateTABLE5590Dto, UpdateTABLE5590Dto, int>, ITABLE5590Service
{
    public TABLE5590Service(IRepository<TABLE5590> repository)
        : base(repository, TABLE5590MappingExtensions.ToDto, TABLE5590MappingExtensions.ToEntity, TABLE5590MappingExtensions.UpdateEntity) { }
}
