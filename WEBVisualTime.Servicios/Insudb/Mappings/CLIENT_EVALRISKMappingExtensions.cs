using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_EVALRISK;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIENT_EVALRISKMappingExtensions
{
    public static CLIENT_EVALRISKDto ToDto(this CLIENT_EVALRISK entity)
    {
        if (entity == null) return null!;
        return new CLIENT_EVALRISKDto
        {
            SCLIENT = entity.SCLIENT,
            DEFFECDATE = entity.DEFFECDATE,
            DOTHERDATE = entity.DOTHERDATE,
            NSINCEYEAR = entity.NSINCEYEAR,
            TABLE9010SDESCRIPT = entity.TABLE9010?.SDESCRIPT,
            NNUMEMPLOYERS = entity.NNUMEMPLOYERS,
            NCNTRYRISK = entity.NCNTRYRISK,
            TABLE9011SDESCRIPT = entity.TABLE9011?.SDESCRIPT,
            NTYPECIA = entity.NTYPECIA,
            TABLE9012SDESCRIPT = entity.TABLE9012?.SDESCRIPT,
            NTYPEPRODUCT = entity.NTYPEPRODUCT,
            TABLE9013SDESCRIPT = entity.TABLE9013?.SDESCRIPT,
            NRISK = entity.NRISK,
            TABLE9014SDESCRIPT = entity.TABLE9014?.SDESCRIPT,
            NACTBUS = entity.NACTBUS,
            TABLE9015SDESCRIPT = entity.TABLE9015?.SDESCRIPT,
            NREFBANK = entity.NREFBANK,
            TABLE9016SDESCRIPT = entity.TABLE9016?.SDESCRIPT,
            NREFBUS = entity.NREFBUS,
            TABLE9017SDESCRIPT = entity.TABLE9017?.SDESCRIPT,
            NREFLAW = entity.NREFLAW,
            TABLE9018SDESCRIPT = entity.TABLE9018?.SDESCRIPT,
            NNUMPAYS = entity.NNUMPAYS,
            TABLE9019SDESCRIPT = entity.TABLE9019?.SDESCRIPT,
            NOLDINSURANCE = entity.NOLDINSURANCE,
            TABLE9020SDESCRIPT = entity.TABLE9020?.SDESCRIPT,
            NPROPAY = entity.NPROPAY,
            TABLE9021SDESCRIPT = entity.TABLE9021?.SDESCRIPT,
            NCODDICOM = entity.NCODDICOM,
            SDESDICOM = entity.SDESDICOM,
            NCREDITREASON = entity.NCREDITREASON,
            TABLE9022SDESCRIPT = entity.TABLE9022?.SDESCRIPT,
            NLIQCURRENT = entity.NLIQCURRENT,
            TABLE9023SDESCRIPT = entity.TABLE9023?.SDESCRIPT,
            NLIQACD = entity.NLIQACD,
            TABLE9024SDESCRIPT = entity.TABLE9024?.SDESCRIPT,
            NRENTABILITY = entity.NRENTABILITY,
            TABLE9025SDESCRIPT = entity.TABLE9025?.SDESCRIPT,
            NGROWSALES = entity.NGROWSALES,
            TABLE9026SDESCRIPT = entity.TABLE9026?.SDESCRIPT,
            NECONOMIC = entity.NECONOMIC,
            TABLE9027SDESCRIPT = entity.TABLE9027?.SDESCRIPT,
            NFINANCIAL = entity.NFINANCIAL,
            TABLE9028SDESCRIPT = entity.TABLE9028?.SDESCRIPT,
            NCODRATING = entity.NCODRATING,
            TABLE9029SDESCRIPT = entity.TABLE9029?.SDESCRIPT,
            NDESRATING = entity.NDESRATING,
            TABLE9030SDESCRIPT = entity.TABLE9030?.SDESCRIPT,
            NCOUNTRY = entity.NCOUNTRY,
            TABLE66SDESCRIPT = entity.TABLE66?.SDESCRIPT,
            SNOTE1 = entity.SNOTE1,
            SNOTE2 = entity.SNOTE2,
            SNOTE3 = entity.SNOTE3,
            SNOTE4 = entity.SNOTE4,
            NBRANCHCIA = entity.NBRANCHCIA,
            TABLE9031SDESCRIPT = entity.TABLE9031?.SDESCRIPT,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NLIMITCREDIT = entity.NLIMITCREDIT,
            NCURRENCY = entity.NCURRENCY,
        };
    }

    public static CLIENT_EVALRISK ToEntity(this CreateCLIENT_EVALRISKDto dto)
    {
        if (dto == null) return null!;
        return new CLIENT_EVALRISK
        {
            SCLIENT = dto.SCLIENT,
            DEFFECDATE = dto.DEFFECDATE,
            DOTHERDATE = dto.DOTHERDATE,
            NSINCEYEAR = dto.NSINCEYEAR,
            NNUMEMPLOYERS = dto.NNUMEMPLOYERS,
            NCNTRYRISK = dto.NCNTRYRISK,
            NTYPECIA = dto.NTYPECIA,
            NTYPEPRODUCT = dto.NTYPEPRODUCT,
            NRISK = dto.NRISK,
            NACTBUS = dto.NACTBUS,
            NREFBANK = dto.NREFBANK,
            NREFBUS = dto.NREFBUS,
            NREFLAW = dto.NREFLAW,
            NNUMPAYS = dto.NNUMPAYS,
            NOLDINSURANCE = dto.NOLDINSURANCE,
            NPROPAY = dto.NPROPAY,
            NCODDICOM = dto.NCODDICOM,
            SDESDICOM = dto.SDESDICOM,
            NCREDITREASON = dto.NCREDITREASON,
            NLIQCURRENT = dto.NLIQCURRENT,
            NLIQACD = dto.NLIQACD,
            NRENTABILITY = dto.NRENTABILITY,
            NGROWSALES = dto.NGROWSALES,
            NECONOMIC = dto.NECONOMIC,
            NFINANCIAL = dto.NFINANCIAL,
            NCODRATING = dto.NCODRATING,
            NDESRATING = dto.NDESRATING,
            NCOUNTRY = dto.NCOUNTRY,
            SNOTE1 = dto.SNOTE1,
            SNOTE2 = dto.SNOTE2,
            SNOTE3 = dto.SNOTE3,
            SNOTE4 = dto.SNOTE4,
            NBRANCHCIA = dto.NBRANCHCIA,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NLIMITCREDIT = dto.NLIMITCREDIT,
            NCURRENCY = dto.NCURRENCY,
        };
    }

    public static void UpdateEntity(this CLIENT_EVALRISK entity, UpdateCLIENT_EVALRISKDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.DOTHERDATE = dto.DOTHERDATE;
        entity.NSINCEYEAR = dto.NSINCEYEAR;
        entity.NNUMEMPLOYERS = dto.NNUMEMPLOYERS;
        entity.NCNTRYRISK = dto.NCNTRYRISK;
        entity.NTYPECIA = dto.NTYPECIA;
        entity.NTYPEPRODUCT = dto.NTYPEPRODUCT;
        entity.NRISK = dto.NRISK;
        entity.NACTBUS = dto.NACTBUS;
        entity.NREFBANK = dto.NREFBANK;
        entity.NREFBUS = dto.NREFBUS;
        entity.NREFLAW = dto.NREFLAW;
        entity.NNUMPAYS = dto.NNUMPAYS;
        entity.NOLDINSURANCE = dto.NOLDINSURANCE;
        entity.NPROPAY = dto.NPROPAY;
        entity.NCODDICOM = dto.NCODDICOM;
        entity.SDESDICOM = dto.SDESDICOM;
        entity.NCREDITREASON = dto.NCREDITREASON;
        entity.NLIQCURRENT = dto.NLIQCURRENT;
        entity.NLIQACD = dto.NLIQACD;
        entity.NRENTABILITY = dto.NRENTABILITY;
        entity.NGROWSALES = dto.NGROWSALES;
        entity.NECONOMIC = dto.NECONOMIC;
        entity.NFINANCIAL = dto.NFINANCIAL;
        entity.NCODRATING = dto.NCODRATING;
        entity.NDESRATING = dto.NDESRATING;
        entity.NCOUNTRY = dto.NCOUNTRY;
        entity.SNOTE1 = dto.SNOTE1;
        entity.SNOTE2 = dto.SNOTE2;
        entity.SNOTE3 = dto.SNOTE3;
        entity.SNOTE4 = dto.SNOTE4;
        entity.NBRANCHCIA = dto.NBRANCHCIA;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NLIMITCREDIT = dto.NLIMITCREDIT;
        entity.NCURRENCY = dto.NCURRENCY;
    }
}
