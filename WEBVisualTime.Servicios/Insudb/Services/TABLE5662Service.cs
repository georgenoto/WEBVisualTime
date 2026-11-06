using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5662;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5662Service : CrudService<TABLE5662, TABLE5662Dto, CreateTABLE5662Dto, UpdateTABLE5662Dto, int>, ITABLE5662Service
{
    public TABLE5662Service(IRepository<TABLE5662> repository)
        : base(repository, TABLE5662MappingExtensions.ToDto, TABLE5662MappingExtensions.ToEntity, TABLE5662MappingExtensions.UpdateEntity) { }
}
