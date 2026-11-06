using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPEND_STATUSES;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SDD_DEPEND_STATUSESService : CrudService<SDD_DEPEND_STATUSES, SDD_DEPEND_STATUSESDto, CreateSDD_DEPEND_STATUSESDto, UpdateSDD_DEPEND_STATUSESDto, string>, ISDD_DEPEND_STATUSESService
{
    public SDD_DEPEND_STATUSESService(IRepository<SDD_DEPEND_STATUSES> repository)
        : base(repository, SDD_DEPEND_STATUSESMappingExtensions.ToDto, SDD_DEPEND_STATUSESMappingExtensions.ToEntity, SDD_DEPEND_STATUSESMappingExtensions.UpdateEntity) { }
}
