using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE512;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE512Service : CrudService<TABLE512, TABLE512Dto, CreateTABLE512Dto, UpdateTABLE512Dto, int>, ITABLE512Service
{
    public TABLE512Service(IRepository<TABLE512> repository)
        : base(repository, TABLE512MappingExtensions.ToDto, TABLE512MappingExtensions.ToEntity, TABLE512MappingExtensions.UpdateEntity) { }
}
