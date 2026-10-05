using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BILLS_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BILLS_HISMappingExtensions
{
    public static BILLS_HISDto ToDto(this BILLS_HIS entity)
    {
        if (entity == null) return null!;
        return new BILLS_HISDto
        {
            SBILLTYPE = entity.SBILLTYPE,
            NBILLNUM = entity.NBILLNUM,
            DSTATDATE = entity.DSTATDATE,
            NTRANSAC = entity.NTRANSAC,
            NBILLMOVCODE = entity.NBILLMOVCODE,
            STEXT = entity.STEXT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NBILLNUM_OLD = entity.NBILLNUM_OLD,
            DSTATDATE_OLD = entity.DSTATDATE_OLD,
            NUSER = entity.NUSER,
            NUSER_OLD = entity.NUSER_OLD,
            NIDTRANSACTION = entity.NIDTRANSACTION,
            NIDTRANSACTION_OLD = entity.NIDTRANSACTION_OLD,
            SBILLNUMSFE = entity.SBILLNUMSFE,
            SBILLNUMSFE_OLD = entity.SBILLNUMSFE_OLD,
            SNOTEDESCRIPTS = entity.SNOTEDESCRIPTS,
        };
    }

    public static BILLS_HIS ToEntity(this CreateBILLS_HISDto dto)
    {
        if (dto == null) return null!;
        return new BILLS_HIS
        {
            SBILLTYPE = dto.SBILLTYPE,
            NBILLNUM = dto.NBILLNUM,
            DSTATDATE = dto.DSTATDATE,
            NTRANSAC = dto.NTRANSAC,
            NBILLMOVCODE = dto.NBILLMOVCODE,
            STEXT = dto.STEXT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NBILLNUM_OLD = dto.NBILLNUM_OLD,
            DSTATDATE_OLD = dto.DSTATDATE_OLD,
            NUSER = dto.NUSER,
            NUSER_OLD = dto.NUSER_OLD,
            NIDTRANSACTION = dto.NIDTRANSACTION,
            NIDTRANSACTION_OLD = dto.NIDTRANSACTION_OLD,
            SBILLNUMSFE = dto.SBILLNUMSFE,
            SBILLNUMSFE_OLD = dto.SBILLNUMSFE_OLD,
            SNOTEDESCRIPTS = dto.SNOTEDESCRIPTS,
        };
    }

    public static void UpdateEntity(this BILLS_HIS entity, UpdateBILLS_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SBILLTYPE = dto.SBILLTYPE;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.DSTATDATE = dto.DSTATDATE;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NBILLMOVCODE = dto.NBILLMOVCODE;
        entity.STEXT = dto.STEXT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NBILLNUM_OLD = dto.NBILLNUM_OLD;
        entity.DSTATDATE_OLD = dto.DSTATDATE_OLD;
        entity.NUSER = dto.NUSER;
        entity.NUSER_OLD = dto.NUSER_OLD;
        entity.NIDTRANSACTION = dto.NIDTRANSACTION;
        entity.NIDTRANSACTION_OLD = dto.NIDTRANSACTION_OLD;
        entity.SBILLNUMSFE = dto.SBILLNUMSFE;
        entity.SBILLNUMSFE_OLD = dto.SBILLNUMSFE_OLD;
        entity.SNOTEDESCRIPTS = dto.SNOTEDESCRIPTS;
    }
}
