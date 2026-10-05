using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_ORDERS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMMPAYREQ_ORDERSMappingExtensions
{
    public static COMMPAYREQ_ORDERSDto ToDto(this COMMPAYREQ_ORDERS entity)
    {
        if (entity == null) return null!;
        return new COMMPAYREQ_ORDERSDto
        {
            NID_COMMPAYREQ = entity.NID_COMMPAYREQ,
            COMMPAYMENTREQUESTSSCLIENAME_HOLDER = entity.COMMPAYMENTREQUESTS?.SCLIENAME_HOLDER,
            NCLAIM = entity.NCLAIM,
            CLAIM_ORDERNCLAIMSTYPECARE = entity.CLAIM_ORDERNCLAIM?.STYPECARE,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_ORDERNCASE_NUMSTYPECARE = entity.CLAIM_ORDERNCASE_NUM?.STYPECARE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            CLAIM_ORDERNDEMAN_TYPESTYPECARE = entity.CLAIM_ORDERNDEMAN_TYPE?.STYPECARE,
            NORDER_NUM = entity.NORDER_NUM,
            CLAIM_ORDERNORDER_NUMSTYPECARE = entity.CLAIM_ORDERNORDER_NUM?.STYPECARE,
            NMASTERORDER = entity.NMASTERORDER,
            MASTERCL_ORDERSNAMECLIENT = entity.MASTERCL_ORDER?.SNAMECLIENT,
            NMASTERORDERTYPE = entity.NMASTERORDERTYPE,
            TABLE9265SDESCRIPT = entity.TABLE9265?.SDESCRIPT,
            STYPECARE = entity.STYPECARE,
            TABLE8604SDESCRIPT = entity.TABLE8604?.SDESCRIPT,
            DIAGNOSIS_ORDER = entity.DIAGNOSIS_ORDER,
            REASONREJECT_ORDER = entity.REASONREJECT_ORDER,
            NCURRENCY_MO = entity.NCURRENCY_MO,
            TABLE11SDESCRIPT = entity.TABLE11?.SDESCRIPT,
            NAMOUNTREJECTED_ORDER = entity.NAMOUNTREJECTED_ORDER,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NSTATUS_ORDER = entity.NSTATUS_ORDER,
            TABLE9241SDESCRIPT = entity.TABLE9241?.SDESCRIPT,
        };
    }

    public static COMMPAYREQ_ORDERS ToEntity(this CreateCOMMPAYREQ_ORDERSDto dto)
    {
        if (dto == null) return null!;
        return new COMMPAYREQ_ORDERS
        {
            NMASTERORDER = dto.NMASTERORDER,
            NMASTERORDERTYPE = dto.NMASTERORDERTYPE,
            STYPECARE = dto.STYPECARE,
            DIAGNOSIS_ORDER = dto.DIAGNOSIS_ORDER,
            REASONREJECT_ORDER = dto.REASONREJECT_ORDER,
            NCURRENCY_MO = dto.NCURRENCY_MO,
            NAMOUNTREJECTED_ORDER = dto.NAMOUNTREJECTED_ORDER,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NSTATUS_ORDER = dto.NSTATUS_ORDER,
        };
    }

    public static void UpdateEntity(this COMMPAYREQ_ORDERS entity, UpdateCOMMPAYREQ_ORDERSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NMASTERORDER = dto.NMASTERORDER;
        entity.NMASTERORDERTYPE = dto.NMASTERORDERTYPE;
        entity.STYPECARE = dto.STYPECARE;
        entity.DIAGNOSIS_ORDER = dto.DIAGNOSIS_ORDER;
        entity.REASONREJECT_ORDER = dto.REASONREJECT_ORDER;
        entity.NCURRENCY_MO = dto.NCURRENCY_MO;
        entity.NAMOUNTREJECTED_ORDER = dto.NAMOUNTREJECTED_ORDER;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NSTATUS_ORDER = dto.NSTATUS_ORDER;
    }
}
