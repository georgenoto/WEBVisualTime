using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5610;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5610Service : CrudService<TABLE5610, TABLE5610Dto, CreateTABLE5610Dto, UpdateTABLE5610Dto, int>, ITABLE5610Service
{
    public TABLE5610Service(IRepository<TABLE5610> repository)
        : base(repository, TABLE5610MappingExtensions.ToDto, TABLE5610MappingExtensions.ToEntity, TABLE5610MappingExtensions.UpdateEntity) { }
}
