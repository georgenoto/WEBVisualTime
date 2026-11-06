using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE693;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE693Service : CrudService<TABLE693, TABLE693Dto, CreateTABLE693Dto, UpdateTABLE693Dto, int>, ITABLE693Service
{
    public TABLE693Service(IRepository<TABLE693> repository)
        : base(repository, TABLE693MappingExtensions.ToDto, TABLE693MappingExtensions.ToEntity, TABLE693MappingExtensions.UpdateEntity) { }
}
