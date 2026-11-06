using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE62;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE62Service : CrudService<TABLE62, TABLE62Dto, CreateTABLE62Dto, UpdateTABLE62Dto, int>, ITABLE62Service
{
    public TABLE62Service(IRepository<TABLE62> repository)
        : base(repository, TABLE62MappingExtensions.ToDto, TABLE62MappingExtensions.ToEntity, TABLE62MappingExtensions.UpdateEntity) { }
}
