using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CHEQUES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CHEQUESMappingExtensions
{
    public static CHEQUESDto ToDto(this CHEQUES entity)
    {
        if (entity == null) return null!;
        return new CHEQUESDto
        {
            NREQUEST_NU = entity.NREQUEST_NU,
            SCHEQUE = entity.SCHEQUE,
            NCONSEC = entity.NCONSEC,
            NCONCEPT = entity.NCONCEPT,
            PAY_ORD_CONCEPTSNCONCEPTSSTATREGT = entity.PAY_ORD_CONCEPTSNCONCEPT?.SSTATREGT,
            NAMOUNT = entity.NAMOUNT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NBRANCH_LED = entity.NBRANCH_LED,
            TABLE75SDESCRIPT = entity.TABLE75?.SDESCRIPT,
            NCLAIM = entity.NCLAIM,
            CLAIMSCERTYPE = entity.CLAIM?.SCERTYPE,
            DCOMPDATE = entity.DCOMPDATE,
            NVOUCHER_LE = entity.NVOUCHER_LE,
            NVOUCHER = entity.NVOUCHER,
            DDAT_PROPOS = entity.DDAT_PROPOS,
            SDESCRIPT = entity.SDESCRIPT,
            DISSUE_DAT = entity.DISSUE_DAT,
            DLEDGER_DAT = entity.DLEDGER_DAT,
            NNULLCODE = entity.NNULLCODE,
            TABLE295SDESCRIPT = entity.TABLE295?.SDESCRIPT,
            DNULLDATE = entity.DNULLDATE,
            SPAY_FREQ = entity.SPAY_FREQ,
            NQ_PAYS = entity.NQ_PAYS,
            NRECEIPT = entity.NRECEIPT,
            SREQUEST_TY = entity.SREQUEST_TY,
            TABLE193SDESCRIPT = entity.TABLE193?.SDESCRIPT,
            NSTA_CHEQUE = entity.NSTA_CHEQUE,
            TABLE187SDESCRIPT = entity.TABLE187?.SDESCRIPT,
            DSTAT_DATE = entity.DSTAT_DATE,
            NTRANSAC = entity.NTRANSAC,
            NUSER_SOL = entity.NUSER_SOL,
            NUSERCODE = entity.NUSERCODE,
            NYEAR_MONTH = entity.NYEAR_MONTH,
            NACC_BANK = entity.NACC_BANK,
            BANK_ACCSACC_LEDGER = entity.BANK_ACC?.SACC_LEDGER,
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            NNOTENUM = entity.NNOTENUM,
            NAFECT = entity.NAFECT,
            NEXENT = entity.NEXENT,
            NTAXCODE = entity.NTAXCODE,
            NTAX_AMOUNT = entity.NTAX_AMOUNT,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NCASHNUM = entity.NCASHNUM,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            NPAYORDBORD = entity.NPAYORDBORD,
            NCOMPANY = entity.NCOMPANY,
            PAY_ORD_CONCEPTSNCOMPANYSSTATREGT = entity.PAY_ORD_CONCEPTSNCOMPANY?.SSTATREGT,
            SINTER_PAY = entity.SINTER_PAY,
            NAMOUNT_LOCAL = entity.NAMOUNT_LOCAL,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            SFILE_FIN700 = entity.SFILE_FIN700,
            DDATE_FIN700 = entity.DDATE_FIN700,
            NTYPESUPPORT = entity.NTYPESUPPORT,
            TABLE5570SDESCRIPT = entity.TABLE5570?.SDESCRIPT,
            NDOCSUPPORT = entity.NDOCSUPPORT,
            NTAX_PERCENT = entity.NTAX_PERCENT,
            NCURRENCYORI = entity.NCURRENCYORI,
            NCURRENCYPAY = entity.NCURRENCYPAY,
            NAMOUNTPAY = entity.NAMOUNTPAY,
            DPOSTED = entity.DPOSTED,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            TABLE5556SDESCRIPT = entity.TABLE5556?.SDESCRIPT,
            NAGENCY = entity.NAGENCY,
            AGENCIESSPAY = entity.AGENCIES?.SPAY,
            NORDPAY_REL = entity.NORDPAY_REL,
            NNUM_RELPAY = entity.NNUM_RELPAY,
            SINDPROCES = entity.SINDPROCES,
            SACCOUNTHOLDER = entity.SACCOUNTHOLDER,
            NBANKEXT = entity.NBANKEXT,
            SBANKACCOUNT = entity.SBANKACCOUNT,
            NPAY_COMM = entity.NPAY_COMM,
            NACC_TYPE = entity.NACC_TYPE,
            NID_EXTERNALSYSTEM = entity.NID_EXTERNALSYSTEM,
            NEXTERNAL_CONCEPT = entity.NEXTERNAL_CONCEPT,
        };
    }

    public static CHEQUES ToEntity(this CreateCHEQUESDto dto)
    {
        if (dto == null) return null!;
        return new CHEQUES
        {
            NCONCEPT = dto.NCONCEPT,
            NAMOUNT = dto.NAMOUNT,
            SCLIENT = dto.SCLIENT,
            NBRANCH_LED = dto.NBRANCH_LED,
            NCLAIM = dto.NCLAIM,
            DCOMPDATE = dto.DCOMPDATE,
            NVOUCHER_LE = dto.NVOUCHER_LE,
            NVOUCHER = dto.NVOUCHER,
            DDAT_PROPOS = dto.DDAT_PROPOS,
            SDESCRIPT = dto.SDESCRIPT,
            DISSUE_DAT = dto.DISSUE_DAT,
            DLEDGER_DAT = dto.DLEDGER_DAT,
            NNULLCODE = dto.NNULLCODE,
            DNULLDATE = dto.DNULLDATE,
            SPAY_FREQ = dto.SPAY_FREQ,
            NQ_PAYS = dto.NQ_PAYS,
            NRECEIPT = dto.NRECEIPT,
            SREQUEST_TY = dto.SREQUEST_TY,
            NSTA_CHEQUE = dto.NSTA_CHEQUE,
            DSTAT_DATE = dto.DSTAT_DATE,
            NTRANSAC = dto.NTRANSAC,
            NUSER_SOL = dto.NUSER_SOL,
            NUSERCODE = dto.NUSERCODE,
            NYEAR_MONTH = dto.NYEAR_MONTH,
            NACC_BANK = dto.NACC_BANK,
            NBORDEREAUX = dto.NBORDEREAUX,
            NNOTENUM = dto.NNOTENUM,
            NAFECT = dto.NAFECT,
            NEXENT = dto.NEXENT,
            NTAXCODE = dto.NTAXCODE,
            NTAX_AMOUNT = dto.NTAX_AMOUNT,
            NOFFICE = dto.NOFFICE,
            NCASHNUM = dto.NCASHNUM,
            NINSUR_AREA = dto.NINSUR_AREA,
            NPAYORDBORD = dto.NPAYORDBORD,
            NCOMPANY = dto.NCOMPANY,
            SINTER_PAY = dto.SINTER_PAY,
            NAMOUNT_LOCAL = dto.NAMOUNT_LOCAL,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            SFILE_FIN700 = dto.SFILE_FIN700,
            DDATE_FIN700 = dto.DDATE_FIN700,
            NTYPESUPPORT = dto.NTYPESUPPORT,
            NDOCSUPPORT = dto.NDOCSUPPORT,
            NTAX_PERCENT = dto.NTAX_PERCENT,
            NCURRENCYORI = dto.NCURRENCYORI,
            NCURRENCYPAY = dto.NCURRENCYPAY,
            NAMOUNTPAY = dto.NAMOUNTPAY,
            DPOSTED = dto.DPOSTED,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NAGENCY = dto.NAGENCY,
            NORDPAY_REL = dto.NORDPAY_REL,
            NNUM_RELPAY = dto.NNUM_RELPAY,
            SINDPROCES = dto.SINDPROCES,
            SACCOUNTHOLDER = dto.SACCOUNTHOLDER,
            NBANKEXT = dto.NBANKEXT,
            SBANKACCOUNT = dto.SBANKACCOUNT,
            NPAY_COMM = dto.NPAY_COMM,
            NACC_TYPE = dto.NACC_TYPE,
            NID_EXTERNALSYSTEM = dto.NID_EXTERNALSYSTEM,
            NEXTERNAL_CONCEPT = dto.NEXTERNAL_CONCEPT,
        };
    }

    public static void UpdateEntity(this CHEQUES entity, UpdateCHEQUESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SCLIENT = dto.SCLIENT;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NCLAIM = dto.NCLAIM;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NVOUCHER_LE = dto.NVOUCHER_LE;
        entity.NVOUCHER = dto.NVOUCHER;
        entity.DDAT_PROPOS = dto.DDAT_PROPOS;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DISSUE_DAT = dto.DISSUE_DAT;
        entity.DLEDGER_DAT = dto.DLEDGER_DAT;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SPAY_FREQ = dto.SPAY_FREQ;
        entity.NQ_PAYS = dto.NQ_PAYS;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.SREQUEST_TY = dto.SREQUEST_TY;
        entity.NSTA_CHEQUE = dto.NSTA_CHEQUE;
        entity.DSTAT_DATE = dto.DSTAT_DATE;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.NUSER_SOL = dto.NUSER_SOL;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NYEAR_MONTH = dto.NYEAR_MONTH;
        entity.NACC_BANK = dto.NACC_BANK;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NAFECT = dto.NAFECT;
        entity.NEXENT = dto.NEXENT;
        entity.NTAXCODE = dto.NTAXCODE;
        entity.NTAX_AMOUNT = dto.NTAX_AMOUNT;
        entity.NOFFICE = dto.NOFFICE;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.NPAYORDBORD = dto.NPAYORDBORD;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.SINTER_PAY = dto.SINTER_PAY;
        entity.NAMOUNT_LOCAL = dto.NAMOUNT_LOCAL;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.SFILE_FIN700 = dto.SFILE_FIN700;
        entity.DDATE_FIN700 = dto.DDATE_FIN700;
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
        entity.NDOCSUPPORT = dto.NDOCSUPPORT;
        entity.NTAX_PERCENT = dto.NTAX_PERCENT;
        entity.NCURRENCYORI = dto.NCURRENCYORI;
        entity.NCURRENCYPAY = dto.NCURRENCYPAY;
        entity.NAMOUNTPAY = dto.NAMOUNTPAY;
        entity.DPOSTED = dto.DPOSTED;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NAGENCY = dto.NAGENCY;
        entity.NORDPAY_REL = dto.NORDPAY_REL;
        entity.NNUM_RELPAY = dto.NNUM_RELPAY;
        entity.SINDPROCES = dto.SINDPROCES;
        entity.SACCOUNTHOLDER = dto.SACCOUNTHOLDER;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.SBANKACCOUNT = dto.SBANKACCOUNT;
        entity.NPAY_COMM = dto.NPAY_COMM;
        entity.NACC_TYPE = dto.NACC_TYPE;
        entity.NID_EXTERNALSYSTEM = dto.NID_EXTERNALSYSTEM;
        entity.NEXTERNAL_CONCEPT = dto.NEXTERNAL_CONCEPT;
    }
}
