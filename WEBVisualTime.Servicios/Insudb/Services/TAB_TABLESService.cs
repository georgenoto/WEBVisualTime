using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TABLES;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TAB_TABLESService : CrudService<TAB_TABLES, TAB_TABLESDto, CreateTAB_TABLESDto, UpdateTAB_TABLESDto, string>, ITAB_TABLESService
{
    public TAB_TABLESService(IRepository<TAB_TABLES> repository)
        : base(repository, TAB_TABLESMappingExtensions.ToDto, TAB_TABLESMappingExtensions.ToEntity, TAB_TABLESMappingExtensions.UpdateEntity) { }
}
