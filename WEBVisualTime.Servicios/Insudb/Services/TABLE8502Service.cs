using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8502;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8502Service : CrudService<TABLE8502, TABLE8502Dto, CreateTABLE8502Dto, UpdateTABLE8502Dto, int>, ITABLE8502Service
{
    public TABLE8502Service(IRepository<TABLE8502> repository)
        : base(repository, TABLE8502MappingExtensions.ToDto, TABLE8502MappingExtensions.ToEntity, TABLE8502MappingExtensions.UpdateEntity) { }
}
