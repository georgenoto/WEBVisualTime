using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_SYS_EXE;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TAB_SYS_EXEService : CrudService<TAB_SYS_EXE, TAB_SYS_EXEDto, CreateTAB_SYS_EXEDto, UpdateTAB_SYS_EXEDto, int>, ITAB_SYS_EXEService
{
    public TAB_SYS_EXEService(IRepository<TAB_SYS_EXE> repository)
        : base(repository, TAB_SYS_EXEMappingExtensions.ToDto, TAB_SYS_EXEMappingExtensions.ToEntity, TAB_SYS_EXEMappingExtensions.UpdateEntity) { }
}
