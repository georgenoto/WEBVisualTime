using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5612;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5612Service : CrudService<TABLE5612, TABLE5612Dto, CreateTABLE5612Dto, UpdateTABLE5612Dto, int>, ITABLE5612Service
{
    public TABLE5612Service(IRepository<TABLE5612> repository)
        : base(repository, TABLE5612MappingExtensions.ToDto, TABLE5612MappingExtensions.ToEntity, TABLE5612MappingExtensions.UpdateEntity) { }
}
