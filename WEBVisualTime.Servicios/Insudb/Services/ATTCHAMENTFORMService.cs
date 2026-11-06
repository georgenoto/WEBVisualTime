using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.ATTCHAMENTFORM;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class ATTCHAMENTFORMService : CrudService<ATTCHAMENTFORM, ATTCHAMENTFORMDto, CreateATTCHAMENTFORMDto, UpdateATTCHAMENTFORMDto, long>, IATTCHAMENTFORMService
{
    public ATTCHAMENTFORMService(IRepository<ATTCHAMENTFORM> repository)
        : base(repository, ATTCHAMENTFORMMappingExtensions.ToDto, ATTCHAMENTFORMMappingExtensions.ToEntity, ATTCHAMENTFORMMappingExtensions.UpdateEntity) { }
}
