using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8602;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8602Service : CrudService<TABLE8602, TABLE8602Dto, CreateTABLE8602Dto, UpdateTABLE8602Dto, string>, ITABLE8602Service
{
    public TABLE8602Service(IRepository<TABLE8602> repository)
        : base(repository, TABLE8602MappingExtensions.ToDto, TABLE8602MappingExtensions.ToEntity, TABLE8602MappingExtensions.UpdateEntity) { }
}
