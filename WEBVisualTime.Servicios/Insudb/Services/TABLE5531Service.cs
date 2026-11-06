using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5531;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5531Service : CrudService<TABLE5531, TABLE5531Dto, CreateTABLE5531Dto, UpdateTABLE5531Dto, int>, ITABLE5531Service
{
    public TABLE5531Service(IRepository<TABLE5531> repository)
        : base(repository, TABLE5531MappingExtensions.ToDto, TABLE5531MappingExtensions.ToEntity, TABLE5531MappingExtensions.UpdateEntity) { }
}
