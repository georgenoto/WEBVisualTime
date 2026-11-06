using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE185;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE185Service : CrudService<TABLE185, TABLE185Dto, CreateTABLE185Dto, UpdateTABLE185Dto, int>, ITABLE185Service
{
    public TABLE185Service(IRepository<TABLE185> repository)
        : base(repository, TABLE185MappingExtensions.ToDto, TABLE185MappingExtensions.ToEntity, TABLE185MappingExtensions.UpdateEntity) { }
}
