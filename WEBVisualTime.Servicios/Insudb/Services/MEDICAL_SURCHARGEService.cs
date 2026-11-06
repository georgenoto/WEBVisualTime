using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_SURCHARGE;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class MEDICAL_SURCHARGEService : CrudService<MEDICAL_SURCHARGE, MEDICAL_SURCHARGEDto, CreateMEDICAL_SURCHARGEDto, UpdateMEDICAL_SURCHARGEDto, int>, IMEDICAL_SURCHARGEService
{
    public MEDICAL_SURCHARGEService(IRepository<MEDICAL_SURCHARGE> repository)
        : base(repository, MEDICAL_SURCHARGEMappingExtensions.ToDto, MEDICAL_SURCHARGEMappingExtensions.ToEntity, MEDICAL_SURCHARGEMappingExtensions.UpdateEntity) { }
}
