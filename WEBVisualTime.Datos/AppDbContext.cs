using Microsoft.EntityFrameworkCore;
using WEBVisualTime.Entidades.Insudb;

namespace WEBVisualTime.Datos;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public virtual DbSet<ACTIONS> ACTIONSs { get; set; } = null!;
    public virtual DbSet<ADDRESS> ADDRESSs { get; set; } = null!;
    public virtual DbSet<ADDRESS_CONFIG> ADDRESS_CONFIGs { get; set; } = null!;
    public virtual DbSet<AGENCIES> AGENCIESs { get; set; } = null!;
    public virtual DbSet<AGREEMENT> AGREEMENTs { get; set; } = null!;
    public virtual DbSet<AGREEMENT_AL> AGREEMENT_ALs { get; set; } = null!;
    public virtual DbSet<APPUSER> APPUSERs { get; set; } = null!;
    public virtual DbSet<APV_LED_ACC> APV_LED_ACCs { get; set; } = null!;
    public virtual DbSet<ASCII_I_DET> ASCII_I_DETs { get; set; } = null!;
    public virtual DbSet<ASCII_I_HEAD> ASCII_I_HEADs { get; set; } = null!;
    public virtual DbSet<ATTCHAMENTFORM> ATTCHAMENTFORMs { get; set; } = null!;
    public virtual DbSet<BANK_ACC> BANK_ACCs { get; set; } = null!;
    public virtual DbSet<BANK_AGREE> BANK_AGREEs { get; set; } = null!;
    public virtual DbSet<BANK_MOV> BANK_MOVs { get; set; } = null!;
    public virtual DbSet<BATCH_JOB> BATCH_JOBs { get; set; } = null!;
    public virtual DbSet<BATCH_PARAM> BATCH_PARAMs { get; set; } = null!;
    public virtual DbSet<BATCH_PARAM_VALUE> BATCH_PARAM_VALUEs { get; set; } = null!;
    public virtual DbSet<BATCH_PROCESS> BATCH_PROCESSs { get; set; } = null!;
    public virtual DbSet<BENEFGROUP_DETAIL> BENEFGROUP_DETAILs { get; set; } = null!;
    public virtual DbSet<BENEFICIAR> BENEFICIARs { get; set; } = null!;
    public virtual DbSet<BENEFITS_CATEGORY> BENEFITS_CATEGORYs { get; set; } = null!;
    public virtual DbSet<BENEFITS_GROUP> BENEFITS_GROUPs { get; set; } = null!;
    public virtual DbSet<BILLS> BILLSs { get; set; } = null!;
    public virtual DbSet<BILLS_HIS> BILLS_HISs { get; set; } = null!;
    public virtual DbSet<BILLS_NUM> BILLS_NUMs { get; set; } = null!;
    public virtual DbSet<BK_ACCOUNT> BK_ACCOUNTs { get; set; } = null!;
    public virtual DbSet<BOOK_COLLECTION> BOOK_COLLECTIONs { get; set; } = null!;
    public virtual DbSet<BOOK_PRODUCTION> BOOK_PRODUCTIONs { get; set; } = null!;
    public virtual DbSet<BRANPROD_ALLOW> BRANPROD_ALLOWs { get; set; } = null!;
    public virtual DbSet<BROKER_DET> BROKER_DETs { get; set; } = null!;
    public virtual DbSet<BUSSKIND> BUSSKINDs { get; set; } = null!;
    public virtual DbSet<CASH_ACC> CASH_ACCs { get; set; } = null!;
    public virtual DbSet<CASH_CONCEPTS> CASH_CONCEPTSs { get; set; } = null!;
    public virtual DbSet<CASH_CONCLASS> CASH_CONCLASSs { get; set; } = null!;
    public virtual DbSet<CASH_MOV> CASH_MOVs { get; set; } = null!;
    public virtual DbSet<CASH_STAT> CASH_STATs { get; set; } = null!;
    public virtual DbSet<CERTIFICAT> CERTIFICATs { get; set; } = null!;
    public virtual DbSet<CESSION_PR> CESSION_PRs { get; set; } = null!;
    public virtual DbSet<CHARG_PREBASPAY> CHARG_PREBASPAYs { get; set; } = null!;
    public virtual DbSet<CHEQ_BOOK> CHEQ_BOOKs { get; set; } = null!;
    public virtual DbSet<CHEQUE_MOV> CHEQUE_MOVs { get; set; } = null!;
    public virtual DbSet<CHEQUES> CHEQUESs { get; set; } = null!;
    public virtual DbSet<CLAIM> CLAIMs { get; set; } = null!;
    public virtual DbSet<CLAIM_ACTIONS_SCHE> CLAIM_ACTIONS_SCHEs { get; set; } = null!;
    public virtual DbSet<CLAIM_ACTIONS_STATE> CLAIM_ACTIONS_STATEs { get; set; } = null!;
    public virtual DbSet<CLAIMBENEF> CLAIMBENEFs { get; set; } = null!;
    public virtual DbSet<CLAIM_CASE> CLAIM_CASEs { get; set; } = null!;
    public virtual DbSet<CLAIM_CAUS> CLAIM_CAUSs { get; set; } = null!;
    public virtual DbSet<CLAIM_CES> CLAIM_CESs { get; set; } = null!;
    public virtual DbSet<CLAIM_HIS> CLAIM_HISs { get; set; } = null!;
    public virtual DbSet<CLAIM_MASTER> CLAIM_MASTERs { get; set; } = null!;
    public virtual DbSet<CLAIM_ORDER> CLAIM_ORDERs { get; set; } = null!;
    public virtual DbSet<CLAIM_PRESCRIPTION> CLAIM_PRESCRIPTIONs { get; set; } = null!;
    public virtual DbSet<CLAIM_SETT_DOCUM> CLAIM_SETT_DOCUMs { get; set; } = null!;
    public virtual DbSet<CLAIM_SETT_FILTERS> CLAIM_SETT_FILTERSs { get; set; } = null!;
    public virtual DbSet<CLAIM_SETT_HIS> CLAIM_SETT_HISs { get; set; } = null!;
    public virtual DbSet<CLAIM_SETTLEMENT> CLAIM_SETTLEMENTs { get; set; } = null!;
    public virtual DbSet<CLAIM_SETT_ORDER> CLAIM_SETT_ORDERs { get; set; } = null!;
    public virtual DbSet<CLAIM_SETT_VOUCHER> CLAIM_SETT_VOUCHERs { get; set; } = null!;
    public virtual DbSet<CLAIM_VOUCHER> CLAIM_VOUCHERs { get; set; } = null!;
    public virtual DbSet<CLAIM_VOUCHER_ORDER> CLAIM_VOUCHER_ORDERs { get; set; } = null!;
    public virtual DbSet<CLAIM_WIN> CLAIM_WINs { get; set; } = null!;
    public virtual DbSet<CLASSPROPERTYWIN> CLASSPROPERTYWINs { get; set; } = null!;
    public virtual DbSet<CLAUS_CO_G> CLAUS_CO_Gs { get; set; } = null!;
    public virtual DbSet<CLAUS_CO_P> CLAUS_CO_Ps { get; set; } = null!;
    public virtual DbSet<CLAUSE> CLAUSEs { get; set; } = null!;
    public virtual DbSet<CL_COMMERTYPEPAY> CL_COMMERTYPEPAYs { get; set; } = null!;
    public virtual DbSet<CL_COVER> CL_COVERs { get; set; } = null!;
    public virtual DbSet<CL_COVERMA> CL_COVERMAs { get; set; } = null!;
    public virtual DbSet<CLIALLOCLA> CLIALLOCLAs { get; set; } = null!;
    public virtual DbSet<CLIALLOPRO> CLIALLOPROs { get; set; } = null!;
    public virtual DbSet<CLIDOCPOL> CLIDOCPOLs { get; set; } = null!;
    public virtual DbSet<CLIDOCUMENTS> CLIDOCUMENTSs { get; set; } = null!;
    public virtual DbSet<CLIENT> CLIENTs { get; set; } = null!;
    public virtual DbSet<CLIENT_HIS> CLIENT_HISs { get; set; } = null!;
    public virtual DbSet<CLIENT_REQ> CLIENT_REQs { get; set; } = null!;
    public virtual DbSet<CLIENT_SF> CLIENT_SFs { get; set; } = null!;
    public virtual DbSet<CLIENT_TMP> CLIENT_TMPs { get; set; } = null!;
    public virtual DbSet<CLIENT_WIN> CLIENT_WINs { get; set; } = null!;
    public virtual DbSet<CL_M_COVER> CL_M_COVERs { get; set; } = null!;
    public virtual DbSet<CLORDER_ADDITIONALS> CLORDER_ADDITIONALSs { get; set; } = null!;
    public virtual DbSet<CLORDER_DETAIL> CLORDER_DETAILs { get; set; } = null!;
    public virtual DbSet<CLORDER_DOCUMENTS> CLORDER_DOCUMENTSs { get; set; } = null!;
    public virtual DbSet<CLORDER_HIS> CLORDER_HISs { get; set; } = null!;
    public virtual DbSet<COLFORMREF> COLFORMREFs { get; set; } = null!;
    public virtual DbSet<COLLECTOR> COLLECTORs { get; set; } = null!;
    public virtual DbSet<COLSHEET> COLSHEETs { get; set; } = null!;
    public virtual DbSet<COMMIS_HIS> COMMIS_HISs { get; set; } = null!;
    public virtual DbSet<COMMISSION> COMMISSIONs { get; set; } = null!;
    public virtual DbSet<COMMISS_PR> COMMISS_PRs { get; set; } = null!;
    public virtual DbSet<COMMPAYMENTREQUESTS> COMMPAYMENTREQUESTSs { get; set; } = null!;
    public virtual DbSet<COMMPAYREQ_HIS> COMMPAYREQ_HISs { get; set; } = null!;
    public virtual DbSet<COMMPAYREQ_ORDERS> COMMPAYREQ_ORDERSs { get; set; } = null!;
    public virtual DbSet<COMMPAYREQ_POLICIES> COMMPAYREQ_POLICIESs { get; set; } = null!;
    public virtual DbSet<COMM_POL> COMM_POLs { get; set; } = null!;
    public virtual DbSet<COMM_TOT> COMM_TOTs { get; set; } = null!;
    public virtual DbSet<COMPANY> COMPANYs { get; set; } = null!;
    public virtual DbSet<CONTRAT_PAY> CONTRAT_PAYs { get; set; } = null!;
    public virtual DbSet<CONTR_CESCOV> CONTR_CESCOVs { get; set; } = null!;
    public virtual DbSet<CONTR_LIMCOV> CONTR_LIMCOVs { get; set; } = null!;
    public virtual DbSet<CONTRMASTER> CONTRMASTERs { get; set; } = null!;
    public virtual DbSet<CONTRNP_PAYS> CONTRNP_PAYSs { get; set; } = null!;
    public virtual DbSet<CONTRNPRO> CONTRNPROs { get; set; } = null!;
    public virtual DbSet<CONTRPROC> CONTRPROCs { get; set; } = null!;
    public virtual DbSet<COVER> COVERs { get; set; } = null!;
    public virtual DbSet<COVER_CO_G> COVER_CO_Gs { get; set; } = null!;
    public virtual DbSet<COVER_CO_P> COVER_CO_Ps { get; set; } = null!;
    public virtual DbSet<COVER_QUOTA> COVER_QUOTAs { get; set; } = null!;
    public virtual DbSet<COVER_TMP> COVER_TMPs { get; set; } = null!;
    public virtual DbSet<COV_USED> COV_USEDs { get; set; } = null!;
    public virtual DbSet<CRED_CARD> CRED_CARDs { get; set; } = null!;
    public virtual DbSet<CTROL_DATE> CTROL_DATEs { get; set; } = null!;
    public virtual DbSet<CUENTECN> CUENTECNs { get; set; } = null!;
    public virtual DbSet<CUR_ALLOW> CUR_ALLOWs { get; set; } = null!;
    public virtual DbSet<CURR_ACC> CURR_ACCs { get; set; } = null!;
    public virtual DbSet<CURREN_POL> CURREN_POLs { get; set; } = null!;
    public virtual DbSet<DEPEND_SHEET> DEPEND_SHEETs { get; set; } = null!;
    public virtual DbSet<DETAIL_PRE> DETAIL_PREs { get; set; } = null!;
    public virtual DbSet<DETAIL_PRE_INI> DETAIL_PRE_INIs { get; set; } = null!;
    public virtual DbSet<DET_COMLIF> DET_COMLIFs { get; set; } = null!;
    public virtual DbSet<DEVLOCALRECORDSDELETED> DEVLOCALRECORDSDELETEDs { get; set; } = null!;
    public virtual DbSet<DIR_DEBIT> DIR_DEBITs { get; set; } = null!;
    public virtual DbSet<DIR_DEBIT_CLI> DIR_DEBIT_CLIs { get; set; } = null!;
    public virtual DbSet<DISCO_EXPR> DISCO_EXPRs { get; set; } = null!;
    public virtual DbSet<DISC_XPRE_G> DISC_XPRE_Gs { get; set; } = null!;
    public virtual DbSet<DISC_XPREM> DISC_XPREMs { get; set; } = null!;
    public virtual DbSet<DISC_XPRE_P> DISC_XPRE_Ps { get; set; } = null!;
    public virtual DbSet<DISEX_INT_M> DISEX_INT_Ms { get; set; } = null!;
    public virtual DbSet<DOC_REQ_CLI> DOC_REQ_CLIs { get; set; } = null!;
    public virtual DbSet<DOCUMENTS> DOCUMENTSs { get; set; } = null!;
    public virtual DbSet<DOCUMENTS_PRECLAIM> DOCUMENTS_PRECLAIMs { get; set; } = null!;
    public virtual DbSet<DRAFT_HIST> DRAFT_HISTs { get; set; } = null!;
    public virtual DbSet<DSEX_CONDI> DSEX_CONDIs { get; set; } = null!;
    public virtual DbSet<DURINSU_PROD> DURINSU_PRODs { get; set; } = null!;
    public virtual DbSet<DURPAY_PROD> DURPAY_PRODs { get; set; } = null!;
    public virtual DbSet<EVAL_MASTER> EVAL_MASTERs { get; set; } = null!;
    public virtual DbSet<EXCHANGE> EXCHANGEs { get; set; } = null!;
    public virtual DbSet<FIELDSHEET> FIELDSHEETs { get; set; } = null!;
    public virtual DbSet<FINANC_COM> FINANC_COMs { get; set; } = null!;
    public virtual DbSet<FINANC_DRA> FINANC_DRAs { get; set; } = null!;
    public virtual DbSet<FINANCE_CO> FINANCE_COs { get; set; } = null!;
    public virtual DbSet<FINANC_PRE> FINANC_PREs { get; set; } = null!;
    public virtual DbSet<FINANC_WIN> FINANC_WINs { get; set; } = null!;
    public virtual DbSet<FOLDERS> FOLDERSs { get; set; } = null!;
    public virtual DbSet<FORMATVALUES> FORMATVALUESs { get; set; } = null!;
    public virtual DbSet<FREQ_WAY_PROD> FREQ_WAY_PRODs { get; set; } = null!;
    public virtual DbSet<GROUP_COLUMNS> GROUP_COLUMNSs { get; set; } = null!;
    public virtual DbSet<GROUPPARAMS> GROUPPARAMSs { get; set; } = null!;
    public virtual DbSet<GROUPS> GROUPSs { get; set; } = null!;
    public virtual DbSet<GROUPVARIABLES> GROUPVARIABLESs { get; set; } = null!;
    public virtual DbSet<H_ASSIGNMENT_PART> H_ASSIGNMENT_PARTs { get; set; } = null!;
    public virtual DbSet<HEALTHCLAIMFORM> HEALTHCLAIMFORMs { get; set; } = null!;
    public virtual DbSet<HIS_ASC_I> HIS_ASC_Is { get; set; } = null!;
    public virtual DbSet<HIS_ASC_II> HIS_ASC_IIs { get; set; } = null!;
    public virtual DbSet<HOBBY> HOBBYs { get; set; } = null!;
    public virtual DbSet<HOLLIDAYS> HOLLIDAYSs { get; set; } = null!;
    public virtual DbSet<IMAGES> IMAGESs { get; set; } = null!;
    public virtual DbSet<INQUIRY_AS> INQUIRY_ASs { get; set; } = null!;
    public virtual DbSet<INSURED_EXPDIS> INSURED_EXPDISs { get; set; } = null!;
    public virtual DbSet<INTERMED_HIS> INTERMED_HISs { get; set; } = null!;
    public virtual DbSet<INTERMEDIA> INTERMEDIAs { get; set; } = null!;
    public virtual DbSet<INTERMED_PARTIC> INTERMED_PARTICs { get; set; } = null!;
    public virtual DbSet<INTERM_TYP> INTERM_TYPs { get; set; } = null!;
    public virtual DbSet<INT_FIXVAL> INT_FIXVALs { get; set; } = null!;
    public virtual DbSet<LATEPAYMENTPENALTY> LATEPAYMENTPENALTYs { get; set; } = null!;
    public virtual DbSet<LED_COMPAN> LED_COMPANs { get; set; } = null!;
    public virtual DbSet<LEDGER_ACC> LEDGER_ACCs { get; set; } = null!;
    public virtual DbSet<LEND_AGREE_PRES> LEND_AGREE_PRESs { get; set; } = null!;
    public virtual DbSet<LEND_AGREE_PROD> LEND_AGREE_PRODs { get; set; } = null!;
    public virtual DbSet<LEVELS> LEVELSs { get; set; } = null!;
    public virtual DbSet<LIFE> LIFEs { get; set; } = null!;
    public virtual DbSet<LIFE_COVER> LIFE_COVERs { get; set; } = null!;
    public virtual DbSet<LIFE_DOCU> LIFE_DOCUs { get; set; } = null!;
    public virtual DbSet<LIFE_SPECI> LIFE_SPECIs { get; set; } = null!;
    public virtual DbSet<LIMITS> LIMITSs { get; set; } = null!;
    public virtual DbSet<LOGBILLS> LOGBILLSs { get; set; } = null!;
    public virtual DbSet<MARGENREP> MARGENREPs { get; set; } = null!;
    public virtual DbSet<MASSIVE_LOG_PROC> MASSIVE_LOG_PROCs { get; set; } = null!;
    public virtual DbSet<MASSIVE_PART_CONDITIONS> MASSIVE_PART_CONDITIONSs { get; set; } = null!;
    public virtual DbSet<MASSIVE_POLICY> MASSIVE_POLICYs { get; set; } = null!;
    public virtual DbSet<MASSIVE_RULES> MASSIVE_RULESs { get; set; } = null!;
    public virtual DbSet<MASS_PROC_SPONSOR> MASS_PROC_SPONSORs { get; set; } = null!;
    public virtual DbSet<MASTERCL_BENEF> MASTERCL_BENEFs { get; set; } = null!;
    public virtual DbSet<MASTERCL_DETAIL> MASTERCL_DETAILs { get; set; } = null!;
    public virtual DbSet<MASTERCL_DOCUMENTS> MASTERCL_DOCUMENTSs { get; set; } = null!;
    public virtual DbSet<MASTERCL_HIS> MASTERCL_HISs { get; set; } = null!;
    public virtual DbSet<MASTERCL_ORDER> MASTERCL_ORDERs { get; set; } = null!;
    public virtual DbSet<MASTERSHEET> MASTERSHEETs { get; set; } = null!;
    public virtual DbSet<MEDBENEFITS_PROD> MEDBENEFITS_PRODs { get; set; } = null!;
    public virtual DbSet<MEDICALBENEFITS> MEDICALBENEFITSs { get; set; } = null!;
    public virtual DbSet<MEDICAL_EVAL_ROL> MEDICAL_EVAL_ROLs { get; set; } = null!;
    public virtual DbSet<MEDICALFEES> MEDICALFEESs { get; set; } = null!;
    public virtual DbSet<MEDICAL_SURCHARGE> MEDICAL_SURCHARGEs { get; set; } = null!;
    public virtual DbSet<MEDICALTEAMS_FEES> MEDICALTEAMS_FEESs { get; set; } = null!;
    public virtual DbSet<MESSAGE> MESSAGEs { get; set; } = null!;
    public virtual DbSet<MODUL_CO_G> MODUL_CO_Gs { get; set; } = null!;
    public virtual DbSet<MODUL_CO_P> MODUL_CO_Ps { get; set; } = null!;
    public virtual DbSet<MODULES> MODULESs { get; set; } = null!;
    public virtual DbSet<MODUL_INSURED> MODUL_INSUREDs { get; set; } = null!;
    public virtual DbSet<MOVE_ACC> MOVE_ACCs { get; set; } = null!;
    public virtual DbSet<MUNICIPALITY> MUNICIPALITYs { get; set; } = null!;
    public virtual DbSet<NOCONVERS> NOCONVERSs { get; set; } = null!;
    public virtual DbSet<NONWORKINGDAYFACTOR> NONWORKINGDAYFACTORs { get; set; } = null!;
    public virtual DbSet<NOTES> NOTESs { get; set; } = null!;
    public virtual DbSet<NOTIFICA_ERP> NOTIFICA_ERPs { get; set; } = null!;
    public virtual DbSet<NULL_CONDI> NULL_CONDIs { get; set; } = null!;
    public virtual DbSet<NUMERATOR> NUMERATORs { get; set; } = null!;
    public virtual DbSet<ODWA_HELP_ITEMS> ODWA_HELP_ITEMSs { get; set; } = null!;
    public virtual DbSet<ODWA_HELP_NODES> ODWA_HELP_NODESs { get; set; } = null!;
    public virtual DbSet<ODWA_HELP_TEXT> ODWA_HELP_TEXTs { get; set; } = null!;
    public virtual DbSet<ODWA_PREFERENCES> ODWA_PREFERENCESs { get; set; } = null!;
    public virtual DbSet<OFF_ACC> OFF_ACCs { get; set; } = null!;
    public virtual DbSet<OFFICE_ALLOW_PROD> OFFICE_ALLOW_PRODs { get; set; } = null!;
    public virtual DbSet<OUT_MOVEME> OUT_MOVEMEs { get; set; } = null!;
    public virtual DbSet<OUT_PREMIU> OUT_PREMIUs { get; set; } = null!;
    public virtual DbSet<OUT_PREMIU_INI> OUT_PREMIU_INIs { get; set; } = null!;
    public virtual DbSet<PART_CONTR> PART_CONTRs { get; set; } = null!;
    public virtual DbSet<PAY_FRACTI> PAY_FRACTIs { get; set; } = null!;
    public virtual DbSet<PAY_ORD_CONCEPTS> PAY_ORD_CONCEPTSs { get; set; } = null!;
    public virtual DbSet<PCC004_FORM> PCC004_FORMs { get; set; } = null!;
    public virtual DbSet<PERSON_TYPE> PERSON_TYPEs { get; set; } = null!;
    public virtual DbSet<PHONES> PHONESs { get; set; } = null!;
    public virtual DbSet<PIE_ELEMENT_TYPES> PIE_ELEMENT_TYPESs { get; set; } = null!;
    public virtual DbSet<POLICY> POLICYs { get; set; } = null!;
    public virtual DbSet<POLICY_HIS> POLICY_HISs { get; set; } = null!;
    public virtual DbSet<POLICY_WIN> POLICY_WINs { get; set; } = null!;
    public virtual DbSet<PRECLAIM> PRECLAIMs { get; set; } = null!;
    public virtual DbSet<PREMIUM> PREMIUMs { get; set; } = null!;
    public virtual DbSet<PREMIUM_CE> PREMIUM_CEs { get; set; } = null!;
    public virtual DbSet<PREMIUM_CE_INI> PREMIUM_CE_INIs { get; set; } = null!;
    public virtual DbSet<PREMIUM_MO> PREMIUM_MOs { get; set; } = null!;
    public virtual DbSet<PROD_ADDCAP> PROD_ADDCAPs { get; set; } = null!;
    public virtual DbSet<PRODMASTER> PRODMASTERs { get; set; } = null!;
    public virtual DbSet<PROD_RESERVE> PROD_RESERVEs { get; set; } = null!;
    public virtual DbSet<PRODUCT> PRODUCTs { get; set; } = null!;
    public virtual DbSet<PRODUCT_LI> PRODUCT_LIs { get; set; } = null!;
    public virtual DbSet<PROD_WIN> PROD_WINs { get; set; } = null!;
    public virtual DbSet<PROPERTYLIBRARY> PROPERTYLIBRARYs { get; set; } = null!;
    public virtual DbSet<PROV_BRANCH> PROV_BRANCHs { get; set; } = null!;
    public virtual DbSet<PROVINCE> PROVINCEs { get; set; } = null!;
    public virtual DbSet<PROVISION_TYPE> PROVISION_TYPEs { get; set; } = null!;
    public virtual DbSet<PROV_TABLIFCOV> PROV_TABLIFCOVs { get; set; } = null!;
    public virtual DbSet<QC_PARAM> QC_PARAMs { get; set; } = null!;
    public virtual DbSet<REFINAN_DRA> REFINAN_DRAs { get; set; } = null!;
    public virtual DbSet<REINSU_FRE> REINSU_FREs { get; set; } = null!;
    public virtual DbSet<REINSU_PRIM_HEALTH> REINSU_PRIM_HEALTHs { get; set; } = null!;
    public virtual DbSet<REINSURAN> REINSURANs { get; set; } = null!;
    public virtual DbSet<REJECT_CAUSE> REJECT_CAUSEs { get; set; } = null!;
    public virtual DbSet<REJECTCAUSE_PRECLAIM> REJECTCAUSE_PRECLAIMs { get; set; } = null!;
    public virtual DbSet<RELATIONS> RELATIONSs { get; set; } = null!;
    public virtual DbSet<RELATIONSHIP> RELATIONSHIPs { get; set; } = null!;
    public virtual DbSet<RELCONCEPTS> RELCONCEPTSs { get; set; } = null!;
    public virtual DbSet<REPORTMASTER> REPORTMASTERs { get; set; } = null!;
    public virtual DbSet<REPORT_PROD> REPORT_PRODs { get; set; } = null!;
    public virtual DbSet<REPORTSHEET> REPORTSHEETs { get; set; } = null!;
    public virtual DbSet<REQ_ENDOR> REQ_ENDORs { get; set; } = null!;
    public virtual DbSet<REQUEST> REQUESTs { get; set; } = null!;
    public virtual DbSet<RETENTIONCOV> RETENTIONCOVs { get; set; } = null!;
    public virtual DbSet<RM_REG_TYPES> RM_REG_TYPESs { get; set; } = null!;
    public virtual DbSet<RNULLCONDI> RNULLCONDIs { get; set; } = null!;
    public virtual DbSet<ROLDOCREQ> ROLDOCREQs { get; set; } = null!;
    public virtual DbSet<ROLES> ROLESs { get; set; } = null!;
    public virtual DbSet<ROLE_TYPE_AMEND> ROLE_TYPE_AMENDs { get; set; } = null!;
    public virtual DbSet<SCHEMA_CUR> SCHEMA_CURs { get; set; } = null!;
    public virtual DbSet<SCHEMA_FOLDER> SCHEMA_FOLDERs { get; set; } = null!;
    public virtual DbSet<SDD_DEPENDENCY_TYPES> SDD_DEPENDENCY_TYPESs { get; set; } = null!;
    public virtual DbSet<SDD_DEPEND_STATUSES> SDD_DEPEND_STATUSESs { get; set; } = null!;
    public virtual DbSet<SDD_GLOBAL_NAME_DOMAINS> SDD_GLOBAL_NAME_DOMAINSs { get; set; } = null!;
    public virtual DbSet<SDD_NLS_GLOBAL_NAME_DOMAINS> SDD_NLS_GLOBAL_NAME_DOMAINSs { get; set; } = null!;
    public virtual DbSet<SECTION_PO> SECTION_POs { get; set; } = null!;
    public virtual DbSet<SECUR_SCHE> SECUR_SCHEs { get; set; } = null!;
    public virtual DbSet<SELLCHANNEL_PROD> SELLCHANNEL_PRODs { get; set; } = null!;
    public virtual DbSet<SEQFOLDER> SEQFOLDERs { get; set; } = null!;
    public virtual DbSet<SEQUEN_POL> SEQUEN_POLs { get; set; } = null!;
    public virtual DbSet<SIGNSCAPOFF> SIGNSCAPOFFs { get; set; } = null!;
    public virtual DbSet<SIGNSREP> SIGNSREPs { get; set; } = null!;
    public virtual DbSet<SITUATION> SITUATIONs { get; set; } = null!;
    public virtual DbSet<SPORT> SPORTs { get; set; } = null!;
    public virtual DbSet<STATUS_CLAIM> STATUS_CLAIMs { get; set; } = null!;
    public virtual DbSet<STIPEND_POL> STIPEND_POLs { get; set; } = null!;
    public virtual DbSet<TAB_AM_EXC> TAB_AM_EXCs { get; set; } = null!;
    public virtual DbSet<TAB_AM_ILL> TAB_AM_ILLs { get; set; } = null!;
    public virtual DbSet<TAB_AU_VEH> TAB_AU_VEHs { get; set; } = null!;
    public virtual DbSet<TAB_BILL_I> TAB_BILL_Is { get; set; } = null!;
    public virtual DbSet<TAB_BK_AGE> TAB_BK_AGEs { get; set; } = null!;
    public virtual DbSet<TAB_CLAUSE> TAB_CLAUSEs { get; set; } = null!;
    public virtual DbSet<TAB_CL_OPE> TAB_CL_OPEs { get; set; } = null!;
    public virtual DbSet<TAB_COLLECTCOMM> TAB_COLLECTCOMMs { get; set; } = null!;
    public virtual DbSet<TAB_COMLIF> TAB_COMLIFs { get; set; } = null!;
    public virtual DbSet<TAB_COMPRO> TAB_COMPROs { get; set; } = null!;
    public virtual DbSet<TAB_COVROL> TAB_COVROLs { get; set; } = null!;
    public virtual DbSet<TAB_DENTITION> TAB_DENTITIONs { get; set; } = null!;
    public virtual DbSet<TAB_DOCU> TAB_DOCUs { get; set; } = null!;
    public virtual DbSet<TAB_FN_INSTITUTION> TAB_FN_INSTITUTIONs { get; set; } = null!;
    public virtual DbSet<TAB_FONASA> TAB_FONASAs { get; set; } = null!;
    public virtual DbSet<TAB_GENCOV> TAB_GENCOVs { get; set; } = null!;
    public virtual DbSet<TAB_GOALS> TAB_GOALSs { get; set; } = null!;
    public virtual DbSet<TABLESHEET> TABLESHEETs { get; set; } = null!;
    public virtual DbSet<TABLE1> TABLE1s { get; set; } = null!;
    public virtual DbSet<TABLE10> TABLE10s { get; set; } = null!;
    public virtual DbSet<TABLE1000> TABLE1000s { get; set; } = null!;
    public virtual DbSet<TABLE1006> TABLE1006s { get; set; } = null!;
    public virtual DbSet<TABLE1007> TABLE1007s { get; set; } = null!;
    public virtual DbSet<TABLE1008> TABLE1008s { get; set; } = null!;
    public virtual DbSet<TABLE1009> TABLE1009s { get; set; } = null!;
    public virtual DbSet<TABLE1014> TABLE1014s { get; set; } = null!;
    public virtual DbSet<TABLE105> TABLE105s { get; set; } = null!;
    public virtual DbSet<TABLE108> TABLE108s { get; set; } = null!;
    public virtual DbSet<TABLE11> TABLE11s { get; set; } = null!;
    public virtual DbSet<TABLE113> TABLE113s { get; set; } = null!;
    public virtual DbSet<TABLE114> TABLE114s { get; set; } = null!;
    public virtual DbSet<TABLE118> TABLE118s { get; set; } = null!;
    public virtual DbSet<TABLE12> TABLE12s { get; set; } = null!;
    public virtual DbSet<TABLE124> TABLE124s { get; set; } = null!;
    public virtual DbSet<TABLE125> TABLE125s { get; set; } = null!;
    public virtual DbSet<TABLE126> TABLE126s { get; set; } = null!;
    public virtual DbSet<TABLE127> TABLE127s { get; set; } = null!;
    public virtual DbSet<TABLE13> TABLE13s { get; set; } = null!;
    public virtual DbSet<TABLE132> TABLE132s { get; set; } = null!;
    public virtual DbSet<TABLE133> TABLE133s { get; set; } = null!;
    public virtual DbSet<TABLE135> TABLE135s { get; set; } = null!;
    public virtual DbSet<TABLE136> TABLE136s { get; set; } = null!;
    public virtual DbSet<TABLE137> TABLE137s { get; set; } = null!;
    public virtual DbSet<TABLE138> TABLE138s { get; set; } = null!;
    public virtual DbSet<TABLE14> TABLE14s { get; set; } = null!;
    public virtual DbSet<TABLE140> TABLE140s { get; set; } = null!;
    public virtual DbSet<TABLE141> TABLE141s { get; set; } = null!;
    public virtual DbSet<TABLE146> TABLE146s { get; set; } = null!;
    public virtual DbSet<TABLE147> TABLE147s { get; set; } = null!;
    public virtual DbSet<TABLE149> TABLE149s { get; set; } = null!;
    public virtual DbSet<TABLE15> TABLE15s { get; set; } = null!;
    public virtual DbSet<TABLE151> TABLE151s { get; set; } = null!;
    public virtual DbSet<TABLE153> TABLE153s { get; set; } = null!;
    public virtual DbSet<TABLE154> TABLE154s { get; set; } = null!;
    public virtual DbSet<TABLE157> TABLE157s { get; set; } = null!;
    public virtual DbSet<TABLE159> TABLE159s { get; set; } = null!;
    public virtual DbSet<TABLE16> TABLE16s { get; set; } = null!;
    public virtual DbSet<TABLE160> TABLE160s { get; set; } = null!;
    public virtual DbSet<TABLE161> TABLE161s { get; set; } = null!;
    public virtual DbSet<TABLE163> TABLE163s { get; set; } = null!;
    public virtual DbSet<TABLE165> TABLE165s { get; set; } = null!;
    public virtual DbSet<TABLE17> TABLE17s { get; set; } = null!;
    public virtual DbSet<TABLE173> TABLE173s { get; set; } = null!;
    public virtual DbSet<TABLE174> TABLE174s { get; set; } = null!;
    public virtual DbSet<TABLE178> TABLE178s { get; set; } = null!;
    public virtual DbSet<TABLE179> TABLE179s { get; set; } = null!;
    public virtual DbSet<TABLE18> TABLE18s { get; set; } = null!;
    public virtual DbSet<TABLE180> TABLE180s { get; set; } = null!;
    public virtual DbSet<TABLE181> TABLE181s { get; set; } = null!;
    public virtual DbSet<TABLE182> TABLE182s { get; set; } = null!;
    public virtual DbSet<TABLE183> TABLE183s { get; set; } = null!;
    public virtual DbSet<TABLE184> TABLE184s { get; set; } = null!;
    public virtual DbSet<TABLE185> TABLE185s { get; set; } = null!;
    public virtual DbSet<TABLE187> TABLE187s { get; set; } = null!;
    public virtual DbSet<TABLE19> TABLE19s { get; set; } = null!;
    public virtual DbSet<TABLE190> TABLE190s { get; set; } = null!;
    public virtual DbSet<TABLE191> TABLE191s { get; set; } = null!;
    public virtual DbSet<TABLE192> TABLE192s { get; set; } = null!;
    public virtual DbSet<TABLE193> TABLE193s { get; set; } = null!;
    public virtual DbSet<TABLE195> TABLE195s { get; set; } = null!;
    public virtual DbSet<TABLE196> TABLE196s { get; set; } = null!;
    public virtual DbSet<TABLE197> TABLE197s { get; set; } = null!;
    public virtual DbSet<TABLE199> TABLE199s { get; set; } = null!;
    public virtual DbSet<TABLE2> TABLE2s { get; set; } = null!;
    public virtual DbSet<TABLE20> TABLE20s { get; set; } = null!;
    public virtual DbSet<TABLE200> TABLE200s { get; set; } = null!;
    public virtual DbSet<TABLE2000> TABLE2000s { get; set; } = null!;
    public virtual DbSet<TABLE201> TABLE201s { get; set; } = null!;
    public virtual DbSet<TABLE203> TABLE203s { get; set; } = null!;
    public virtual DbSet<TABLE204> TABLE204s { get; set; } = null!;
    public virtual DbSet<TABLE205> TABLE205s { get; set; } = null!;
    public virtual DbSet<TABLE21> TABLE21s { get; set; } = null!;
    public virtual DbSet<TABLE210> TABLE210s { get; set; } = null!;
    public virtual DbSet<TABLE211> TABLE211s { get; set; } = null!;
    public virtual DbSet<TABLE215> TABLE215s { get; set; } = null!;
    public virtual DbSet<TABLE216> TABLE216s { get; set; } = null!;
    public virtual DbSet<TABLE219> TABLE219s { get; set; } = null!;
    public virtual DbSet<TABLE22> TABLE22s { get; set; } = null!;
    public virtual DbSet<TABLE220> TABLE220s { get; set; } = null!;
    public virtual DbSet<TABLE221> TABLE221s { get; set; } = null!;
    public virtual DbSet<TABLE222> TABLE222s { get; set; } = null!;
    public virtual DbSet<TABLE224> TABLE224s { get; set; } = null!;
    public virtual DbSet<TABLE226> TABLE226s { get; set; } = null!;
    public virtual DbSet<TABLE23> TABLE23s { get; set; } = null!;
    public virtual DbSet<TABLE232> TABLE232s { get; set; } = null!;
    public virtual DbSet<TABLE233> TABLE233s { get; set; } = null!;
    public virtual DbSet<TABLE235> TABLE235s { get; set; } = null!;
    public virtual DbSet<TABLE237> TABLE237s { get; set; } = null!;
    public virtual DbSet<TABLE239> TABLE239s { get; set; } = null!;
    public virtual DbSet<TABLE24> TABLE24s { get; set; } = null!;
    public virtual DbSet<TABLE240> TABLE240s { get; set; } = null!;
    public virtual DbSet<TABLE241> TABLE241s { get; set; } = null!;
    public virtual DbSet<TABLE242> TABLE242s { get; set; } = null!;
    public virtual DbSet<TABLE245> TABLE245s { get; set; } = null!;
    public virtual DbSet<TABLE248> TABLE248s { get; set; } = null!;
    public virtual DbSet<TABLE249> TABLE249s { get; set; } = null!;
    public virtual DbSet<TABLE25> TABLE25s { get; set; } = null!;
    public virtual DbSet<TABLE250> TABLE250s { get; set; } = null!;
    public virtual DbSet<TABLE251> TABLE251s { get; set; } = null!;
    public virtual DbSet<TABLE252> TABLE252s { get; set; } = null!;
    public virtual DbSet<TABLE253> TABLE253s { get; set; } = null!;
    public virtual DbSet<TABLE254> TABLE254s { get; set; } = null!;
    public virtual DbSet<TABLE255> TABLE255s { get; set; } = null!;
    public virtual DbSet<TABLE256> TABLE256s { get; set; } = null!;
    public virtual DbSet<TABLE258> TABLE258s { get; set; } = null!;
    public virtual DbSet<TABLE259> TABLE259s { get; set; } = null!;
    public virtual DbSet<TABLE26> TABLE26s { get; set; } = null!;
    public virtual DbSet<TABLE260> TABLE260s { get; set; } = null!;
    public virtual DbSet<TABLE268> TABLE268s { get; set; } = null!;
    public virtual DbSet<TABLE269> TABLE269s { get; set; } = null!;
    public virtual DbSet<TABLE270> TABLE270s { get; set; } = null!;
    public virtual DbSet<TABLE271> TABLE271s { get; set; } = null!;
    public virtual DbSet<TABLE273> TABLE273s { get; set; } = null!;
    public virtual DbSet<TABLE275> TABLE275s { get; set; } = null!;
    public virtual DbSet<TABLE276> TABLE276s { get; set; } = null!;
    public virtual DbSet<TABLE277> TABLE277s { get; set; } = null!;
    public virtual DbSet<TABLE278> TABLE278s { get; set; } = null!;
    public virtual DbSet<TABLE282> TABLE282s { get; set; } = null!;
    public virtual DbSet<TABLE283> TABLE283s { get; set; } = null!;
    public virtual DbSet<TABLE285> TABLE285s { get; set; } = null!;
    public virtual DbSet<TABLE286> TABLE286s { get; set; } = null!;
    public virtual DbSet<TABLE287> TABLE287s { get; set; } = null!;
    public virtual DbSet<TABLE288> TABLE288s { get; set; } = null!;
    public virtual DbSet<TABLE289> TABLE289s { get; set; } = null!;
    public virtual DbSet<TABLE290> TABLE290s { get; set; } = null!;
    public virtual DbSet<TABLE291> TABLE291s { get; set; } = null!;
    public virtual DbSet<TABLE293> TABLE293s { get; set; } = null!;
    public virtual DbSet<TABLE294> TABLE294s { get; set; } = null!;
    public virtual DbSet<TABLE295> TABLE295s { get; set; } = null!;
    public virtual DbSet<TABLE296> TABLE296s { get; set; } = null!;
    public virtual DbSet<TABLE297> TABLE297s { get; set; } = null!;
    public virtual DbSet<TABLE298> TABLE298s { get; set; } = null!;
    public virtual DbSet<TABLE30> TABLE30s { get; set; } = null!;
    public virtual DbSet<TABLE300> TABLE300s { get; set; } = null!;
    public virtual DbSet<TABLE3012> TABLE3012s { get; set; } = null!;
    public virtual DbSet<TABLE3019> TABLE3019s { get; set; } = null!;
    public virtual DbSet<TABLE3022> TABLE3022s { get; set; } = null!;
    public virtual DbSet<TABLE304> TABLE304s { get; set; } = null!;
    public virtual DbSet<TABLE307> TABLE307s { get; set; } = null!;
    public virtual DbSet<TABLE308> TABLE308s { get; set; } = null!;
    public virtual DbSet<TABLE311> TABLE311s { get; set; } = null!;
    public virtual DbSet<TABLE312> TABLE312s { get; set; } = null!;
    public virtual DbSet<TABLE313> TABLE313s { get; set; } = null!;
    public virtual DbSet<TABLE314> TABLE314s { get; set; } = null!;
    public virtual DbSet<TABLE32> TABLE32s { get; set; } = null!;
    public virtual DbSet<TABLE320> TABLE320s { get; set; } = null!;
    public virtual DbSet<TABLE321> TABLE321s { get; set; } = null!;
    public virtual DbSet<TABLE322> TABLE322s { get; set; } = null!;
    public virtual DbSet<TABLE323> TABLE323s { get; set; } = null!;
    public virtual DbSet<TABLE324> TABLE324s { get; set; } = null!;
    public virtual DbSet<TABLE33> TABLE33s { get; set; } = null!;
    public virtual DbSet<TABLE333> TABLE333s { get; set; } = null!;
    public virtual DbSet<TABLE334> TABLE334s { get; set; } = null!;
    public virtual DbSet<TABLE34> TABLE34s { get; set; } = null!;
    public virtual DbSet<TABLE340> TABLE340s { get; set; } = null!;
    public virtual DbSet<TABLE36> TABLE36s { get; set; } = null!;
    public virtual DbSet<TABLE360> TABLE360s { get; set; } = null!;
    public virtual DbSet<TABLE37> TABLE37s { get; set; } = null!;
    public virtual DbSet<TABLE4> TABLE4s { get; set; } = null!;
    public virtual DbSet<TABLE40> TABLE40s { get; set; } = null!;
    public virtual DbSet<TABLE400> TABLE400s { get; set; } = null!;
    public virtual DbSet<TABLE401> TABLE401s { get; set; } = null!;
    public virtual DbSet<TABLE403> TABLE403s { get; set; } = null!;
    public virtual DbSet<TABLE41> TABLE41s { get; set; } = null!;
    public virtual DbSet<TABLE415> TABLE415s { get; set; } = null!;
    public virtual DbSet<TABLE416> TABLE416s { get; set; } = null!;
    public virtual DbSet<TABLE417> TABLE417s { get; set; } = null!;
    public virtual DbSet<TABLE418> TABLE418s { get; set; } = null!;
    public virtual DbSet<TABLE45> TABLE45s { get; set; } = null!;
    public virtual DbSet<TABLE46> TABLE46s { get; set; } = null!;
    public virtual DbSet<TABLE47> TABLE47s { get; set; } = null!;
    public virtual DbSet<TABLE48> TABLE48s { get; set; } = null!;
    public virtual DbSet<TABLE49> TABLE49s { get; set; } = null!;
    public virtual DbSet<TABLE50> TABLE50s { get; set; } = null!;
    public virtual DbSet<TABLE5000> TABLE5000s { get; set; } = null!;
    public virtual DbSet<TABLE5001> TABLE5001s { get; set; } = null!;
    public virtual DbSet<TABLE5002> TABLE5002s { get; set; } = null!;
    public virtual DbSet<TABLE5003> TABLE5003s { get; set; } = null!;
    public virtual DbSet<TABLE5004> TABLE5004s { get; set; } = null!;
    public virtual DbSet<TABLE5005> TABLE5005s { get; set; } = null!;
    public virtual DbSet<TABLE5006> TABLE5006s { get; set; } = null!;
    public virtual DbSet<TABLE5007> TABLE5007s { get; set; } = null!;
    public virtual DbSet<TABLE5008> TABLE5008s { get; set; } = null!;
    public virtual DbSet<TABLE5009> TABLE5009s { get; set; } = null!;
    public virtual DbSet<TABLE502> TABLE502s { get; set; } = null!;
    public virtual DbSet<TABLE511> TABLE511s { get; set; } = null!;
    public virtual DbSet<TABLE512> TABLE512s { get; set; } = null!;
    public virtual DbSet<TABLE515> TABLE515s { get; set; } = null!;
    public virtual DbSet<TABLE52> TABLE52s { get; set; } = null!;
    public virtual DbSet<TABLE521> TABLE521s { get; set; } = null!;
    public virtual DbSet<TABLE525> TABLE525s { get; set; } = null!;
    public virtual DbSet<TABLE526> TABLE526s { get; set; } = null!;
    public virtual DbSet<TABLE527> TABLE527s { get; set; } = null!;
    public virtual DbSet<TABLE531> TABLE531s { get; set; } = null!;
    public virtual DbSet<TABLE532> TABLE532s { get; set; } = null!;
    public virtual DbSet<TABLE533> TABLE533s { get; set; } = null!;
    public virtual DbSet<TABLE534> TABLE534s { get; set; } = null!;
    public virtual DbSet<TABLE55> TABLE55s { get; set; } = null!;
    public virtual DbSet<TABLE5500> TABLE5500s { get; set; } = null!;
    public virtual DbSet<TABLE5501> TABLE5501s { get; set; } = null!;
    public virtual DbSet<TABLE5503> TABLE5503s { get; set; } = null!;
    public virtual DbSet<TABLE5504> TABLE5504s { get; set; } = null!;
    public virtual DbSet<TABLE5505> TABLE5505s { get; set; } = null!;
    public virtual DbSet<TABLE5506> TABLE5506s { get; set; } = null!;
    public virtual DbSet<TABLE5516> TABLE5516s { get; set; } = null!;
    public virtual DbSet<TABLE5517> TABLE5517s { get; set; } = null!;
    public virtual DbSet<TABLE5518> TABLE5518s { get; set; } = null!;
    public virtual DbSet<TABLE5519> TABLE5519s { get; set; } = null!;
    public virtual DbSet<TABLE5520> TABLE5520s { get; set; } = null!;
    public virtual DbSet<TABLE5521> TABLE5521s { get; set; } = null!;
    public virtual DbSet<TABLE5522> TABLE5522s { get; set; } = null!;
    public virtual DbSet<TABLE5523> TABLE5523s { get; set; } = null!;
    public virtual DbSet<TABLE5524> TABLE5524s { get; set; } = null!;
    public virtual DbSet<TABLE5525> TABLE5525s { get; set; } = null!;
    public virtual DbSet<TABLE5526> TABLE5526s { get; set; } = null!;
    public virtual DbSet<TABLE5527> TABLE5527s { get; set; } = null!;
    public virtual DbSet<TABLE5529> TABLE5529s { get; set; } = null!;
    public virtual DbSet<TABLE5530> TABLE5530s { get; set; } = null!;
    public virtual DbSet<TABLE5531> TABLE5531s { get; set; } = null!;
    public virtual DbSet<TABLE5532> TABLE5532s { get; set; } = null!;
    public virtual DbSet<TABLE5533> TABLE5533s { get; set; } = null!;
    public virtual DbSet<TABLE5534> TABLE5534s { get; set; } = null!;
    public virtual DbSet<TABLE5535> TABLE5535s { get; set; } = null!;
    public virtual DbSet<TABLE5536> TABLE5536s { get; set; } = null!;
    public virtual DbSet<TABLE5538> TABLE5538s { get; set; } = null!;
    public virtual DbSet<TABLE5539> TABLE5539s { get; set; } = null!;
    public virtual DbSet<TABLE5540> TABLE5540s { get; set; } = null!;
    public virtual DbSet<TABLE5541> TABLE5541s { get; set; } = null!;
    public virtual DbSet<TABLE5542> TABLE5542s { get; set; } = null!;
    public virtual DbSet<TABLE5543> TABLE5543s { get; set; } = null!;
    public virtual DbSet<TABLE5544> TABLE5544s { get; set; } = null!;
    public virtual DbSet<TABLE5545> TABLE5545s { get; set; } = null!;
    public virtual DbSet<TABLE5546> TABLE5546s { get; set; } = null!;
    public virtual DbSet<TABLE5547> TABLE5547s { get; set; } = null!;
    public virtual DbSet<TABLE5548> TABLE5548s { get; set; } = null!;
    public virtual DbSet<TABLE5549> TABLE5549s { get; set; } = null!;
    public virtual DbSet<TABLE5550> TABLE5550s { get; set; } = null!;
    public virtual DbSet<TABLE5551> TABLE5551s { get; set; } = null!;
    public virtual DbSet<TABLE5552> TABLE5552s { get; set; } = null!;
    public virtual DbSet<TABLE5553> TABLE5553s { get; set; } = null!;
    public virtual DbSet<TABLE5554> TABLE5554s { get; set; } = null!;
    public virtual DbSet<TABLE5555> TABLE5555s { get; set; } = null!;
    public virtual DbSet<TABLE5556> TABLE5556s { get; set; } = null!;
    public virtual DbSet<TABLE5557> TABLE5557s { get; set; } = null!;
    public virtual DbSet<TABLE5558> TABLE5558s { get; set; } = null!;
    public virtual DbSet<TABLE5559> TABLE5559s { get; set; } = null!;
    public virtual DbSet<TABLE5560> TABLE5560s { get; set; } = null!;
    public virtual DbSet<TABLE5561> TABLE5561s { get; set; } = null!;
    public virtual DbSet<TABLE5562> TABLE5562s { get; set; } = null!;
    public virtual DbSet<TABLE5563> TABLE5563s { get; set; } = null!;
    public virtual DbSet<TABLE5564> TABLE5564s { get; set; } = null!;
    public virtual DbSet<TABLE5565> TABLE5565s { get; set; } = null!;
    public virtual DbSet<TABLE5566> TABLE5566s { get; set; } = null!;
    public virtual DbSet<TABLE5567> TABLE5567s { get; set; } = null!;
    public virtual DbSet<TABLE5568> TABLE5568s { get; set; } = null!;
    public virtual DbSet<TABLE5569> TABLE5569s { get; set; } = null!;
    public virtual DbSet<TABLE5570> TABLE5570s { get; set; } = null!;
    public virtual DbSet<TABLE5571> TABLE5571s { get; set; } = null!;
    public virtual DbSet<TABLE5572> TABLE5572s { get; set; } = null!;
    public virtual DbSet<TABLE5573> TABLE5573s { get; set; } = null!;
    public virtual DbSet<TABLE5574> TABLE5574s { get; set; } = null!;
    public virtual DbSet<TABLE5575> TABLE5575s { get; set; } = null!;
    public virtual DbSet<TABLE5576> TABLE5576s { get; set; } = null!;
    public virtual DbSet<TABLE5577> TABLE5577s { get; set; } = null!;
    public virtual DbSet<TABLE5578> TABLE5578s { get; set; } = null!;
    public virtual DbSet<TABLE5579> TABLE5579s { get; set; } = null!;
    public virtual DbSet<TABLE5580> TABLE5580s { get; set; } = null!;
    public virtual DbSet<TABLE5581> TABLE5581s { get; set; } = null!;
    public virtual DbSet<TABLE5582> TABLE5582s { get; set; } = null!;
    public virtual DbSet<TABLE5584> TABLE5584s { get; set; } = null!;
    public virtual DbSet<TABLE5585> TABLE5585s { get; set; } = null!;
    public virtual DbSet<TABLE5586> TABLE5586s { get; set; } = null!;
    public virtual DbSet<TABLE5587> TABLE5587s { get; set; } = null!;
    public virtual DbSet<TABLE5588> TABLE5588s { get; set; } = null!;
    public virtual DbSet<TABLE5589> TABLE5589s { get; set; } = null!;
    public virtual DbSet<TABLE5590> TABLE5590s { get; set; } = null!;
    public virtual DbSet<TABLE5591> TABLE5591s { get; set; } = null!;
    public virtual DbSet<TABLE5592> TABLE5592s { get; set; } = null!;
    public virtual DbSet<TABLE5593> TABLE5593s { get; set; } = null!;
    public virtual DbSet<TABLE5594> TABLE5594s { get; set; } = null!;
    public virtual DbSet<TABLE5595> TABLE5595s { get; set; } = null!;
    public virtual DbSet<TABLE5596> TABLE5596s { get; set; } = null!;
    public virtual DbSet<TABLE5597> TABLE5597s { get; set; } = null!;
    public virtual DbSet<TABLE5598> TABLE5598s { get; set; } = null!;
    public virtual DbSet<TABLE5599> TABLE5599s { get; set; } = null!;
    public virtual DbSet<TABLE560> TABLE560s { get; set; } = null!;
    public virtual DbSet<TABLE5600> TABLE5600s { get; set; } = null!;
    public virtual DbSet<TABLE5601> TABLE5601s { get; set; } = null!;
    public virtual DbSet<TABLE5602> TABLE5602s { get; set; } = null!;
    public virtual DbSet<TABLE5603> TABLE5603s { get; set; } = null!;
    public virtual DbSet<TABLE5604> TABLE5604s { get; set; } = null!;
    public virtual DbSet<TABLE5605> TABLE5605s { get; set; } = null!;
    public virtual DbSet<TABLE5606> TABLE5606s { get; set; } = null!;
    public virtual DbSet<TABLE5607> TABLE5607s { get; set; } = null!;
    public virtual DbSet<TABLE5608> TABLE5608s { get; set; } = null!;
    public virtual DbSet<TABLE5609> TABLE5609s { get; set; } = null!;
    public virtual DbSet<TABLE561> TABLE561s { get; set; } = null!;
    public virtual DbSet<TABLE5610> TABLE5610s { get; set; } = null!;
    public virtual DbSet<TABLE5611> TABLE5611s { get; set; } = null!;
    public virtual DbSet<TABLE5612> TABLE5612s { get; set; } = null!;
    public virtual DbSet<TABLE5613> TABLE5613s { get; set; } = null!;
    public virtual DbSet<TABLE5614> TABLE5614s { get; set; } = null!;
    public virtual DbSet<TABLE5615> TABLE5615s { get; set; } = null!;
    public virtual DbSet<TABLE5616> TABLE5616s { get; set; } = null!;
    public virtual DbSet<TABLE5617> TABLE5617s { get; set; } = null!;
    public virtual DbSet<TABLE5621> TABLE5621s { get; set; } = null!;
    public virtual DbSet<TABLE5622> TABLE5622s { get; set; } = null!;
    public virtual DbSet<TABLE5623> TABLE5623s { get; set; } = null!;
    public virtual DbSet<TABLE5625> TABLE5625s { get; set; } = null!;
    public virtual DbSet<TABLE563> TABLE563s { get; set; } = null!;
    public virtual DbSet<TABLE5631> TABLE5631s { get; set; } = null!;
    public virtual DbSet<TABLE5632> TABLE5632s { get; set; } = null!;
    public virtual DbSet<TABLE5633> TABLE5633s { get; set; } = null!;
    public virtual DbSet<TABLE5634> TABLE5634s { get; set; } = null!;
    public virtual DbSet<TABLE5635> TABLE5635s { get; set; } = null!;
    public virtual DbSet<TABLE5636> TABLE5636s { get; set; } = null!;
    public virtual DbSet<TABLE5638> TABLE5638s { get; set; } = null!;
    public virtual DbSet<TABLE5639> TABLE5639s { get; set; } = null!;
    public virtual DbSet<TABLE564> TABLE564s { get; set; } = null!;
    public virtual DbSet<TABLE5640> TABLE5640s { get; set; } = null!;
    public virtual DbSet<TABLE5641> TABLE5641s { get; set; } = null!;
    public virtual DbSet<TABLE5642> TABLE5642s { get; set; } = null!;
    public virtual DbSet<TABLE5644> TABLE5644s { get; set; } = null!;
    public virtual DbSet<TABLE5647> TABLE5647s { get; set; } = null!;
    public virtual DbSet<TABLE5650> TABLE5650s { get; set; } = null!;
    public virtual DbSet<TABLE5651> TABLE5651s { get; set; } = null!;
    public virtual DbSet<TABLE5660> TABLE5660s { get; set; } = null!;
    public virtual DbSet<TABLE5661> TABLE5661s { get; set; } = null!;
    public virtual DbSet<TABLE5662> TABLE5662s { get; set; } = null!;
    public virtual DbSet<TABLE5670> TABLE5670s { get; set; } = null!;
    public virtual DbSet<TABLE5671> TABLE5671s { get; set; } = null!;
    public virtual DbSet<TABLE5672> TABLE5672s { get; set; } = null!;
    public virtual DbSet<TABLE5673> TABLE5673s { get; set; } = null!;
    public virtual DbSet<TABLE5674> TABLE5674s { get; set; } = null!;
    public virtual DbSet<TABLE5675> TABLE5675s { get; set; } = null!;
    public virtual DbSet<TABLE5677> TABLE5677s { get; set; } = null!;
    public virtual DbSet<TABLE5679> TABLE5679s { get; set; } = null!;
    public virtual DbSet<TABLE5700> TABLE5700s { get; set; } = null!;
    public virtual DbSet<TABLE5701> TABLE5701s { get; set; } = null!;
    public virtual DbSet<TABLE5702> TABLE5702s { get; set; } = null!;
    public virtual DbSet<TABLE5703> TABLE5703s { get; set; } = null!;
    public virtual DbSet<TABLE5704> TABLE5704s { get; set; } = null!;
    public virtual DbSet<TABLE5705> TABLE5705s { get; set; } = null!;
    public virtual DbSet<TABLE5706> TABLE5706s { get; set; } = null!;
    public virtual DbSet<TABLE5707> TABLE5707s { get; set; } = null!;
    public virtual DbSet<TABLE5708> TABLE5708s { get; set; } = null!;
    public virtual DbSet<TABLE5709> TABLE5709s { get; set; } = null!;
    public virtual DbSet<TABLE5710> TABLE5710s { get; set; } = null!;
    public virtual DbSet<TABLE5712> TABLE5712s { get; set; } = null!;
    public virtual DbSet<TABLE5713> TABLE5713s { get; set; } = null!;
    public virtual DbSet<TABLE5719> TABLE5719s { get; set; } = null!;
    public virtual DbSet<TABLE5728> TABLE5728s { get; set; } = null!;
    public virtual DbSet<TABLE5741> TABLE5741s { get; set; } = null!;
    public virtual DbSet<TABLE5742> TABLE5742s { get; set; } = null!;
    public virtual DbSet<TABLE5743> TABLE5743s { get; set; } = null!;
    public virtual DbSet<TABLE5744> TABLE5744s { get; set; } = null!;
    public virtual DbSet<TABLE5745> TABLE5745s { get; set; } = null!;
    public virtual DbSet<TABLE5746> TABLE5746s { get; set; } = null!;
    public virtual DbSet<TABLE5747> TABLE5747s { get; set; } = null!;
    public virtual DbSet<TABLE5748> TABLE5748s { get; set; } = null!;
    public virtual DbSet<TABLE5749> TABLE5749s { get; set; } = null!;
    public virtual DbSet<TABLE5750> TABLE5750s { get; set; } = null!;
    public virtual DbSet<TABLE5770> TABLE5770s { get; set; } = null!;
    public virtual DbSet<TABLE5775> TABLE5775s { get; set; } = null!;
    public virtual DbSet<TABLE58> TABLE58s { get; set; } = null!;
    public virtual DbSet<TABLE5800> TABLE5800s { get; set; } = null!;
    public virtual DbSet<TABLE5801> TABLE5801s { get; set; } = null!;
    public virtual DbSet<TABLE5810> TABLE5810s { get; set; } = null!;
    public virtual DbSet<TABLE5811> TABLE5811s { get; set; } = null!;
    public virtual DbSet<TABLE5812> TABLE5812s { get; set; } = null!;
    public virtual DbSet<TABLE59> TABLE59s { get; set; } = null!;
    public virtual DbSet<TABLE5902> TABLE5902s { get; set; } = null!;
    public virtual DbSet<TABLE591> TABLE591s { get; set; } = null!;
    public virtual DbSet<TABLE6> TABLE6s { get; set; } = null!;
    public virtual DbSet<TABLE60> TABLE60s { get; set; } = null!;
    public virtual DbSet<TABLE6000> TABLE6000s { get; set; } = null!;
    public virtual DbSet<TABLE6001> TABLE6001s { get; set; } = null!;
    public virtual DbSet<TABLE6002> TABLE6002s { get; set; } = null!;
    public virtual DbSet<TABLE6003> TABLE6003s { get; set; } = null!;
    public virtual DbSet<TABLE6004> TABLE6004s { get; set; } = null!;
    public virtual DbSet<TABLE6005> TABLE6005s { get; set; } = null!;
    public virtual DbSet<TABLE6007> TABLE6007s { get; set; } = null!;
    public virtual DbSet<TABLE6012> TABLE6012s { get; set; } = null!;
    public virtual DbSet<TABLE6013> TABLE6013s { get; set; } = null!;
    public virtual DbSet<TABLE6014> TABLE6014s { get; set; } = null!;
    public virtual DbSet<TABLE6022> TABLE6022s { get; set; } = null!;
    public virtual DbSet<TABLE6023> TABLE6023s { get; set; } = null!;
    public virtual DbSet<TABLE6028> TABLE6028s { get; set; } = null!;
    public virtual DbSet<TABLE6030> TABLE6030s { get; set; } = null!;
    public virtual DbSet<TABLE6031> TABLE6031s { get; set; } = null!;
    public virtual DbSet<TABLE6034> TABLE6034s { get; set; } = null!;
    public virtual DbSet<TABLE6046> TABLE6046s { get; set; } = null!;
    public virtual DbSet<TABLE6054> TABLE6054s { get; set; } = null!;
    public virtual DbSet<TABLE6059> TABLE6059s { get; set; } = null!;
    public virtual DbSet<TABLE6070> TABLE6070s { get; set; } = null!;
    public virtual DbSet<TABLE6071> TABLE6071s { get; set; } = null!;
    public virtual DbSet<TABLE6072> TABLE6072s { get; set; } = null!;
    public virtual DbSet<TABLE61> TABLE61s { get; set; } = null!;
    public virtual DbSet<TABLE6100> TABLE6100s { get; set; } = null!;
    public virtual DbSet<TABLE62> TABLE62s { get; set; } = null!;
    public virtual DbSet<TABLE622> TABLE622s { get; set; } = null!;
    public virtual DbSet<TABLE624> TABLE624s { get; set; } = null!;
    public virtual DbSet<TABLE6335> TABLE6335s { get; set; } = null!;
    public virtual DbSet<TABLE634> TABLE634s { get; set; } = null!;
    public virtual DbSet<TABLE636> TABLE636s { get; set; } = null!;
    public virtual DbSet<TABLE64> TABLE64s { get; set; } = null!;
    public virtual DbSet<TABLE640> TABLE640s { get; set; } = null!;
    public virtual DbSet<TABLE641> TABLE641s { get; set; } = null!;
    public virtual DbSet<TABLE642> TABLE642s { get; set; } = null!;
    public virtual DbSet<TABLE645> TABLE645s { get; set; } = null!;
    public virtual DbSet<TABLE66> TABLE66s { get; set; } = null!;
    public virtual DbSet<TABLE6785> TABLE6785s { get; set; } = null!;
    public virtual DbSet<TABLE6786> TABLE6786s { get; set; } = null!;
    public virtual DbSet<TABLE680> TABLE680s { get; set; } = null!;
    public virtual DbSet<TABLE6805> TABLE6805s { get; set; } = null!;
    public virtual DbSet<TABLE6900> TABLE6900s { get; set; } = null!;
    public virtual DbSet<TABLE692> TABLE692s { get; set; } = null!;
    public virtual DbSet<TABLE693> TABLE693s { get; set; } = null!;
    public virtual DbSet<TABLE694> TABLE694s { get; set; } = null!;
    public virtual DbSet<TABLE695> TABLE695s { get; set; } = null!;
    public virtual DbSet<TABLE696> TABLE696s { get; set; } = null!;
    public virtual DbSet<TABLE697> TABLE697s { get; set; } = null!;
    public virtual DbSet<TABLE7> TABLE7s { get; set; } = null!;
    public virtual DbSet<TABLE7000> TABLE7000s { get; set; } = null!;
    public virtual DbSet<TABLE7001> TABLE7001s { get; set; } = null!;
    public virtual DbSet<TABLE7002> TABLE7002s { get; set; } = null!;
    public virtual DbSet<TABLE7003> TABLE7003s { get; set; } = null!;
    public virtual DbSet<TABLE7006> TABLE7006s { get; set; } = null!;
    public virtual DbSet<TABLE7007> TABLE7007s { get; set; } = null!;
    public virtual DbSet<TABLE7013> TABLE7013s { get; set; } = null!;
    public virtual DbSet<TABLE7014> TABLE7014s { get; set; } = null!;
    public virtual DbSet<TABLE7027> TABLE7027s { get; set; } = null!;
    public virtual DbSet<TABLE7028> TABLE7028s { get; set; } = null!;
    public virtual DbSet<TABLE7031> TABLE7031s { get; set; } = null!;
    public virtual DbSet<TABLE7037> TABLE7037s { get; set; } = null!;
    public virtual DbSet<TABLE7038> TABLE7038s { get; set; } = null!;
    public virtual DbSet<TABLE7039> TABLE7039s { get; set; } = null!;
    public virtual DbSet<TABLE7040> TABLE7040s { get; set; } = null!;
    public virtual DbSet<TABLE7042> TABLE7042s { get; set; } = null!;
    public virtual DbSet<TABLE7043> TABLE7043s { get; set; } = null!;
    public virtual DbSet<TABLE7044> TABLE7044s { get; set; } = null!;
    public virtual DbSet<TABLE7045> TABLE7045s { get; set; } = null!;
    public virtual DbSet<TABLE7046> TABLE7046s { get; set; } = null!;
    public virtual DbSet<TABLE7047> TABLE7047s { get; set; } = null!;
    public virtual DbSet<TABLE7051> TABLE7051s { get; set; } = null!;
    public virtual DbSet<TABLE71> TABLE71s { get; set; } = null!;
    public virtual DbSet<TABLE7100> TABLE7100s { get; set; } = null!;
    public virtual DbSet<TABLE72> TABLE72s { get; set; } = null!;
    public virtual DbSet<TABLE7200> TABLE7200s { get; set; } = null!;
    public virtual DbSet<TABLE7201> TABLE7201s { get; set; } = null!;
    public virtual DbSet<TABLE7203> TABLE7203s { get; set; } = null!;
    public virtual DbSet<TABLE7204> TABLE7204s { get; set; } = null!;
    public virtual DbSet<TABLE7205> TABLE7205s { get; set; } = null!;
    public virtual DbSet<TABLE7206> TABLE7206s { get; set; } = null!;
    public virtual DbSet<TABLE7210> TABLE7210s { get; set; } = null!;
    public virtual DbSet<TABLE7211> TABLE7211s { get; set; } = null!;
    public virtual DbSet<TABLE7212> TABLE7212s { get; set; } = null!;
    public virtual DbSet<TABLE7220> TABLE7220s { get; set; } = null!;
    public virtual DbSet<TABLE7230> TABLE7230s { get; set; } = null!;
    public virtual DbSet<TABLE73> TABLE73s { get; set; } = null!;
    public virtual DbSet<TABLE74> TABLE74s { get; set; } = null!;
    public virtual DbSet<TABLE75> TABLE75s { get; set; } = null!;
    public virtual DbSet<TABLE7501> TABLE7501s { get; set; } = null!;
    public virtual DbSet<TABLE7502> TABLE7502s { get; set; } = null!;
    public virtual DbSet<TABLE7504> TABLE7504s { get; set; } = null!;
    public virtual DbSet<TABLE7505> TABLE7505s { get; set; } = null!;
    public virtual DbSet<TABLE7508> TABLE7508s { get; set; } = null!;
    public virtual DbSet<TABLE7509> TABLE7509s { get; set; } = null!;
    public virtual DbSet<TABLE77> TABLE77s { get; set; } = null!;
    public virtual DbSet<TABLE78> TABLE78s { get; set; } = null!;
    public virtual DbSet<TABLE7801> TABLE7801s { get; set; } = null!;
    public virtual DbSet<TABLE78109> TABLE78109s { get; set; } = null!;
    public virtual DbSet<TABLE79> TABLE79s { get; set; } = null!;
    public virtual DbSet<TABLE7996> TABLE7996s { get; set; } = null!;
    public virtual DbSet<TABLE8> TABLE8s { get; set; } = null!;
    public virtual DbSet<TABLE80> TABLE80s { get; set; } = null!;
    public virtual DbSet<TABLE8000> TABLE8000s { get; set; } = null!;
    public virtual DbSet<TABLE8001> TABLE8001s { get; set; } = null!;
    public virtual DbSet<TABLE8002> TABLE8002s { get; set; } = null!;
    public virtual DbSet<TABLE8003> TABLE8003s { get; set; } = null!;
    public virtual DbSet<TABLE8004> TABLE8004s { get; set; } = null!;
    public virtual DbSet<TABLE8005> TABLE8005s { get; set; } = null!;
    public virtual DbSet<TABLE8006> TABLE8006s { get; set; } = null!;
    public virtual DbSet<TABLE8007> TABLE8007s { get; set; } = null!;
    public virtual DbSet<TABLE8008> TABLE8008s { get; set; } = null!;
    public virtual DbSet<TABLE8010> TABLE8010s { get; set; } = null!;
    public virtual DbSet<TABLE8016> TABLE8016s { get; set; } = null!;
    public virtual DbSet<TABLE8017> TABLE8017s { get; set; } = null!;
    public virtual DbSet<TABLE8018> TABLE8018s { get; set; } = null!;
    public virtual DbSet<TABLE8019> TABLE8019s { get; set; } = null!;
    public virtual DbSet<TABLE8020> TABLE8020s { get; set; } = null!;
    public virtual DbSet<TABLE8030> TABLE8030s { get; set; } = null!;
    public virtual DbSet<TABLE8060> TABLE8060s { get; set; } = null!;
    public virtual DbSet<TABLE8090> TABLE8090s { get; set; } = null!;
    public virtual DbSet<TABLE8100> TABLE8100s { get; set; } = null!;
    public virtual DbSet<TABLE8101> TABLE8101s { get; set; } = null!;
    public virtual DbSet<TABLE8103> TABLE8103s { get; set; } = null!;
    public virtual DbSet<TABLE8106> TABLE8106s { get; set; } = null!;
    public virtual DbSet<TABLE8200> TABLE8200s { get; set; } = null!;
    public virtual DbSet<TABLE8202> TABLE8202s { get; set; } = null!;
    public virtual DbSet<TABLE8204> TABLE8204s { get; set; } = null!;
    public virtual DbSet<TABLE8205> TABLE8205s { get; set; } = null!;
    public virtual DbSet<TABLE8206> TABLE8206s { get; set; } = null!;
    public virtual DbSet<TABLE8215> TABLE8215s { get; set; } = null!;
    public virtual DbSet<TABLE8300> TABLE8300s { get; set; } = null!;
    public virtual DbSet<TABLE8320> TABLE8320s { get; set; } = null!;
    public virtual DbSet<TABLE84> TABLE84s { get; set; } = null!;
    public virtual DbSet<TABLE85> TABLE85s { get; set; } = null!;
    public virtual DbSet<TABLE8500> TABLE8500s { get; set; } = null!;
    public virtual DbSet<TABLE8502> TABLE8502s { get; set; } = null!;
    public virtual DbSet<TABLE8505> TABLE8505s { get; set; } = null!;
    public virtual DbSet<TABLE8600> TABLE8600s { get; set; } = null!;
    public virtual DbSet<TABLE8601> TABLE8601s { get; set; } = null!;
    public virtual DbSet<TABLE8602> TABLE8602s { get; set; } = null!;
    public virtual DbSet<TABLE8603> TABLE8603s { get; set; } = null!;
    public virtual DbSet<TABLE8604> TABLE8604s { get; set; } = null!;
    public virtual DbSet<TABLE8605> TABLE8605s { get; set; } = null!;
    public virtual DbSet<TABLE8606> TABLE8606s { get; set; } = null!;
    public virtual DbSet<TABLE8607> TABLE8607s { get; set; } = null!;
    public virtual DbSet<TABLE87> TABLE87s { get; set; } = null!;
    public virtual DbSet<TABLE88> TABLE88s { get; set; } = null!;
    public virtual DbSet<TABLE89> TABLE89s { get; set; } = null!;
    public virtual DbSet<TABLE9> TABLE9s { get; set; } = null!;
    public virtual DbSet<TABLE90> TABLE90s { get; set; } = null!;
    public virtual DbSet<TABLE900> TABLE900s { get; set; } = null!;
    public virtual DbSet<TABLE9000> TABLE9000s { get; set; } = null!;
    public virtual DbSet<TABLE9001> TABLE9001s { get; set; } = null!;
    public virtual DbSet<TABLE9002> TABLE9002s { get; set; } = null!;
    public virtual DbSet<TABLE9003> TABLE9003s { get; set; } = null!;
    public virtual DbSet<TABLE9004> TABLE9004s { get; set; } = null!;
    public virtual DbSet<TABLE9005> TABLE9005s { get; set; } = null!;
    public virtual DbSet<TABLE9006> TABLE9006s { get; set; } = null!;
    public virtual DbSet<TABLE9007> TABLE9007s { get; set; } = null!;
    public virtual DbSet<TABLE901> TABLE901s { get; set; } = null!;
    public virtual DbSet<TABLE9010> TABLE9010s { get; set; } = null!;
    public virtual DbSet<TABLE9011> TABLE9011s { get; set; } = null!;
    public virtual DbSet<TABLE9012> TABLE9012s { get; set; } = null!;
    public virtual DbSet<TABLE9013> TABLE9013s { get; set; } = null!;
    public virtual DbSet<TABLE9014> TABLE9014s { get; set; } = null!;
    public virtual DbSet<TABLE9015> TABLE9015s { get; set; } = null!;
    public virtual DbSet<TABLE9016> TABLE9016s { get; set; } = null!;
    public virtual DbSet<TABLE9017> TABLE9017s { get; set; } = null!;
    public virtual DbSet<TABLE9018> TABLE9018s { get; set; } = null!;
    public virtual DbSet<TABLE9019> TABLE9019s { get; set; } = null!;
    public virtual DbSet<TABLE902> TABLE902s { get; set; } = null!;
    public virtual DbSet<TABLE9020> TABLE9020s { get; set; } = null!;
    public virtual DbSet<TABLE9021> TABLE9021s { get; set; } = null!;
    public virtual DbSet<TABLE9022> TABLE9022s { get; set; } = null!;
    public virtual DbSet<TABLE9023> TABLE9023s { get; set; } = null!;
    public virtual DbSet<TABLE9024> TABLE9024s { get; set; } = null!;
    public virtual DbSet<TABLE9025> TABLE9025s { get; set; } = null!;
    public virtual DbSet<TABLE9026> TABLE9026s { get; set; } = null!;
    public virtual DbSet<TABLE9027> TABLE9027s { get; set; } = null!;
    public virtual DbSet<TABLE9028> TABLE9028s { get; set; } = null!;
    public virtual DbSet<TABLE9029> TABLE9029s { get; set; } = null!;
    public virtual DbSet<TABLE903> TABLE903s { get; set; } = null!;
    public virtual DbSet<TABLE9030> TABLE9030s { get; set; } = null!;
    public virtual DbSet<TABLE9031> TABLE9031s { get; set; } = null!;
    public virtual DbSet<TABLE9040> TABLE9040s { get; set; } = null!;
    public virtual DbSet<TABLE9050> TABLE9050s { get; set; } = null!;
    public virtual DbSet<TABLE9056> TABLE9056s { get; set; } = null!;
    public virtual DbSet<TABLE9100> TABLE9100s { get; set; } = null!;
    public virtual DbSet<TABLE9101> TABLE9101s { get; set; } = null!;
    public virtual DbSet<TABLE9102> TABLE9102s { get; set; } = null!;
    public virtual DbSet<TABLE9105> TABLE9105s { get; set; } = null!;
    public virtual DbSet<TABLE9108> TABLE9108s { get; set; } = null!;
    public virtual DbSet<TABLE92> TABLE92s { get; set; } = null!;
    public virtual DbSet<TABLE9200> TABLE9200s { get; set; } = null!;
    public virtual DbSet<TABLE9202> TABLE9202s { get; set; } = null!;
    public virtual DbSet<TABLE9203> TABLE9203s { get; set; } = null!;
    public virtual DbSet<TABLE9204> TABLE9204s { get; set; } = null!;
    public virtual DbSet<TABLE9205> TABLE9205s { get; set; } = null!;
    public virtual DbSet<TABLE9207> TABLE9207s { get; set; } = null!;
    public virtual DbSet<TABLE9208> TABLE9208s { get; set; } = null!;
    public virtual DbSet<TABLE9210> TABLE9210s { get; set; } = null!;
    public virtual DbSet<TABLE9211> TABLE9211s { get; set; } = null!;
    public virtual DbSet<TABLE9212> TABLE9212s { get; set; } = null!;
    public virtual DbSet<TABLE9213> TABLE9213s { get; set; } = null!;
    public virtual DbSet<TABLE9214> TABLE9214s { get; set; } = null!;
    public virtual DbSet<TABLE9215> TABLE9215s { get; set; } = null!;
    public virtual DbSet<TABLE9216> TABLE9216s { get; set; } = null!;
    public virtual DbSet<TABLE9217> TABLE9217s { get; set; } = null!;
    public virtual DbSet<TABLE9218> TABLE9218s { get; set; } = null!;
    public virtual DbSet<TABLE9219> TABLE9219s { get; set; } = null!;
    public virtual DbSet<TABLE9220> TABLE9220s { get; set; } = null!;
    public virtual DbSet<TABLE9221> TABLE9221s { get; set; } = null!;
    public virtual DbSet<TABLE9222> TABLE9222s { get; set; } = null!;
    public virtual DbSet<TABLE9223> TABLE9223s { get; set; } = null!;
    public virtual DbSet<TABLE9224> TABLE9224s { get; set; } = null!;
    public virtual DbSet<TABLE9229> TABLE9229s { get; set; } = null!;
    public virtual DbSet<TABLE9232> TABLE9232s { get; set; } = null!;
    public virtual DbSet<TABLE9233> TABLE9233s { get; set; } = null!;
    public virtual DbSet<TABLE9234> TABLE9234s { get; set; } = null!;
    public virtual DbSet<TABLE9235> TABLE9235s { get; set; } = null!;
    public virtual DbSet<TABLE9236> TABLE9236s { get; set; } = null!;
    public virtual DbSet<TABLE9237> TABLE9237s { get; set; } = null!;
    public virtual DbSet<TABLE9238> TABLE9238s { get; set; } = null!;
    public virtual DbSet<TABLE9239> TABLE9239s { get; set; } = null!;
    public virtual DbSet<TABLE9241> TABLE9241s { get; set; } = null!;
    public virtual DbSet<TABLE9242> TABLE9242s { get; set; } = null!;
    public virtual DbSet<TABLE9243> TABLE9243s { get; set; } = null!;
    public virtual DbSet<TABLE9244> TABLE9244s { get; set; } = null!;
    public virtual DbSet<TABLE9245> TABLE9245s { get; set; } = null!;
    public virtual DbSet<TABLE9246> TABLE9246s { get; set; } = null!;
    public virtual DbSet<TABLE9247> TABLE9247s { get; set; } = null!;
    public virtual DbSet<TABLE9248> TABLE9248s { get; set; } = null!;
    public virtual DbSet<TABLE9249> TABLE9249s { get; set; } = null!;
    public virtual DbSet<TABLE9250> TABLE9250s { get; set; } = null!;
    public virtual DbSet<TABLE9251> TABLE9251s { get; set; } = null!;
    public virtual DbSet<TABLE9252> TABLE9252s { get; set; } = null!;
    public virtual DbSet<TABLE9253> TABLE9253s { get; set; } = null!;
    public virtual DbSet<TABLE9254> TABLE9254s { get; set; } = null!;
    public virtual DbSet<TABLE9255> TABLE9255s { get; set; } = null!;
    public virtual DbSet<TABLE9256> TABLE9256s { get; set; } = null!;
    public virtual DbSet<TABLE9257> TABLE9257s { get; set; } = null!;
    public virtual DbSet<TABLE9258> TABLE9258s { get; set; } = null!;
    public virtual DbSet<TABLE9259> TABLE9259s { get; set; } = null!;
    public virtual DbSet<TABLE9260> TABLE9260s { get; set; } = null!;
    public virtual DbSet<TABLE9261> TABLE9261s { get; set; } = null!;
    public virtual DbSet<TABLE9262> TABLE9262s { get; set; } = null!;
    public virtual DbSet<TABLE9263> TABLE9263s { get; set; } = null!;
    public virtual DbSet<TABLE9264> TABLE9264s { get; set; } = null!;
    public virtual DbSet<TABLE9265> TABLE9265s { get; set; } = null!;
    public virtual DbSet<TABLE9266> TABLE9266s { get; set; } = null!;
    public virtual DbSet<TABLE9267> TABLE9267s { get; set; } = null!;
    public virtual DbSet<TABLE9268> TABLE9268s { get; set; } = null!;
    public virtual DbSet<TABLE9269> TABLE9269s { get; set; } = null!;
    public virtual DbSet<TABLE9270> TABLE9270s { get; set; } = null!;
    public virtual DbSet<TABLE9271> TABLE9271s { get; set; } = null!;
    public virtual DbSet<TABLE9272> TABLE9272s { get; set; } = null!;
    public virtual DbSet<TABLE9274> TABLE9274s { get; set; } = null!;
    public virtual DbSet<TABLE9275> TABLE9275s { get; set; } = null!;
    public virtual DbSet<TABLE9276> TABLE9276s { get; set; } = null!;
    public virtual DbSet<TABLE9277> TABLE9277s { get; set; } = null!;
    public virtual DbSet<TABLE9278> TABLE9278s { get; set; } = null!;
    public virtual DbSet<TABLE9279> TABLE9279s { get; set; } = null!;
    public virtual DbSet<TABLE9280> TABLE9280s { get; set; } = null!;
    public virtual DbSet<TABLE9281> TABLE9281s { get; set; } = null!;
    public virtual DbSet<TABLE93> TABLE93s { get; set; } = null!;
    public virtual DbSet<TABLE9300> TABLE9300s { get; set; } = null!;
    public virtual DbSet<TABLE9301> TABLE9301s { get; set; } = null!;
    public virtual DbSet<TABLE95> TABLE95s { get; set; } = null!;
    public virtual DbSet<TABLE950> TABLE950s { get; set; } = null!;
    public virtual DbSet<TABLE96> TABLE96s { get; set; } = null!;
    public virtual DbSet<TABLE97> TABLE97s { get; set; } = null!;
    public virtual DbSet<TABLE9781> TABLE9781s { get; set; } = null!;
    public virtual DbSet<TABLE98> TABLE98s { get; set; } = null!;
    public virtual DbSet<TABLE99> TABLE99s { get; set; } = null!;
    public virtual DbSet<TABLE994> TABLE994s { get; set; } = null!;
    public virtual DbSet<TABLE996> TABLE996s { get; set; } = null!;
    public virtual DbSet<TABLE997> TABLE997s { get; set; } = null!;
    public virtual DbSet<TABLE998> TABLE998s { get; set; } = null!;
    public virtual DbSet<TABLE999> TABLE999s { get; set; } = null!;
    public virtual DbSet<TAB_LIFCOV> TAB_LIFCOVs { get; set; } = null!;
    public virtual DbSet<TAB_LOCAT> TAB_LOCATs { get; set; } = null!;
    public virtual DbSet<TAB_MATRIX_RH> TAB_MATRIX_RHs { get; set; } = null!;
    public virtual DbSet<TAB_MEDBENEFITS> TAB_MEDBENEFITSs { get; set; } = null!;
    public virtual DbSet<TAB_MEDBENEFITS_CO> TAB_MEDBENEFITS_COs { get; set; } = null!;
    public virtual DbSet<TAB_MEDICALFEES> TAB_MEDICALFEESs { get; set; } = null!;
    public virtual DbSet<TAB_MODCLI> TAB_MODCLIs { get; set; } = null!;
    public virtual DbSet<TAB_MODUL> TAB_MODULs { get; set; } = null!;
    public virtual DbSet<TAB_NAME_B> TAB_NAME_Bs { get; set; } = null!;
    public virtual DbSet<TAB_PROV_BKACCOUNT> TAB_PROV_BKACCOUNTs { get; set; } = null!;
    public virtual DbSet<TAB_PROV_CONTACT> TAB_PROV_CONTACTs { get; set; } = null!;
    public virtual DbSet<TAB_PROV_FEES> TAB_PROV_FEESs { get; set; } = null!;
    public virtual DbSet<TAB_PROV_GROUP> TAB_PROV_GROUPs { get; set; } = null!;
    public virtual DbSet<TAB_PROVIDER> TAB_PROVIDERs { get; set; } = null!;
    public virtual DbSet<TAB_PROV_MEDSPEC> TAB_PROV_MEDSPECs { get; set; } = null!;
    public virtual DbSet<TAB_PROV_STAFF> TAB_PROV_STAFFs { get; set; } = null!;
    public virtual DbSet<TAB_PROV_SUBTYPES> TAB_PROV_SUBTYPESs { get; set; } = null!;
    public virtual DbSet<TAB_PROV_ZONE> TAB_PROV_ZONEs { get; set; } = null!;
    public virtual DbSet<TAB_RELAT> TAB_RELATs { get; set; } = null!;
    public virtual DbSet<TAB_ROUTINE> TAB_ROUTINEs { get; set; } = null!;
    public virtual DbSet<TAB_SHORT_G> TAB_SHORT_Gs { get; set; } = null!;
    public virtual DbSet<TAB_STATE_SAAPV> TAB_STATE_SAAPVs { get; set; } = null!;
    public virtual DbSet<TAB_SYS_EXE> TAB_SYS_EXEs { get; set; } = null!;
    public virtual DbSet<TAB_TABLES> TAB_TABLESs { get; set; } = null!;
    public virtual DbSet<TAB_TYPERR> TAB_TYPERRs { get; set; } = null!;
    public virtual DbSet<TAB_WAITPO> TAB_WAITPOs { get; set; } = null!;
    public virtual DbSet<TAB_WINCLA> TAB_WINCLAs { get; set; } = null!;
    public virtual DbSet<TAB_WINCLI> TAB_WINCLIs { get; set; } = null!;
    public virtual DbSet<TAB_WINFIN> TAB_WINFINs { get; set; } = null!;
    public virtual DbSet<TAB_WINPOL> TAB_WINPOLs { get; set; } = null!;
    public virtual DbSet<TAB_WINPRO> TAB_WINPROs { get; set; } = null!;
    public virtual DbSet<TAR_HEALT_PREM> TAR_HEALT_PREMs { get; set; } = null!;
    public virtual DbSet<TARIF_COLUMN> TARIF_COLUMNs { get; set; } = null!;
    public virtual DbSet<TAX_FIXVAL> TAX_FIXVALs { get; set; } = null!;
    public virtual DbSet<T_BANK_MOV> T_BANK_MOVs { get; set; } = null!;
    public virtual DbSet<T_BANK_TRANS> T_BANK_TRANSs { get; set; } = null!;
    public virtual DbSet<T_CASH_MOV> T_CASH_MOVs { get; set; } = null!;
    public virtual DbSet<T_CHEQUES> T_CHEQUESs { get; set; } = null!;
    public virtual DbSet<T_CONCEPTS> T_CONCEPTSs { get; set; } = null!;
    public virtual DbSet<TCONVERTIONS> TCONVERTIONSs { get; set; } = null!;
    public virtual DbSet<T_DOCTYP> T_DOCTYPs { get; set; } = null!;
    public virtual DbSet<T_ERR_INTERFACE> T_ERR_INTERFACEs { get; set; } = null!;
    public virtual DbSet<TIMEGLOBALS> TIMEGLOBALSs { get; set; } = null!;
    public virtual DbSet<T_INTERFACE> T_INTERFACEs { get; set; } = null!;
    public virtual DbSet<TLEDAUTREJECTM> TLEDAUTREJECTMs { get; set; } = null!;
    public virtual DbSet<T_MASIVECHARGE> T_MASIVECHARGEs { get; set; } = null!;
    public virtual DbSet<T_MOVE_ACC> T_MOVE_ACCs { get; set; } = null!;
    public virtual DbSet<T_PARAM_INTERFACE> T_PARAM_INTERFACEs { get; set; } = null!;
    public virtual DbSet<TRACKING> TRACKINGs { get; set; } = null!;
    public virtual DbSet<TRELDOC> TRELDOCs { get; set; } = null!;
    public virtual DbSet<TYPE_AMEND> TYPE_AMENDs { get; set; } = null!;
    public virtual DbSet<TYPEPERGROUP> TYPEPERGROUPs { get; set; } = null!;
    public virtual DbSet<TYPESUBTYPE_RELATIONSHIP> TYPESUBTYPE_RELATIONSHIPs { get; set; } = null!;
    public virtual DbSet<UL_LEGAL_TERMS> UL_LEGAL_TERMSs { get; set; } = null!;
    public virtual DbSet<USER_CASHNUM> USER_CASHNUMs { get; set; } = null!;
    public virtual DbSet<USER_OFFICE> USER_OFFICEs { get; set; } = null!;
    public virtual DbSet<USERS> USERSs { get; set; } = null!;
    public virtual DbSet<WAY_PAY_PROD> WAY_PAY_PRODs { get; set; } = null!;
    public virtual DbSet<WIN_ACTIONS> WIN_ACTIONSs { get; set; } = null!;
    public virtual DbSet<WINDOWS> WINDOWSs { get; set; } = null!;
    public virtual DbSet<WIN_FILE_G> WIN_FILE_Gs { get; set; } = null!;
    public virtual DbSet<WIN_HOUR> WIN_HOURs { get; set; } = null!;
    public virtual DbSet<WIN_MESSAG> WIN_MESSAGs { get; set; } = null!;
    public virtual DbSet<WORKSHEET> WORKSHEETs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ACTIONS>(entity =>
        {
            entity.ToTable("ACTIONS", "INSUDB");
            entity.HasKey(e => e.NACTION);
            entity.Property(e => e.SCONTROLKEY).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(20);
            entity.Property(e => e.SHEL_ACTIO).HasMaxLength(70);
            entity.Property(e => e.SSHORT_ACTI).HasMaxLength(2);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.STYPE_ACTIO).HasMaxLength(1);
            entity.Property(e => e.SPATHIMAGE).HasMaxLength(50);
        });

        modelBuilder.Entity<ADDRESS>(entity =>
        {
            entity.ToTable("ADDRESS", "INSUDB");
            entity.HasKey(e => new { e.NRECOWNER, e.SKEYADDRESS, e.DEFFECDATE });
            entity.Property(e => e.SKEYADDRESS).HasMaxLength(50);
            entity.Property(e => e.SRECTYPE).HasMaxLength(1);
            entity.Property(e => e.SSTREET).HasMaxLength(45);
            entity.Property(e => e.SSTREET1).HasMaxLength(45);
            entity.Property(e => e.SZONE).HasMaxLength(20);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SE_MAIL).HasMaxLength(60);
            entity.Property(e => e.NLAT_CARDIN).HasMaxLength(45);
            entity.Property(e => e.NLON_CARDIN).HasMaxLength(45);
            entity.Property(e => e.SBUILD).HasMaxLength(10);
            entity.Property(e => e.SDEPARTMENT).HasMaxLength(10);
            entity.Property(e => e.SPOPULATION).HasMaxLength(45);
            entity.Property(e => e.SINFOR).HasMaxLength(1);
            entity.Property(e => e.SPOBOX).HasMaxLength(15);
            entity.Property(e => e.SDESCADD).HasMaxLength(140);
            entity.Property(e => e.SCOSTCENTER).HasMaxLength(30);
            entity.Property(e => e.SLEDGERPROCESS).HasMaxLength(1);
            entity.Property(e => e.SINVALID_IND).HasMaxLength(1);
            entity.Property(e => e.SSEND_MAIL).HasMaxLength(1);
            entity.Property(e => e.SMAIL).HasMaxLength(1);
            entity.Property(e => e.SBILL).HasMaxLength(1);
            entity.Property(e => e.SZIP_CODE).HasMaxLength(8);
            entity.Property(e => e.SINDSENTEMAIL).HasMaxLength(1);
            entity.Property(e => e.SELEVATION).HasMaxLength(20);
        });

        modelBuilder.Entity<ADDRESS_CONFIG>(entity =>
        {
            entity.ToTable("ADDRESS_CONFIG", "INSUDB");
            entity.HasKey(e => e.COUNTRY);
            entity.Property(e => e.ADDRESS_SETTINGS).HasMaxLength(4000);
            entity.Property(e => e.PHONE_SETTINGS).HasMaxLength(4000);
        });

        modelBuilder.Entity<AGENCIES>(entity =>
        {
            entity.ToTable("AGENCIES", "INSUDB");
            entity.HasKey(e => e.NAGENCY);
            entity.Property(e => e.SPAY).HasMaxLength(1);
        });

        modelBuilder.Entity<AGREEMENT>(entity =>
        {
            entity.ToTable("AGREEMENT", "INSUDB");
            entity.HasKey(e => e.NCOD_AGREE);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SEMAIL_CONTACT).HasMaxLength(60);
            entity.Property(e => e.SPHONE_CONTACT).HasMaxLength(50);
            entity.Property(e => e.SCLIENAME).HasMaxLength(63);
            entity.Property(e => e.SFIRSTNAME).HasMaxLength(19);
            entity.Property(e => e.SLASTNAME).HasMaxLength(19);
            entity.Property(e => e.SEMAILA_CONTACT).HasMaxLength(60);
            entity.Property(e => e.SPHONEA_CONTACT).HasMaxLength(50);
            entity.Property(e => e.SPHONEFAX).HasMaxLength(50);
            entity.Property(e => e.SNAME_AGREE).HasMaxLength(80);
            entity.Property(e => e.SNOCOLLECTION).HasMaxLength(1);
        });

        modelBuilder.Entity<AGREEMENT_AL>(entity =>
        {
            entity.ToTable("AGREEMENT_AL", "INSUDB");
            entity.HasKey(e => e.NAGREEMENT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SLEVELINT).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<APPUSER>(entity =>
        {
            entity.ToTable("APPUSER", "INSUDB");
            entity.HasKey(e => e.NIDUSER);
            entity.Property(e => e.SUSERNAME).HasMaxLength(2000);
            entity.Property(e => e.SNAME).HasMaxLength(100);
        });

        modelBuilder.Entity<APV_LED_ACC>(entity =>
        {
            entity.ToTable("APV_LED_ACC", "INSUDB");
            entity.HasKey(e => new { e.NTYPE_MOVE, e.NTYP_PROFITWORKER });
            entity.Property(e => e.SLEDACC).HasMaxLength(15);
            entity.Property(e => e.SDESCLED).HasMaxLength(60);
        });

        modelBuilder.Entity<ASCII_I_DET>(entity =>
        {
            entity.ToTable("ASCII_I_DET", "INSUDB");
            entity.HasKey(e => new { e.SASCII_NAME, e.NID, e.NPAY_ID });
            entity.Property(e => e.SASCII_NAME).HasMaxLength(35);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCLIENAME).HasMaxLength(63);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SBANKACCOUNT).HasMaxLength(100);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<ASCII_I_HEAD>(entity =>
        {
            entity.ToTable("ASCII_I_HEAD", "INSUDB");
            entity.HasKey(e => e.SASCII_NAME);
            entity.Property(e => e.SASCII_NAME).HasMaxLength(35);
            entity.Property(e => e.SACC_NUMBER).HasMaxLength(100);
            entity.Property(e => e.SSTATMOV).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SPAY_FORM).HasMaxLength(1);
        });

        modelBuilder.Entity<ATTCHAMENTFORM>(entity =>
        {
            entity.ToTable("ATTCHAMENTFORM", "INSUDB");
            entity.HasKey(e => e.NSEQUENCEATT);
            entity.Property(e => e.SFORMID).HasMaxLength(36);
        });

        modelBuilder.Entity<BANK_ACC>(entity =>
        {
            entity.ToTable("BANK_ACC", "INSUDB");
            entity.HasKey(e => e.NACC_BANK);
            entity.Property(e => e.SACC_LEDGER).HasMaxLength(20);
            entity.Property(e => e.SACC_NUMBER).HasMaxLength(100);
            entity.Property(e => e.SAUX_ACCOUN).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<BANK_AGREE>(entity =>
        {
            entity.ToTable("BANK_AGREE", "INSUDB");
            entity.HasKey(e => new { e.STYPE_BANKAGREE, e.NBANK, e.NACCOUNT });
            entity.Property(e => e.STYPE_BANKAGREE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SFORMAT).HasMaxLength(20);
        });

        modelBuilder.Entity<BANK_MOV>(entity =>
        {
            entity.ToTable("BANK_MOV", "INSUDB");
            entity.HasKey(e => new { e.DEFFECDATE, e.NMOVEMENT, e.NACC_BANK });
            entity.Property(e => e.SDEP_NUMBER).HasMaxLength(256);
            entity.Property(e => e.SNULL_MOVEM).HasMaxLength(1);
            entity.Property(e => e.SNULL_RECOR).HasMaxLength(1);
            entity.Property(e => e.SDOCNUMBE).HasMaxLength(30);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SNUMFORM).HasMaxLength(12);
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
        });

        modelBuilder.Entity<BATCH_JOB>(entity =>
        {
            entity.ToTable("BATCH_JOB", "INSUDB");
            entity.HasKey(e => e.SKEY);
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SCOMMAND).HasMaxLength(1000);
            entity.Property(e => e.SKEY_FATHER).HasMaxLength(20);
            entity.Property(e => e.SOUTPUTFILE).HasMaxLength(200);
            entity.Property(e => e.SFILE).HasMaxLength(100);
            entity.Property(e => e.SVERIFIED_PLA).HasMaxLength(1);
        });

        modelBuilder.Entity<BATCH_PARAM>(entity =>
        {
            entity.ToTable("BATCH_PARAM", "INSUDB");
            entity.HasKey(e => new { e.NBATCH, e.NAREA, e.NSEQ });
            entity.Property(e => e.SNAME).HasMaxLength(25);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(100);
        });

        modelBuilder.Entity<BATCH_PARAM_VALUE>(entity =>
        {
            entity.ToTable("BATCH_PARAM_VALUE", "INSUDB");
            entity.HasKey(e => new { e.SKEY, e.NAREA, e.NSEQ, e.NBATCH });
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SVALUE).HasMaxLength(100);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

        modelBuilder.Entity<BATCH_PROCESS>(entity =>
        {
            entity.ToTable("BATCH_PROCESS", "INSUDB");
            entity.HasKey(e => e.NBATCH);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SPROC).HasMaxLength(50);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<BENEFGROUP_DETAIL>(entity =>
        {
            entity.ToTable("BENEFGROUP_DETAIL", "INSUDB");
            entity.HasKey(e => new { e.SBENEFITGROUP, e.SIDDETAIL });
            entity.Property(e => e.SBENEFITGROUP).HasMaxLength(10);
            entity.Property(e => e.SIDDETAIL).HasMaxLength(10);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<BENEFICIAR>(entity =>
        {
            entity.ToTable("BENEFICIAR", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.SCLIENT, e.DEFFECDATE, e.NMODULEC, e.NCOVER });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SIRREVOC).HasMaxLength(1);
            entity.Property(e => e.SCONTING).HasMaxLength(1);
            entity.Property(e => e.SSEND_MAIL).HasMaxLength(1);
            entity.Property(e => e.SDESIGN).HasMaxLength(1);
        });

        modelBuilder.Entity<BENEFITS_CATEGORY>(entity =>
        {
            entity.ToTable("BENEFITS_CATEGORY", "INSUDB");
            entity.HasKey(e => e.NBENEFCATEG);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(100);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.STABLEASOC).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<BENEFITS_GROUP>(entity =>
        {
            entity.ToTable("BENEFITS_GROUP", "INSUDB");
            entity.HasKey(e => e.SBENEFITGROUP);
            entity.Property(e => e.SBENEFITGROUP).HasMaxLength(10);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(350);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(60);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCLARIFICACT).HasMaxLength(500);
        });

        modelBuilder.Entity<BILLS>(entity =>
        {
            entity.ToTable("BILLS", "INSUDB");
            entity.HasKey(e => new { e.NINSUR_AREA, e.SBILLTYPE, e.SBILLING, e.NBILLNUM });
            entity.Property(e => e.SBILLTYPE).HasMaxLength(1);
            entity.Property(e => e.SBILLING).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SKEYADDRESS).HasMaxLength(50);
            entity.Property(e => e.SBILL_IND).HasMaxLength(1);
            entity.Property(e => e.SORIGIN).HasMaxLength(1);
            entity.Property(e => e.SBILLFULLNUM).HasMaxLength(20);
            entity.Property(e => e.SAUTHORIZATION).HasMaxLength(40);
            entity.Property(e => e.SBILLNUMSFE).HasMaxLength(100);
        });

        modelBuilder.Entity<BILLS_HIS>(entity =>
        {
            entity.ToTable("BILLS_HIS", "INSUDB");
            entity.HasKey(e => new { e.SBILLTYPE, e.NBILLNUM, e.DSTATDATE, e.NTRANSAC });
            entity.Property(e => e.SBILLTYPE).HasMaxLength(1);
            entity.Property(e => e.STEXT).HasMaxLength(4000);
            entity.Property(e => e.SBILLNUMSFE).HasMaxLength(100);
            entity.Property(e => e.SBILLNUMSFE_OLD).HasMaxLength(100);
            entity.Property(e => e.SNOTEDESCRIPTS).HasMaxLength(64);
        });

        modelBuilder.Entity<BILLS_NUM>(entity =>
        {
            entity.ToTable("BILLS_NUM", "INSUDB");
            entity.HasKey(e => new { e.NINSUR_AREA, e.SBILLTYPE, e.NINITNUMB });
            entity.Property(e => e.SBILLTYPE).HasMaxLength(1);
        });

        modelBuilder.Entity<BK_ACCOUNT>(entity =>
        {
            entity.ToTable("BK_ACCOUNT", "INSUDB");
            entity.HasKey(e => new { e.NBANKEXT, e.SACCOUNT, e.SCLIENT });
            entity.Property(e => e.SACCOUNT).HasMaxLength(100);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SDEPOSIT).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<BOOK_COLLECTION>(entity =>
        {
            entity.ToTable("BOOK_COLLECTION", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NRECEIPT, e.NBRANCH_LED, e.NTRANSAC, e.SKEY });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SPAY_FORM).HasMaxLength(2);
            entity.Property(e => e.SCLIENTSPONSOR).HasMaxLength(14);
            entity.Property(e => e.SCLIENT_ASEG).HasMaxLength(14);
        });

        modelBuilder.Entity<BOOK_PRODUCTION>(entity =>
        {
            entity.ToTable("BOOK_PRODUCTION", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NRECEIPT, e.NTRANSAC, e.SKEY, e.NCERTIF, e.NBRANCH_LED });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SCLIENTSPONSOR).HasMaxLength(14);
            entity.Property(e => e.SCLIENT_ASEG).HasMaxLength(14);
            entity.Property(e => e.SCLIENT_AGEN).HasMaxLength(14);
        });

        modelBuilder.Entity<BRANPROD_ALLOW>(entity =>
        {
            entity.ToTable("BRANPROD_ALLOW", "INSUDB");
            entity.HasKey(e => new { e.NINTERMED, e.NBRANCH, e.NPRODUCT, e.NMODULEC, e.NINSTALLMENTS, e.NSTARTMONTH, e.NENDMONTH });
        });

        modelBuilder.Entity<BROKER_DET>(entity =>
        {
            entity.ToTable("BROKER_DET", "INSUDB");
            entity.HasKey(e => new { e.NCOMPANY_BR, e.NCOMPANY, e.DEFFECDATE, e.NID });
        });

        modelBuilder.Entity<BUSSKIND>(entity =>
        {
            entity.ToTable("BUSSKIND", "INSUDB");
            entity.HasKey(e => new { e.NBUSINESSTY, e.NCOMMERGRP, e.NCODKIND });
            entity.Property(e => e.SCOMPLCOD).HasMaxLength(6);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<CASH_ACC>(entity =>
        {
            entity.ToTable("CASH_ACC", "INSUDB");
            entity.HasKey(e => new { e.NACC_CASH, e.NOFFICE, e.NCURRENCY, e.NCASHNUM });
            entity.Property(e => e.SACCOUNT).HasMaxLength(20);
            entity.Property(e => e.SAUX_ACCOUN).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<CASH_CONCEPTS>(entity =>
        {
            entity.ToTable("CASH_CONCEPTS", "INSUDB");
            entity.HasKey(e => new { e.NCONCEPT, e.NCOMPANY });
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<CASH_CONCLASS>(entity =>
        {
            entity.ToTable("CASH_CONCLASS", "INSUDB");
            entity.HasKey(e => e.NCONCEPT);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<CASH_MOV>(entity =>
        {
            entity.ToTable("CASH_MOV", "INSUDB");
            entity.HasKey(e => new { e.NACC_CASH, e.NOFFICE, e.NCURRENCY, e.NTRANSAC, e.NCASHNUM, e.DEFFECDATE });
            entity.Property(e => e.SCARD_NUM).HasMaxLength(100);
            entity.Property(e => e.SDEP_NUMBER).HasMaxLength(12);
            entity.Property(e => e.SDOCNUMBE).HasMaxLength(30);
            entity.Property(e => e.SNULL_MOVEM).HasMaxLength(1);
            entity.Property(e => e.SNULL_RECOR).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SNUMFORM).HasMaxLength(12);
            entity.Property(e => e.SINTER_PAY).HasMaxLength(14);
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(650);
            entity.Property(e => e.SPROCESS).HasMaxLength(1);
            entity.Property(e => e.SR_DEPNUM).HasMaxLength(12);
        });

        modelBuilder.Entity<CASH_STAT>(entity =>
        {
            entity.ToTable("CASH_STAT", "INSUDB");
            entity.HasKey(e => new { e.NCASHNUM, e.DSTATDATE, e.NID });
        });

        modelBuilder.Entity<CERTIFICAT>(entity =>
        {
            entity.ToTable("CERTIFICAT", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCUMUL_CODE).HasMaxLength(14);
            entity.Property(e => e.SRENEWAL).HasMaxLength(1);
            entity.Property(e => e.SSTATUSVA).HasMaxLength(1);
            entity.Property(e => e.SPRORSHORT).HasMaxLength(1);
            entity.Property(e => e.SNUMFORM).HasMaxLength(12);
            entity.Property(e => e.SREINSURA).HasMaxLength(1);
            entity.Property(e => e.SCLAIMIND).HasMaxLength(1);
            entity.Property(e => e.SEXCEPTION).HasMaxLength(1);
            entity.Property(e => e.SPROPERUSE).HasMaxLength(1);
            entity.Property(e => e.SEXEMPTION).HasMaxLength(1);
            entity.Property(e => e.SDIRIND).HasMaxLength(1);
            entity.Property(e => e.SAUT_GUARVAL).HasMaxLength(1);
            entity.Property(e => e.SSUS_ORIGI).HasMaxLength(1);
            entity.Property(e => e.SANULLETTER).HasMaxLength(1);
            entity.Property(e => e.SBILL_IND).HasMaxLength(1);
            entity.Property(e => e.SREFUNDPREM).HasMaxLength(1);
            entity.Property(e => e.SPENDINFO).HasMaxLength(1);
            entity.Property(e => e.SFRACRECEIP).HasMaxLength(1);
            entity.Property(e => e.SRETARIF).HasMaxLength(1);
            entity.Property(e => e.SOPERATION).HasMaxLength(16);
            entity.Property(e => e.SAPPLYCOSTFP).HasMaxLength(1);
            entity.Property(e => e.SDETAILED_ENTRY_PRINTED).HasMaxLength(1);
            entity.Property(e => e.SFACULTATIV).HasMaxLength(1);
            entity.Property(e => e.SOFFICIALPOL).HasMaxLength(10);
            entity.Property(e => e.SOFFICIALCER).HasMaxLength(10);
            entity.Property(e => e.SFILENUMBER).HasMaxLength(10);
            entity.Property(e => e.SRECTYPE).HasMaxLength(1);
            entity.Property(e => e.SIND_MULTIANNUAL).HasMaxLength(1);
            entity.Property(e => e.SIND_IFI).HasMaxLength(1);
            entity.Property(e => e.SCODBRANCH_TRANSFER).HasMaxLength(5);
            entity.Property(e => e.SCONTROL).HasMaxLength(20);
            entity.Property(e => e.SINDQSAMEVALUE).HasMaxLength(1);
            entity.Property(e => e.SCLIENTSPONSOR).HasMaxLength(14);
            entity.Property(e => e.SCOMERPRODUCT).HasMaxLength(10);
            entity.Property(e => e.SEXCEP_RANDOM).HasMaxLength(1);
            entity.Property(e => e.SISUGSTART).HasMaxLength(1);
            entity.Property(e => e.SPREVPOLNUM).HasMaxLength(30);
        });

        modelBuilder.Entity<CESSION_PR>(entity =>
        {
            entity.ToTable("CESSION_PR", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NCESSION_NU, e.NID, e.NCERTIF, e.NPOLICY });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SPRINT_CE).HasMaxLength(1);
            entity.Property(e => e.SRETENTION).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SSMOKING).HasMaxLength(1);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SEXTRAPREM).HasMaxLength(1);
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SPOSTEDSEQUENCE).HasMaxLength(100);
            entity.Property(e => e.SINDPROCESS).HasMaxLength(1);
        });

        modelBuilder.Entity<CHARG_PREBASPAY>(entity =>
        {
            entity.ToTable("CHARG_PREBASPAY", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NAGE_INIT, e.NMONTH_INI, e.NOPTION });
            entity.Property(e => e.SAPLYQUOT).HasMaxLength(1);
        });

        modelBuilder.Entity<CHEQ_BOOK>(entity =>
        {
            entity.ToTable("CHEQ_BOOK", "INSUDB");
            entity.HasKey(e => new { e.NACC_BANK, e.DEFFECDATE });
            entity.Property(e => e.SCHEQUE_END).HasMaxLength(10);
            entity.Property(e => e.SCHEQUE_LAS).HasMaxLength(10);
            entity.Property(e => e.SCHEQUE_STA).HasMaxLength(10);
        });

        modelBuilder.Entity<CHEQUE_MOV>(entity =>
        {
            entity.ToTable("CHEQUE_MOV", "INSUDB");
            entity.HasKey(e => new { e.NCOMPANY, e.NBANK_CODE, e.SCHEQUENU, e.DEFFECDATE, e.NCHEOPERTYP, e.NID });
            entity.Property(e => e.SCHEQUENU).HasMaxLength(30);
            entity.Property(e => e.SCHEQUEINTER).HasMaxLength(10);
            entity.Property(e => e.SDEPNUMBER).HasMaxLength(12);
        });

        modelBuilder.Entity<CHEQUES>(entity =>
        {
            entity.ToTable("CHEQUES", "INSUDB");
            entity.HasKey(e => new { e.NREQUEST_NU, e.SCHEQUE, e.NCONSEC });
            entity.Property(e => e.SCHEQUE).HasMaxLength(10);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(650);
            entity.Property(e => e.SPAY_FREQ).HasMaxLength(1);
            entity.Property(e => e.SREQUEST_TY).HasMaxLength(1);
            entity.Property(e => e.SINTER_PAY).HasMaxLength(14);
            entity.Property(e => e.SFILE_FIN700).HasMaxLength(12);
            entity.Property(e => e.SINDPROCES).HasMaxLength(1);
            entity.Property(e => e.SACCOUNTHOLDER).HasMaxLength(14);
            entity.Property(e => e.SBANKACCOUNT).HasMaxLength(100);
        });

        modelBuilder.Entity<CLAIM>(entity =>
        {
            entity.ToTable("CLAIM", "INSUDB");
            entity.HasKey(e => e.NCLAIM);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLAIMTYP).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCOINSURI).HasMaxLength(1);
            entity.Property(e => e.SINS_CLAIM).HasMaxLength(12);
            entity.Property(e => e.SLEADCIAL).HasMaxLength(12);
            entity.Property(e => e.SMAILNUMB).HasMaxLength(6);
            entity.Property(e => e.SPRINTED).HasMaxLength(1);
            entity.Property(e => e.SREINSURI).HasMaxLength(1);
            entity.Property(e => e.SSHOW_STATU).HasMaxLength(1);
            entity.Property(e => e.SSTACLAIM).HasMaxLength(2);
            entity.Property(e => e.SNUMFORM).HasMaxLength(12);
            entity.Property(e => e.SCESS_NPR).HasMaxLength(1);
            entity.Property(e => e.SCLIENT2).HasMaxLength(14);
            entity.Property(e => e.SUNIQUEID).HasMaxLength(50);
            entity.Property(e => e.SHISTORICAL_CLAIM).HasMaxLength(1);
        });

        modelBuilder.Entity<CLAIM_ACTIONS_SCHE>(entity =>
        {
            entity.ToTable("CLAIM_ACTIONS_SCHE", "INSUDB");
            entity.HasKey(e => new { e.SSCHE_CODE, e.SCODISPL, e.NACTIONCLAIM });
            entity.Property(e => e.SSCHE_CODE).HasMaxLength(6);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
        });

        modelBuilder.Entity<CLAIM_ACTIONS_STATE>(entity =>
        {
            entity.ToTable("CLAIM_ACTIONS_STATE", "INSUDB");
            entity.HasKey(e => new { e.SSCHE_CODE, e.SCODISPL, e.NSTATUS, e.NCLAIM_ENTITY, e.NACTIONCLAIM });
            entity.Property(e => e.SSCHE_CODE).HasMaxLength(6);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SIND_CHANGE).HasMaxLength(1);
            entity.Property(e => e.SIND_QUERY).HasMaxLength(1);
        });

        modelBuilder.Entity<CLAIMBENEF>(entity =>
        {
            entity.ToTable("CLAIMBENEF", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.SCLIENT, e.NID });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SDEMANDANT).HasMaxLength(1);
            entity.Property(e => e.SBENEF_TYP).HasMaxLength(1);
            entity.Property(e => e.SCLIENT_REP).HasMaxLength(14);
            entity.Property(e => e.SPAY_INSTALL).HasMaxLength(1);
        });

        modelBuilder.Entity<CLAIM_CASE>(entity =>
        {
            entity.ToTable("CLAIM_CASE", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE });
            entity.Property(e => e.SSTACASE).HasMaxLength(2);
            entity.Property(e => e.SCLAIM_AFFE).HasMaxLength(1);
            entity.Property(e => e.SHAS_SURV_PENSION_BENEFS).HasMaxLength(1);
            entity.Property(e => e.SAFP_TRANS_TYPE).HasMaxLength(1);
        });

        modelBuilder.Entity<CLAIM_CAUS>(entity =>
        {
            entity.ToTable("CLAIM_CAUS", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NCAUSECOD, e.NPRODUCT });
            entity.Property(e => e.SCLAIMTYP).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(130);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
        });

        modelBuilder.Entity<CLAIM_CES>(entity =>
        {
            entity.ToTable("CLAIM_CES", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.NID, e.NCESS_NU });
            entity.Property(e => e.SPRINT_C).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SSTACLAIM).HasMaxLength(1);
        });

        modelBuilder.Entity<CLAIM_HIS>(entity =>
        {
            entity.ToTable("CLAIM_HIS", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.NTRANSAC });
            entity.Property(e => e.SCESSICOI).HasMaxLength(1);
            entity.Property(e => e.SEXECUTED).HasMaxLength(1);
            entity.Property(e => e.SIND_AUT).HasMaxLength(1);
            entity.Property(e => e.SIND_ORDER).HasMaxLength(1);
            entity.Property(e => e.SIND_REV).HasMaxLength(1);
            entity.Property(e => e.SORDER_NUM).HasMaxLength(10);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SREINSU_IND).HasMaxLength(1);
            entity.Property(e => e.SCOINSU_IND).HasMaxLength(1);
            entity.Property(e => e.SCO_PAY).HasMaxLength(1);
            entity.Property(e => e.SINDMARGIN).HasMaxLength(1);
            entity.Property(e => e.SPAY_RENT).HasMaxLength(1);
            entity.Property(e => e.SIND_TRANFER).HasMaxLength(1);
            entity.Property(e => e.SIND_RASA).HasMaxLength(1);
            entity.Property(e => e.SINDPROCESS).HasMaxLength(1);
            entity.Property(e => e.SPOSTEDSEQUENCE).HasMaxLength(100);
        });

        modelBuilder.Entity<CLAIM_MASTER>(entity =>
        {
            entity.ToTable("CLAIM_MASTER", "INSUDB");
            entity.HasKey(e => e.NBORDEREAUX_CL);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SFILENAME).HasMaxLength(150);
            entity.Property(e => e.SSTATUS_PROC).HasMaxLength(1);
        });

        modelBuilder.Entity<CLAIM_ORDER>(entity =>
        {
            entity.ToTable("CLAIM_ORDER", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.NORDER_NUM });
            entity.Property(e => e.STYPECARE).HasMaxLength(10);
            entity.Property(e => e.SPREAUTHORIZATION).HasMaxLength(1);
            entity.Property(e => e.NMOVEMENT).HasMaxLength(5);
            entity.Property(e => e.SCARECLASS).HasMaxLength(10);
            entity.Property(e => e.SPROLTREATMENT).HasMaxLength(1);
            entity.Property(e => e.SCALLCENTER).HasMaxLength(1);
            entity.Property(e => e.SFASTMEDICALEVAL).HasMaxLength(1);
            entity.Property(e => e.SCLIENT_BENEF).HasMaxLength(14);
            entity.Property(e => e.SCLIENT_REP).HasMaxLength(14);
            entity.Property(e => e.SHISTORICAL_CLAIM).HasMaxLength(1);
        });

        modelBuilder.Entity<CLAIM_PRESCRIPTION>(entity =>
        {
            entity.ToTable("CLAIM_PRESCRIPTION", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NCLA_LI_TYP });
        });

        modelBuilder.Entity<CLAIM_SETT_DOCUM>(entity =>
        {
            entity.ToTable("CLAIM_SETT_DOCUM", "INSUDB");
            entity.HasKey(e => new { e.NCONSEC_DOC, e.NSETTLEMENT_NUM });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
        });

        modelBuilder.Entity<CLAIM_SETT_FILTERS>(entity =>
        {
            entity.ToTable("CLAIM_SETT_FILTERS", "INSUDB");
            entity.HasKey(e => e.NSETTLEMENT_NUM);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCLIENT2).HasMaxLength(14);
            entity.Property(e => e.SCLIENT_BENEF).HasMaxLength(14);
        });

        modelBuilder.Entity<CLAIM_SETT_HIS>(entity =>
        {
            entity.ToTable("CLAIM_SETT_HIS", "INSUDB");
            entity.HasKey(e => new { e.NSETTLEMENT_NUM, e.NTRANSAC });
            entity.Property(e => e.SREMARKS).HasMaxLength(60);
        });

        modelBuilder.Entity<CLAIM_SETTLEMENT>(entity =>
        {
            entity.ToTable("CLAIM_SETTLEMENT", "INSUDB");
            entity.HasKey(e => e.NSETTLEMENT_NUM);
            entity.Property(e => e.SCLIENT2).HasMaxLength(14);
            entity.Property(e => e.SCLIENT_PAYEE).HasMaxLength(14);
            entity.Property(e => e.SBANKACCOUNT).HasMaxLength(100);
            entity.Property(e => e.SREFUND).HasMaxLength(1);
            entity.Property(e => e.SCLIENAMEPAYEE).HasMaxLength(63);
            entity.Property(e => e.SCLINUMDOCU).HasMaxLength(18);
            entity.Property(e => e.SPHONE).HasMaxLength(20);
            entity.Property(e => e.SCELLPHONE).HasMaxLength(20);
            entity.Property(e => e.SEMAIL).HasMaxLength(60);
            entity.Property(e => e.SCLIENT_BENEF).HasMaxLength(14);
            entity.Property(e => e.SCLIENT_REP).HasMaxLength(14);
        });

        modelBuilder.Entity<CLAIM_SETT_ORDER>(entity =>
        {
            entity.ToTable("CLAIM_SETT_ORDER", "INSUDB");
            entity.HasKey(e => new { e.NSETTLEMENT_NUM, e.NORDER_NUM });
        });

        modelBuilder.Entity<CLAIM_SETT_VOUCHER>(entity =>
        {
            entity.ToTable("CLAIM_SETT_VOUCHER", "INSUDB");
            entity.HasKey(e => new { e.NSETTLEMENT_NUM, e.NCLAIM_VOUCHER });
        });

        modelBuilder.Entity<CLAIM_VOUCHER>(entity =>
        {
            entity.ToTable("CLAIM_VOUCHER", "INSUDB");
            entity.HasKey(e => e.NCLAIM_VOUCHER);
            entity.Property(e => e.SCLINUMDOCU).HasMaxLength(18);
            entity.Property(e => e.SELECTRONIC_DOC).HasMaxLength(1);
            entity.Property(e => e.SSENDER_NAME).HasMaxLength(63);
            entity.Property(e => e.SCUF_NUMBER).HasMaxLength(60);
            entity.Property(e => e.SVOUCHER_SERIES).HasMaxLength(5);
            entity.Property(e => e.SCONTROL_CODE).HasMaxLength(20);
            entity.Property(e => e.SOBSERV).HasMaxLength(60);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<CLAIM_VOUCHER_ORDER>(entity =>
        {
            entity.ToTable("CLAIM_VOUCHER_ORDER", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM_VOUCHER, e.NORDER_NUM });
        });

        modelBuilder.Entity<CLAIM_WIN>(entity =>
        {
            entity.ToTable("CLAIM_WIN", "INSUDB");
            entity.HasKey(e => e.NCLAIM);
            entity.Property(e => e.SV_CONCLAIM).HasMaxLength(30);
            entity.Property(e => e.SV_WINCLAIM).HasMaxLength(240);
        });

        modelBuilder.Entity<CLASSPROPERTYWIN>(entity =>
        {
            entity.ToTable("CLASSPROPERTYWIN", "INSUDB");
            entity.HasKey(e => new { e.SCODISPL, e.NIDCLASS, e.NIDPROPERTY, e.NORDEN });
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SVISIBLE).HasMaxLength(1);
            entity.Property(e => e.SCAPTION).HasMaxLength(40);
            entity.Property(e => e.SKEY).HasMaxLength(1);
        });

        modelBuilder.Entity<CLAUS_CO_G>(entity =>
        {
            entity.ToTable("CLAUS_CO_G", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NGROUP, e.NCLAUSE, e.DEFFECDATE, e.NMODULEC, e.NCOVER });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.STYPE_CLAUSE).HasMaxLength(1);
            entity.Property(e => e.SDOC_ATTACH).HasMaxLength(45);
        });

        modelBuilder.Entity<CLAUS_CO_P>(entity =>
        {
            entity.ToTable("CLAUS_CO_P", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCLAUSE, e.DEFFECDATE, e.NMODULEC, e.NCOVER });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.STYPE_CLAUSE).HasMaxLength(1);
            entity.Property(e => e.SDOC_ATTACH).HasMaxLength(45);
        });

        modelBuilder.Entity<CLAUSE>(entity =>
        {
            entity.ToTable("CLAUSE", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NCLAUSE, e.DEFFECDATE, e.NID });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SAGREE).HasMaxLength(1);
            entity.Property(e => e.STYPE_CLAUSE).HasMaxLength(1);
            entity.Property(e => e.SDOC_ATTACH).HasMaxLength(45);
        });

        modelBuilder.Entity<CL_COMMERTYPEPAY>(entity =>
        {
            entity.ToTable("CL_COMMERTYPEPAY", "INSUDB");
            entity.HasKey(e => e.NTYPE_COMMPAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SIND_CONTROL).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<CL_COVER>(entity =>
        {
            entity.ToTable("CL_COVER", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCOVER, e.NCASE_NUM, e.NDEMAN_TYPE, e.NMODULEC, e.NCURRENCY, e.SCLIENT });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SFRANTYPE).HasMaxLength(1);
            entity.Property(e => e.SRESERVSTAT).HasMaxLength(1);
            entity.Property(e => e.SBILL_IND).HasMaxLength(1);
        });

        modelBuilder.Entity<CL_COVERMA>(entity =>
        {
            entity.ToTable("CL_COVERMA", "INSUDB");
            entity.HasKey(e => new { e.NMODULEC, e.NCOVER, e.NCONCEPT, e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE });
            entity.Property(e => e.SBUDGET).HasMaxLength(10);
            entity.Property(e => e.SBILL).HasMaxLength(20);
        });

        modelBuilder.Entity<CLIALLOCLA>(entity =>
        {
            entity.ToTable("CLIALLOCLA", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NROLE });
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
            entity.Property(e => e.SIND_CRECLI).HasMaxLength(1);
            entity.Property(e => e.SDEFAULT_CLA_IND).HasMaxLength(1);
        });

        modelBuilder.Entity<CLIALLOPRO>(entity =>
        {
            entity.ToTable("CLIALLOPRO", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.SPOLITYPE, e.SCOMPON, e.NROLE });
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SCOMPON).HasMaxLength(1);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
            entity.Property(e => e.SOPTIONALQUO).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SINSURABLE).HasMaxLength(1);
        });

        modelBuilder.Entity<CLIDOCPOL>(entity =>
        {
            entity.ToTable("CLIDOCPOL", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NROLE, e.SCLIENT, e.NCLASSTYPDOC, e.NTYPCLIENTDOC, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<CLIDOCUMENTS>(entity =>
        {
            entity.ToTable("CLIDOCUMENTS", "INSUDB");
            entity.HasKey(e => new { e.NTYPCLIENTDOC, e.SCLINUMDOCU, e.SCLIENT });
            entity.Property(e => e.SCLINUMDOCU).HasMaxLength(18);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SIDCOMPL).HasMaxLength(5);
        });

        modelBuilder.Entity<CLIENT>(entity =>
        {
            entity.ToTable("CLIENT", "INSUDB");
            entity.HasKey(e => e.SCLIENT);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SACCOUNT_IN).HasMaxLength(1);
            entity.Property(e => e.SBLOCKADE).HasMaxLength(1);
            entity.Property(e => e.SFIRSTNAME).HasMaxLength(20);
            entity.Property(e => e.SLASTNAME).HasMaxLength(20);
            entity.Property(e => e.SLICENSE).HasMaxLength(10);
            entity.Property(e => e.STAX_CODE).HasMaxLength(12);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SSMOKING).HasMaxLength(1);
            entity.Property(e => e.SCUIT).HasMaxLength(14);
            entity.Property(e => e.SAUTO_CHAR).HasMaxLength(1);
            entity.Property(e => e.SCREDIT_CARD).HasMaxLength(1);
            entity.Property(e => e.SLEGALNAME).HasMaxLength(60);
            entity.Property(e => e.SLASTNAME2).HasMaxLength(20);
            entity.Property(e => e.SBILL_IND).HasMaxLength(1);
            entity.Property(e => e.SDIGIT).HasMaxLength(1);
            entity.Property(e => e.SCLIENAME).HasMaxLength(63);
            entity.Property(e => e.SLEDGERPROCESS).HasMaxLength(1);
            entity.Property(e => e.SCOMPLCOD).HasMaxLength(6);
            entity.Property(e => e.SFATCA).HasMaxLength(20);
            entity.Property(e => e.SCLIENTPEP).HasMaxLength(1);
            entity.Property(e => e.SUSPERSON).HasMaxLength(1);
            entity.Property(e => e.SCRS).HasMaxLength(1);
            entity.Property(e => e.SMARRIEDSURNAME).HasMaxLength(20);
            entity.Property(e => e.SSPOUSENAME).HasMaxLength(63);
            entity.Property(e => e.SOTHERTITLE).HasMaxLength(50);
            entity.Property(e => e.SOTHERSPECIALITY).HasMaxLength(50);
            entity.Property(e => e.NCLASEMPRESALEGAL).HasMaxLength(1);
        });

        modelBuilder.Entity<CLIENT_HIS>(entity =>
        {
            entity.ToTable("CLIENT_HIS", "INSUDB");
            entity.HasKey(e => new { e.SCLIENT, e.DEFFECDATE });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCLIENAME).HasMaxLength(63);
            entity.Property(e => e.SFIRSTNAME).HasMaxLength(20);
            entity.Property(e => e.SLASTNAME).HasMaxLength(20);
            entity.Property(e => e.SLASTNAME2).HasMaxLength(20);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SBLOCKADE).HasMaxLength(1);
            entity.Property(e => e.SLEGALNAME).HasMaxLength(60);
        });

        modelBuilder.Entity<CLIENT_REQ>(entity =>
        {
            entity.ToTable("CLIENT_REQ", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NROLE, e.NTRATYPEP, e.NFIELD, e.DEFFECDATE });
            entity.Property(e => e.SBIRTHDAI).HasMaxLength(1);
            entity.Property(e => e.SCIVISTAI).HasMaxLength(1);
            entity.Property(e => e.SREQUIRED).HasMaxLength(1);
            entity.Property(e => e.SOCCUPATI).HasMaxLength(1);
            entity.Property(e => e.SSEXINSUI).HasMaxLength(1);
            entity.Property(e => e.STAX_SITUA).HasMaxLength(1);
            entity.Property(e => e.SADDRESS).HasMaxLength(1);
            entity.Property(e => e.SCREDITLINE).HasMaxLength(1);
        });

        modelBuilder.Entity<CLIENT_SF>(entity =>
        {
            entity.ToTable("CLIENT_SF", "INSUDB");
            entity.HasKey(e => new { e.SCLIENT, e.DEFFECDATE, e.NTYPELIST });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SDIGIT).HasMaxLength(1);
            entity.Property(e => e.SUSADDRES).HasMaxLength(100);
            entity.Property(e => e.SUSLEGAL_PERSON).HasMaxLength(100);
            entity.Property(e => e.SUSPHONE).HasMaxLength(100);
            entity.Property(e => e.SUSACCOUNT).HasMaxLength(100);
            entity.Property(e => e.SSSN).HasMaxLength(12);
            entity.Property(e => e.SUS_ITINNUM).HasMaxLength(12);
            entity.Property(e => e.SUS_IRSIND).HasMaxLength(1);
            entity.Property(e => e.SPLACEBIRTH).HasMaxLength(30);
        });

        modelBuilder.Entity<CLIENT_TMP>(entity =>
        {
            entity.ToTable("CLIENT_TMP", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NGROUP, e.NROLE, e.NID });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.STYPEAGE).HasMaxLength(1);
            entity.Property(e => e.SVIP).HasMaxLength(1);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
        });

        modelBuilder.Entity<CLIENT_WIN>(entity =>
        {
            entity.ToTable("CLIENT_WIN", "INSUDB");
            entity.HasKey(e => new { e.SCLIENT, e.DEFFECDATE });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SV_CONCLIEN).HasMaxLength(20);
            entity.Property(e => e.SV_WINCLIEN).HasMaxLength(160);
        });

        modelBuilder.Entity<CL_M_COVER>(entity =>
        {
            entity.ToTable("CL_M_COVER", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.NTRANSAC, e.NCOVER, e.NMODULEC, e.NCURRENCY, e.SCLIENT });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SAUT_ADJUST).HasMaxLength(1);
            entity.Property(e => e.SCESCATAS).HasMaxLength(1);
            entity.Property(e => e.SPOSTEDSEQUENCE).HasMaxLength(100);
        });

        modelBuilder.Entity<CLORDER_ADDITIONALS>(entity =>
        {
            entity.ToTable("CLORDER_ADDITIONALS", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.NORDER_NUM, e.NADDITIONAL_ORDER });
            entity.Property(e => e.SMEDICATION).HasMaxLength(200);
        });

        modelBuilder.Entity<CLORDER_DETAIL>(entity =>
        {
            entity.ToTable("CLORDER_DETAIL", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.NORDER_NUM, e.NDETAIL_ORDER });
            entity.Property(e => e.SBENEFIT).HasMaxLength(10);
            entity.Property(e => e.VADEMECUM).HasMaxLength(10);
            entity.Property(e => e.SILLNES_DETECT).HasMaxLength(60);
            entity.Property(e => e.SREJECTALERT).HasMaxLength(2000);
            entity.Property(e => e.SILLNESS).HasMaxLength(8);
            entity.Property(e => e.SMEDSPECIALIALTY).HasMaxLength(5);
            entity.Property(e => e.SSECONDVISIT).HasMaxLength(1);
        });

        modelBuilder.Entity<CLORDER_DOCUMENTS>(entity =>
        {
            entity.ToTable("CLORDER_DOCUMENTS", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.SCLIENT, e.NID, e.NDOC_CODE, e.NCONSEC, e.NORDER_NUM, e.NCONSEC_ORDERDOC });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<CLORDER_HIS>(entity =>
        {
            entity.ToTable("CLORDER_HIS", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.NORDER_NUM, e.NMOVEMENT, e.NTRANSAC });
            entity.Property(e => e.STYPECARE).HasMaxLength(10);
            entity.Property(e => e.SIND_REV).HasMaxLength(1);
            entity.Property(e => e.SCARECLASS).HasMaxLength(10);
            entity.Property(e => e.SPREAUTHORIZATION).HasMaxLength(1);
            entity.Property(e => e.SPROLTREATMENT).HasMaxLength(1);
        });

        modelBuilder.Entity<COLFORMREF>(entity =>
        {
            entity.ToTable("COLFORMREF", "INSUDB");
            entity.HasKey(e => e.NBORDEREAUX);
            entity.Property(e => e.STYPE).HasMaxLength(1);
            entity.Property(e => e.SREL_TYPE).HasMaxLength(1);
            entity.Property(e => e.SSTATUS).HasMaxLength(1);
            entity.Property(e => e.SCONWIN).HasMaxLength(5);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SIND_ANNUITY).HasMaxLength(1);
            entity.Property(e => e.SRELORIGI).HasMaxLength(1);
        });

        modelBuilder.Entity<COLLECTOR>(entity =>
        {
            entity.ToTable("COLLECTOR", "INSUDB");
            entity.HasKey(e => e.NCOLLECTOR);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<COLSHEET>(entity =>
        {
            entity.ToTable("COLSHEET", "INSUDB");
            entity.HasKey(e => new { e.NID, e.NIDREC });
            entity.Property(e => e.SCOLUMNNAME).HasMaxLength(30);
            entity.Property(e => e.SSELECTED).HasMaxLength(1);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
            entity.Property(e => e.SVALUE).HasMaxLength(50);
        });

        modelBuilder.Entity<COMMIS_HIS>(entity =>
        {
            entity.ToTable("COMMIS_HIS", "INSUDB");
            entity.HasKey(e => new { e.NINTERMED, e.STYP_COMISS, e.DEFFECDATE });
            entity.Property(e => e.STYP_COMISS).HasMaxLength(1);
        });

        modelBuilder.Entity<COMMISSION>(entity =>
        {
            entity.ToTable("COMMISSION", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NINTERTYP, e.NINTERMED, e.DEFFECDATE, e.NCERTIF });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCOMMITYP).HasMaxLength(1);
            entity.Property(e => e.SPLUSCOLLEC).HasMaxLength(1);
            entity.Property(e => e.SPLUSOFFICE).HasMaxLength(1);
            entity.Property(e => e.SPLUSQUALITY).HasMaxLength(1);
        });

        modelBuilder.Entity<COMMISS_PR>(entity =>
        {
            entity.ToTable("COMMISS_PR", "INSUDB");
            entity.HasKey(e => new { e.NRECEIPT, e.NPRODUCT, e.NBRANCH, e.SCERTYPE, e.NDIGIT, e.NPAYNUMBE, e.NINTERMED });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
        });

        modelBuilder.Entity<COMMPAYMENTREQUESTS>(entity =>
        {
            entity.ToTable("COMMPAYMENTREQUESTS", "INSUDB");
            entity.HasKey(e => e.NID_COMMPAYREQ);
            entity.Property(e => e.SCLIENT_HOLDER).HasMaxLength(14);
            entity.Property(e => e.SCLIENAME_HOLDER).HasMaxLength(63);
            entity.Property(e => e.SCLIENT_INSURED).HasMaxLength(14);
            entity.Property(e => e.SCLIENAME_INSURED).HasMaxLength(63);
            entity.Property(e => e.SCLIENT_AFFECT).HasMaxLength(14);
            entity.Property(e => e.SCLIENAME_AFFECT).HasMaxLength(63);
            entity.Property(e => e.STYPECARE_PRECLAIM).HasMaxLength(10);
            entity.Property(e => e.SIND_RESULT).HasMaxLength(1);
            entity.Property(e => e.SIND_ASSUMEIVA).HasMaxLength(1);
            entity.Property(e => e.SCLIENAME_AUTHORIZER1).HasMaxLength(63);
            entity.Property(e => e.SPOSITION_AUTHORIZER1).HasMaxLength(50);
            entity.Property(e => e.SCLIENAME_AUTHORIZER2).HasMaxLength(63);
            entity.Property(e => e.SPOSITION_AUTHORIZER2).HasMaxLength(50);
            entity.Property(e => e.SADDRESSEDTO).HasMaxLength(63);
        });

        modelBuilder.Entity<COMMPAYREQ_HIS>(entity =>
        {
            entity.ToTable("COMMPAYREQ_HIS", "INSUDB");
            entity.HasKey(e => new { e.NID_COMMPAYREQ, e.NMOVEMENT });
            entity.Property(e => e.SIND_RESULT).HasMaxLength(1);
            entity.Property(e => e.SIND_ASSUMEIVA).HasMaxLength(1);
        });

        modelBuilder.Entity<COMMPAYREQ_ORDERS>(entity =>
        {
            entity.ToTable("COMMPAYREQ_ORDERS", "INSUDB");
            entity.HasKey(e => new { e.NID_COMMPAYREQ, e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.NORDER_NUM });
            entity.Property(e => e.STYPECARE).HasMaxLength(10);
        });

        modelBuilder.Entity<COMMPAYREQ_POLICIES>(entity =>
        {
            entity.ToTable("COMMPAYREQ_POLICIES", "INSUDB");
            entity.HasKey(e => new { e.NID_COMMPAYREQ, e.NCONSEC });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENAME_INTERMEDIA).HasMaxLength(63);
        });

        modelBuilder.Entity<COMM_POL>(entity =>
        {
            entity.ToTable("COMM_POL", "INSUDB");
            entity.HasKey(e => new { e.NINTERMED, e.NCURRENCY, e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NID });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.STYP_COMM).HasMaxLength(1);
            entity.Property(e => e.STYPEDOCU).HasMaxLength(1);
            entity.Property(e => e.SIND_DESC).HasMaxLength(1);
            entity.Property(e => e.SIND_BALANCE).HasMaxLength(1);
        });

        modelBuilder.Entity<COMM_TOT>(entity =>
        {
            entity.ToTable("COMM_TOT", "INSUDB");
            entity.HasKey(e => e.NCOMM);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
        });

        modelBuilder.Entity<COMPANY>(entity =>
        {
            entity.ToTable("COMPANY", "INSUDB");
            entity.HasKey(e => e.NCOMPANY);
            entity.Property(e => e.SACCOUNT).HasMaxLength(25);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SBANKNAME).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.STYPE).HasMaxLength(1);
            entity.Property(e => e.SREGSVS).HasMaxLength(18);
            entity.Property(e => e.SNATIONAL).HasMaxLength(1);
            entity.Property(e => e.SABA_ID).HasMaxLength(10);
            entity.Property(e => e.SWIFT_IT).HasMaxLength(10);
            entity.Property(e => e.SCITY).HasMaxLength(10);
            entity.Property(e => e.NBANKCOUNTRY).HasMaxLength(10);
        });

        modelBuilder.Entity<CONTRAT_PAY>(entity =>
        {
            entity.ToTable("CONTRAT_PAY", "INSUDB");
            entity.HasKey(e => new { e.NCONTRAT_PAY, e.NTYPE_CONTRAT });
            entity.Property(e => e.STYP_COM_IND).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.STAXIN).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
        });

        modelBuilder.Entity<CONTR_CESCOV>(entity =>
        {
            entity.ToTable("CONTR_CESCOV", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH_REI, e.DEFFECDATE, e.NNUMBER, e.NTYPE, e.NINSUR_AREA, e.NCOVERGEN, e.NCOMPANY });
            entity.Property(e => e.SROUCESS).HasMaxLength(12);
            entity.Property(e => e.SINOTHERCOV).HasMaxLength(1);
            entity.Property(e => e.SMORTACOF).HasMaxLength(30);
            entity.Property(e => e.SMORTACOM).HasMaxLength(30);
        });

        modelBuilder.Entity<CONTR_LIMCOV>(entity =>
        {
            entity.ToTable("CONTR_LIMCOV", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH_REI, e.DEFFECDATE, e.NNUMBER, e.NTYPE, e.NINSUR_AREA, e.NCOVERGEN });
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
        });

        modelBuilder.Entity<CONTRMASTER>(entity =>
        {
            entity.ToTable("CONTRMASTER", "INSUDB");
            entity.HasKey(e => new { e.NTYPE_REL, e.NNUMBER, e.NTYPE, e.NBRANCH });
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SFORMPAY).HasMaxLength(1);
        });

        modelBuilder.Entity<CONTRNP_PAYS>(entity =>
        {
            entity.ToTable("CONTRNP_PAYS", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH_REI, e.DEFFECDATE, e.NNUMBER, e.NTYPE, e.NMONTH, e.NYEAR });
            entity.Property(e => e.SCUENTECN).HasMaxLength(1);
        });

        modelBuilder.Entity<CONTRNPRO>(entity =>
        {
            entity.ToTable("CONTRNPRO", "INSUDB");
            entity.HasKey(e => new { e.NNUMBER, e.NBRANCH, e.DEFFECDATE, e.NTYPE });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SREINSURAN).HasMaxLength(1);
            entity.Property(e => e.SROUCESSPR).HasMaxLength(12);
            entity.Property(e => e.SROUCESSCL).HasMaxLength(12);
            entity.Property(e => e.SAGREEMENTPAYS).HasMaxLength(1);
            entity.Property(e => e.SROUNETRET).HasMaxLength(12);
            entity.Property(e => e.SPRORATEREP).HasMaxLength(1);
        });

        modelBuilder.Entity<CONTRPROC>(entity =>
        {
            entity.ToTable("CONTRPROC", "INSUDB");
            entity.HasKey(e => new { e.NNUMBER, e.NBRANCH, e.DEFFECDATE, e.NTYPE });
            entity.Property(e => e.SCAP_NOM_RI).HasMaxLength(1);
            entity.Property(e => e.SRESER_CLAI).HasMaxLength(1);
            entity.Property(e => e.STAB_LIMIT).HasMaxLength(1);
            entity.Property(e => e.SRETCOVER).HasMaxLength(1);
            entity.Property(e => e.SLIMITCOV).HasMaxLength(1);
            entity.Property(e => e.SCESSPRCOV).HasMaxLength(1);
            entity.Property(e => e.SEXTRAPREM).HasMaxLength(1);
            entity.Property(e => e.SGENCESS).HasMaxLength(1);
            entity.Property(e => e.SROUPROFIT).HasMaxLength(12);
            entity.Property(e => e.SCOMMCOV).HasMaxLength(1);
            entity.Property(e => e.SCUMULTYP).HasMaxLength(1);
            entity.Property(e => e.SCUMREINT).HasMaxLength(1);
            entity.Property(e => e.SCUMULPOL).HasMaxLength(1);
            entity.Property(e => e.SRETZONE).HasMaxLength(1);
            entity.Property(e => e.SCESSCIA).HasMaxLength(1);
            entity.Property(e => e.SROUCESS).HasMaxLength(12);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

        modelBuilder.Entity<COVER>(entity =>
        {
            entity.ToTable("COVER", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NGROUP_INSU, e.NMODULEC, e.NCOVER, e.DEFFECDATE, e.SCLIENT });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCHANGE).HasMaxLength(1);
            entity.Property(e => e.SFRANDEDI).HasMaxLength(1);
            entity.Property(e => e.SFREE_PREMI).HasMaxLength(1);
            entity.Property(e => e.SWAIT_TYPE).HasMaxLength(1);
            entity.Property(e => e.SFRANCAPL).HasMaxLength(1);
            entity.Property(e => e.SROUTMAX_EVEN).HasMaxLength(12);
            entity.Property(e => e.SREDUCCAPITAL).HasMaxLength(1);
            entity.Property(e => e.SCOVERCHANGE).HasMaxLength(1);
        });

        modelBuilder.Entity<COVER_CO_G>(entity =>
        {
            entity.ToTable("COVER_CO_G", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NGROUP, e.NMODULEC, e.NCOVER, e.DEFFECDATE, e.NROLE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCHANGE).HasMaxLength(1);
            entity.Property(e => e.SFRANDEDI).HasMaxLength(1);
            entity.Property(e => e.SWAIT_TYPE).HasMaxLength(1);
            entity.Property(e => e.SFRANCAPL).HasMaxLength(1);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SREQUIRED).HasMaxLength(1);
            entity.Property(e => e.SROUTMAX_EVEN).HasMaxLength(12);
        });

        modelBuilder.Entity<COVER_CO_P>(entity =>
        {
            entity.ToTable("COVER_CO_P", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NMODULEC, e.NCOVER, e.DEFFECDATE, e.NROLE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCHANGE).HasMaxLength(1);
            entity.Property(e => e.SFRANDEDI).HasMaxLength(1);
            entity.Property(e => e.SWAIT_TYPE).HasMaxLength(1);
            entity.Property(e => e.SFRANCAPL).HasMaxLength(1);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SREQUIRED).HasMaxLength(1);
            entity.Property(e => e.SROUTMAX_EVEN).HasMaxLength(12);
        });

        modelBuilder.Entity<COVER_QUOTA>(entity =>
        {
            entity.ToTable("COVER_QUOTA", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NGROUP, e.NMODULEC, e.NROLE, e.NCOVER });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
        });

        modelBuilder.Entity<COVER_TMP>(entity =>
        {
            entity.ToTable("COVER_TMP", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NIDCONSEC });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SVALUE).HasMaxLength(60);
            entity.Property(e => e.SSECTION).HasMaxLength(2);
            entity.Property(e => e.SDATATYPE).HasMaxLength(1);
            entity.Property(e => e.SUPDATE).HasMaxLength(1);
        });

        modelBuilder.Entity<COV_USED>(entity =>
        {
            entity.ToTable("COV_USED", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NCASE_NUM, e.NDEMAN_TYPE, e.NTRANSAC, e.NMODULEC, e.NCOVER, e.NCURRENCY, e.SCLIENT, e.NCON_ID });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SPURPOSE).HasMaxLength(8);
        });

        modelBuilder.Entity<CRED_CARD>(entity =>
        {
            entity.ToTable("CRED_CARD", "INSUDB");
            entity.HasKey(e => new { e.SCLIENT, e.NBANKEXT, e.SCREDI_CARD });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCREDI_CARD).HasMaxLength(100);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.STYP_DIRDEB).HasMaxLength(1);
        });

        modelBuilder.Entity<CTROL_DATE>(entity =>
        {
            entity.ToTable("CTROL_DATE", "INSUDB");
            entity.HasKey(e => e.NTYPE_PROCE);
        });

        modelBuilder.Entity<CUENTECN>(entity =>
        {
            entity.ToTable("CUENTECN", "INSUDB");
            entity.HasKey(e => e.NIDCONSEC);
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
            entity.Property(e => e.SMOVE_ACC).HasMaxLength(1);
            entity.Property(e => e.SPRINT).HasMaxLength(1);
            entity.Property(e => e.SACTIVE).HasMaxLength(1);
        });

        modelBuilder.Entity<CUR_ALLOW>(entity =>
        {
            entity.ToTable("CUR_ALLOW", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NCURRENCY, e.DEFFECDATE });
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
        });

        modelBuilder.Entity<CURR_ACC>(entity =>
        {
            entity.ToTable("CURR_ACC", "INSUDB");
            entity.HasKey(e => new { e.NTYP_ACCO, e.STYPE_ACC, e.SCLIENT, e.NCURRENCY });
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SACCOUNT).HasMaxLength(20);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SAUX_ACCOUN).HasMaxLength(20);
        });

        modelBuilder.Entity<CURREN_POL>(entity =>
        {
            entity.ToTable("CURREN_POL", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NCURRENCY, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
        });

        modelBuilder.Entity<DEPEND_SHEET>(entity =>
        {
            entity.ToTable("DEPEND_SHEET", "INSUDB");
            entity.HasKey(e => new { e.NSHEET_FATHER, e.NSHEET_CHILD });
        });

        modelBuilder.Entity<DETAIL_PRE>(entity =>
        {
            entity.ToTable("DETAIL_PRE", "INSUDB");
            entity.HasKey(e => new { e.NPRODUCT, e.NRECEIPT, e.NBRANCH, e.SCERTYPE, e.NDIGIT, e.NPAYNUMBE, e.NID_BILL });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SADDSUINI).HasMaxLength(1);
            entity.Property(e => e.STYPE_DETAI).HasMaxLength(1);
            entity.Property(e => e.SADDTAX).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<DETAIL_PRE_INI>(entity =>
        {
            entity.ToTable("DETAIL_PRE_INI", "INSUDB");
            entity.HasKey(e => new { e.NPRODUCT, e.NRECEIPT, e.NBRANCH, e.SCERTYPE, e.NDIGIT, e.NPAYNUMBE, e.NID_BILL });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SADDSUINI).HasMaxLength(1);
            entity.Property(e => e.STYPE_DETAI).HasMaxLength(1);
            entity.Property(e => e.SADDTAX).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<DET_COMLIF>(entity =>
        {
            entity.ToTable("DET_COMLIF", "INSUDB");
            entity.HasKey(e => new { e.NCOMTABLI, e.NBRANCH, e.NPRODUCT, e.NPOLICY_DUR, e.NMIN_DURAT, e.DEFFECDATE, e.NWAY_PAY, e.NSELLCHANNEL, e.NCOVER, e.NMODULEC, e.NTYPE_CONTRAT, e.NCATEGORY });
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
            entity.Property(e => e.SSMOKING).HasMaxLength(1);
        });

        modelBuilder.Entity<DEVLOCALRECORDSDELETED>(entity =>
        {
            entity.ToTable("DEVLOCALRECORDSDELETED", "INSUDB");
            entity.HasKey(e => new { e.LOCALRECDELID, e.NAME });
            entity.Property(e => e.NAME).HasMaxLength(30);
            entity.Property(e => e.PKEY).HasMaxLength(120);
        });

        modelBuilder.Entity<DIR_DEBIT>(entity =>
        {
            entity.ToTable("DIR_DEBIT", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SACCOUNT).HasMaxLength(100);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCREDI_CARD).HasMaxLength(100);
            entity.Property(e => e.STYP_DIRDEB).HasMaxLength(5);
            entity.Property(e => e.SBANKAUTH).HasMaxLength(30);
            entity.Property(e => e.SREUSE).HasMaxLength(1);
            entity.Property(e => e.SDEBIT_CARD).HasMaxLength(100);
        });

        modelBuilder.Entity<DIR_DEBIT_CLI>(entity =>
        {
            entity.ToTable("DIR_DEBIT_CLI", "INSUDB");
            entity.HasKey(e => new { e.SCLIENT, e.DEFFECDATE });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SACCOUNT).HasMaxLength(100);
            entity.Property(e => e.STYP_DIRDEB).HasMaxLength(1);
            entity.Property(e => e.SBANKAUTH).HasMaxLength(30);
        });

        modelBuilder.Entity<DISCO_EXPR>(entity =>
        {
            entity.ToTable("DISCO_EXPR", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NDISEXPRC, e.DEFFECDATE });
            entity.Property(e => e.SCHANALLO).HasMaxLength(1);
            entity.Property(e => e.SCOMMISSI_I).HasMaxLength(1);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SDEVOALLO).HasMaxLength(1);
            entity.Property(e => e.SEDPERAPL).HasMaxLength(1);
            entity.Property(e => e.SPRORATE).HasMaxLength(1);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SDISEXPRI).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SDEFPOL).HasMaxLength(1);
            entity.Property(e => e.STYPMAR).HasMaxLength(1);
            entity.Property(e => e.SIVA).HasMaxLength(1);
            entity.Property(e => e.SIND_STIPENDS).HasMaxLength(1);
        });

        modelBuilder.Entity<DISC_XPRE_G>(entity =>
        {
            entity.ToTable("DISC_XPRE_G", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NGROUP, e.NDISC_CODE, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
        });

        modelBuilder.Entity<DISC_XPREM>(entity =>
        {
            entity.ToTable("DISC_XPREM", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NDISC_CODE, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SAGREE).HasMaxLength(1);
        });

        modelBuilder.Entity<DISC_XPRE_P>(entity =>
        {
            entity.ToTable("DISC_XPRE_P", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NDISC_CODE, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
        });

        modelBuilder.Entity<DISEX_INT_M>(entity =>
        {
            entity.ToTable("DISEX_INT_M", "INSUDB");
            entity.HasKey(e => e.NECO_SCHE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<DOC_REQ_CLI>(entity =>
        {
            entity.ToTable("DOC_REQ_CLI", "INSUDB");
            entity.HasKey(e => new { e.NEVAL, e.NID });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(40);
            entity.Property(e => e.SREQUEST).HasMaxLength(1);
        });

        modelBuilder.Entity<DOCUMENTS>(entity =>
        {
            entity.ToTable("DOCUMENTS", "INSUDB");
            entity.HasKey(e => new { e.NCLAIM, e.NDOC_CODE, e.NCASE_NUM, e.NDEMAN_TYPE, e.SCLIENT, e.NID, e.NCONSEC });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SOBSERVATIONS).HasMaxLength(60);
        });

        modelBuilder.Entity<DOCUMENTS_PRECLAIM>(entity =>
        {
            entity.ToTable("DOCUMENTS_PRECLAIM", "INSUDB");
            entity.HasKey(e => new { e.NIDPRECLAIM, e.NCONSEC });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SOBSERVATIONS).HasMaxLength(60);
        });

        modelBuilder.Entity<DRAFT_HIST>(entity =>
        {
            entity.ToTable("DRAFT_HIST", "INSUDB");
            entity.HasKey(e => new { e.NCONTRAT, e.NTRANSAC, e.NDRAFT });
            entity.Property(e => e.SINTERMEI).HasMaxLength(1);
            entity.Property(e => e.SDOCNUMBE).HasMaxLength(30);
            entity.Property(e => e.SPAY_FORM).HasMaxLength(2);
            entity.Property(e => e.SCHANGE_ACC).HasMaxLength(20);
            entity.Property(e => e.SAUX_ACCOUN).HasMaxLength(20);
            entity.Property(e => e.SCESSICOI).HasMaxLength(1);
            entity.Property(e => e.SIND_REVER).HasMaxLength(1);
        });

        modelBuilder.Entity<DSEX_CONDI>(entity =>
        {
            entity.ToTable("DSEX_CONDI", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NDISEXPRC, e.NAPLICATION, e.NCODE, e.DEFFECDATE, e.NMODULEC, e.NROLE });
        });

        modelBuilder.Entity<DURINSU_PROD>(entity =>
        {
            entity.ToTable("DURINSU_PROD", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.DEFFECDATE, e.NIDURAFIX, e.NTYPDURINS });
        });

        modelBuilder.Entity<DURPAY_PROD>(entity =>
        {
            entity.ToTable("DURPAY_PROD", "INSUDB");
            entity.HasKey(e => new { e.NID, e.DEFFECDATE, e.NBRANCH, e.NPRODUCT });
        });

        modelBuilder.Entity<EVAL_MASTER>(entity =>
        {
            entity.ToTable("EVAL_MASTER", "INSUDB");
            entity.HasKey(e => e.NEVAL);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
        });

        modelBuilder.Entity<EXCHANGE>(entity =>
        {
            entity.ToTable("EXCHANGE", "INSUDB");
            entity.HasKey(e => new { e.NCURRENCY, e.DEFFECDATE });
        });

        modelBuilder.Entity<FIELDSHEET>(entity =>
        {
            entity.ToTable("FIELDSHEET", "INSUDB");
            entity.HasKey(e => new { e.NSHEET, e.NFIELD });
            entity.Property(e => e.STABLE).HasMaxLength(40);
            entity.Property(e => e.SFIELDDESC).HasMaxLength(30);
            entity.Property(e => e.SCOLUMNNAME).HasMaxLength(30);
            entity.Property(e => e.SVALUE).HasMaxLength(60);
            entity.Property(e => e.SRUTINE).HasMaxLength(60);
            entity.Property(e => e.SVALUESLIST).HasMaxLength(500);
            entity.Property(e => e.SFIELDCOMMEN).HasMaxLength(50);
            entity.Property(e => e.SFIELDREL).HasMaxLength(100);
            entity.Property(e => e.SOBLIGATORY).HasMaxLength(1);
            entity.Property(e => e.SLASTMOVE).HasMaxLength(1);
            entity.Property(e => e.SRPARENTH).HasMaxLength(1);
            entity.Property(e => e.SLPARENTH).HasMaxLength(1);
            entity.Property(e => e.SREPORT).HasMaxLength(1);
            entity.Property(e => e.LPADVAR).HasMaxLength(30);
            entity.Property(e => e.RPADVAR).HasMaxLength(30);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SUPDATEIND).HasMaxLength(1);
        });

        modelBuilder.Entity<FINANC_COM>(entity =>
        {
            entity.ToTable("FINANC_COM", "INSUDB");
            entity.HasKey(e => new { e.NRECEIPT, e.NCONTRAT, e.NINTERMED });
        });

        modelBuilder.Entity<FINANC_DRA>(entity =>
        {
            entity.ToTable("FINANC_DRA", "INSUDB");
            entity.HasKey(e => new { e.NCONTRAT, e.NDRAFT });
            entity.Property(e => e.SINDCHEQUE).HasMaxLength(1);
            entity.Property(e => e.SSUS_ORIGI).HasMaxLength(1);
            entity.Property(e => e.SBILLTYPE).HasMaxLength(1);
            entity.Property(e => e.SDOCNUMBE).HasMaxLength(10);
            entity.Property(e => e.NRETENTIONSERIES).HasMaxLength(15);
            entity.Property(e => e.NAUTORIZATIONNUMBER).HasMaxLength(37);
        });

        modelBuilder.Entity<FINANCE_CO>(entity =>
        {
            entity.ToTable("FINANCE_CO", "INSUDB");
            entity.HasKey(e => new { e.NCONTRAT, e.DEFFECDATE });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SOPT_COMMI).HasMaxLength(1);
            entity.Property(e => e.SPAYMENT_IN).HasMaxLength(1);
            entity.Property(e => e.SWAIT_CONTR).HasMaxLength(1);
            entity.Property(e => e.STYPE_CONTR).HasMaxLength(1);
            entity.Property(e => e.SORIGIN).HasMaxLength(1);
        });

        modelBuilder.Entity<FINANC_PRE>(entity =>
        {
            entity.ToTable("FINANC_PRE", "INSUDB");
            entity.HasKey(e => new { e.NCONTRAT, e.NRECEIPT });
            entity.Property(e => e.SSTAT_FINPR).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SEXTRECEIPT).HasMaxLength(1);
        });

        modelBuilder.Entity<FINANC_WIN>(entity =>
        {
            entity.ToTable("FINANC_WIN", "INSUDB");
            entity.HasKey(e => e.NCONTRAT);
            entity.Property(e => e.SV_CONCONTR).HasMaxLength(30);
            entity.Property(e => e.SV_WINCONTR).HasMaxLength(240);
        });

        modelBuilder.Entity<FOLDERS>(entity =>
        {
            entity.ToTable("FOLDERS", "INSUDB");
            entity.HasKey(e => e.NFOLDER);
            entity.Property(e => e.SFOLDERNAME).HasMaxLength(30);
            entity.Property(e => e.SROOTNAME).HasMaxLength(30);
            entity.Property(e => e.SCLASS).HasMaxLength(30);
            entity.Property(e => e.SFOLDERKEY).HasMaxLength(25);
            entity.Property(e => e.SORIGI).HasMaxLength(1);
        });

        modelBuilder.Entity<FORMATVALUES>(entity =>
        {
            entity.ToTable("FORMATVALUES", "INSUDB");
            entity.HasKey(e => new { e.NTYPCLIENTDOC, e.NCLASSTYPDOC });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SFORMAT).HasMaxLength(25);
            entity.Property(e => e.STYPPERSON).HasMaxLength(1);
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<FREQ_WAY_PROD>(entity =>
        {
            entity.ToTable("FREQ_WAY_PROD", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NWAY_PAY, e.NPAYFREQ, e.DEFFECDATE });
            entity.Property(e => e.SIVA_COVER_IND).HasMaxLength(1);
            entity.Property(e => e.SNO_SELL).HasMaxLength(1);
        });

        modelBuilder.Entity<GROUP_COLUMNS>(entity =>
        {
            entity.ToTable("GROUP_COLUMNS", "INSUDB");
            entity.HasKey(e => e.NIDREC);
            entity.Property(e => e.SFIELD).HasMaxLength(30);
            entity.Property(e => e.SCOLUMNNAME).HasMaxLength(30);
            entity.Property(e => e.SVALUESLIST).HasMaxLength(30);
            entity.Property(e => e.STABLE).HasMaxLength(30);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
            entity.Property(e => e.SCOMMENT).HasMaxLength(30);
            entity.Property(e => e.SUPDATEIND).HasMaxLength(1);
        });

        modelBuilder.Entity<GROUPPARAMS>(entity =>
        {
            entity.ToTable("GROUPPARAMS", "INSUDB");
            entity.HasKey(e => e.NLETT_GROUP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SPARAMETERS).HasMaxLength(7);
        });

        modelBuilder.Entity<GROUPS>(entity =>
        {
            entity.ToTable("GROUPS", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPOLICY, e.NPRODUCT, e.NGROUP, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<GROUPVARIABLES>(entity =>
        {
            entity.ToTable("GROUPVARIABLES", "INSUDB");
            entity.HasKey(e => new { e.NLETT_GROUP, e.SVARIABLE });
            entity.Property(e => e.SVARIABLE).HasMaxLength(12);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.STABLENAME).HasMaxLength(20);
            entity.Property(e => e.SCOLUMNAME).HasMaxLength(30);
            entity.Property(e => e.STABVALUE).HasMaxLength(12);
            entity.Property(e => e.SALIASTABLE).HasMaxLength(30);
            entity.Property(e => e.SALIASCOLUMN).HasMaxLength(30);
        });

        modelBuilder.Entity<H_ASSIGNMENT_PART>(entity =>
        {
            entity.ToTable("H_ASSIGNMENT_PART", "INSUDB");
            entity.HasKey(e => e.NID_NUMREG);
            entity.Property(e => e.STEMPASSI).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<HEALTHCLAIMFORM>(entity =>
        {
            entity.ToTable("HEALTHCLAIMFORM", "INSUDB");
            entity.HasKey(e => new { e.FORMID, e.MODELID });
            entity.Property(e => e.CLIENTE).HasMaxLength(14);
            entity.Property(e => e.FORMULARIO).HasMaxLength(30);
            entity.Property(e => e.FORMID).HasMaxLength(36);
            entity.Property(e => e.MODELID).HasMaxLength(36);
            entity.Property(e => e.USERID).HasMaxLength(256);
        });

        modelBuilder.Entity<HIS_ASC_I>(entity =>
        {
            entity.ToTable("HIS_ASC_I", "INSUDB");
            entity.HasKey(e => e.NID);
            entity.Property(e => e.SASCII_NAME).HasMaxLength(35);
            entity.Property(e => e.SPAY_FORM).HasMaxLength(2);
            entity.Property(e => e.SACC_NUMBER).HasMaxLength(100);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SACCOUNTHOLDER).HasMaxLength(63);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SBANKACCOUNT).HasMaxLength(100);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<HIS_ASC_II>(entity =>
        {
            entity.ToTable("HIS_ASC_II", "INSUDB");
            entity.HasKey(e => new { e.NID_UPLOAD, e.NID });
            entity.Property(e => e.SBANK_ORI).HasMaxLength(30);
            entity.Property(e => e.SUNIQ_CODE).HasMaxLength(30);
            entity.Property(e => e.SCURRENCY).HasMaxLength(30);
            entity.Property(e => e.SPAY_MET).HasMaxLength(30);
            entity.Property(e => e.SCONCEPT).HasMaxLength(30);
            entity.Property(e => e.SREFERENCE).HasMaxLength(30);
            entity.Property(e => e.SDOC_TYPE).HasMaxLength(30);
            entity.Property(e => e.SCLIENAME).HasMaxLength(63);
            entity.Property(e => e.SPHON_BEN).HasMaxLength(12);
            entity.Property(e => e.SBANKACCOUNT).HasMaxLength(100);
            entity.Property(e => e.SBANKEXT).HasMaxLength(30);
            entity.Property(e => e.SSTATUS).HasMaxLength(30);
            entity.Property(e => e.SREASON).HasMaxLength(100);
            entity.Property(e => e.SDETAIL).HasMaxLength(100);
            entity.Property(e => e.SSTATMOV).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.NDOCUMENT).HasMaxLength(18);
        });

        modelBuilder.Entity<HOBBY>(entity =>
        {
            entity.ToTable("HOBBY", "INSUDB");
            entity.HasKey(e => new { e.NHOBBY, e.SCLIENT });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<HOLLIDAYS>(entity =>
        {
            entity.ToTable("HOLLIDAYS", "INSUDB");
            entity.HasKey(e => new { e.NMONTH, e.NDAY, e.NCOUNTRY });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
        });

        modelBuilder.Entity<IMAGES>(entity =>
        {
            entity.ToTable("IMAGES", "INSUDB");
            entity.HasKey(e => new { e.NIMAGENUM, e.NCONSEC });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
        });

        modelBuilder.Entity<INQUIRY_AS>(entity =>
        {
            entity.ToTable("INQUIRY_AS", "INSUDB");
            entity.HasKey(e => new { e.NKEYNUM, e.SCODISPL });
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
        });

        modelBuilder.Entity<INSURED_EXPDIS>(entity =>
        {
            entity.ToTable("INSURED_EXPDIS", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NGROUP_INSU, e.SCLIENT, e.NDISEXPRC, e.NMODULEC, e.NCOVER, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SDISEXPRI).HasMaxLength(1);
            entity.Property(e => e.SUNIT).HasMaxLength(1);
            entity.Property(e => e.SPERM_TEMP).HasMaxLength(1);
            entity.Property(e => e.SAGREE).HasMaxLength(1);
            entity.Property(e => e.SINITDATE_CALC).HasMaxLength(1);
        });

        modelBuilder.Entity<INTERMED_HIS>(entity =>
        {
            entity.ToTable("INTERMED_HIS", "INSUDB");
            entity.HasKey(e => new { e.NINTERMED, e.DEFFECDATE });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

        modelBuilder.Entity<INTERMEDIA>(entity =>
        {
            entity.ToTable("INTERMEDIA", "INSUDB");
            entity.HasKey(e => e.NINTERMED);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCOL_AGREE).HasMaxLength(1);
            entity.Property(e => e.SINTER_ID).HasMaxLength(18);
            entity.Property(e => e.SAGREEINT).HasMaxLength(1);
            entity.Property(e => e.SLIFE).HasMaxLength(1);
            entity.Property(e => e.SNONLIFE).HasMaxLength(1);
            entity.Property(e => e.SVALID).HasMaxLength(1);
            entity.Property(e => e.SPERSIS).HasMaxLength(1);
            entity.Property(e => e.SCODAGENT_SCAB).HasMaxLength(15);
        });

        modelBuilder.Entity<INTERMED_PARTIC>(entity =>
        {
            entity.ToTable("INTERMED_PARTIC", "INSUDB");
            entity.HasKey(e => e.NINTERMED);
        });

        modelBuilder.Entity<INTERM_TYP>(entity =>
        {
            entity.ToTable("INTERM_TYP", "INSUDB");
            entity.HasKey(e => e.NINTERTYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SPARTICIN).HasMaxLength(1);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SIND_FECU).HasMaxLength(1);
            entity.Property(e => e.SGEN_CERTIF).HasMaxLength(1);
        });

        modelBuilder.Entity<INT_FIXVAL>(entity =>
        {
            entity.ToTable("INT_FIXVAL", "INSUDB");
            entity.HasKey(e => new { e.NCODE, e.DEFFECDATE });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

        modelBuilder.Entity<LATEPAYMENTPENALTY>(entity =>
        {
            entity.ToTable("LATEPAYMENTPENALTY", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NDAY_INI, e.DEFFECTDATE });
        });

        modelBuilder.Entity<LED_COMPAN>(entity =>
        {
            entity.ToTable("LED_COMPAN", "INSUDB");
            entity.HasKey(e => e.NLED_COMPAN);
            entity.Property(e => e.SACCOUNT_BG).HasMaxLength(20);
            entity.Property(e => e.SACCOUNT_GP).HasMaxLength(20);
            entity.Property(e => e.SBAL_ACTU).HasMaxLength(1);
            entity.Property(e => e.SCLOSE_MONT).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SSTRUCT_UNI).HasMaxLength(3);
            entity.Property(e => e.SSTRUCTURE).HasMaxLength(7);
        });

        modelBuilder.Entity<LEDGER_ACC>(entity =>
        {
            entity.ToTable("LEDGER_ACC", "INSUDB");
            entity.HasKey(e => new { e.NLED_COMPAN, e.SACCOUNT, e.SAUX_ACCOUN });
            entity.Property(e => e.SACCOUNT).HasMaxLength(20);
            entity.Property(e => e.SAUX_ACCOUN).HasMaxLength(20);
            entity.Property(e => e.SADJU_EXCI).HasMaxLength(1);
            entity.Property(e => e.SBLOCK_CRE).HasMaxLength(1);
            entity.Property(e => e.SBLOCK_DEB).HasMaxLength(1);
            entity.Property(e => e.SBUDGET_IND).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(50);
            entity.Property(e => e.SORGAN_UNIT).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
        });

        modelBuilder.Entity<LEND_AGREE_PRES>(entity =>
        {
            entity.ToTable("LEND_AGREE_PRES", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NGROUP, e.NMODULEC, e.NCOVER, e.SCLIENT, e.NPRESTAC, e.NCOD_AGREE, e.NCITY_RESIDENCE, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<LEND_AGREE_PROD>(entity =>
        {
            entity.ToTable("LEND_AGREE_PROD", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NCOD_AGREE, e.DEFFECDATE });
        });

        modelBuilder.Entity<LEVELS>(entity =>
        {
            entity.ToTable("LEVELS", "INSUDB");
            entity.HasKey(e => new { e.SSCHE_CODE, e.SIND_TYPE, e.SCODE_MT });
            entity.Property(e => e.SSCHE_CODE).HasMaxLength(6);
            entity.Property(e => e.SIND_TYPE).HasMaxLength(1);
            entity.Property(e => e.SCODE_MT).HasMaxLength(8);
            entity.Property(e => e.SSUPERVIS).HasMaxLength(1);
            entity.Property(e => e.SPERMITTED).HasMaxLength(1);
            entity.Property(e => e.SENCRYPTED).HasMaxLength(1);
        });

        modelBuilder.Entity<LIFE>(entity =>
        {
            entity.ToTable("LIFE", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NPRODUCT, e.NBRANCH, e.NPOLICY, e.NCERTIF, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SAMORTI_WAY).HasMaxLength(1);
            entity.Property(e => e.SLOAN_NUMBE).HasMaxLength(10);
            entity.Property(e => e.SPDURAIND).HasMaxLength(1);
            entity.Property(e => e.SSALD_PROG).HasMaxLength(1);
            entity.Property(e => e.SCREDITNUM).HasMaxLength(20);
            entity.Property(e => e.SACCNUM).HasMaxLength(20);
            entity.Property(e => e.SIDURAIND).HasMaxLength(1);
            entity.Property(e => e.SPRINTCOV).HasMaxLength(1);
            entity.Property(e => e.SFOLIONUMBER).HasMaxLength(10);
        });

        modelBuilder.Entity<LIFE_COVER>(entity =>
        {
            entity.ToTable("LIFE_COVER", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NCOVER, e.NPRODUCT, e.NMODULEC, e.DEFFECDATE });
            entity.Property(e => e.SADDSUINI).HasMaxLength(1);
            entity.Property(e => e.SADDREINI).HasMaxLength(1);
            entity.Property(e => e.SADDTAXIN).HasMaxLength(1);
            entity.Property(e => e.SMORTACOF).HasMaxLength(6);
            entity.Property(e => e.SMORTACOM).HasMaxLength(6);
            entity.Property(e => e.SCOVERUSE).HasMaxLength(1);
            entity.Property(e => e.SROURESER).HasMaxLength(12);
            entity.Property(e => e.SROUSURRE).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCONTROL).HasMaxLength(1);
            entity.Property(e => e.SCALREIN).HasMaxLength(1);
            entity.Property(e => e.SDEPEND).HasMaxLength(1);
            entity.Property(e => e.SSURV).HasMaxLength(1);
            entity.Property(e => e.SREINORIGCOND).HasMaxLength(1);
            entity.Property(e => e.SCONDSVS).HasMaxLength(30);
            entity.Property(e => e.SROUCLATEC).HasMaxLength(12);
            entity.Property(e => e.SROUTRESRISK).HasMaxLength(12);
            entity.Property(e => e.SRESOLUTION).HasMaxLength(12);
            entity.Property(e => e.SGOVAPRNAME).HasMaxLength(50);
            entity.Property(e => e.STECPREMIND).HasMaxLength(1);
            entity.Property(e => e.SRISPREMIND).HasMaxLength(1);
        });

        modelBuilder.Entity<LIFE_DOCU>(entity =>
        {
            entity.ToTable("LIFE_DOCU", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPOLICY, e.NPRODUCT, e.NCERTIF, e.DEFFECDATE, e.NMODULEC, e.NCRTHECNI, e.NCOVER, e.NROLE, e.SCLIENT });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SREQUEST).HasMaxLength(1);
            entity.Property(e => e.SRANDOM).HasMaxLength(1);
        });

        modelBuilder.Entity<LIFE_SPECI>(entity =>
        {
            entity.ToTable("LIFE_SPECI", "INSUDB");
            entity.HasKey(e => new { e.NCONSEC, e.NMODULEC, e.NBRANCH, e.NCOVER, e.NPRODUCT, e.DEFFECDATE, e.NROLE });
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SRANDOM).HasMaxLength(1);
        });

        modelBuilder.Entity<LIMITS>(entity =>
        {
            entity.ToTable("LIMITS", "INSUDB");
            entity.HasKey(e => new { e.SSCHE_CODE, e.NCURRENCY, e.NBRANCH, e.NPRODUCT });
            entity.Property(e => e.SSCHE_CODE).HasMaxLength(6);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<LOGBILLS>(entity =>
        {
            entity.ToTable("LOGBILLS", "INSUDB");
            entity.HasKey(e => new { e.NINSUR_AREA, e.NOPERTYPE, e.SCLIENT, e.NPOLICY, e.NCERTIF, e.NBORDEREAUX });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SSTATUSDESC).HasMaxLength(4000);
            entity.Property(e => e.SBILLNUMSFE).HasMaxLength(100);
            entity.Property(e => e.SPROCESSED).HasMaxLength(1);
        });

        modelBuilder.Entity<MARGENREP>(entity =>
        {
            entity.ToTable("MARGENREP", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NREPTYPE });
            entity.Property(e => e.SLOGO).HasMaxLength(100);
            entity.Property(e => e.SLOG).HasMaxLength(1);
        });

        modelBuilder.Entity<MASSIVE_LOG_PROC>(entity =>
        {
            entity.ToTable("MASSIVE_LOG_PROC", "INSUDB");
            entity.HasKey(e => new { e.SKEY, e.NKEY, e.NSEQ, e.NROW });
            entity.Property(e => e.SKEY).HasMaxLength(60);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCANCELEDCLAIMS).HasMaxLength(30);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SITEM).HasMaxLength(100);
            entity.Property(e => e.SLOT).HasMaxLength(100);
            entity.Property(e => e.SCOMERPRODUCT).HasMaxLength(10);
            entity.Property(e => e.SOFFICIALPOL).HasMaxLength(10);
            entity.Property(e => e.SPREVNUMPOL).HasMaxLength(30);
        });

        modelBuilder.Entity<MASSIVE_PART_CONDITIONS>(entity =>
        {
            entity.ToTable("MASSIVE_PART_CONDITIONS", "INSUDB");
            entity.HasKey(e => new { e.NIDCONDI, e.STYP_CONDI, e.NSECTION });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(200);
            entity.Property(e => e.SENABLED).HasMaxLength(1);
            entity.Property(e => e.STYP_CONDI).HasMaxLength(1);
        });

        modelBuilder.Entity<MASSIVE_POLICY>(entity =>
        {
            entity.ToTable("MASSIVE_POLICY", "INSUDB");
            entity.HasKey(e => new { e.SKEY, e.NROW, e.NSEQ });
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SERROR).HasMaxLength(1);
            entity.Property(e => e.SCLIENT_S).HasMaxLength(14);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SSMOKING).HasMaxLength(1);
            entity.Property(e => e.SFIRSTNAME).HasMaxLength(20);
            entity.Property(e => e.SLASTNAME).HasMaxLength(20);
            entity.Property(e => e.SLASTNAME2).HasMaxLength(20);
            entity.Property(e => e.SCLIENAME).HasMaxLength(63);
            entity.Property(e => e.SRECTYPE).HasMaxLength(1);
            entity.Property(e => e.SSTREET).HasMaxLength(40);
            entity.Property(e => e.SE_MAIL).HasMaxLength(60);
            entity.Property(e => e.SPHONE).HasMaxLength(11);
            entity.Property(e => e.SITEM).HasMaxLength(100);
            entity.Property(e => e.SCREDITNUM).HasMaxLength(30);
            entity.Property(e => e.SACCOUNT).HasMaxLength(64);
            entity.Property(e => e.SCREDI_CARD).HasMaxLength(64);
            entity.Property(e => e.STYP_DIRDEB).HasMaxLength(1);
            entity.Property(e => e.SCHASSIS).HasMaxLength(30);
            entity.Property(e => e.SMOTOR).HasMaxLength(30);
            entity.Property(e => e.SREGIST).HasMaxLength(30);
            entity.Property(e => e.SBUILD).HasMaxLength(30);
            entity.Property(e => e.SDEPARTMENT).HasMaxLength(30);
            entity.Property(e => e.SVEHCODE).HasMaxLength(30);
            entity.Property(e => e.SCLIENTSPONSOR).HasMaxLength(14);
            entity.Property(e => e.SCOMERPRODUCT).HasMaxLength(10);
            entity.Property(e => e.SSTATUSVA).HasMaxLength(1);
            entity.Property(e => e.SCLINUMDOCU).HasMaxLength(15);
            entity.Property(e => e.SDESCADD).HasMaxLength(140);
            entity.Property(e => e.SDESCADD1).HasMaxLength(140);
            entity.Property(e => e.SCELULAR).HasMaxLength(11);
            entity.Property(e => e.SCBU).HasMaxLength(64);
            entity.Property(e => e.SDIGIT).HasMaxLength(1);
            entity.Property(e => e.SINDBILLER).HasMaxLength(1);
            entity.Property(e => e.SIDCOMPL).HasMaxLength(5);
            entity.Property(e => e.SIDCERTIF).HasMaxLength(25);
            entity.Property(e => e.SDESCGROUP).HasMaxLength(30);
            entity.Property(e => e.SDESCMODUL).HasMaxLength(30);
            entity.Property(e => e.SINDMATERNITY).HasMaxLength(1);
            entity.Property(e => e.SMARRIEDSURNAME).HasMaxLength(20);
            entity.Property(e => e.SSPOUSENAME).HasMaxLength(60);
            entity.Property(e => e.SSTREET1).HasMaxLength(40);
            entity.Property(e => e.SBUILD1).HasMaxLength(30);
            entity.Property(e => e.SDEPARTMENT1).HasMaxLength(30);
            entity.Property(e => e.SE_MAIL1).HasMaxLength(60);
            entity.Property(e => e.SCELULAR1).HasMaxLength(11);
            entity.Property(e => e.SPHONE1).HasMaxLength(11);
            entity.Property(e => e.SSENDADDRESS).HasMaxLength(1);
            entity.Property(e => e.SCERTADDRESS).HasMaxLength(1);
            entity.Property(e => e.SINDANTI).HasMaxLength(1);
            entity.Property(e => e.SFPHYSICAL_CREDEN).HasMaxLength(1);
            entity.Property(e => e.SDPSDELIVERED).HasMaxLength(1);
            entity.Property(e => e.SIDDELIVERED).HasMaxLength(1);
            entity.Property(e => e.SDESCGROUP_DEST).HasMaxLength(30);
            entity.Property(e => e.SDESCMODUL_DEST).HasMaxLength(30);
            entity.Property(e => e.SPREVNUMPOL).HasMaxLength(30);
            entity.Property(e => e.SCLINUMDOCU_BILL).HasMaxLength(18);
        });

        modelBuilder.Entity<MASSIVE_RULES>(entity =>
        {
            entity.ToTable("MASSIVE_RULES", "INSUDB");
            entity.HasKey(e => e.NIDRULE);
            entity.Property(e => e.SERRORTYP).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(200);
            entity.Property(e => e.SBREAK).HasMaxLength(1);
            entity.Property(e => e.SENABLED).HasMaxLength(1);
            entity.Property(e => e.SVIP).HasMaxLength(1);
            entity.Property(e => e.STYP_CONDI).HasMaxLength(1);
        });

        modelBuilder.Entity<MASS_PROC_SPONSOR>(entity =>
        {
            entity.ToTable("MASS_PROC_SPONSOR", "INSUDB");
            entity.HasKey(e => new { e.SKEY, e.NCOD_AGREE });
            entity.Property(e => e.SKEY).HasMaxLength(60);
            entity.Property(e => e.SLOT).HasMaxLength(100);
            entity.Property(e => e.STYPEEXECUTION).HasMaxLength(1);
            entity.Property(e => e.SFILENAME).HasMaxLength(150);
        });

        modelBuilder.Entity<MASTERCL_BENEF>(entity =>
        {
            entity.ToTable("MASTERCL_BENEF", "INSUDB");
            entity.HasKey(e => new { e.NMASTERORDER, e.NCONSEC });
            entity.Property(e => e.SCLIENT_BENEF).HasMaxLength(14);
            entity.Property(e => e.SCLIENT_REP).HasMaxLength(14);
            entity.Property(e => e.SCLIENAME_BEN).HasMaxLength(63);
            entity.Property(e => e.SCLINUMDOCU_BEN).HasMaxLength(18);
            entity.Property(e => e.SPHONE_BEN).HasMaxLength(20);
            entity.Property(e => e.SCELLPHONE_BEN).HasMaxLength(20);
            entity.Property(e => e.SEMAIL_BEN).HasMaxLength(60);
            entity.Property(e => e.SCLIENAME_REP).HasMaxLength(63);
            entity.Property(e => e.SCLINUMDOCU_REP).HasMaxLength(18);
            entity.Property(e => e.SPHONE_REP).HasMaxLength(20);
            entity.Property(e => e.SCELLPHONE_REP).HasMaxLength(20);
            entity.Property(e => e.SEMAIL_REP).HasMaxLength(60);
        });

        modelBuilder.Entity<MASTERCL_DETAIL>(entity =>
        {
            entity.ToTable("MASTERCL_DETAIL", "INSUDB");
            entity.HasKey(e => new { e.NMASTERORDER, e.NPROCEDURE_ID });
            entity.Property(e => e.SBENEFIT).HasMaxLength(10);
            entity.Property(e => e.SSAME_INCISION).HasMaxLength(1);
            entity.Property(e => e.SILLNESS).HasMaxLength(8);
            entity.Property(e => e.SREJECTALERT).HasMaxLength(2000);
            entity.Property(e => e.SILLNES_DETECT).HasMaxLength(60);
        });

        modelBuilder.Entity<MASTERCL_DOCUMENTS>(entity =>
        {
            entity.ToTable("MASTERCL_DOCUMENTS", "INSUDB");
            entity.HasKey(e => new { e.NMASTERORDER, e.NCONSEC_MASTERORDERDOC });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<MASTERCL_HIS>(entity =>
        {
            entity.ToTable("MASTERCL_HIS", "INSUDB");
            entity.HasKey(e => new { e.NMASTERORDER, e.NMOVEMENT });
            entity.Property(e => e.STYPECARE).HasMaxLength(10);
            entity.Property(e => e.SCARECLASS).HasMaxLength(10);
            entity.Property(e => e.SIND_REV).HasMaxLength(1);
            entity.Property(e => e.SPREAUTHORIZATION).HasMaxLength(1);
        });

        modelBuilder.Entity<MASTERCL_ORDER>(entity =>
        {
            entity.ToTable("MASTERCL_ORDER", "INSUDB");
            entity.HasKey(e => e.NMASTERORDER);
            entity.Property(e => e.SNAMECLIENT).HasMaxLength(63);
            entity.Property(e => e.SPREAUTHORIZATION).HasMaxLength(1);
            entity.Property(e => e.STYPECARE).HasMaxLength(10);
            entity.Property(e => e.SCARECLASS).HasMaxLength(10);
            entity.Property(e => e.SCALLCENTER).HasMaxLength(1);
            entity.Property(e => e.SHISTORICAL_CLAIM).HasMaxLength(1);
        });

        modelBuilder.Entity<MASTERSHEET>(entity =>
        {
            entity.ToTable("MASTERSHEET", "INSUDB");
            entity.HasKey(e => e.NSHEET);
            entity.Property(e => e.SPROCESS).HasMaxLength(30);
            entity.Property(e => e.SSELECT).HasMaxLength(500);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SAUTOMATIC).HasMaxLength(1);
            entity.Property(e => e.SSHORTDESC).HasMaxLength(8);
            entity.Property(e => e.SGROUPBY).HasMaxLength(1);
            entity.Property(e => e.SSTATUSSHEET).HasMaxLength(1);
            entity.Property(e => e.SONLINE).HasMaxLength(1);
            entity.Property(e => e.SPROCESS_END).HasMaxLength(30);
            entity.Property(e => e.SPREFIX_FNAME).HasMaxLength(9);
            entity.Property(e => e.SHEADER).HasMaxLength(1);
            entity.Property(e => e.STOTAL).HasMaxLength(1);
            entity.Property(e => e.SMASSIVE).HasMaxLength(1);
            entity.Property(e => e.SSPACE).HasMaxLength(1);
            entity.Property(e => e.SPATH).HasMaxLength(30);
            entity.Property(e => e.SSEPARATOR).HasMaxLength(1);
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
            entity.Property(e => e.SNOGRID).HasMaxLength(1);
            entity.Property(e => e.SVIEW_INTERFACE).HasMaxLength(1);
            entity.Property(e => e.SVIEW_REPORT).HasMaxLength(1);
            entity.Property(e => e.SREPORT).HasMaxLength(50);
            entity.Property(e => e.SSHEET_FATHER).HasMaxLength(1);
            entity.Property(e => e.SFILE_UNIQUE).HasMaxLength(1);
            entity.Property(e => e.SQUERY).HasMaxLength(4000);
            entity.Property(e => e.SXSL).HasMaxLength(1);
            entity.Property(e => e.SNAME_ROUTINE).HasMaxLength(12);
            entity.Property(e => e.SOUT_ROUTINE).HasMaxLength(12);
            entity.Property(e => e.SWORKFLOWNAME).HasMaxLength(200);
            entity.Property(e => e.SFOLDER).HasMaxLength(200);
            entity.Property(e => e.SQUEPROCESS).HasMaxLength(30);
            entity.Property(e => e.SQUEQUERY).HasMaxLength(4000);
            entity.Property(e => e.ST_INTERFACE).HasMaxLength(1);
            entity.Property(e => e.SDATEFORMAT).HasMaxLength(30);
            entity.Property(e => e.SDECIMAL).HasMaxLength(1);
        });

        modelBuilder.Entity<MEDBENEFITS_PROD>(entity =>
        {
            entity.ToTable("MEDBENEFITS_PROD", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NMODULEC, e.DEFFECDATE, e.NCOVER, e.NIDMEDBENEF });
            entity.Property(e => e.SCHANALLO).HasMaxLength(1);
            entity.Property(e => e.SCAREN_TYPE).HasMaxLength(1);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SILLNESS).HasMaxLength(8);
            entity.Property(e => e.SCLARIFICACT).HasMaxLength(300);
            entity.Property(e => e.SBENEFCATEG_CODE).HasMaxLength(10);
            entity.Property(e => e.SPRINT_DES).HasMaxLength(60);
        });

        modelBuilder.Entity<MEDICALBENEFITS>(entity =>
        {
            entity.ToTable("MEDICALBENEFITS", "INSUDB");
            entity.HasKey(e => e.SBENEFIT);
            entity.Property(e => e.SBENEFIT).HasMaxLength(10);
            entity.Property(e => e.STYPEBENEFIT).HasMaxLength(5);
            entity.Property(e => e.SBENEFITCLAS).HasMaxLength(5);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(350);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(60);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<MEDICAL_EVAL_ROL>(entity =>
        {
            entity.ToTable("MEDICAL_EVAL_ROL", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NROLE, e.SCLIENT, e.NMEDICALSTAT, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<MEDICALFEES>(entity =>
        {
            entity.ToTable("MEDICALFEES", "INSUDB");
            entity.HasKey(e => new { e.NIDMEDICALFEE, e.SBENEFITCODE, e.DEFFECDATE, e.NCURRENCY });
            entity.Property(e => e.SBENEFITCODE).HasMaxLength(10);
            entity.Property(e => e.SHOMOLOG_BENEFIT).HasMaxLength(20);
        });

        modelBuilder.Entity<MEDICAL_SURCHARGE>(entity =>
        {
            entity.ToTable("MEDICAL_SURCHARGE", "INSUDB");
            entity.HasKey(e => e.NSURCHAR_MED);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<MEDICALTEAMS_FEES>(entity =>
        {
            entity.ToTable("MEDICALTEAMS_FEES", "INSUDB");
            entity.HasKey(e => new { e.NOFFICE, e.NDOCTORROL, e.NORD_PROCEDURE, e.DEFFECDATE });
        });

        modelBuilder.Entity<MESSAGE>(entity =>
        {
            entity.ToTable("MESSAGE", "INSUDB");
            entity.HasKey(e => e.NERRORNUM);
            entity.Property(e => e.SMESSAGED).HasMaxLength(200);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<MODUL_CO_G>(entity =>
        {
            entity.ToTable("MODUL_CO_G", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NGROUP, e.NMODULEC, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.STYP_RAT).HasMaxLength(1);
        });

        modelBuilder.Entity<MODUL_CO_P>(entity =>
        {
            entity.ToTable("MODUL_CO_P", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NMODULEC, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.STYP_RAT).HasMaxLength(1);
        });

        modelBuilder.Entity<MODULES>(entity =>
        {
            entity.ToTable("MODULES", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NGROUP_INSU, e.NMODULEC, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCHANGEI).HasMaxLength(1);
            entity.Property(e => e.STYP_RAT).HasMaxLength(1);
            entity.Property(e => e.SINHERIT).HasMaxLength(1);
        });

        modelBuilder.Entity<MODUL_INSURED>(entity =>
        {
            entity.ToTable("MODUL_INSURED", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NGROUP_INSU, e.NMODULEC, e.SCLIENT, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<MOVE_ACC>(entity =>
        {
            entity.ToTable("MOVE_ACC", "INSUDB");
            entity.HasKey(e => new { e.NTYP_ACCO, e.STYPE_ACC, e.SCLIENT, e.NCURRENCY, e.DOPERDATE, e.NIDCONSEC });
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCHEQUE).HasMaxLength(10);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SMANUALMOV).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SPROCESS).HasMaxLength(1);
            entity.Property(e => e.SNUMFORM).HasMaxLength(12);
            entity.Property(e => e.SAUTORIZA).HasMaxLength(1);
            entity.Property(e => e.SNULL_RECOR).HasMaxLength(1);
            entity.Property(e => e.SPROCESS_IND).HasMaxLength(1);
            entity.Property(e => e.SCLIENT_REL).HasMaxLength(14);
            entity.Property(e => e.SPAY_FORM).HasMaxLength(2);
            entity.Property(e => e.SDEP_NUMBER).HasMaxLength(12);
            entity.Property(e => e.NRETENTIONSERIES).HasMaxLength(15);
            entity.Property(e => e.NAUTORIZATIONNUMBER).HasMaxLength(37);
            entity.Property(e => e.SPOSTEDSEQUENCE).HasMaxLength(100);
            entity.Property(e => e.SSCAB).HasMaxLength(1);
        });

        modelBuilder.Entity<MUNICIPALITY>(entity =>
        {
            entity.ToTable("MUNICIPALITY", "INSUDB");
            entity.HasKey(e => e.NMUNICIPALITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(50);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
        });

        modelBuilder.Entity<NOCONVERS>(entity =>
        {
            entity.ToTable("NOCONVERS", "INSUDB");
            entity.HasKey(e => e.NNO_CONVERS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SDEVO).HasMaxLength(1);
            entity.Property(e => e.SDISC).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
        });

        modelBuilder.Entity<NONWORKINGDAYFACTOR>(entity =>
        {
            entity.ToTable("NONWORKINGDAYFACTOR", "INSUDB");
            entity.HasKey(e => e.NIDFACTOR);
        });

        modelBuilder.Entity<NOTES>(entity =>
        {
            entity.ToTable("NOTES", "INSUDB");
            entity.HasKey(e => new { e.NNOTENUM, e.NCONSEC });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
        });

        modelBuilder.Entity<NOTIFICA_ERP>(entity =>
        {
            entity.ToTable("NOTIFICA_ERP", "INSUDB");
            entity.HasKey(e => e.SKEY);
            entity.Property(e => e.SPROCESO).HasMaxLength(30);
            entity.Property(e => e.SKEY).HasMaxLength(30);
            entity.Property(e => e.SESTADO).HasMaxLength(10);
        });

        modelBuilder.Entity<NULL_CONDI>(entity =>
        {
            entity.ToTable("NULL_CONDI", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NNULLCODE, e.DEFFECDATE });
            entity.Property(e => e.SREGTYPEN).HasMaxLength(1);
            entity.Property(e => e.SRETURN_IND).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SNOTREHAB).HasMaxLength(1);
            entity.Property(e => e.SREHAB_AUTO).HasMaxLength(1);
            entity.Property(e => e.SROUTINE_PAY).HasMaxLength(12);
        });

        modelBuilder.Entity<NUMERATOR>(entity =>
        {
            entity.ToTable("NUMERATOR", "INSUDB");
            entity.HasKey(e => new { e.NTYPENUM, e.NORD_NUM });
        });

        modelBuilder.Entity<ODWA_HELP_ITEMS>(entity =>
        {
            entity.ToTable("ODWA_HELP_ITEMS", "INSUDB");
            entity.HasKey(e => e.ID);
            entity.Property(e => e.DESCRIPTION).HasMaxLength(200);
            entity.Property(e => e.DOCUMENT).HasMaxLength(200);
            entity.Property(e => e.KEYWORDS).HasMaxLength(500);
        });

        modelBuilder.Entity<ODWA_HELP_NODES>(entity =>
        {
            entity.ToTable("ODWA_HELP_NODES", "INSUDB");
            entity.HasKey(e => e.ID);
            entity.Property(e => e.DISPLAY_LABEL).HasMaxLength(400);
        });

        modelBuilder.Entity<ODWA_HELP_TEXT>(entity =>
        {
            entity.ToTable("ODWA_HELP_TEXT", "INSUDB");
            entity.HasKey(e => new { e.HIM_ID, e.SEQ });
            entity.Property(e => e.TXT).HasMaxLength(4000);
        });

        modelBuilder.Entity<ODWA_PREFERENCES>(entity =>
        {
            entity.ToTable("ODWA_PREFERENCES", "INSUDB");
            entity.HasKey(e => e.PREFERENCE_NAME);
            entity.Property(e => e.PREFERENCE_NAME).HasMaxLength(50);
            entity.Property(e => e.PREFERENCE_VALUE).HasMaxLength(2000);
            entity.Property(e => e.PREFERENCE_DESCRIPTION).HasMaxLength(2000);
        });

        modelBuilder.Entity<OFF_ACC>(entity =>
        {
            entity.ToTable("OFF_ACC", "INSUDB");
            entity.HasKey(e => new { e.SSCHE_CODE, e.NOFFICE });
            entity.Property(e => e.SSCHE_CODE).HasMaxLength(6);
            entity.Property(e => e.SIND_INQU).HasMaxLength(1);
            entity.Property(e => e.SIND_UPDA).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<OFFICE_ALLOW_PROD>(entity =>
        {
            entity.ToTable("OFFICE_ALLOW_PROD", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NOFFICE_PROD, e.DEFFECDATE });
        });

        modelBuilder.Entity<OUT_MOVEME>(entity =>
        {
            entity.ToTable("OUT_MOVEME", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NMOVNUMBE, e.NDIGIT });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SSTATUS_MOV).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<OUT_PREMIU>(entity =>
        {
            entity.ToTable("OUT_PREMIU", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NMOVNUMBE, e.NDIGIT, e.NID_BILL });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SADDSUINI).HasMaxLength(1);
            entity.Property(e => e.STYPE_DETAI).HasMaxLength(1);
            entity.Property(e => e.SADDTAX).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<OUT_PREMIU_INI>(entity =>
        {
            entity.ToTable("OUT_PREMIU_INI", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NMOVNUMBE, e.NDIGIT, e.NID_BILL });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SADDSUINI).HasMaxLength(1);
            entity.Property(e => e.STYPE_DETAI).HasMaxLength(1);
            entity.Property(e => e.SADDTAX).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<PART_CONTR>(entity =>
        {
            entity.ToTable("PART_CONTR", "INSUDB");
            entity.HasKey(e => new { e.NTYPE_REL, e.NNUMBER, e.NBRANCH, e.DEFFECDATE, e.NTYPE, e.DSTARTDATE, e.NCOMPANY });
            entity.Property(e => e.SROUCESS).HasMaxLength(12);
            entity.Property(e => e.SROUPROFIT).HasMaxLength(12);
            entity.Property(e => e.SFREQPROFIT).HasMaxLength(1);
        });

        modelBuilder.Entity<PAY_FRACTI>(entity =>
        {
            entity.ToTable("PAY_FRACTI", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NPAYFREQ, e.NQUOTA, e.DEFFECDATE });
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<PAY_ORD_CONCEPTS>(entity =>
        {
            entity.ToTable("PAY_ORD_CONCEPTS", "INSUDB");
            entity.HasKey(e => new { e.NCOMPANY, e.NCONCEPT });
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<PCC004_FORM>(entity =>
        {
            entity.ToTable("PCC004_FORM", "INSUDB");
            entity.HasKey(e => e.NNUM_PCC004);
            entity.Property(e => e.SLEGALNAME_COMPANY).HasMaxLength(63);
            entity.Property(e => e.SCLINUMDOCU_COMPANY).HasMaxLength(18);
            entity.Property(e => e.SDESCADD_COMPANY).HasMaxLength(140);
            entity.Property(e => e.SZONA_COMPANY).HasMaxLength(30);
            entity.Property(e => e.SPHONE_COMPANY).HasMaxLength(15);
            entity.Property(e => e.SFIRSTNAME).HasMaxLength(20);
            entity.Property(e => e.SLASTNAME).HasMaxLength(20);
            entity.Property(e => e.SLASTNAME2).HasMaxLength(20);
            entity.Property(e => e.SCLINUMDOCU).HasMaxLength(18);
            entity.Property(e => e.SIDCOMPL).HasMaxLength(5);
            entity.Property(e => e.SCOMPANYWORKS).HasMaxLength(63);
            entity.Property(e => e.SDESCADD_LABOUR).HasMaxLength(140);
            entity.Property(e => e.SLEGALNAME).HasMaxLength(63);
            entity.Property(e => e.SZONA).HasMaxLength(30);
            entity.Property(e => e.SDESCADD_DOMICILE).HasMaxLength(140);
            entity.Property(e => e.SPHONE).HasMaxLength(15);
            entity.Property(e => e.SCLIENAME_INTERMEDIARY).HasMaxLength(63);
            entity.Property(e => e.SCLIENAME_TITULAR).HasMaxLength(63);
            entity.Property(e => e.SBANKACCOUNT).HasMaxLength(100);
            entity.Property(e => e.SCHEQUE).HasMaxLength(10);
            entity.Property(e => e.SORIGENRESOURCES).HasMaxLength(140);
            entity.Property(e => e.SDESTINYRESOURCES).HasMaxLength(140);
            entity.Property(e => e.SREMARKS).HasMaxLength(500);
            entity.Property(e => e.SPHONE_PART).HasMaxLength(15);
            entity.Property(e => e.SZONE_PART).HasMaxLength(30);
            entity.Property(e => e.SCLIENAME_BROKER).HasMaxLength(63);
            entity.Property(e => e.NIND_CASHFLOW).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT_CITY).HasMaxLength(140);
            entity.Property(e => e.SDESPOLICY).HasMaxLength(140);
        });

        modelBuilder.Entity<PERSON_TYPE>(entity =>
        {
            entity.ToTable("PERSON_TYPE", "INSUDB");
            entity.HasKey(e => e.NIDPERSONTYPE);
            entity.Property(e => e.SNAME).HasMaxLength(50);
            entity.Property(e => e.SENABLE).HasMaxLength(1);
        });

        modelBuilder.Entity<PHONES>(entity =>
        {
            entity.ToTable("PHONES", "INSUDB");
            entity.HasKey(e => new { e.NRECOWNER, e.SKEYADDRESS, e.NKEYPHONES, e.DEFFECDATE });
            entity.Property(e => e.SKEYADDRESS).HasMaxLength(50);
            entity.Property(e => e.SPHONE).HasMaxLength(11);
            entity.Property(e => e.SASSOCADDR).HasMaxLength(50);
        });

        modelBuilder.Entity<PIE_ELEMENT_TYPES>(entity =>
        {
            entity.ToTable("PIE_ELEMENT_TYPES", "INSUDB");
            entity.HasKey(e => e.SHORT_NAME);
            entity.Property(e => e.DISPLAY_NAME).HasMaxLength(100);
            entity.Property(e => e.NAME).HasMaxLength(100);
            entity.Property(e => e.PLURAL).HasMaxLength(100);
            entity.Property(e => e.GIF_FILE).HasMaxLength(100);
            entity.Property(e => e.ROOT_PROCEDURE).HasMaxLength(100);
            entity.Property(e => e.SHORT_NAME).HasMaxLength(10);
            entity.Property(e => e.DETAIL_PROCEDURE).HasMaxLength(100);
        });

        modelBuilder.Entity<POLICY>(entity =>
        {
            entity.ToTable("POLICY", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SACCOUNTI).HasMaxLength(1);
            entity.Property(e => e.SBUSSITYP).HasMaxLength(1);
            entity.Property(e => e.SCOINSURI).HasMaxLength(1);
            entity.Property(e => e.SCOLINVOT).HasMaxLength(1);
            entity.Property(e => e.SCOLREINT).HasMaxLength(1);
            entity.Property(e => e.SCOLTIMRE).HasMaxLength(1);
            entity.Property(e => e.SCOMMITYP).HasMaxLength(1);
            entity.Property(e => e.SDECLARI).HasMaxLength(1);
            entity.Property(e => e.SDIRDEBIT).HasMaxLength(1);
            entity.Property(e => e.SINDEXTYP).HasMaxLength(1);
            entity.Property(e => e.SLEADINVO).HasMaxLength(12);
            entity.Property(e => e.SLEADNOTI).HasMaxLength(12);
            entity.Property(e => e.SLEADPOLI).HasMaxLength(12);
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SPROPO_CERT).HasMaxLength(1);
            entity.Property(e => e.SRENEWAL).HasMaxLength(1);
            entity.Property(e => e.SREVALAPL).HasMaxLength(1);
            entity.Property(e => e.SSTATUS_POL).HasMaxLength(1);
            entity.Property(e => e.SSUBSTITI).HasMaxLength(1);
            entity.Property(e => e.STYP_CLAUSE).HasMaxLength(1);
            entity.Property(e => e.STYP_DISCXP).HasMaxLength(1);
            entity.Property(e => e.STYP_MODULE).HasMaxLength(1);
            entity.Property(e => e.SNONULL).HasMaxLength(1);
            entity.Property(e => e.SCONCOLL).HasMaxLength(1);
            entity.Property(e => e.SNUMFORM).HasMaxLength(12);
            entity.Property(e => e.STYPE_PROP).HasMaxLength(1);
            entity.Property(e => e.SPRORSHORT).HasMaxLength(1);
            entity.Property(e => e.SORIGINAL).HasMaxLength(20);
            entity.Property(e => e.STYPENOM).HasMaxLength(1);
            entity.Property(e => e.SNOPAYROLL).HasMaxLength(1);
            entity.Property(e => e.SINSUBANK).HasMaxLength(1);
            entity.Property(e => e.SLEG).HasMaxLength(1);
            entity.Property(e => e.SCOLTPRES).HasMaxLength(1);
            entity.Property(e => e.SIND_COMM).HasMaxLength(1);
            entity.Property(e => e.SCURRACC).HasMaxLength(1);
            entity.Property(e => e.SMASSIVE).HasMaxLength(1);
            entity.Property(e => e.SREPPRINTCOV).HasMaxLength(1);
            entity.Property(e => e.SRECEIPT_IND).HasMaxLength(1);
            entity.Property(e => e.SDOCUTYP).HasMaxLength(1);
            entity.Property(e => e.SACCHSEND_IND).HasMaxLength(1);
            entity.Property(e => e.STYPCALC_FLATPREM).HasMaxLength(1);
            entity.Property(e => e.STYPDIS_PAYPERCEN).HasMaxLength(1);
            entity.Property(e => e.SPREVPOLNUM).HasMaxLength(30);
        });

        modelBuilder.Entity<POLICY_HIS>(entity =>
        {
            entity.ToTable("POLICY_HIS", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NMOVEMENT });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SNULL_MOVE).HasMaxLength(1);
            entity.Property(e => e.SINTERMEI).HasMaxLength(1);
            entity.Property(e => e.SFILE_REPORT).HasMaxLength(2000);
            entity.Property(e => e.SPROCESS_NUM).HasMaxLength(50);
            entity.Property(e => e.SIND_TRANFER).HasMaxLength(1);
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SLOT).HasMaxLength(500);
        });

        modelBuilder.Entity<POLICY_WIN>(entity =>
        {
            entity.ToTable("POLICY_WIN", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SV_CONPOLIC).HasMaxLength(60);
            entity.Property(e => e.SV_WINPOLIC).HasMaxLength(480);
        });

        modelBuilder.Entity<PRECLAIM>(entity =>
        {
            entity.ToTable("PRECLAIM", "INSUDB");
            entity.HasKey(e => e.NIDPRECLAIM);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SADDRESS).HasMaxLength(140);
            entity.Property(e => e.SNAMECLIENT).HasMaxLength(63);
            entity.Property(e => e.SCLIENT_AFFECT).HasMaxLength(14);
            entity.Property(e => e.SCLINUMDOCU).HasMaxLength(18);
            entity.Property(e => e.SLOCALOCCUR).HasMaxLength(30);
            entity.Property(e => e.SACCIDENT).HasMaxLength(1);
            entity.Property(e => e.SPREAUTHORIZATION).HasMaxLength(1);
            entity.Property(e => e.SCALLCENTER).HasMaxLength(1);
            entity.Property(e => e.SHISTORICAL_CLAIM).HasMaxLength(1);
        });

        modelBuilder.Entity<PREMIUM>(entity =>
        {
            entity.ToTable("PREMIUM", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NRECEIPT, e.NBRANCH, e.NPRODUCT, e.NDIGIT, e.NPAYNUMBE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCESSIONS).HasMaxLength(1);
            entity.Property(e => e.SDIRDEBIT).HasMaxLength(1);
            entity.Property(e => e.SLEADINVO).HasMaxLength(12);
            entity.Property(e => e.SMANAUTI).HasMaxLength(1);
            entity.Property(e => e.SRENEWAL).HasMaxLength(1);
            entity.Property(e => e.SSUBSTITI).HasMaxLength(1);
            entity.Property(e => e.SCONCOLL).HasMaxLength(1);
            entity.Property(e => e.SSTATUSVA).HasMaxLength(1);
            entity.Property(e => e.SORIGRECEIPT).HasMaxLength(20);
            entity.Property(e => e.SSUS_ORIGI).HasMaxLength(1);
            entity.Property(e => e.SREJECT).HasMaxLength(1);
            entity.Property(e => e.SBILLTYPE).HasMaxLength(1);
            entity.Property(e => e.SINDCHEQUE).HasMaxLength(1);
            entity.Property(e => e.SIND_CAP).HasMaxLength(1);
            entity.Property(e => e.SINDMARGIN).HasMaxLength(1);
            entity.Property(e => e.SIND_RESERV).HasMaxLength(1);
            entity.Property(e => e.SDOCUMENT).HasMaxLength(25);
            entity.Property(e => e.SCLINUMDOCU).HasMaxLength(18);
        });

        modelBuilder.Entity<PREMIUM_CE>(entity =>
        {
            entity.ToTable("PREMIUM_CE", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NPRODUCT, e.NBRANCH, e.NRECEIPT, e.NDIGIT, e.NPAYNUMBE, e.NPOLICY, e.NCERTIF, e.NID_BILL });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.STYPE_DETAI).HasMaxLength(1);
            entity.Property(e => e.SADDTAX).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<PREMIUM_CE_INI>(entity =>
        {
            entity.ToTable("PREMIUM_CE_INI", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NPRODUCT, e.NBRANCH, e.NRECEIPT, e.NDIGIT, e.NPAYNUMBE, e.NPOLICY, e.NCERTIF, e.NID_BILL });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.STYPE_DETAI).HasMaxLength(1);
            entity.Property(e => e.SADDTAX).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<PREMIUM_MO>(entity =>
        {
            entity.ToTable("PREMIUM_MO", "INSUDB");
            entity.HasKey(e => new { e.NRECEIPT, e.NPRODUCT, e.NBRANCH, e.SCERTYPE, e.NDIGIT, e.NPAYNUMBE, e.NTRANSAC });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SAUX_ACCOUN).HasMaxLength(20);
            entity.Property(e => e.SCARD_NUM).HasMaxLength(20);
            entity.Property(e => e.SCESSICOI).HasMaxLength(1);
            entity.Property(e => e.SCHANG_ACC).HasMaxLength(20);
            entity.Property(e => e.SDOCNUMBE).HasMaxLength(30);
            entity.Property(e => e.SIND_REVER).HasMaxLength(1);
            entity.Property(e => e.SINTERMEI).HasMaxLength(1);
            entity.Property(e => e.SPAY_FORM).HasMaxLength(2);
            entity.Property(e => e.SSTATISI).HasMaxLength(1);
            entity.Property(e => e.SINDASSOCPRO).HasMaxLength(1);
            entity.Property(e => e.SIND_ASIS).HasMaxLength(1);
            entity.Property(e => e.SIND_COMI).HasMaxLength(1);
            entity.Property(e => e.SBILLTYPE).HasMaxLength(1);
            entity.Property(e => e.SIND_SOAP).HasMaxLength(1);
            entity.Property(e => e.SINDCHEQUE).HasMaxLength(1);
            entity.Property(e => e.SPROCESS_IND).HasMaxLength(1);
            entity.Property(e => e.SSTIPENDS).HasMaxLength(1);
            entity.Property(e => e.STYPREVERSE).HasMaxLength(1);
            entity.Property(e => e.SPOSTEDSEQUENCE).HasMaxLength(100);
        });

        modelBuilder.Entity<PROD_ADDCAP>(entity =>
        {
            entity.ToTable("PROD_ADDCAP", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NCOVERGEN, e.NBRANCHADD, e.NPRODUCTADD, e.NID, e.DEFFECDATE });
        });

        modelBuilder.Entity<PRODMASTER>(entity =>
        {
            entity.ToTable("PRODMASTER", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SBRANCHT).HasMaxLength(1);
            entity.Property(e => e.SREALIND).HasMaxLength(1);
            entity.Property(e => e.SPREFFIX).HasMaxLength(20);
        });

        modelBuilder.Entity<PROD_RESERVE>(entity =>
        {
            entity.ToTable("PROD_RESERVE", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NMODULEC, e.NCOVER, e.NTYPE_RESERVE, e.DEFFECDATE });
            entity.Property(e => e.SROURESER).HasMaxLength(12);
            entity.Property(e => e.SROUTINECOST).HasMaxLength(12);
            entity.Property(e => e.SMORTALCO).HasMaxLength(6);
        });

        modelBuilder.Entity<PRODUCT>(entity =>
        {
            entity.ToTable("PRODUCT", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.DEFFECDATE });
            entity.Property(e => e.SCOLINVOT).HasMaxLength(1);
            entity.Property(e => e.SCUMREINT).HasMaxLength(1);
            entity.Property(e => e.SCUMULTYP).HasMaxLength(1);
            entity.Property(e => e.SDECLAAUT).HasMaxLength(1);
            entity.Property(e => e.STYP_CLAUSE).HasMaxLength(1);
            entity.Property(e => e.STYP_DISCXP).HasMaxLength(1);
            entity.Property(e => e.STYP_MODULE).HasMaxLength(1);
            entity.Property(e => e.SGROUPIND).HasMaxLength(1);
            entity.Property(e => e.SINDIVIND).HasMaxLength(1);
            entity.Property(e => e.SMULTIIND).HasMaxLength(1);
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SREINTYPE).HasMaxLength(1);
            entity.Property(e => e.SRENEWAL).HasMaxLength(1);
            entity.Property(e => e.SREVALAPL).HasMaxLength(1);
            entity.Property(e => e.SREVALTYP).HasMaxLength(1);
            entity.Property(e => e.SSTYLE_COMM).HasMaxLength(1);
            entity.Property(e => e.SSTYLE_PREM).HasMaxLength(1);
            entity.Property(e => e.SSTYLE_TAX).HasMaxLength(1);
            entity.Property(e => e.STIMEREN).HasMaxLength(1);
            entity.Property(e => e.SWIN_DECLAR).HasMaxLength(8);
            entity.Property(e => e.SHOLDER).HasMaxLength(1);
            entity.Property(e => e.SGROUPSI).HasMaxLength(1);
            entity.Property(e => e.STYP_DOM).HasMaxLength(1);
            entity.Property(e => e.SLEG).HasMaxLength(1);
            entity.Property(e => e.SREINST).HasMaxLength(1);
            entity.Property(e => e.SDATECOLL).HasMaxLength(1);
            entity.Property(e => e.SFIRST_PAY).HasMaxLength(1);
            entity.Property(e => e.SROUTAUT_R).HasMaxLength(12);
            entity.Property(e => e.SNUMPROP).HasMaxLength(1);
            entity.Property(e => e.SFRACRECEIP).HasMaxLength(1);
            entity.Property(e => e.SCONDSVS).HasMaxLength(30);
            entity.Property(e => e.SAUTO_SUSC).HasMaxLength(1);
            entity.Property(e => e.SRECSEC).HasMaxLength(1);
            entity.Property(e => e.SRETARIF).HasMaxLength(1);
            entity.Property(e => e.SSETPREM).HasMaxLength(1);
            entity.Property(e => e.SLETTER).HasMaxLength(1);
            entity.Property(e => e.SMASSIVE).HasMaxLength(1);
            entity.Property(e => e.STARQUO_IND).HasMaxLength(1);
            entity.Property(e => e.SREACTIVATION).HasMaxLength(1);
            entity.Property(e => e.SROUTREACT).HasMaxLength(12);
            entity.Property(e => e.SNAME_REPORT).HasMaxLength(50);
            entity.Property(e => e.SRATINGSERVICEUSING).HasMaxLength(1);
            entity.Property(e => e.SROU_WARNING_CHARG).HasMaxLength(12);
            entity.Property(e => e.SROU_COVER).HasMaxLength(12);
            entity.Property(e => e.SRESOLUTIONSBS).HasMaxLength(100);
            entity.Property(e => e.SAUTOMATICBILL).HasMaxLength(1);
            entity.Property(e => e.SASSOCIATED_POLICY_REQUIRED).HasMaxLength(1);
            entity.Property(e => e.SPREMIUMZEROIND).HasMaxLength(1);
            entity.Property(e => e.SNOTGENRECEIPT).HasMaxLength(1);
            entity.Property(e => e.SCOMERPRODUCT).HasMaxLength(10);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SNATIONALS).HasMaxLength(1);
            entity.Property(e => e.SRESOLUTION).HasMaxLength(25);
            entity.Property(e => e.SGOVAPRNAME).HasMaxLength(100);
        });

        modelBuilder.Entity<PRODUCT_LI>(entity =>
        {
            entity.ToTable("PRODUCT_LI", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.DEFFECDATE });
            entity.Property(e => e.SACCOUNTI).HasMaxLength(1);
            entity.Property(e => e.SASSOCIAI).HasMaxLength(1);
            entity.Property(e => e.SCLALLPRE).HasMaxLength(1);
            entity.Property(e => e.SCLANNPEI).HasMaxLength(12);
            entity.Property(e => e.SCLLIFEAI).HasMaxLength(12);
            entity.Property(e => e.SCLNOPREI).HasMaxLength(1);
            entity.Property(e => e.SCLPAYPRI).HasMaxLength(1);
            entity.Property(e => e.SCLSIMPAI).HasMaxLength(1);
            entity.Property(e => e.SCLSURREI).HasMaxLength(1);
            entity.Property(e => e.SCLTRANSI).HasMaxLength(1);
            entity.Property(e => e.SIDURVARI).HasMaxLength(1);
            entity.Property(e => e.SMETHAGAV).HasMaxLength(1);
            entity.Property(e => e.SMETHPRAV).HasMaxLength(1);
            entity.Property(e => e.SMETHPRIN).HasMaxLength(1);
            entity.Property(e => e.SMORCAPII).HasMaxLength(1);
            entity.Property(e => e.SNOPERIOD).HasMaxLength(1);
            entity.Property(e => e.SNPEUNIFA).HasMaxLength(1);
            entity.Property(e => e.SPERIODIC).HasMaxLength(1);
            entity.Property(e => e.SREVALTYP).HasMaxLength(1);
            entity.Property(e => e.SPERUNIFA).HasMaxLength(1);
            entity.Property(e => e.SROUADVAN).HasMaxLength(12);
            entity.Property(e => e.SROUREDDC).HasMaxLength(12);
            entity.Property(e => e.SROUREDUC).HasMaxLength(12);
            entity.Property(e => e.SROUSURRE).HasMaxLength(12);
            entity.Property(e => e.SSURRENPI).HasMaxLength(1);
            entity.Property(e => e.SSURRENTI).HasMaxLength(1);
            entity.Property(e => e.SULFCHANI).HasMaxLength(1);
            entity.Property(e => e.SASSOTOTAL).HasMaxLength(1);
            entity.Property(e => e.SBENRES).HasMaxLength(1);
            entity.Property(e => e.SPREMIUMTYPE).HasMaxLength(1);
            entity.Property(e => e.SROUINTEREST).HasMaxLength(12);
            entity.Property(e => e.SROUTINSU).HasMaxLength(12);
            entity.Property(e => e.SROUTINE_C).HasMaxLength(12);
            entity.Property(e => e.SPDURVARI).HasMaxLength(1);
            entity.Property(e => e.SROUTPAY).HasMaxLength(12);
            entity.Property(e => e.SS_ALLWCHNG).HasMaxLength(1);
            entity.Property(e => e.SIX_ALLWCHNG).HasMaxLength(1);
            entity.Property(e => e.SW_ALLWCHNG).HasMaxLength(1);
            entity.Property(e => e.SAPV).HasMaxLength(1);
            entity.Property(e => e.SINDCL_PAY).HasMaxLength(1);
            entity.Property(e => e.SROUTINESURR).HasMaxLength(12);
            entity.Property(e => e.SAPPLYROUSURR).HasMaxLength(1);
            entity.Property(e => e.SACCOUNT_MIRROR).HasMaxLength(1);
            entity.Property(e => e.SROUTINEVPN).HasMaxLength(12);
            entity.Property(e => e.SPRORATE).HasMaxLength(1);
            entity.Property(e => e.SNO_HOLIDAYS).HasMaxLength(1);
            entity.Property(e => e.NAOF).HasMaxLength(1);
            entity.Property(e => e.STYPPB).HasMaxLength(1);
            entity.Property(e => e.SLOANSGUARANT).HasMaxLength(1);
            entity.Property(e => e.SROUTINEREQPREM).HasMaxLength(12);
            entity.Property(e => e.SPOSTEXPIRATION).HasMaxLength(1);
            entity.Property(e => e.SROUTPR).HasMaxLength(12);
            entity.Property(e => e.SROUMINBAL).HasMaxLength(12);
            entity.Property(e => e.SREFINANCE_LOANS).HasMaxLength(1);
            entity.Property(e => e.STYPESURRLOAN).HasMaxLength(1);
            entity.Property(e => e.SAUTOLOANS).HasMaxLength(1);
            entity.Property(e => e.SROUTINE_RANDOM).HasMaxLength(30);
        });

        modelBuilder.Entity<PROD_WIN>(entity =>
        {
            entity.ToTable("PROD_WIN", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.DEFFECDATE });
            entity.Property(e => e.SV_CONPRODU).HasMaxLength(50);
            entity.Property(e => e.SV_WINPRODU).HasMaxLength(200);
            entity.Property(e => e.SV_WINPRODU1).HasMaxLength(200);
        });

        modelBuilder.Entity<PROPERTYLIBRARY>(entity =>
        {
            entity.ToTable("PROPERTYLIBRARY", "INSUDB");
            entity.HasKey(e => e.NIDPROPERTY);
            entity.Property(e => e.SPROPERTY).HasMaxLength(20);
            entity.Property(e => e.SFORMAT).HasMaxLength(255);
        });

        modelBuilder.Entity<PROV_BRANCH>(entity =>
        {
            entity.ToTable("PROV_BRANCH", "INSUDB");
            entity.HasKey(e => new { e.NPROVIDER, e.NBRANCH });
        });

        modelBuilder.Entity<PROVINCE>(entity =>
        {
            entity.ToTable("PROVINCE", "INSUDB");
            entity.HasKey(e => e.NPROVINCE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
        });

        modelBuilder.Entity<PROVISION_TYPE>(entity =>
        {
            entity.ToTable("PROVISION_TYPE", "INSUDB");
            entity.HasKey(e => e.NIDPROVISIONTYPE);
            entity.Property(e => e.SNAME).HasMaxLength(50);
            entity.Property(e => e.SENABLE).HasMaxLength(1);
            entity.Property(e => e.SMANEJAUF).HasMaxLength(1);
        });

        modelBuilder.Entity<PROV_TABLIFCOV>(entity =>
        {
            entity.ToTable("PROV_TABLIFCOV", "INSUDB");
            entity.HasKey(e => new { e.NCOVERGEN, e.NCOD_AGREE });
        });

        modelBuilder.Entity<QC_PARAM>(entity =>
        {
            entity.ToTable("QC_PARAM", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.SPOLITYPE, e.NCURRENCY, e.DEFFECDATE });
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SINDQCOBL).HasMaxLength(1);
            entity.Property(e => e.SROUT_QC).HasMaxLength(17);
            entity.Property(e => e.SROUT_QCCAP).HasMaxLength(17);
            entity.Property(e => e.SSTATREG).HasMaxLength(1);
        });

        modelBuilder.Entity<REFINAN_DRA>(entity =>
        {
            entity.ToTable("REFINAN_DRA", "INSUDB");
            entity.HasKey(e => new { e.NCONTRAT, e.NCONTRAT_D, e.NDRAFT_D });
            entity.Property(e => e.SSTAT_FINPR).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<REINSU_FRE>(entity =>
        {
            entity.ToTable("REINSU_FRE", "INSUDB");
            entity.HasKey(e => new { e.DEFFECDATE, e.NCOMPANY, e.NTYPE_REL, e.NNUMBER, e.NTYPE, e.NYEAR_CONTR, e.NBRANCH, e.NCURRENCY, e.NTYPE_PER, e.NPERIODY });
            entity.Property(e => e.SBUSSITYPE).HasMaxLength(1);
            entity.Property(e => e.SFREE).HasMaxLength(1);
        });

        modelBuilder.Entity<REINSU_PRIM_HEALTH>(entity =>
        {
            entity.ToTable("REINSU_PRIM_HEALTH", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NMODULEC, e.NCURRENCY, e.DEEFECDATE });
            entity.Property(e => e.SSTATREG).HasMaxLength(1);
        });

        modelBuilder.Entity<REINSURAN>(entity =>
        {
            entity.ToTable("REINSURAN", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NBRANCH_REI, e.NMODULEC, e.NTYPE_REIN, e.SCLIENT, e.NCOVER, e.DEFFECDATE, e.NCOMPANY });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SHEAP_CODE).HasMaxLength(14);
            entity.Property(e => e.NACEP_CODE).HasMaxLength(10);
            entity.Property(e => e.SMANUALMOV).HasMaxLength(1);
        });

        modelBuilder.Entity<REJECT_CAUSE>(entity =>
        {
            entity.ToTable("REJECT_CAUSE", "INSUDB");
            entity.HasKey(e => new { e.NREJECTCAUSE, e.NBANK_CODE, e.NWAY_PAY });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SNO_ENDEAVOUR).HasMaxLength(1);
        });

        modelBuilder.Entity<REJECTCAUSE_PRECLAIM>(entity =>
        {
            entity.ToTable("REJECTCAUSE_PRECLAIM", "INSUDB");
            entity.HasKey(e => new { e.NIDPRECLAIM, e.NREJECT_CAUSE });
            entity.Property(e => e.SMESSAGE_REJECT).HasMaxLength(200);
        });

        modelBuilder.Entity<RELATIONS>(entity =>
        {
            entity.ToTable("RELATIONS", "INSUDB");
            entity.HasKey(e => new { e.SCLIENTR, e.SCLIENT, e.NRELASHIP });
            entity.Property(e => e.SCLIENTR).HasMaxLength(14);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<RELATIONSHIP>(entity =>
        {
            entity.ToTable("RELATIONSHIP", "INSUDB");
            entity.HasKey(e => e.NIDRELATIONSHIP);
            entity.Property(e => e.SNAME).HasMaxLength(50);
            entity.Property(e => e.SENABLE).HasMaxLength(1);
        });

        modelBuilder.Entity<RELCONCEPTS>(entity =>
        {
            entity.ToTable("RELCONCEPTS", "INSUDB");
            entity.HasKey(e => new { e.NBORDEREAUX, e.NTRANSAC });
            entity.Property(e => e.SSEL).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.STYPE_BANKAGREE).HasMaxLength(1);
            entity.Property(e => e.NRETENTIONSERIES).HasMaxLength(15);
            entity.Property(e => e.NAUTORIZATIONNUMBER).HasMaxLength(37);
        });

        modelBuilder.Entity<REPORTMASTER>(entity =>
        {
            entity.ToTable("REPORTMASTER", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NMODULEC, e.NCOVER, e.NCOD_AGREE });
            entity.Property(e => e.SCODE_REPORT).HasMaxLength(8);
        });

        modelBuilder.Entity<REPORT_PROD>(entity =>
        {
            entity.ToTable("REPORT_PROD", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.DEFFECDATE, e.SCODISPL, e.NTRATYPEP });
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SREPORT).HasMaxLength(50);
        });

        modelBuilder.Entity<REPORTSHEET>(entity =>
        {
            entity.ToTable("REPORTSHEET", "INSUDB");
            entity.HasKey(e => new { e.SCODE_REPORT, e.NBOX, e.NCOLUMN, e.NROW, e.DEFFECDATE });
            entity.Property(e => e.SCODE_REPORT).HasMaxLength(8);
            entity.Property(e => e.SCONTENT).HasMaxLength(4000);
        });

        modelBuilder.Entity<REQ_ENDOR>(entity =>
        {
            entity.ToTable("REQ_ENDOR", "INSUDB");
            entity.HasKey(e => e.NREQENDOR);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCERTYPEENDOR).HasMaxLength(1);
            entity.Property(e => e.SOBS).HasMaxLength(4000);
            entity.Property(e => e.SREASON_REJECT).HasMaxLength(4000);
        });

        modelBuilder.Entity<REQUEST>(entity =>
        {
            entity.ToTable("REQUEST", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.DEFFECDATE, e.NFUNDS });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.STYP_SURR).HasMaxLength(1);
            entity.Property(e => e.SPAYORDER).HasMaxLength(1);
            entity.Property(e => e.SNULL_REC).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SREH_LREC).HasMaxLength(1);
            entity.Property(e => e.SCLIPAYSURR).HasMaxLength(14);
            entity.Property(e => e.SCERTPAYSURR).HasMaxLength(1);
            entity.Property(e => e.SCLIENTINSTITUTION).HasMaxLength(14);
            entity.Property(e => e.SRETURN_IND).HasMaxLength(1);
            entity.Property(e => e.SSWITCHSTATUS).HasMaxLength(1);
            entity.Property(e => e.SIND_INSUR).HasMaxLength(1);
            entity.Property(e => e.SSWITCHORIGIN).HasMaxLength(1);
        });

        modelBuilder.Entity<RETENTIONCOV>(entity =>
        {
            entity.ToTable("RETENTIONCOV", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH_REI, e.DEFFECDATE, e.NNUMBER, e.NTYPE, e.NINSUR_AREA, e.NCOVERGEN });
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
            entity.Property(e => e.SEARTHQUAKE).HasMaxLength(1);
        });

        modelBuilder.Entity<RM_REG_TYPES>(entity =>
        {
            entity.ToTable("RM_REG_TYPES", "INSUDB");
            entity.HasKey(e => new { e.PRODUCT, e.NAME });
            entity.Property(e => e.TABLE_NAME).HasMaxLength(30);
            entity.Property(e => e.PRODUCT).HasMaxLength(240);
            entity.Property(e => e.NAME).HasMaxLength(40);
            entity.Property(e => e.SHORT_NAME).HasMaxLength(30);
            entity.Property(e => e.PLURAL_NAME).HasMaxLength(40);
            entity.Property(e => e.NLS_NAME).HasMaxLength(240);
            entity.Property(e => e.NLS_PLURAL_NAME).HasMaxLength(240);
            entity.Property(e => e.USER_EXTENSION).HasMaxLength(30);
            entity.Property(e => e.HELP_TAG).HasMaxLength(10);
        });

        modelBuilder.Entity<RNULLCONDI>(entity =>
        {
            entity.ToTable("RNULLCONDI", "INSUDB");
            entity.HasKey(e => new { e.NNULLCODE, e.NBRANCH, e.NPRODUCT, e.SPOLITYPE, e.NTRATYPEI, e.DEFFECDATE });
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SPOLICY).HasMaxLength(1);
            entity.Property(e => e.SCERTIF).HasMaxLength(1);
        });

        modelBuilder.Entity<ROLDOCREQ>(entity =>
        {
            entity.ToTable("ROLDOCREQ", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.SPOLITYPE, e.SCOMPON, e.NROLE, e.NCLASSTYPDOC, e.NTYPCLIENTDOC });
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SCOMPON).HasMaxLength(1);
        });

        modelBuilder.Entity<ROLES>(entity =>
        {
            entity.ToTable("ROLES", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NROLE, e.SCLIENT, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SSMOKING).HasMaxLength(1);
            entity.Property(e => e.SVIP).HasMaxLength(1);
            entity.Property(e => e.SCONTINUED).HasMaxLength(1);
            entity.Property(e => e.SPRINTNAME).HasMaxLength(60);
            entity.Property(e => e.SITEM).HasMaxLength(30);
            entity.Property(e => e.SFPHYSICAL_CREDEN).HasMaxLength(1);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
        });

        modelBuilder.Entity<ROLE_TYPE_AMEND>(entity =>
        {
            entity.ToTable("ROLE_TYPE_AMEND", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.DEFFECDATE, e.NTYPE_AMEND, e.NROLEID });
        });

        modelBuilder.Entity<SCHEMA_CUR>(entity =>
        {
            entity.ToTable("SCHEMA_CUR", "INSUDB");
            entity.HasKey(e => new { e.SSCHE_CODE, e.NCURRENCY });
            entity.Property(e => e.SSCHE_CODE).HasMaxLength(6);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<SCHEMA_FOLDER>(entity =>
        {
            entity.ToTable("SCHEMA_FOLDER", "INSUDB");
            entity.HasKey(e => new { e.SSCHE_CODE, e.NFOLDER });
            entity.Property(e => e.SSCHE_CODE).HasMaxLength(6);
            entity.Property(e => e.SPERMITTED).HasMaxLength(1);
        });

        modelBuilder.Entity<SDD_DEPENDENCY_TYPES>(entity =>
        {
            entity.ToTable("SDD_DEPENDENCY_TYPES", "INSUDB");
            entity.HasKey(e => e.IRID);
            entity.Property(e => e.TYPE).HasMaxLength(256);
            entity.Property(e => e.SYSTEM_FLAG).HasMaxLength(1);
            entity.Property(e => e.TRANSITIVE).HasMaxLength(1);
            entity.Property(e => e.CREATED_BY).HasMaxLength(30);
            entity.Property(e => e.CHANGED_BY).HasMaxLength(30);
            entity.Property(e => e.SUBTYPE).HasMaxLength(256);
        });

        modelBuilder.Entity<SDD_DEPEND_STATUSES>(entity =>
        {
            entity.ToTable("SDD_DEPEND_STATUSES", "INSUDB");
            entity.HasKey(e => e.STATUS);
            entity.Property(e => e.STATUS).HasMaxLength(1);
            entity.Property(e => e.DESCRIPTION).HasMaxLength(256);
            entity.Property(e => e.SYSTEM_FLAG).HasMaxLength(1);
            entity.Property(e => e.CREATED_BY).HasMaxLength(30);
            entity.Property(e => e.CHANGED_BY).HasMaxLength(30);
        });

        modelBuilder.Entity<SDD_GLOBAL_NAME_DOMAINS>(entity =>
        {
            entity.ToTable("SDD_GLOBAL_NAME_DOMAINS", "INSUDB");
            entity.HasKey(e => e.IRID);
            entity.Property(e => e.NAME).HasMaxLength(256);
            entity.Property(e => e.SYSTEM_FLAG).HasMaxLength(1);
            entity.Property(e => e.CREATED_BY).HasMaxLength(30);
            entity.Property(e => e.CHANGED_BY).HasMaxLength(30);
        });

        modelBuilder.Entity<SDD_NLS_GLOBAL_NAME_DOMAINS>(entity =>
        {
            entity.ToTable("SDD_NLS_GLOBAL_NAME_DOMAINS", "INSUDB");
            entity.HasKey(e => e.IRID);
            entity.Property(e => e.NLS_NAME).HasMaxLength(256);
            entity.Property(e => e.NLS_PLURAL_NAME).HasMaxLength(256);
            entity.Property(e => e.NLS_LANG).HasMaxLength(3);
            entity.Property(e => e.CREATED_BY).HasMaxLength(30);
            entity.Property(e => e.CHANGED_BY).HasMaxLength(30);
        });

        modelBuilder.Entity<SECTION_PO>(entity =>
        {
            entity.ToTable("SECTION_PO", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.SPOLITYPE, e.SCOMPON, e.SCODISPL, e.NTRATYPEP, e.DEFFECDATE, e.NID });
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SCOMPON).HasMaxLength(1);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SREPORT).HasMaxLength(50);
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

        modelBuilder.Entity<SECUR_SCHE>(entity =>
        {
            entity.ToTable("SECUR_SCHE", "INSUDB");
            entity.HasKey(e => e.SSCHE_CODE);
            entity.Property(e => e.SSCHE_CODE).HasMaxLength(6);
            entity.Property(e => e.SLONGDESC).HasMaxLength(30);
            entity.Property(e => e.SSHORTDES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.STIME1_FROM).HasMaxLength(5);
            entity.Property(e => e.STIME1_TO).HasMaxLength(5);
            entity.Property(e => e.STIME2_FROM).HasMaxLength(5);
            entity.Property(e => e.STIME2_TO).HasMaxLength(5);
            entity.Property(e => e.STIMEQ1_FRO).HasMaxLength(5);
            entity.Property(e => e.STIMEQ1_TO).HasMaxLength(5);
            entity.Property(e => e.STIMEQ2_FRO).HasMaxLength(5);
            entity.Property(e => e.STIMEQ2_TO).HasMaxLength(5);
            entity.Property(e => e.SUSEQUERY).HasMaxLength(1);
            entity.Property(e => e.SENCRYPTED).HasMaxLength(1);
        });

        modelBuilder.Entity<SELLCHANNEL_PROD>(entity =>
        {
            entity.ToTable("SELLCHANNEL_PROD", "INSUDB");
            entity.HasKey(e => new { e.DEFFECDATE, e.NCLASSIFICATION, e.NINTERTYP, e.NSELLCHANNEL });
        });

        modelBuilder.Entity<SEQFOLDER>(entity =>
        {
            entity.ToTable("SEQFOLDER", "INSUDB");
            entity.HasKey(e => new { e.NQUERYTYPE, e.NPARENT, e.NFOLDER });
        });

        modelBuilder.Entity<SEQUEN_POL>(entity =>
        {
            entity.ToTable("SEQUEN_POL", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.SBUSSITYP, e.NTRATYPEP, e.SPOLITYPE, e.SCOMPON, e.NSEQUENCE, e.DEFFECDATE, e.NTYPE_AMEND });
            entity.Property(e => e.SBUSSITYP).HasMaxLength(1);
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SCOMPON).HasMaxLength(1);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
            entity.Property(e => e.SAUTOMATIC).HasMaxLength(1);
        });

        modelBuilder.Entity<SIGNSCAPOFF>(entity =>
        {
            entity.ToTable("SIGNSCAPOFF", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NOFFICE, e.NCURRENCY, e.NUSERSIGN, e.NORDSIGN, e.NCAPMINSING, e.NCAPMAXSING, e.DEFFECDATE });
            entity.Property(e => e.SSTATREG).HasMaxLength(1);
        });

        modelBuilder.Entity<SIGNSREP>(entity =>
        {
            entity.ToTable("SIGNSREP", "INSUDB");
            entity.HasKey(e => new { e.NUSERSIGN, e.DEFFECDATE });
            entity.Property(e => e.SPOSITION).HasMaxLength(50);
            entity.Property(e => e.SPATHSING).HasMaxLength(250);
            entity.Property(e => e.SSTATREG).HasMaxLength(1);
        });

        modelBuilder.Entity<SITUATION>(entity =>
        {
            entity.ToTable("SITUATION", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NSITUATION, e.NCOD_AGREE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

        modelBuilder.Entity<SPORT>(entity =>
        {
            entity.ToTable("SPORT", "INSUDB");
            entity.HasKey(e => new { e.NSPORT, e.SCLIENT });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<STATUS_CLAIM>(entity =>
        {
            entity.ToTable("STATUS_CLAIM", "INSUDB");
            entity.HasKey(e => e.NIDSTATUSCLAIM);
            entity.Property(e => e.SNAME).HasMaxLength(50);
            entity.Property(e => e.SENABLE).HasMaxLength(1);
        });

        modelBuilder.Entity<STIPEND_POL>(entity =>
        {
            entity.ToTable("STIPEND_POL", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NROLE, e.SCLIENT, e.NTYPE_CONTRAT, e.DEFFECDATE });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCOMMITYP).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_AM_EXC>(entity =>
        {
            entity.ToTable("TAB_AM_EXC", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NTARIFF, e.SILLNESS, e.DEFFECDATE, e.NID });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SILLNESS).HasMaxLength(8);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.STYPE_EXC).HasMaxLength(1);
            entity.Property(e => e.SPREEXISTING).HasMaxLength(1);
            entity.Property(e => e.SCARENCY).HasMaxLength(1);
            entity.Property(e => e.SPERMANENT).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(200);
            entity.Property(e => e.SSEL).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_AM_ILL>(entity =>
        {
            entity.ToTable("TAB_AM_ILL", "INSUDB");
            entity.HasKey(e => e.SILLNESS);
            entity.Property(e => e.SILLNESS).HasMaxLength(8);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(260);
            entity.Property(e => e.SILL_OMS).HasMaxLength(6);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SIND_SEVERITY).HasMaxLength(1);
            entity.Property(e => e.SIND_FRECUENCY).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_AU_VEH>(entity =>
        {
            entity.ToTable("TAB_AU_VEH", "INSUDB");
            entity.HasKey(e => e.SVEHCODE);
            entity.Property(e => e.SVEHCODE).HasMaxLength(6);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SVEHMODEL).HasMaxLength(30);
            entity.Property(e => e.SAACHCODE).HasMaxLength(100);
        });

        modelBuilder.Entity<TAB_BILL_I>(entity =>
        {
            entity.ToTable("TAB_BILL_I", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NBILL_ITEM, e.DEFFECDATE });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
        });

        modelBuilder.Entity<TAB_BK_AGE>(entity =>
        {
            entity.ToTable("TAB_BK_AGE", "INSUDB");
            entity.HasKey(e => new { e.NBANK_CODE, e.NBK_AGENCY });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SN_ABA).HasMaxLength(20);
        });

        modelBuilder.Entity<TAB_CLAUSE>(entity =>
        {
            entity.ToTable("TAB_CLAUSE", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NMODULEC, e.NCOVER, e.NCLAUSE, e.DEFFECDATE });
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SMODIFIED).HasMaxLength(1);
            entity.Property(e => e.STYPE_CLAUSE).HasMaxLength(1);
            entity.Property(e => e.SDOC_ATTACH).HasMaxLength(45);
            entity.Property(e => e.STITCLAUSE).HasMaxLength(100);
        });

        modelBuilder.Entity<TAB_CL_OPE>(entity =>
        {
            entity.ToTable("TAB_CL_OPE", "INSUDB");
            entity.HasKey(e => e.NOPER_TYPE);
        });

        modelBuilder.Entity<TAB_COLLECTCOMM>(entity =>
        {
            entity.ToTable("TAB_COLLECTCOMM", "INSUDB");
            entity.HasKey(e => e.NCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_COMLIF>(entity =>
        {
            entity.ToTable("TAB_COMLIF", "INSUDB");
            entity.HasKey(e => e.NCOMTABLI);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_COMPRO>(entity =>
        {
            entity.ToTable("TAB_COMPRO", "INSUDB");
            entity.HasKey(e => new { e.NTYPE_TRAN, e.NLINE });
            entity.Property(e => e.SDEBITSIDE).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_COVROL>(entity =>
        {
            entity.ToTable("TAB_COVROL", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NMODULEC, e.NCOVER, e.NROLE, e.DEFFECDATE });
            entity.Property(e => e.SREQUIRED).HasMaxLength(1);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SROUPREMI).HasMaxLength(12);
            entity.Property(e => e.SRECHAPRI).HasMaxLength(1);
            entity.Property(e => e.SRENEWALI).HasMaxLength(1);
            entity.Property(e => e.SROUCHACA).HasMaxLength(12);
            entity.Property(e => e.SROUCHAPR).HasMaxLength(12);
            entity.Property(e => e.SREVINDEX).HasMaxLength(1);
            entity.Property(e => e.SROUPRCAL).HasMaxLength(12);
            entity.Property(e => e.SFRANCAPL).HasMaxLength(1);
            entity.Property(e => e.SROUFRANC).HasMaxLength(12);
            entity.Property(e => e.SFRANTYPE).HasMaxLength(1);
            entity.Property(e => e.SFDREQUIRE).HasMaxLength(1);
            entity.Property(e => e.SFDCHANTYP).HasMaxLength(1);
            entity.Property(e => e.SROUTINECC).HasMaxLength(12);
            entity.Property(e => e.SAPPLYCC).HasMaxLength(1);
            entity.Property(e => e.SCHTYPCAP).HasMaxLength(1);
            entity.Property(e => e.SCHANGETYP).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SROUT_PAY).HasMaxLength(12);
            entity.Property(e => e.SCAREN_TYPE).HasMaxLength(1);
            entity.Property(e => e.SCLACCIDI).HasMaxLength(12);
            entity.Property(e => e.SCLDEATHI).HasMaxLength(12);
            entity.Property(e => e.SCLINCAPI).HasMaxLength(12);
            entity.Property(e => e.SCLINVALI).HasMaxLength(12);
            entity.Property(e => e.SCLVEHACI).HasMaxLength(12);
            entity.Property(e => e.SCLIILLNESS).HasMaxLength(12);
            entity.Property(e => e.SCACALTYP).HasMaxLength(1);
            entity.Property(e => e.SCLSURVII).HasMaxLength(12);
            entity.Property(e => e.SLEG).HasMaxLength(1);
            entity.Property(e => e.SROU_COND_CAP).HasMaxLength(12);
            entity.Property(e => e.SROURATE).HasMaxLength(12);
            entity.Property(e => e.SDEVPRIMEXCESS).HasMaxLength(1);
            entity.Property(e => e.SPROVCOV).HasMaxLength(1);
            entity.Property(e => e.SMAX_EVEN).HasMaxLength(1);
            entity.Property(e => e.SROUTMAX_EVEN).HasMaxLength(12);
            entity.Property(e => e.SROUT_REDUCTCAP).HasMaxLength(12);
            entity.Property(e => e.SEXEMPTION).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_DENTITION>(entity =>
        {
            entity.ToTable("TAB_DENTITION", "INSUDB");
            entity.HasKey(e => e.NIDDENTITION);
            entity.Property(e => e.SADA).HasMaxLength(2);
            entity.Property(e => e.SFDI).HasMaxLength(2);
            entity.Property(e => e.STOOTHNAM).HasMaxLength(30);
            entity.Property(e => e.SPALATINE).HasMaxLength(1);
            entity.Property(e => e.SLINGUAL).HasMaxLength(1);
            entity.Property(e => e.SVESTIBULAR).HasMaxLength(1);
            entity.Property(e => e.SMESIAL).HasMaxLength(1);
            entity.Property(e => e.SDISTAL).HasMaxLength(1);
            entity.Property(e => e.SINCISAL).HasMaxLength(1);
            entity.Property(e => e.SOCLUSAL).HasMaxLength(1);
            entity.Property(e => e.SLABIAL).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_DOCU>(entity =>
        {
            entity.ToTable("TAB_DOCU", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NDOC_CODE, e.NPRODUCT, e.NCOVER, e.NMODULEC, e.NCAUSECOD });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCLAIMPAY).HasMaxLength(1);
            entity.Property(e => e.STEXT).HasMaxLength(500);
            entity.Property(e => e.SREQUIERED).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_FN_INSTITUTION>(entity =>
        {
            entity.ToTable("TAB_FN_INSTITUTION", "INSUDB");
            entity.HasKey(e => e.NINSTITUTION);
            entity.Property(e => e.SNAME).HasMaxLength(50);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SINSTITUTION).HasMaxLength(5);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SDIGIT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_FONASA>(entity =>
        {
            entity.ToTable("TAB_FONASA", "INSUDB");
            entity.HasKey(e => new { e.NYEAR, e.SSERVICE, e.SSUBSERVICE, e.NCURRENCY, e.DEFFECDATE });
            entity.Property(e => e.SSERVICE).HasMaxLength(10);
            entity.Property(e => e.SSUBSERVICE).HasMaxLength(4);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

        modelBuilder.Entity<TAB_GENCOV>(entity =>
        {
            entity.ToTable("TAB_GENCOV", "INSUDB");
            entity.HasKey(e => e.NCOVERGEN);
            entity.Property(e => e.SAUTOMREP).HasMaxLength(1);
            entity.Property(e => e.SCACALFRI).HasMaxLength(1);
            entity.Property(e => e.SCACALILI).HasMaxLength(1);
            entity.Property(e => e.SCACALREI).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(120);
            entity.Property(e => e.SFRANCAPL).HasMaxLength(1);
            entity.Property(e => e.SFRANTYPE).HasMaxLength(1);
            entity.Property(e => e.SROUCAPIT).HasMaxLength(12);
            entity.Property(e => e.SROUFRANC).HasMaxLength(12);
            entity.Property(e => e.SROUPREMI).HasMaxLength(12);
            entity.Property(e => e.SROURESER).HasMaxLength(12);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCONDSVS).HasMaxLength(30);
            entity.Property(e => e.SINFORPROV).HasMaxLength(1);
            entity.Property(e => e.SPROVIDER).HasMaxLength(14);
            entity.Property(e => e.SRISK).HasMaxLength(1);
            entity.Property(e => e.SROUFRANCCLA).HasMaxLength(12);
            entity.Property(e => e.STAXHEREDITY).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_GOALS>(entity =>
        {
            entity.ToTable("TAB_GOALS", "INSUDB");
            entity.HasKey(e => e.NCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLESHEET>(entity =>
        {
            entity.ToTable("TABLESHEET", "INSUDB");
            entity.HasKey(e => new { e.NSHEET, e.STABLE });
            entity.Property(e => e.STABLE).HasMaxLength(40);
            entity.Property(e => e.SALIAS).HasMaxLength(5);
        });

        modelBuilder.Entity<TABLE1>(entity =>
        {
            entity.ToTable("TABLE1", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE10>(entity =>
        {
            entity.ToTable("TABLE10", "INSUDB");
            entity.HasKey(e => e.NBRANCH);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE1000>(entity =>
        {
            entity.ToTable("TABLE1000", "INSUDB");
            entity.HasKey(e => e.NCODTOLER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE1006>(entity =>
        {
            entity.ToTable("TABLE1006", "INSUDB");
            entity.HasKey(e => e.NPRIORITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE1007>(entity =>
        {
            entity.ToTable("TABLE1007", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE1008>(entity =>
        {
            entity.ToTable("TABLE1008", "INSUDB");
            entity.HasKey(e => e.NVAL_ASSO);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE1009>(entity =>
        {
            entity.ToTable("TABLE1009", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE1014>(entity =>
        {
            entity.ToTable("TABLE1014", "INSUDB");
            entity.HasKey(e => e.NKEYNUM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE105>(entity =>
        {
            entity.ToTable("TABLE105", "INSUDB");
            entity.HasKey(e => e.STYPE);
            entity.Property(e => e.STYPE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE108>(entity =>
        {
            entity.ToTable("TABLE108", "INSUDB");
            entity.HasKey(e => e.SPERIODTYP);
            entity.Property(e => e.SPERIODTYP).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE11>(entity =>
        {
            entity.ToTable("TABLE11", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE113>(entity =>
        {
            entity.ToTable("TABLE113", "INSUDB");
            entity.HasKey(e => e.NBENEFAPL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE114>(entity =>
        {
            entity.ToTable("TABLE114", "INSUDB");
            entity.HasKey(e => e.NSURRFREQ);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE118>(entity =>
        {
            entity.ToTable("TABLE118", "INSUDB");
            entity.HasKey(e => e.NARTICLE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(100);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE12>(entity =>
        {
            entity.ToTable("TABLE12", "INSUDB");
            entity.HasKey(e => e.NROLE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE124>(entity =>
        {
            entity.ToTable("TABLE124", "INSUDB");
            entity.HasKey(e => e.NPRODCLAS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE125>(entity =>
        {
            entity.ToTable("TABLE125", "INSUDB");
            entity.HasKey(e => e.NVALUESTY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE126>(entity =>
        {
            entity.ToTable("TABLE126", "INSUDB");
            entity.HasKey(e => e.NVALUESMO);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE127>(entity =>
        {
            entity.ToTable("TABLE127", "INSUDB");
            entity.HasKey(e => e.NTYPE_RESERVE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(50);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE13>(entity =>
        {
            entity.ToTable("TABLE13", "INSUDB");
            entity.HasKey(e => e.NNULLCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE132>(entity =>
        {
            entity.ToTable("TABLE132", "INSUDB");
            entity.HasKey(e => e.SCLAIMTYP);
            entity.Property(e => e.SCLAIMTYP).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE133>(entity =>
        {
            entity.ToTable("TABLE133", "INSUDB");
            entity.HasKey(e => e.NUNACCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE135>(entity =>
        {
            entity.ToTable("TABLE135", "INSUDB");
            entity.HasKey(e => e.SSTACLAIM);
            entity.Property(e => e.SSTACLAIM).HasMaxLength(2);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE136>(entity =>
        {
            entity.ToTable("TABLE136", "INSUDB");
            entity.HasKey(e => e.NNULLCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE137>(entity =>
        {
            entity.ToTable("TABLE137", "INSUDB");
            entity.HasKey(e => e.NTYPE_PAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE138>(entity =>
        {
            entity.ToTable("TABLE138", "INSUDB");
            entity.HasKey(e => e.NPAY_FORM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE14>(entity =>
        {
            entity.ToTable("TABLE14", "INSUDB");
            entity.HasKey(e => e.NCIVILSTA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE140>(entity =>
        {
            entity.ToTable("TABLE140", "INSUDB");
            entity.HasKey(e => e.NOPER_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE141>(entity =>
        {
            entity.ToTable("TABLE141", "INSUDB");
            entity.HasKey(e => e.NEVALSTAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE146>(entity =>
        {
            entity.ToTable("TABLE146", "INSUDB");
            entity.HasKey(e => e.NCLASS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE147>(entity =>
        {
            entity.ToTable("TABLE147", "INSUDB");
            entity.HasKey(e => e.NECONOMIC_L);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE149>(entity =>
        {
            entity.ToTable("TABLE149", "INSUDB");
            entity.HasKey(e => e.NHOUSE_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE15>(entity =>
        {
            entity.ToTable("TABLE15", "INSUDB");
            entity.HasKey(e => e.NRELASHIP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE151>(entity =>
        {
            entity.ToTable("TABLE151", "INSUDB");
            entity.HasKey(e => e.NCODE_SUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE153>(entity =>
        {
            entity.ToTable("TABLE153", "INSUDB");
            entity.HasKey(e => e.SERRORTYP);
            entity.Property(e => e.SERRORTYP).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE154>(entity =>
        {
            entity.ToTable("TABLE154", "INSUDB");
            entity.HasKey(e => e.SREVALAPL);
            entity.Property(e => e.SREVALAPL).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE157>(entity =>
        {
            entity.ToTable("TABLE157", "INSUDB");
            entity.HasKey(e => e.SCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE159>(entity =>
        {
            entity.ToTable("TABLE159", "INSUDB");
            entity.HasKey(e => e.NGROUP_PRES);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE16>(entity =>
        {
            entity.ToTable("TABLE16", "INSUDB");
            entity.HasKey(e => e.NSPECIALITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE160>(entity =>
        {
            entity.ToTable("TABLE160", "INSUDB");
            entity.HasKey(e => e.NPAY_CONCEP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE161>(entity =>
        {
            entity.ToTable("TABLE161", "INSUDB");
            entity.HasKey(e => e.SSTYLE_COMM);
            entity.Property(e => e.SSTYLE_COMM).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE163>(entity =>
        {
            entity.ToTable("TABLE163", "INSUDB");
            entity.HasKey(e => e.NNULLCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE165>(entity =>
        {
            entity.ToTable("TABLE165", "INSUDB");
            entity.HasKey(e => e.NTYPE_HIST);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE17>(entity =>
        {
            entity.ToTable("TABLE17", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE173>(entity =>
        {
            entity.ToTable("TABLE173", "INSUDB");
            entity.HasKey(e => e.NTYPE_REIN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE174>(entity =>
        {
            entity.ToTable("TABLE174", "INSUDB");
            entity.HasKey(e => e.NCLASS_AP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE178>(entity =>
        {
            entity.ToTable("TABLE178", "INSUDB");
            entity.HasKey(e => e.NAREA_LED);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE179>(entity =>
        {
            entity.ToTable("TABLE179", "INSUDB");
            entity.HasKey(e => e.NTYPECASH);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE18>(entity =>
        {
            entity.ToTable("TABLE18", "INSUDB");
            entity.HasKey(e => e.SSEXCLIEN);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE180>(entity =>
        {
            entity.ToTable("TABLE180", "INSUDB");
            entity.HasKey(e => e.NFOR_PAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE181>(entity =>
        {
            entity.ToTable("TABLE181", "INSUDB");
            entity.HasKey(e => e.SSTATUSVA);
            entity.Property(e => e.SSTATUSVA).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE182>(entity =>
        {
            entity.ToTable("TABLE182", "INSUDB");
            entity.HasKey(e => e.SPAY_FORM);
            entity.Property(e => e.SPAY_FORM).HasMaxLength(2);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE183>(entity =>
        {
            entity.ToTable("TABLE183", "INSUDB");
            entity.HasKey(e => e.NCARD_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE184>(entity =>
        {
            entity.ToTable("TABLE184", "INSUDB");
            entity.HasKey(e => e.NBENE_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE185>(entity =>
        {
            entity.ToTable("TABLE185", "INSUDB");
            entity.HasKey(e => e.NFINANSTAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE187>(entity =>
        {
            entity.ToTable("TABLE187", "INSUDB");
            entity.HasKey(e => e.NSTA_CHEQUE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE19>(entity =>
        {
            entity.ToTable("TABLE19", "INSUDB");
            entity.HasKey(e => e.NSTATUS_PRE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE190>(entity =>
        {
            entity.ToTable("TABLE190", "INSUDB");
            entity.HasKey(e => e.NACC_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE191>(entity =>
        {
            entity.ToTable("TABLE191", "INSUDB");
            entity.HasKey(e => e.SSTATLOAN);
            entity.Property(e => e.SSTATLOAN).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE192>(entity =>
        {
            entity.ToTable("TABLE192", "INSUDB");
            entity.HasKey(e => e.NCL_SEQ_TRA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE193>(entity =>
        {
            entity.ToTable("TABLE193", "INSUDB");
            entity.HasKey(e => e.SREQUEST_TY);
            entity.Property(e => e.SREQUEST_TY).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE195>(entity =>
        {
            entity.ToTable("TABLE195", "INSUDB");
            entity.HasKey(e => e.SCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE196>(entity =>
        {
            entity.ToTable("TABLE196", "INSUDB");
            entity.HasKey(e => e.SCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE197>(entity =>
        {
            entity.ToTable("TABLE197", "INSUDB");
            entity.HasKey(e => e.NAVAIL_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE199>(entity =>
        {
            entity.ToTable("TABLE199", "INSUDB");
            entity.HasKey(e => e.NPAY_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE2>(entity =>
        {
            entity.ToTable("TABLE2", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE20>(entity =>
        {
            entity.ToTable("TABLE20", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE200>(entity =>
        {
            entity.ToTable("TABLE200", "INSUDB");
            entity.HasKey(e => e.NINT_STATUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE2000>(entity =>
        {
            entity.ToTable("TABLE2000", "INSUDB");
            entity.HasKey(e => e.NAPLY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE201>(entity =>
        {
            entity.ToTable("TABLE201", "INSUDB");
            entity.HasKey(e => e.NTYPEWARRANTY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE203>(entity =>
        {
            entity.ToTable("TABLE203", "INSUDB");
            entity.HasKey(e => e.NSTATUS_DOC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE204>(entity =>
        {
            entity.ToTable("TABLE204", "INSUDB");
            entity.HasKey(e => e.NBLAME);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE205>(entity =>
        {
            entity.ToTable("TABLE205", "INSUDB");
            entity.HasKey(e => e.NINFRACTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE21>(entity =>
        {
            entity.ToTable("TABLE21", "INSUDB");
            entity.HasKey(e => e.NLEVEL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE210>(entity =>
        {
            entity.ToTable("TABLE210", "INSUDB");
            entity.HasKey(e => e.NCLA_LI_TYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(100);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(50);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE211>(entity =>
        {
            entity.ToTable("TABLE211", "INSUDB");
            entity.HasKey(e => e.NIN_LIF_TYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE215>(entity =>
        {
            entity.ToTable("TABLE215", "INSUDB");
            entity.HasKey(e => e.NSTATUS_ORD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE216>(entity =>
        {
            entity.ToTable("TABLE216", "INSUDB");
            entity.HasKey(e => e.NRECOVER_TYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE219>(entity =>
        {
            entity.ToTable("TABLE219", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE22>(entity =>
        {
            entity.ToTable("TABLE22", "INSUDB");
            entity.HasKey(e => e.NCONCEPT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE220>(entity =>
        {
            entity.ToTable("TABLE220", "INSUDB");
            entity.HasKey(e => e.NVESTATUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE221>(entity =>
        {
            entity.ToTable("TABLE221", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE222>(entity =>
        {
            entity.ToTable("TABLE222", "INSUDB");
            entity.HasKey(e => e.NTITLE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE224>(entity =>
        {
            entity.ToTable("TABLE224", "INSUDB");
            entity.HasKey(e => e.NAUTOZONE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE226>(entity =>
        {
            entity.ToTable("TABLE226", "INSUDB");
            entity.HasKey(e => e.NVEHTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SAACHCODE).HasMaxLength(100);
        });

        modelBuilder.Entity<TABLE23>(entity =>
        {
            entity.ToTable("TABLE23", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE232>(entity =>
        {
            entity.ToTable("TABLE232", "INSUDB");
            entity.HasKey(e => e.NCLASSMERCH);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE233>(entity =>
        {
            entity.ToTable("TABLE233", "INSUDB");
            entity.HasKey(e => e.NCONSTCAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE235>(entity =>
        {
            entity.ToTable("TABLE235", "INSUDB");
            entity.HasKey(e => e.SDECLA_TYPE);
            entity.Property(e => e.SDECLA_TYPE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE237>(entity =>
        {
            entity.ToTable("TABLE237", "INSUDB");
            entity.HasKey(e => e.NPACKING);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE239>(entity =>
        {
            entity.ToTable("TABLE239", "INSUDB");
            entity.HasKey(e => e.NUBICATION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE24>(entity =>
        {
            entity.ToTable("TABLE24", "INSUDB");
            entity.HasKey(e => e.NTRATYPEI);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE240>(entity =>
        {
            entity.ToTable("TABLE240", "INSUDB");
            entity.HasKey(e => e.NCATEGORY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE241>(entity =>
        {
            entity.ToTable("TABLE241", "INSUDB");
            entity.HasKey(e => e.NRISKCLASS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE242>(entity =>
        {
            entity.ToTable("TABLE242", "INSUDB");
            entity.HasKey(e => e.NUNIT_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE245>(entity =>
        {
            entity.ToTable("TABLE245", "INSUDB");
            entity.HasKey(e => e.NTYPELOAN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE248>(entity =>
        {
            entity.ToTable("TABLE248", "INSUDB");
            entity.HasKey(e => e.NRISK);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE249>(entity =>
        {
            entity.ToTable("TABLE249", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE25>(entity =>
        {
            entity.ToTable("TABLE25", "INSUDB");
            entity.HasKey(e => e.STIMEREN);
            entity.Property(e => e.STIMEREN).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE250>(entity =>
        {
            entity.ToTable("TABLE250", "INSUDB");
            entity.HasKey(e => e.NFRECUENCY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE251>(entity =>
        {
            entity.ToTable("TABLE251", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE252>(entity =>
        {
            entity.ToTable("TABLE252", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE253>(entity =>
        {
            entity.ToTable("TABLE253", "INSUDB");
            entity.HasKey(e => e.NSTAT_DRAFT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE254>(entity =>
        {
            entity.ToTable("TABLE254", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE255>(entity =>
        {
            entity.ToTable("TABLE255", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE256>(entity =>
        {
            entity.ToTable("TABLE256", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE258>(entity =>
        {
            entity.ToTable("TABLE258", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE259>(entity =>
        {
            entity.ToTable("TABLE259", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE26>(entity =>
        {
            entity.ToTable("TABLE26", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE260>(entity =>
        {
            entity.ToTable("TABLE260", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE268>(entity =>
        {
            entity.ToTable("TABLE268", "INSUDB");
            entity.HasKey(e => e.NGROUP_COMP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE269>(entity =>
        {
            entity.ToTable("TABLE269", "INSUDB");
            entity.HasKey(e => e.NDED_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE270>(entity =>
        {
            entity.ToTable("TABLE270", "INSUDB");
            entity.HasKey(e => e.NBENEF_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE271>(entity =>
        {
            entity.ToTable("TABLE271", "INSUDB");
            entity.HasKey(e => e.NEXC_CODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(250);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE273>(entity =>
        {
            entity.ToTable("TABLE273", "INSUDB");
            entity.HasKey(e => e.NCATEG);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE275>(entity =>
        {
            entity.ToTable("TABLE275", "INSUDB");
            entity.HasKey(e => e.NSTAT_DOCREQ);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE276>(entity =>
        {
            entity.ToTable("TABLE276", "INSUDB");
            entity.HasKey(e => e.STYPE_INFOR);
            entity.Property(e => e.STYPE_INFOR).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE277>(entity =>
        {
            entity.ToTable("TABLE277", "INSUDB");
            entity.HasKey(e => e.NSERVICE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE278>(entity =>
        {
            entity.ToTable("TABLE278", "INSUDB");
            entity.HasKey(e => e.NSTAT_CONTR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE282>(entity =>
        {
            entity.ToTable("TABLE282", "INSUDB");
            entity.HasKey(e => e.NSTATPRINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE283>(entity =>
        {
            entity.ToTable("TABLE283", "INSUDB");
            entity.HasKey(e => e.NPOSITION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE285>(entity =>
        {
            entity.ToTable("TABLE285", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE286>(entity =>
        {
            entity.ToTable("TABLE286", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE287>(entity =>
        {
            entity.ToTable("TABLE287", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE288>(entity =>
        {
            entity.ToTable("TABLE288", "INSUDB");
            entity.HasKey(e => e.NTYPE_DOC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE289>(entity =>
        {
            entity.ToTable("TABLE289", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE290>(entity =>
        {
            entity.ToTable("TABLE290", "INSUDB");
            entity.HasKey(e => e.SCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE291>(entity =>
        {
            entity.ToTable("TABLE291", "INSUDB");
            entity.HasKey(e => e.STYPE_ASSIG);
            entity.Property(e => e.STYPE_ASSIG).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE293>(entity =>
        {
            entity.ToTable("TABLE293", "INSUDB");
            entity.HasKey(e => e.NCONCEPT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE294>(entity =>
        {
            entity.ToTable("TABLE294", "INSUDB");
            entity.HasKey(e => e.NEFFCLAMO);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE295>(entity =>
        {
            entity.ToTable("TABLE295", "INSUDB");
            entity.HasKey(e => e.NNULLCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE296>(entity =>
        {
            entity.ToTable("TABLE296", "INSUDB");
            entity.HasKey(e => e.NTYPE_MOV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE297>(entity =>
        {
            entity.ToTable("TABLE297", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE298>(entity =>
        {
            entity.ToTable("TABLE298", "INSUDB");
            entity.HasKey(e => e.NAPLICATION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE30>(entity =>
        {
            entity.ToTable("TABLE30", "INSUDB");
            entity.HasKey(e => e.SDISEXPRI);
            entity.Property(e => e.SDISEXPRI).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE300>(entity =>
        {
            entity.ToTable("TABLE300", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE3012>(entity =>
        {
            entity.ToTable("TABLE3012", "INSUDB");
            entity.HasKey(e => e.NENDORSETYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE3019>(entity =>
        {
            entity.ToTable("TABLE3019", "INSUDB");
            entity.HasKey(e => e.NRECOWNER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE3022>(entity =>
        {
            entity.ToTable("TABLE3022", "INSUDB");
            entity.HasKey(e => e.NENDORSEOWN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE304>(entity =>
        {
            entity.ToTable("TABLE304", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE307>(entity =>
        {
            entity.ToTable("TABLE307", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE308>(entity =>
        {
            entity.ToTable("TABLE308", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE311>(entity =>
        {
            entity.ToTable("TABLE311", "INSUDB");
            entity.HasKey(e => e.NARITOPER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE312>(entity =>
        {
            entity.ToTable("TABLE312", "INSUDB");
            entity.HasKey(e => e.NLINK);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE313>(entity =>
        {
            entity.ToTable("TABLE313", "INSUDB");
            entity.HasKey(e => e.NOPERATOR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE314>(entity =>
        {
            entity.ToTable("TABLE314", "INSUDB");
            entity.HasKey(e => e.NEXP_ROUTINE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE32>(entity =>
        {
            entity.ToTable("TABLE32", "INSUDB");
            entity.HasKey(e => e.NCRTHECNI);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(100);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE320>(entity =>
        {
            entity.ToTable("TABLE320", "INSUDB");
            entity.HasKey(e => e.NOPERATOR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE321>(entity =>
        {
            entity.ToTable("TABLE321", "INSUDB");
            entity.HasKey(e => e.NFUNCTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE322>(entity =>
        {
            entity.ToTable("TABLE322", "INSUDB");
            entity.HasKey(e => e.NCONDACTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE323>(entity =>
        {
            entity.ToTable("TABLE323", "INSUDB");
            entity.HasKey(e => e.NSEQUENCE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE324>(entity =>
        {
            entity.ToTable("TABLE324", "INSUDB");
            entity.HasKey(e => e.NTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE33>(entity =>
        {
            entity.ToTable("TABLE33", "INSUDB");
            entity.HasKey(e => e.SFRANCAPL);
            entity.Property(e => e.SFRANCAPL).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE333>(entity =>
        {
            entity.ToTable("TABLE333", "INSUDB");
            entity.HasKey(e => e.NTYPE_MOVE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE334>(entity =>
        {
            entity.ToTable("TABLE334", "INSUDB");
            entity.HasKey(e => e.NSTATUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE34>(entity =>
        {
            entity.ToTable("TABLE34", "INSUDB");
            entity.HasKey(e => e.NANLIFINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE340>(entity =>
        {
            entity.ToTable("TABLE340", "INSUDB");
            entity.HasKey(e => e.NFREQMAXEVEN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE36>(entity =>
        {
            entity.ToTable("TABLE36", "INSUDB");
            entity.HasKey(e => e.NPAYFREQ);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE360>(entity =>
        {
            entity.ToTable("TABLE360", "INSUDB");
            entity.HasKey(e => e.NTYPEATTRIBUT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE37>(entity =>
        {
            entity.ToTable("TABLE37", "INSUDB");
            entity.HasKey(e => e.SBRANCHT);
            entity.Property(e => e.SBRANCHT).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE4>(entity =>
        {
            entity.ToTable("TABLE4", "INSUDB");
            entity.HasKey(e => e.NBILL_ITEM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE40>(entity =>
        {
            entity.ToTable("TABLE40", "INSUDB");
            entity.HasKey(e => e.SCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE400>(entity =>
        {
            entity.ToTable("TABLE400", "INSUDB");
            entity.HasKey(e => e.NTYP_ACCO);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE401>(entity =>
        {
            entity.ToTable("TABLE401", "INSUDB");
            entity.HasKey(e => e.NTYPE_MOVE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE403>(entity =>
        {
            entity.ToTable("TABLE403", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE41>(entity =>
        {
            entity.ToTable("TABLE41", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE415>(entity =>
        {
            entity.ToTable("TABLE415", "INSUDB");
            entity.HasKey(e => e.NMOVE_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE416>(entity =>
        {
            entity.ToTable("TABLE416", "INSUDB");
            entity.HasKey(e => e.NCONCEPT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE417>(entity =>
        {
            entity.ToTable("TABLE417", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE418>(entity =>
        {
            entity.ToTable("TABLE418", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE45>(entity =>
        {
            entity.ToTable("TABLE45", "INSUDB");
            entity.HasKey(e => e.SHOLDER);
            entity.Property(e => e.SHOLDER).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE46>(entity =>
        {
            entity.ToTable("TABLE46", "INSUDB");
            entity.HasKey(e => e.SREVALTYP);
            entity.Property(e => e.SREVALTYP).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE47>(entity =>
        {
            entity.ToTable("TABLE47", "INSUDB");
            entity.HasKey(e => e.SCOMMITYP);
            entity.Property(e => e.SCOMMITYP).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE48>(entity =>
        {
            entity.ToTable("TABLE48", "INSUDB");
            entity.HasKey(e => e.NTYPE_RESERVE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(50);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE49>(entity =>
        {
            entity.ToTable("TABLE49", "INSUDB");
            entity.HasKey(e => e.SCOLREINT);
            entity.Property(e => e.SCOLREINT).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE50>(entity =>
        {
            entity.ToTable("TABLE50", "INSUDB");
            entity.HasKey(e => e.SCOLINVOT);
            entity.Property(e => e.SCOLINVOT).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5000>(entity =>
        {
            entity.ToTable("TABLE5000", "INSUDB");
            entity.HasKey(e => e.NBRANCH_REI);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5001>(entity =>
        {
            entity.ToTable("TABLE5001", "INSUDB");
            entity.HasKey(e => e.NINSUR_AREA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5002>(entity =>
        {
            entity.ToTable("TABLE5002", "INSUDB");
            entity.HasKey(e => e.NWAY_PAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(100);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5003>(entity =>
        {
            entity.ToTable("TABLE5003", "INSUDB");
            entity.HasKey(e => e.NREJECTCAUSE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5004>(entity =>
        {
            entity.ToTable("TABLE5004", "INSUDB");
            entity.HasKey(e => e.NSTATUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5005>(entity =>
        {
            entity.ToTable("TABLE5005", "INSUDB");
            entity.HasKey(e => e.NCANCEL_COD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5006>(entity =>
        {
            entity.ToTable("TABLE5006", "INSUDB");
            entity.HasKey(e => e.NPERSON_TYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5007>(entity =>
        {
            entity.ToTable("TABLE5007", "INSUDB");
            entity.HasKey(e => e.SINDTYPTOT);
            entity.Property(e => e.SINDTYPTOT).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5008>(entity =>
        {
            entity.ToTable("TABLE5008", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5009>(entity =>
        {
            entity.ToTable("TABLE5009", "INSUDB");
            entity.HasKey(e => e.NCOMERLINE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE502>(entity =>
        {
            entity.ToTable("TABLE502", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE511>(entity =>
        {
            entity.ToTable("TABLE511", "INSUDB");
            entity.HasKey(e => e.SIND_TYPE);
            entity.Property(e => e.SIND_TYPE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE512>(entity =>
        {
            entity.ToTable("TABLE512", "INSUDB");
            entity.HasKey(e => e.NSPORT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE515>(entity =>
        {
            entity.ToTable("TABLE515", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE52>(entity =>
        {
            entity.ToTable("TABLE52", "INSUDB");
            entity.HasKey(e => e.SCAREN_TYPE);
            entity.Property(e => e.SCAREN_TYPE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE521>(entity =>
        {
            entity.ToTable("TABLE521", "INSUDB");
            entity.HasKey(e => e.NINF_ORDER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE525>(entity =>
        {
            entity.ToTable("TABLE525", "INSUDB");
            entity.HasKey(e => e.NMOD_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE526>(entity =>
        {
            entity.ToTable("TABLE526", "INSUDB");
            entity.HasKey(e => e.NTYPE_PROCE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(50);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE527>(entity =>
        {
            entity.ToTable("TABLE527", "INSUDB");
            entity.HasKey(e => e.NSINIES_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE531>(entity =>
        {
            entity.ToTable("TABLE531", "INSUDB");
            entity.HasKey(e => e.NSOURCE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE532>(entity =>
        {
            entity.ToTable("TABLE532", "INSUDB");
            entity.HasKey(e => e.NTYP_AMOUNT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE533>(entity =>
        {
            entity.ToTable("TABLE533", "INSUDB");
            entity.HasKey(e => e.NCONCEPT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE534>(entity =>
        {
            entity.ToTable("TABLE534", "INSUDB");
            entity.HasKey(e => e.NCESS_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE55>(entity =>
        {
            entity.ToTable("TABLE55", "INSUDB");
            entity.HasKey(e => e.NRELATION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5500>(entity =>
        {
            entity.ToTable("TABLE5500", "INSUDB");
            entity.HasKey(e => e.NSCHE_CODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5501>(entity =>
        {
            entity.ToTable("TABLE5501", "INSUDB");
            entity.HasKey(e => e.NLEGAL_SCH);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5503>(entity =>
        {
            entity.ToTable("TABLE5503", "INSUDB");
            entity.HasKey(e => e.NAREA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5504>(entity =>
        {
            entity.ToTable("TABLE5504", "INSUDB");
            entity.HasKey(e => e.NTYPDRIVER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5505>(entity =>
        {
            entity.ToTable("TABLE5505", "INSUDB");
            entity.HasKey(e => e.NDISABILITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5506>(entity =>
        {
            entity.ToTable("TABLE5506", "INSUDB");
            entity.HasKey(e => e.NHOBBY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5516>(entity =>
        {
            entity.ToTable("TABLE5516", "INSUDB");
            entity.HasKey(e => e.NMOTIVE_ITIN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5517>(entity =>
        {
            entity.ToTable("TABLE5517", "INSUDB");
            entity.HasKey(e => e.NTYPLOAN_MOV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5518>(entity =>
        {
            entity.ToTable("TABLE5518", "INSUDB");
            entity.HasKey(e => e.NNATIONALITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5519>(entity =>
        {
            entity.ToTable("TABLE5519", "INSUDB");
            entity.HasKey(e => e.NOPTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5520>(entity =>
        {
            entity.ToTable("TABLE5520", "INSUDB");
            entity.HasKey(e => e.NTYPEINVEST);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(18);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5521>(entity =>
        {
            entity.ToTable("TABLE5521", "INSUDB");
            entity.HasKey(e => e.NLIMITDRIV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5522>(entity =>
        {
            entity.ToTable("TABLE5522", "INSUDB");
            entity.HasKey(e => e.NINVOICING);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5523>(entity =>
        {
            entity.ToTable("TABLE5523", "INSUDB");
            entity.HasKey(e => e.NHEALTH_ORG);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5524>(entity =>
        {
            entity.ToTable("TABLE5524", "INSUDB");
            entity.HasKey(e => e.NAFP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5525>(entity =>
        {
            entity.ToTable("TABLE5525", "INSUDB");
            entity.HasKey(e => e.NTYPEMOVE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5526>(entity =>
        {
            entity.ToTable("TABLE5526", "INSUDB");
            entity.HasKey(e => e.NSTATQUOTA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5527>(entity =>
        {
            entity.ToTable("TABLE5527", "INSUDB");
            entity.HasKey(e => e.NTYPEPAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5529>(entity =>
        {
            entity.ToTable("TABLE5529", "INSUDB");
            entity.HasKey(e => e.NTYPEAGREE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5530>(entity =>
        {
            entity.ToTable("TABLE5530", "INSUDB");
            entity.HasKey(e => e.NCOMP_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(45);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5531>(entity =>
        {
            entity.ToTable("TABLE5531", "INSUDB");
            entity.HasKey(e => e.NCHANGE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5532>(entity =>
        {
            entity.ToTable("TABLE5532", "INSUDB");
            entity.HasKey(e => e.NSELLCHANNEL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5533>(entity =>
        {
            entity.ToTable("TABLE5533", "INSUDB");
            entity.HasKey(e => e.NPART_AUTO);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5534>(entity =>
        {
            entity.ToTable("TABLE5534", "INSUDB");
            entity.HasKey(e => e.NDAMAG_AUTO);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5535>(entity =>
        {
            entity.ToTable("TABLE5535", "INSUDB");
            entity.HasKey(e => e.NDAMAGE_MAGNIF);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5536>(entity =>
        {
            entity.ToTable("TABLE5536", "INSUDB");
            entity.HasKey(e => e.NSTRUCTURE_WALL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5538>(entity =>
        {
            entity.ToTable("TABLE5538", "INSUDB");
            entity.HasKey(e => e.NSTRUCTURE_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5539>(entity =>
        {
            entity.ToTable("TABLE5539", "INSUDB");
            entity.HasKey(e => e.NINSTRUMENT_TY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5540>(entity =>
        {
            entity.ToTable("TABLE5540", "INSUDB");
            entity.HasKey(e => e.NSECTOR_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5541>(entity =>
        {
            entity.ToTable("TABLE5541", "INSUDB");
            entity.HasKey(e => e.NLEVEL_SECTOR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5542>(entity =>
        {
            entity.ToTable("TABLE5542", "INSUDB");
            entity.HasKey(e => e.NLOCK_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5543>(entity =>
        {
            entity.ToTable("TABLE5543", "INSUDB");
            entity.HasKey(e => e.NPROTEC_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5544>(entity =>
        {
            entity.ToTable("TABLE5544", "INSUDB");
            entity.HasKey(e => e.NTYPCOND);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5545>(entity =>
        {
            entity.ToTable("TABLE5545", "INSUDB");
            entity.HasKey(e => e.NTYPELOAD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5546>(entity =>
        {
            entity.ToTable("TABLE5546", "INSUDB");
            entity.HasKey(e => e.NLEVEL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5547>(entity =>
        {
            entity.ToTable("TABLE5547", "INSUDB");
            entity.HasKey(e => e.NCAUSEUPD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5548>(entity =>
        {
            entity.ToTable("TABLE5548", "INSUDB");
            entity.HasKey(e => e.NLEVEL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5549>(entity =>
        {
            entity.ToTable("TABLE5549", "INSUDB");
            entity.HasKey(e => e.NINCAPACITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5550>(entity =>
        {
            entity.ToTable("TABLE5550", "INSUDB");
            entity.HasKey(e => e.NINCAP_COD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5551>(entity =>
        {
            entity.ToTable("TABLE5551", "INSUDB");
            entity.HasKey(e => e.NCOLLECTORTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5552>(entity =>
        {
            entity.ToTable("TABLE5552", "INSUDB");
            entity.HasKey(e => e.NTYPECAP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5553>(entity =>
        {
            entity.ToTable("TABLE5553", "INSUDB");
            entity.HasKey(e => e.NCHEQUELOCAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5554>(entity =>
        {
            entity.ToTable("TABLE5554", "INSUDB");
            entity.HasKey(e => e.NINPUTTYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5555>(entity =>
        {
            entity.ToTable("TABLE5555", "INSUDB");
            entity.HasKey(e => e.NAGENCY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5556>(entity =>
        {
            entity.ToTable("TABLE5556", "INSUDB");
            entity.HasKey(e => e.NOFFICEAGEN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5557>(entity =>
        {
            entity.ToTable("TABLE5557", "INSUDB");
            entity.HasKey(e => e.NCONTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5558>(entity =>
        {
            entity.ToTable("TABLE5558", "INSUDB");
            entity.HasKey(e => e.NTYPEREC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5559>(entity =>
        {
            entity.ToTable("TABLE5559", "INSUDB");
            entity.HasKey(e => e.NRETARIF);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5560>(entity =>
        {
            entity.ToTable("TABLE5560", "INSUDB");
            entity.HasKey(e => e.NCALCAPITAL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5561>(entity =>
        {
            entity.ToTable("TABLE5561", "INSUDB");
            entity.HasKey(e => e.NSTATUSROL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5562>(entity =>
        {
            entity.ToTable("TABLE5562", "INSUDB");
            entity.HasKey(e => e.NCASH_OPERTYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5563>(entity =>
        {
            entity.ToTable("TABLE5563", "INSUDB");
            entity.HasKey(e => e.NCLASIFIC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5564>(entity =>
        {
            entity.ToTable("TABLE5564", "INSUDB");
            entity.HasKey(e => e.NBILLSTAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5565>(entity =>
        {
            entity.ToTable("TABLE5565", "INSUDB");
            entity.HasKey(e => e.NTYPECODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5566>(entity =>
        {
            entity.ToTable("TABLE5566", "INSUDB");
            entity.HasKey(e => e.NSUS_REASON);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5567>(entity =>
        {
            entity.ToTable("TABLE5567", "INSUDB");
            entity.HasKey(e => e.NTYPMOV_COMM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5568>(entity =>
        {
            entity.ToTable("TABLE5568", "INSUDB");
            entity.HasKey(e => e.NSTATUS_COMM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5569>(entity =>
        {
            entity.ToTable("TABLE5569", "INSUDB");
            entity.HasKey(e => e.NTYPEISSUE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5570>(entity =>
        {
            entity.ToTable("TABLE5570", "INSUDB");
            entity.HasKey(e => e.NTYPESUPPORT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5571>(entity =>
        {
            entity.ToTable("TABLE5571", "INSUDB");
            entity.HasKey(e => e.NSEARCH);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5572>(entity =>
        {
            entity.ToTable("TABLE5572", "INSUDB");
            entity.HasKey(e => e.NSTATUS_EVAL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5573>(entity =>
        {
            entity.ToTable("TABLE5573", "INSUDB");
            entity.HasKey(e => e.NOBSERVATION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(100);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5574>(entity =>
        {
            entity.ToTable("TABLE5574", "INSUDB");
            entity.HasKey(e => e.NSENDADDR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5575>(entity =>
        {
            entity.ToTable("TABLE5575", "INSUDB");
            entity.HasKey(e => e.NCHEOPERTYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5576>(entity =>
        {
            entity.ToTable("TABLE5576", "INSUDB");
            entity.HasKey(e => e.NCHEQUE_STAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5577>(entity =>
        {
            entity.ToTable("TABLE5577", "INSUDB");
            entity.HasKey(e => e.NCHEOPER_REASON);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5578>(entity =>
        {
            entity.ToTable("TABLE5578", "INSUDB");
            entity.HasKey(e => e.NACTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5579>(entity =>
        {
            entity.ToTable("TABLE5579", "INSUDB");
            entity.HasKey(e => e.NAUTO_PART);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5580>(entity =>
        {
            entity.ToTable("TABLE5580", "INSUDB");
            entity.HasKey(e => e.NORIGIN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5581>(entity =>
        {
            entity.ToTable("TABLE5581", "INSUDB");
            entity.HasKey(e => e.NTYPE_REC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5582>(entity =>
        {
            entity.ToTable("TABLE5582", "INSUDB");
            entity.HasKey(e => e.NTYPCOND);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5584>(entity =>
        {
            entity.ToTable("TABLE5584", "INSUDB");
            entity.HasKey(e => e.NTYPE_TAR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5585>(entity =>
        {
            entity.ToTable("TABLE5585", "INSUDB");
            entity.HasKey(e => e.NTYPEMOV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5586>(entity =>
        {
            entity.ToTable("TABLE5586", "INSUDB");
            entity.HasKey(e => e.NDEFERRED);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5587>(entity =>
        {
            entity.ToTable("TABLE5587", "INSUDB");
            entity.HasKey(e => e.NCOLLECDOCTYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5588>(entity =>
        {
            entity.ToTable("TABLE5588", "INSUDB");
            entity.HasKey(e => e.NTRATYPEP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5589>(entity =>
        {
            entity.ToTable("TABLE5589", "INSUDB");
            entity.HasKey(e => e.NTYPDUR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5590>(entity =>
        {
            entity.ToTable("TABLE5590", "INSUDB");
            entity.HasKey(e => e.TCREDIT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5591>(entity =>
        {
            entity.ToTable("TABLE5591", "INSUDB");
            entity.HasKey(e => e.NCARDINAL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5592>(entity =>
        {
            entity.ToTable("TABLE5592", "INSUDB");
            entity.HasKey(e => e.NTYPENAME);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5593>(entity =>
        {
            entity.ToTable("TABLE5593", "INSUDB");
            entity.HasKey(e => e.NMEASUNIT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5594>(entity =>
        {
            entity.ToTable("TABLE5594", "INSUDB");
            entity.HasKey(e => e.NLIC_SPECIAL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5595>(entity =>
        {
            entity.ToTable("TABLE5595", "INSUDB");
            entity.HasKey(e => e.NELECPROT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5596>(entity =>
        {
            entity.ToTable("TABLE5596", "INSUDB");
            entity.HasKey(e => e.NMATERPIPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5597>(entity =>
        {
            entity.ToTable("TABLE5597", "INSUDB");
            entity.HasKey(e => e.NORD_TYPECOST);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5598>(entity =>
        {
            entity.ToTable("TABLE5598", "INSUDB");
            entity.HasKey(e => e.NACTIONCOV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5599>(entity =>
        {
            entity.ToTable("TABLE5599", "INSUDB");
            entity.HasKey(e => e.NILLUSTTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE560>(entity =>
        {
            entity.ToTable("TABLE560", "INSUDB");
            entity.HasKey(e => e.NORDCLASS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5600>(entity =>
        {
            entity.ToTable("TABLE5600", "INSUDB");
            entity.HasKey(e => e.NINDRECDEP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5601>(entity =>
        {
            entity.ToTable("TABLE5601", "INSUDB");
            entity.HasKey(e => e.NCODMODPAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5602>(entity =>
        {
            entity.ToTable("TABLE5602", "INSUDB");
            entity.HasKey(e => e.STYPETAX);
            entity.Property(e => e.STYPETAX).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5603>(entity =>
        {
            entity.ToTable("TABLE5603", "INSUDB");
            entity.HasKey(e => e.NAREAWAIT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5604>(entity =>
        {
            entity.ToTable("TABLE5604", "INSUDB");
            entity.HasKey(e => e.NWAITCL_CODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5605>(entity =>
        {
            entity.ToTable("TABLE5605", "INSUDB");
            entity.HasKey(e => e.NDOC_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5606>(entity =>
        {
            entity.ToTable("TABLE5606", "INSUDB");
            entity.HasKey(e => e.NFACTOR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5607>(entity =>
        {
            entity.ToTable("TABLE5607", "INSUDB");
            entity.HasKey(e => e.NTABLETYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5608>(entity =>
        {
            entity.ToTable("TABLE5608", "INSUDB");
            entity.HasKey(e => e.NSOURCE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5609>(entity =>
        {
            entity.ToTable("TABLE5609", "INSUDB");
            entity.HasKey(e => e.NCLAIMCLASS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE561>(entity =>
        {
            entity.ToTable("TABLE561", "INSUDB");
            entity.HasKey(e => e.NEVALSTAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5610>(entity =>
        {
            entity.ToTable("TABLE5610", "INSUDB");
            entity.HasKey(e => e.NTYPEREC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5611>(entity =>
        {
            entity.ToTable("TABLE5611", "INSUDB");
            entity.HasKey(e => e.NCON_EARTHQUAKE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5612>(entity =>
        {
            entity.ToTable("TABLE5612", "INSUDB");
            entity.HasKey(e => e.NDAMAGE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5613>(entity =>
        {
            entity.ToTable("TABLE5613", "INSUDB");
            entity.HasKey(e => e.NCONTAINRISK);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5614>(entity =>
        {
            entity.ToTable("TABLE5614", "INSUDB");
            entity.HasKey(e => e.NINUNDAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5615>(entity =>
        {
            entity.ToTable("TABLE5615", "INSUDB");
            entity.HasKey(e => e.NVALUE_TYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5616>(entity =>
        {
            entity.ToTable("TABLE5616", "INSUDB");
            entity.HasKey(e => e.NPAYFORMCREDITCARD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5617>(entity =>
        {
            entity.ToTable("TABLE5617", "INSUDB");
            entity.HasKey(e => e.NPAYFREQCREDITCARD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5621>(entity =>
        {
            entity.ToTable("TABLE5621", "INSUDB");
            entity.HasKey(e => e.NTODAYSDEPOSIT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5622>(entity =>
        {
            entity.ToTable("TABLE5622", "INSUDB");
            entity.HasKey(e => e.NTYPEOFWORK);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(5);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5623>(entity =>
        {
            entity.ToTable("TABLE5623", "INSUDB");
            entity.HasKey(e => e.NPARTICULARCLAS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5625>(entity =>
        {
            entity.ToTable("TABLE5625", "INSUDB");
            entity.HasKey(e => e.NTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE563>(entity =>
        {
            entity.ToTable("TABLE563", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5631>(entity =>
        {
            entity.ToTable("TABLE5631", "INSUDB");
            entity.HasKey(e => e.NCAUSE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(100);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5632>(entity =>
        {
            entity.ToTable("TABLE5632", "INSUDB");
            entity.HasKey(e => e.SCERTYPE);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5633>(entity =>
        {
            entity.ToTable("TABLE5633", "INSUDB");
            entity.HasKey(e => e.NORIGIN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5634>(entity =>
        {
            entity.ToTable("TABLE5634", "INSUDB");
            entity.HasKey(e => e.NTYPEINSTITU);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5635>(entity =>
        {
            entity.ToTable("TABLE5635", "INSUDB");
            entity.HasKey(e => e.NSURR_REASON);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5636>(entity =>
        {
            entity.ToTable("TABLE5636", "INSUDB");
            entity.HasKey(e => e.NTYPE_PAYMENT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5638>(entity =>
        {
            entity.ToTable("TABLE5638", "INSUDB");
            entity.HasKey(e => e.NCOMPANY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SOWNER_BASE).HasMaxLength(20);
            entity.Property(e => e.SACCESSWO).HasMaxLength(12);
        });

        modelBuilder.Entity<TABLE5639>(entity =>
        {
            entity.ToTable("TABLE5639", "INSUDB");
            entity.HasKey(e => e.NTYPERISK);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE564>(entity =>
        {
            entity.ToTable("TABLE564", "INSUDB");
            entity.HasKey(e => e.NPHONE_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5640>(entity =>
        {
            entity.ToTable("TABLE5640", "INSUDB");
            entity.HasKey(e => e.NDEFAULTDAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5641>(entity =>
        {
            entity.ToTable("TABLE5641", "INSUDB");
            entity.HasKey(e => e.NINTENTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5642>(entity =>
        {
            entity.ToTable("TABLE5642", "INSUDB");
            entity.HasKey(e => e.NCHANGESDAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5644>(entity =>
        {
            entity.ToTable("TABLE5644", "INSUDB");
            entity.HasKey(e => e.NTYPE_PERIOD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5647>(entity =>
        {
            entity.ToTable("TABLE5647", "INSUDB");
            entity.HasKey(e => e.NLIMIT_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5650>(entity =>
        {
            entity.ToTable("TABLE5650", "INSUDB");
            entity.HasKey(e => e.NCLASS_CONCEPT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5651>(entity =>
        {
            entity.ToTable("TABLE5651", "INSUDB");
            entity.HasKey(e => e.NPREM_DET);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5660>(entity =>
        {
            entity.ToTable("TABLE5660", "INSUDB");
            entity.HasKey(e => e.NTYPE_CALC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5661>(entity =>
        {
            entity.ToTable("TABLE5661", "INSUDB");
            entity.HasKey(e => e.NTYPE_COST);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5662>(entity =>
        {
            entity.ToTable("TABLE5662", "INSUDB");
            entity.HasKey(e => e.NTYPE_COMM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5670>(entity =>
        {
            entity.ToTable("TABLE5670", "INSUDB");
            entity.HasKey(e => e.NTYP_CUMUL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5671>(entity =>
        {
            entity.ToTable("TABLE5671", "INSUDB");
            entity.HasKey(e => e.NTYPE_COMM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5672>(entity =>
        {
            entity.ToTable("TABLE5672", "INSUDB");
            entity.HasKey(e => e.NTYPPORT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5673>(entity =>
        {
            entity.ToTable("TABLE5673", "INSUDB");
            entity.HasKey(e => e.NINFORTYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5674>(entity =>
        {
            entity.ToTable("TABLE5674", "INSUDB");
            entity.HasKey(e => e.NMAG_DAM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5675>(entity =>
        {
            entity.ToTable("TABLE5675", "INSUDB");
            entity.HasKey(e => e.NINFTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5677>(entity =>
        {
            entity.ToTable("TABLE5677", "INSUDB");
            entity.HasKey(e => e.NREPINSURED);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5679>(entity =>
        {
            entity.ToTable("TABLE5679", "INSUDB");
            entity.HasKey(e => e.NCAUSE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5700>(entity =>
        {
            entity.ToTable("TABLE5700", "INSUDB");
            entity.HasKey(e => e.NOPERTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5701>(entity =>
        {
            entity.ToTable("TABLE5701", "INSUDB");
            entity.HasKey(e => e.NFORMAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5702>(entity =>
        {
            entity.ToTable("TABLE5702", "INSUDB");
            entity.HasKey(e => e.NFIELDTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5703>(entity =>
        {
            entity.ToTable("TABLE5703", "INSUDB");
            entity.HasKey(e => e.NOBJTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5704>(entity =>
        {
            entity.ToTable("TABLE5704", "INSUDB");
            entity.HasKey(e => e.NOPERATOR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5705>(entity =>
        {
            entity.ToTable("TABLE5705", "INSUDB");
            entity.HasKey(e => e.NSYSTEM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5706>(entity =>
        {
            entity.ToTable("TABLE5706", "INSUDB");
            entity.HasKey(e => e.NTABLE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5707>(entity =>
        {
            entity.ToTable("TABLE5707", "INSUDB");
            entity.HasKey(e => e.NINTERTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5708>(entity =>
        {
            entity.ToTable("TABLE5708", "INSUDB");
            entity.HasKey(e => e.NTYPE_MOVE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SPB_BMG).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5709>(entity =>
        {
            entity.ToTable("TABLE5709", "INSUDB");
            entity.HasKey(e => e.NTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5710>(entity =>
        {
            entity.ToTable("TABLE5710", "INSUDB");
            entity.HasKey(e => e.NPERIOD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5712>(entity =>
        {
            entity.ToTable("TABLE5712", "INSUDB");
            entity.HasKey(e => e.NCAUSE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5713>(entity =>
        {
            entity.ToTable("TABLE5713", "INSUDB");
            entity.HasKey(e => e.NTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5719>(entity =>
        {
            entity.ToTable("TABLE5719", "INSUDB");
            entity.HasKey(e => e.NREASON);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5728>(entity =>
        {
            entity.ToTable("TABLE5728", "INSUDB");
            entity.HasKey(e => e.NFORMPAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5741>(entity =>
        {
            entity.ToTable("TABLE5741", "INSUDB");
            entity.HasKey(e => e.NCODE_STATE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5742>(entity =>
        {
            entity.ToTable("TABLE5742", "INSUDB");
            entity.HasKey(e => e.NTYPE_SAAPV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5743>(entity =>
        {
            entity.ToTable("TABLE5743", "INSUDB");
            entity.HasKey(e => e.NTYPE_AMEAPV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5744>(entity =>
        {
            entity.ToTable("TABLE5744", "INSUDB");
            entity.HasKey(e => e.NFUNDS_ORIGIN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5745>(entity =>
        {
            entity.ToTable("TABLE5745", "INSUDB");
            entity.HasKey(e => e.SAFP_TYPE);
            entity.Property(e => e.SAFP_TYPE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5746>(entity =>
        {
            entity.ToTable("TABLE5746", "INSUDB");
            entity.HasKey(e => e.NTYPEMOVRH);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5747>(entity =>
        {
            entity.ToTable("TABLE5747", "INSUDB");
            entity.HasKey(e => e.NTYPE_SPAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5748>(entity =>
        {
            entity.ToTable("TABLE5748", "INSUDB");
            entity.HasKey(e => e.NTYPEAGE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5749>(entity =>
        {
            entity.ToTable("TABLE5749", "INSUDB");
            entity.HasKey(e => e.NTYPEVAL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5750>(entity =>
        {
            entity.ToTable("TABLE5750", "INSUDB");
            entity.HasKey(e => e.STYPECOM);
            entity.Property(e => e.STYPECOM).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5770>(entity =>
        {
            entity.ToTable("TABLE5770", "INSUDB");
            entity.HasKey(e => e.NSPECIALBUSINES);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(5);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5775>(entity =>
        {
            entity.ToTable("TABLE5775", "INSUDB");
            entity.HasKey(e => e.NTRANSACTIO);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE58>(entity =>
        {
            entity.ToTable("TABLE58", "INSUDB");
            entity.HasKey(e => e.NTYPE_INDEX);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCOMMENTS).HasMaxLength(200);
        });

        modelBuilder.Entity<TABLE5800>(entity =>
        {
            entity.ToTable("TABLE5800", "INSUDB");
            entity.HasKey(e => e.NID_TABLE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5801>(entity =>
        {
            entity.ToTable("TABLE5801", "INSUDB");
            entity.HasKey(e => e.NTYPE_CALC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5810>(entity =>
        {
            entity.ToTable("TABLE5810", "INSUDB");
            entity.HasKey(e => e.NQAMENTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5811>(entity =>
        {
            entity.ToTable("TABLE5811", "INSUDB");
            entity.HasKey(e => e.NQAMENTACTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5812>(entity =>
        {
            entity.ToTable("TABLE5812", "INSUDB");
            entity.HasKey(e => e.NDOC_CODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE59>(entity =>
        {
            entity.ToTable("TABLE59", "INSUDB");
            entity.HasKey(e => e.NTYPE_PARAMETER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE5902>(entity =>
        {
            entity.ToTable("TABLE5902", "INSUDB");
            entity.HasKey(e => e.NTYPE_MAIL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE591>(entity =>
        {
            entity.ToTable("TABLE591", "INSUDB");
            entity.HasKey(e => e.NSTATUS_BANKAUTH);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6>(entity =>
        {
            entity.ToTable("TABLE6", "INSUDB");
            entity.HasKey(e => e.NTYPE_TRAN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE60>(entity =>
        {
            entity.ToTable("TABLE60", "INSUDB");
            entity.HasKey(e => e.NPAYCONRE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6000>(entity =>
        {
            entity.ToTable("TABLE6000", "INSUDB");
            entity.HasKey(e => e.NTYPEOFADDRESS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6001>(entity =>
        {
            entity.ToTable("TABLE6001", "INSUDB");
            entity.HasKey(e => e.NAIRTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6002>(entity =>
        {
            entity.ToTable("TABLE6002", "INSUDB");
            entity.HasKey(e => e.NALT_HEATING);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6003>(entity =>
        {
            entity.ToTable("TABLE6003", "INSUDB");
            entity.HasKey(e => e.NFOUNDTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6004>(entity =>
        {
            entity.ToTable("TABLE6004", "INSUDB");
            entity.HasKey(e => e.NSWIMPOOL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6005>(entity =>
        {
            entity.ToTable("TABLE6005", "INSUDB");
            entity.HasKey(e => e.NOWNERSHIP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6007>(entity =>
        {
            entity.ToTable("TABLE6007", "INSUDB");
            entity.HasKey(e => e.NZONETYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6012>(entity =>
        {
            entity.ToTable("TABLE6012", "INSUDB");
            entity.HasKey(e => e.NDWELLINGTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6013>(entity =>
        {
            entity.ToTable("TABLE6013", "INSUDB");
            entity.HasKey(e => e.NUNIT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6014>(entity =>
        {
            entity.ToTable("TABLE6014", "INSUDB");
            entity.HasKey(e => e.NSEVERITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6022>(entity =>
        {
            entity.ToTable("TABLE6022", "INSUDB");
            entity.HasKey(e => e.NSOATCLASS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6023>(entity =>
        {
            entity.ToTable("TABLE6023", "INSUDB");
            entity.HasKey(e => e.NCLASSTYPDOC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6028>(entity =>
        {
            entity.ToTable("TABLE6028", "INSUDB");
            entity.HasKey(e => e.NGROUPVEH);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6030>(entity =>
        {
            entity.ToTable("TABLE6030", "INSUDB");
            entity.HasKey(e => e.NTYPECALCULATE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6031>(entity =>
        {
            entity.ToTable("TABLE6031", "INSUDB");
            entity.HasKey(e => e.NTRANSPTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6034>(entity =>
        {
            entity.ToTable("TABLE6034", "INSUDB");
            entity.HasKey(e => e.NMODALITYSUMINS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6046>(entity =>
        {
            entity.ToTable("TABLE6046", "INSUDB");
            entity.HasKey(e => e.NCLI_CATEGORY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6054>(entity =>
        {
            entity.ToTable("TABLE6054", "INSUDB");
            entity.HasKey(e => e.NSECTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6059>(entity =>
        {
            entity.ToTable("TABLE6059", "INSUDB");
            entity.HasKey(e => e.NTYPE_AMEND);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6070>(entity =>
        {
            entity.ToTable("TABLE6070", "INSUDB");
            entity.HasKey(e => e.STRATYPEI);
            entity.Property(e => e.STRATYPEI).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6071>(entity =>
        {
            entity.ToTable("TABLE6071", "INSUDB");
            entity.HasKey(e => e.NTYPE_ACC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6072>(entity =>
        {
            entity.ToTable("TABLE6072", "INSUDB");
            entity.HasKey(e => e.NIDCATAS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE61>(entity =>
        {
            entity.ToTable("TABLE61", "INSUDB");
            entity.HasKey(e => e.NORIGIN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6100>(entity =>
        {
            entity.ToTable("TABLE6100", "INSUDB");
            entity.HasKey(e => e.NCLASEMPRESALEGAL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE62>(entity =>
        {
            entity.ToTable("TABLE62", "INSUDB");
            entity.HasKey(e => e.NRECTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE622>(entity =>
        {
            entity.ToTable("TABLE622", "INSUDB");
            entity.HasKey(e => e.NPARAMETERS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE624>(entity =>
        {
            entity.ToTable("TABLE624", "INSUDB");
            entity.HasKey(e => e.NSTATLETTER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6335>(entity =>
        {
            entity.ToTable("TABLE6335", "INSUDB");
            entity.HasKey(e => e.NTYPPREMRECOG);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE634>(entity =>
        {
            entity.ToTable("TABLE634", "INSUDB");
            entity.HasKey(e => e.NBRANCH_GEN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE636>(entity =>
        {
            entity.ToTable("TABLE636", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE64>(entity =>
        {
            entity.ToTable("TABLE64", "INSUDB");
            entity.HasKey(e => e.SFRANTYPE);
            entity.Property(e => e.SFRANTYPE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE640>(entity =>
        {
            entity.ToTable("TABLE640", "INSUDB");
            entity.HasKey(e => e.NECON_AREA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE641>(entity =>
        {
            entity.ToTable("TABLE641", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE642>(entity =>
        {
            entity.ToTable("TABLE642", "INSUDB");
            entity.HasKey(e => e.NPROV_GROUP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE645>(entity =>
        {
            entity.ToTable("TABLE645", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE66>(entity =>
        {
            entity.ToTable("TABLE66", "INSUDB");
            entity.HasKey(e => e.NCOUNTRY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6785>(entity =>
        {
            entity.ToTable("TABLE6785", "INSUDB");
            entity.HasKey(e => e.NRISKTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6786>(entity =>
        {
            entity.ToTable("TABLE6786", "INSUDB");
            entity.HasKey(e => e.NDEFTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE680>(entity =>
        {
            entity.ToTable("TABLE680", "INSUDB");
            entity.HasKey(e => e.NAGREE_TYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6805>(entity =>
        {
            entity.ToTable("TABLE6805", "INSUDB");
            entity.HasKey(e => e.NDATATYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE6900>(entity =>
        {
            entity.ToTable("TABLE6900", "INSUDB");
            entity.HasKey(e => e.NINSMODALITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE692>(entity =>
        {
            entity.ToTable("TABLE692", "INSUDB");
            entity.HasKey(e => e.NDEMAN_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE693>(entity =>
        {
            entity.ToTable("TABLE693", "INSUDB");
            entity.HasKey(e => e.NPRERECEIPT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE694>(entity =>
        {
            entity.ToTable("TABLE694", "INSUDB");
            entity.HasKey(e => e.NINTCALC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE695>(entity =>
        {
            entity.ToTable("TABLE695", "INSUDB");
            entity.HasKey(e => e.NSYSMODUL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE696>(entity =>
        {
            entity.ToTable("TABLE696", "INSUDB");
            entity.HasKey(e => e.NPOLICYSALE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE697>(entity =>
        {
            entity.ToTable("TABLE697", "INSUDB");
            entity.HasKey(e => e.NSHEET);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7>(entity =>
        {
            entity.ToTable("TABLE7", "INSUDB");
            entity.HasKey(e => e.NBANK_CODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7000>(entity =>
        {
            entity.ToTable("TABLE7000", "INSUDB");
            entity.HasKey(e => e.NTABLE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7001>(entity =>
        {
            entity.ToTable("TABLE7001", "INSUDB");
            entity.HasKey(e => e.NTYPEREQUEST);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(5);
        });

        modelBuilder.Entity<TABLE7002>(entity =>
        {
            entity.ToTable("TABLE7002", "INSUDB");
            entity.HasKey(e => e.NRESPONSECODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(5);
        });

        modelBuilder.Entity<TABLE7003>(entity =>
        {
            entity.ToTable("TABLE7003", "INSUDB");
            entity.HasKey(e => e.NROLEREQUEST);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(5);
        });

        modelBuilder.Entity<TABLE7006>(entity =>
        {
            entity.ToTable("TABLE7006", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7007>(entity =>
        {
            entity.ToTable("TABLE7007", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7013>(entity =>
        {
            entity.ToTable("TABLE7013", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7014>(entity =>
        {
            entity.ToTable("TABLE7014", "INSUDB");
            entity.HasKey(e => e.NTYPE_INF);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7027>(entity =>
        {
            entity.ToTable("TABLE7027", "INSUDB");
            entity.HasKey(e => e.NTYPEPROV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7028>(entity =>
        {
            entity.ToTable("TABLE7028", "INSUDB");
            entity.HasKey(e => e.NRETURN_CODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7031>(entity =>
        {
            entity.ToTable("TABLE7031", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7037>(entity =>
        {
            entity.ToTable("TABLE7037", "INSUDB");
            entity.HasKey(e => e.NSIDECLOSETYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7038>(entity =>
        {
            entity.ToTable("TABLE7038", "INSUDB");
            entity.HasKey(e => e.NROOFTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7039>(entity =>
        {
            entity.ToTable("TABLE7039", "INSUDB");
            entity.HasKey(e => e.NBUILDTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7040>(entity =>
        {
            entity.ToTable("TABLE7040", "INSUDB");
            entity.HasKey(e => e.NSPCOMBTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7042>(entity =>
        {
            entity.ToTable("TABLE7042", "INSUDB");
            entity.HasKey(e => e.NVEHBRAND);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SAACHCODE).HasMaxLength(100);
        });

        modelBuilder.Entity<TABLE7043>(entity =>
        {
            entity.ToTable("TABLE7043", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7044>(entity =>
        {
            entity.ToTable("TABLE7044", "INSUDB");
            entity.HasKey(e => e.NACTIVITYCAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7045>(entity =>
        {
            entity.ToTable("TABLE7045", "INSUDB");
            entity.HasKey(e => e.NACTIVITYTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7046>(entity =>
        {
            entity.ToTable("TABLE7046", "INSUDB");
            entity.HasKey(e => e.NFAMILY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7047>(entity =>
        {
            entity.ToTable("TABLE7047", "INSUDB");
            entity.HasKey(e => e.NSEISMICZONE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7051>(entity =>
        {
            entity.ToTable("TABLE7051", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE71>(entity =>
        {
            entity.ToTable("TABLE71", "INSUDB");
            entity.HasKey(e => e.NBRANCH_EST);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7100>(entity =>
        {
            entity.ToTable("TABLE7100", "INSUDB");
            entity.HasKey(e => e.NORDERTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE72>(entity =>
        {
            entity.ToTable("TABLE72", "INSUDB");
            entity.HasKey(e => e.NREQEXC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7200>(entity =>
        {
            entity.ToTable("TABLE7200", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7201>(entity =>
        {
            entity.ToTable("TABLE7201", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7203>(entity =>
        {
            entity.ToTable("TABLE7203", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7204>(entity =>
        {
            entity.ToTable("TABLE7204", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7205>(entity =>
        {
            entity.ToTable("TABLE7205", "INSUDB");
            entity.HasKey(e => e.NFI_POLICYTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7206>(entity =>
        {
            entity.ToTable("TABLE7206", "INSUDB");
            entity.HasKey(e => e.NINSURTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7210>(entity =>
        {
            entity.ToTable("TABLE7210", "INSUDB");
            entity.HasKey(e => e.NDEPRECIATION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7211>(entity =>
        {
            entity.ToTable("TABLE7211", "INSUDB");
            entity.HasKey(e => e.NEQUIPMENT_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7212>(entity =>
        {
            entity.ToTable("TABLE7212", "INSUDB");
            entity.HasKey(e => e.NTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7220>(entity =>
        {
            entity.ToTable("TABLE7220", "INSUDB");
            entity.HasKey(e => e.NSECTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7230>(entity =>
        {
            entity.ToTable("TABLE7230", "INSUDB");
            entity.HasKey(e => e.NDEDUCTIBLE_MET);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE73>(entity =>
        {
            entity.ToTable("TABLE73", "INSUDB");
            entity.HasKey(e => e.NRELREQEXC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE74>(entity =>
        {
            entity.ToTable("TABLE74", "INSUDB");
            entity.HasKey(e => e.NPAYINTER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE75>(entity =>
        {
            entity.ToTable("TABLE75", "INSUDB");
            entity.HasKey(e => e.NBRANCH_LED);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7501>(entity =>
        {
            entity.ToTable("TABLE7501", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7502>(entity =>
        {
            entity.ToTable("TABLE7502", "INSUDB");
            entity.HasKey(e => e.SREL_TYPE);
            entity.Property(e => e.SREL_TYPE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7504>(entity =>
        {
            entity.ToTable("TABLE7504", "INSUDB");
            entity.HasKey(e => e.STYP_COMISS);
            entity.Property(e => e.STYP_COMISS).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7505>(entity =>
        {
            entity.ToTable("TABLE7505", "INSUDB");
            entity.HasKey(e => e.SNULLACTION);
            entity.Property(e => e.SNULLACTION).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7508>(entity =>
        {
            entity.ToTable("TABLE7508", "INSUDB");
            entity.HasKey(e => e.NDAMAGE_TYP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7509>(entity =>
        {
            entity.ToTable("TABLE7509", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE77>(entity =>
        {
            entity.ToTable("TABLE77", "INSUDB");
            entity.HasKey(e => e.NCAUSE_AMEN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE78>(entity =>
        {
            entity.ToTable("TABLE78", "INSUDB");
            entity.HasKey(e => e.NMOV_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7801>(entity =>
        {
            entity.ToTable("TABLE7801", "INSUDB");
            entity.HasKey(e => e.NPAYMENTADDRESS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE78109>(entity =>
        {
            entity.ToTable("TABLE78109", "INSUDB");
            entity.HasKey(e => e.NSOAP_VEHTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SAACHCODE).HasMaxLength(100);
        });

        modelBuilder.Entity<TABLE79>(entity =>
        {
            entity.ToTable("TABLE79", "INSUDB");
            entity.HasKey(e => e.SCUMULTYP);
            entity.Property(e => e.SCUMULTYP).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE7996>(entity =>
        {
            entity.ToTable("TABLE7996", "INSUDB");
            entity.HasKey(e => e.NLOAD_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8>(entity =>
        {
            entity.ToTable("TABLE8", "INSUDB");
            entity.HasKey(e => e.SREINTYPE);
            entity.Property(e => e.SREINTYPE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE80>(entity =>
        {
            entity.ToTable("TABLE80", "INSUDB");
            entity.HasKey(e => e.SLICENSE_TY);
            entity.Property(e => e.SLICENSE_TY).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8000>(entity =>
        {
            entity.ToTable("TABLE8000", "INSUDB");
            entity.HasKey(e => e.NTYPEDOC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8001>(entity =>
        {
            entity.ToTable("TABLE8001", "INSUDB");
            entity.HasKey(e => e.NGUARSAV_STAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8002>(entity =>
        {
            entity.ToTable("TABLE8002", "INSUDB");
            entity.HasKey(e => e.NVALDATE_ISSUE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8003>(entity =>
        {
            entity.ToTable("TABLE8003", "INSUDB");
            entity.HasKey(e => e.NTYPROUTE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8004>(entity =>
        {
            entity.ToTable("TABLE8004", "INSUDB");
            entity.HasKey(e => e.NTYPEPOP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(200);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8005>(entity =>
        {
            entity.ToTable("TABLE8005", "INSUDB");
            entity.HasKey(e => e.NTYPETABLE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8006>(entity =>
        {
            entity.ToTable("TABLE8006", "INSUDB");
            entity.HasKey(e => e.NTYPEAFEC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8007>(entity =>
        {
            entity.ToTable("TABLE8007", "INSUDB");
            entity.HasKey(e => e.NAFECBASADI);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8008>(entity =>
        {
            entity.ToTable("TABLE8008", "INSUDB");
            entity.HasKey(e => e.NORIGINS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8010>(entity =>
        {
            entity.ToTable("TABLE8010", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8016>(entity =>
        {
            entity.ToTable("TABLE8016", "INSUDB");
            entity.HasKey(e => e.NTYPMOV_GUAR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8017>(entity =>
        {
            entity.ToTable("TABLE8017", "INSUDB");
            entity.HasKey(e => e.NFIELD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8018>(entity =>
        {
            entity.ToTable("TABLE8018", "INSUDB");
            entity.HasKey(e => e.NNOTINFORMEMAIL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8019>(entity =>
        {
            entity.ToTable("TABLE8019", "INSUDB");
            entity.HasKey(e => e.NGROUP_SAVING);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8020>(entity =>
        {
            entity.ToTable("TABLE8020", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8030>(entity =>
        {
            entity.ToTable("TABLE8030", "INSUDB");
            entity.HasKey(e => e.NREPTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8060>(entity =>
        {
            entity.ToTable("TABLE8060", "INSUDB");
            entity.HasKey(e => e.NBESTTIMETOCALL);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
        });

        modelBuilder.Entity<TABLE8090>(entity =>
        {
            entity.ToTable("TABLE8090", "INSUDB");
            entity.HasKey(e => e.NSERIES);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8100>(entity =>
        {
            entity.ToTable("TABLE8100", "INSUDB");
            entity.HasKey(e => e.NTYPE_CALC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8101>(entity =>
        {
            entity.ToTable("TABLE8101", "INSUDB");
            entity.HasKey(e => e.NAPLY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8103>(entity =>
        {
            entity.ToTable("TABLE8103", "INSUDB");
            entity.HasKey(e => e.NWAIT_CODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8106>(entity =>
        {
            entity.ToTable("TABLE8106", "INSUDB");
            entity.HasKey(e => e.NFIELDDATE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8200>(entity =>
        {
            entity.ToTable("TABLE8200", "INSUDB");
            entity.HasKey(e => e.NPROCESS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8202>(entity =>
        {
            entity.ToTable("TABLE8202", "INSUDB");
            entity.HasKey(e => e.NSTATUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8204>(entity =>
        {
            entity.ToTable("TABLE8204", "INSUDB");
            entity.HasKey(e => e.STYP_CONDI);
            entity.Property(e => e.STYP_CONDI).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8205>(entity =>
        {
            entity.ToTable("TABLE8205", "INSUDB");
            entity.HasKey(e => e.NSECTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8206>(entity =>
        {
            entity.ToTable("TABLE8206", "INSUDB");
            entity.HasKey(e => e.NACTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8215>(entity =>
        {
            entity.ToTable("TABLE8215", "INSUDB");
            entity.HasKey(e => e.NTYPE_VALUECOLLECT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8300>(entity =>
        {
            entity.ToTable("TABLE8300", "INSUDB");
            entity.HasKey(e => e.NTYPE_RATEPROY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8320>(entity =>
        {
            entity.ToTable("TABLE8320", "INSUDB");
            entity.HasKey(e => e.NTYPEPROFILE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE84>(entity =>
        {
            entity.ToTable("TABLE84", "INSUDB");
            entity.HasKey(e => e.NDEPARTME);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE85>(entity =>
        {
            entity.ToTable("TABLE85", "INSUDB");
            entity.HasKey(e => e.NLANGUAGE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8500>(entity =>
        {
            entity.ToTable("TABLE8500", "INSUDB");
            entity.HasKey(e => e.NTYPE_SCHCOM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8502>(entity =>
        {
            entity.ToTable("TABLE8502", "INSUDB");
            entity.HasKey(e => e.NTYPECALCULATEPREMSOAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8505>(entity =>
        {
            entity.ToTable("TABLE8505", "INSUDB");
            entity.HasKey(e => e.NTYPEPREMIUM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8600>(entity =>
        {
            entity.ToTable("TABLE8600", "INSUDB");
            entity.HasKey(e => e.STYPEBENEFIT);
            entity.Property(e => e.STYPEBENEFIT).HasMaxLength(5);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8601>(entity =>
        {
            entity.ToTable("TABLE8601", "INSUDB");
            entity.HasKey(e => e.SBENEFITCLAS);
            entity.Property(e => e.SBENEFITCLAS).HasMaxLength(5);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(120);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8602>(entity =>
        {
            entity.ToTable("TABLE8602", "INSUDB");
            entity.HasKey(e => e.SGROUP_ILL);
            entity.Property(e => e.SGROUP_ILL).HasMaxLength(6);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(210);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8603>(entity =>
        {
            entity.ToTable("TABLE8603", "INSUDB");
            entity.HasKey(e => e.SMEDSPECIALIALTY);
            entity.Property(e => e.SMEDSPECIALIALTY).HasMaxLength(5);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8604>(entity =>
        {
            entity.ToTable("TABLE8604", "INSUDB");
            entity.HasKey(e => e.STYPECARE);
            entity.Property(e => e.STYPECARE).HasMaxLength(10);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8605>(entity =>
        {
            entity.ToTable("TABLE8605", "INSUDB");
            entity.HasKey(e => e.SCARECLASS);
            entity.Property(e => e.SCARECLASS).HasMaxLength(10);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8606>(entity =>
        {
            entity.ToTable("TABLE8606", "INSUDB");
            entity.HasKey(e => e.NTYPE_GROUP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE8607>(entity =>
        {
            entity.ToTable("TABLE8607", "INSUDB");
            entity.HasKey(e => e.NDOCTORROL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE87>(entity =>
        {
            entity.ToTable("TABLE87", "INSUDB");
            entity.HasKey(e => e.NMODULES);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE88>(entity =>
        {
            entity.ToTable("TABLE88", "INSUDB");
            entity.HasKey(e => e.NWINDOWTY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE89>(entity =>
        {
            entity.ToTable("TABLE89", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9>(entity =>
        {
            entity.ToTable("TABLE9", "INSUDB");
            entity.HasKey(e => e.NOFFICE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE90>(entity =>
        {
            entity.ToTable("TABLE90", "INSUDB");
            entity.HasKey(e => e.SCUMREINT);
            entity.Property(e => e.SCUMREINT).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE900>(entity =>
        {
            entity.ToTable("TABLE900", "INSUDB");
            entity.HasKey(e => e.SCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9000>(entity =>
        {
            entity.ToTable("TABLE9000", "INSUDB");
            entity.HasKey(e => e.NCOMMERGRP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(100);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9001>(entity =>
        {
            entity.ToTable("TABLE9001", "INSUDB");
            entity.HasKey(e => e.NTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9002>(entity =>
        {
            entity.ToTable("TABLE9002", "INSUDB");
            entity.HasKey(e => e.NMATERIA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9003>(entity =>
        {
            entity.ToTable("TABLE9003", "INSUDB");
            entity.HasKey(e => e.NAJUSTTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9004>(entity =>
        {
            entity.ToTable("TABLE9004", "INSUDB");
            entity.HasKey(e => e.NCLASSCLIENT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9005>(entity =>
        {
            entity.ToTable("TABLE9005", "INSUDB");
            entity.HasKey(e => e.NBUSINESSTY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9006>(entity =>
        {
            entity.ToTable("TABLE9006", "INSUDB");
            entity.HasKey(e => e.NCONSTCLASS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9007>(entity =>
        {
            entity.ToTable("TABLE9007", "INSUDB");
            entity.HasKey(e => e.NMACHINECODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE901>(entity =>
        {
            entity.ToTable("TABLE901", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9010>(entity =>
        {
            entity.ToTable("TABLE9010", "INSUDB");
            entity.HasKey(e => e.NSINCEYEAR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9011>(entity =>
        {
            entity.ToTable("TABLE9011", "INSUDB");
            entity.HasKey(e => e.NCNTRYRISK);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9012>(entity =>
        {
            entity.ToTable("TABLE9012", "INSUDB");
            entity.HasKey(e => e.NTYPECIA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9013>(entity =>
        {
            entity.ToTable("TABLE9013", "INSUDB");
            entity.HasKey(e => e.NTYPEPRODUCT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9014>(entity =>
        {
            entity.ToTable("TABLE9014", "INSUDB");
            entity.HasKey(e => e.NRISK);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9015>(entity =>
        {
            entity.ToTable("TABLE9015", "INSUDB");
            entity.HasKey(e => e.NACTBUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9016>(entity =>
        {
            entity.ToTable("TABLE9016", "INSUDB");
            entity.HasKey(e => e.NREFBANK);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9017>(entity =>
        {
            entity.ToTable("TABLE9017", "INSUDB");
            entity.HasKey(e => e.NREFBUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9018>(entity =>
        {
            entity.ToTable("TABLE9018", "INSUDB");
            entity.HasKey(e => e.NREFLAW);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9019>(entity =>
        {
            entity.ToTable("TABLE9019", "INSUDB");
            entity.HasKey(e => e.NNUMPAYS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE902>(entity =>
        {
            entity.ToTable("TABLE902", "INSUDB");
            entity.HasKey(e => e.SCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9020>(entity =>
        {
            entity.ToTable("TABLE9020", "INSUDB");
            entity.HasKey(e => e.NOLDINSURANCE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9021>(entity =>
        {
            entity.ToTable("TABLE9021", "INSUDB");
            entity.HasKey(e => e.NPROPAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9022>(entity =>
        {
            entity.ToTable("TABLE9022", "INSUDB");
            entity.HasKey(e => e.NCREDITREASON);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9023>(entity =>
        {
            entity.ToTable("TABLE9023", "INSUDB");
            entity.HasKey(e => e.NLIQCURRENT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9024>(entity =>
        {
            entity.ToTable("TABLE9024", "INSUDB");
            entity.HasKey(e => e.NLIQACD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9025>(entity =>
        {
            entity.ToTable("TABLE9025", "INSUDB");
            entity.HasKey(e => e.NRENTABILITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9026>(entity =>
        {
            entity.ToTable("TABLE9026", "INSUDB");
            entity.HasKey(e => e.NGROWSALES);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9027>(entity =>
        {
            entity.ToTable("TABLE9027", "INSUDB");
            entity.HasKey(e => e.NECONOMIC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9028>(entity =>
        {
            entity.ToTable("TABLE9028", "INSUDB");
            entity.HasKey(e => e.NFINANCIAL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9029>(entity =>
        {
            entity.ToTable("TABLE9029", "INSUDB");
            entity.HasKey(e => e.NCODRATING);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE903>(entity =>
        {
            entity.ToTable("TABLE903", "INSUDB");
            entity.HasKey(e => e.NSTAINFCASE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9030>(entity =>
        {
            entity.ToTable("TABLE9030", "INSUDB");
            entity.HasKey(e => e.NDESRATING);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9031>(entity =>
        {
            entity.ToTable("TABLE9031", "INSUDB");
            entity.HasKey(e => e.NBRANCHCIA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9040>(entity =>
        {
            entity.ToTable("TABLE9040", "INSUDB");
            entity.HasKey(e => e.NTYPE_SETTLE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9050>(entity =>
        {
            entity.ToTable("TABLE9050", "INSUDB");
            entity.HasKey(e => e.NFORMPAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9056>(entity =>
        {
            entity.ToTable("TABLE9056", "INSUDB");
            entity.HasKey(e => e.NDUPLICATEDTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9100>(entity =>
        {
            entity.ToTable("TABLE9100", "INSUDB");
            entity.HasKey(e => e.NSHIPUSE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9101>(entity =>
        {
            entity.ToTable("TABLE9101", "INSUDB");
            entity.HasKey(e => e.NMATERIAL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9102>(entity =>
        {
            entity.ToTable("TABLE9102", "INSUDB");
            entity.HasKey(e => e.NSHIPTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9105>(entity =>
        {
            entity.ToTable("TABLE9105", "INSUDB");
            entity.HasKey(e => e.NROUTINETYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9108>(entity =>
        {
            entity.ToTable("TABLE9108", "INSUDB");
            entity.HasKey(e => e.NTYPE_CONTRAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE92>(entity =>
        {
            entity.ToTable("TABLE92", "INSUDB");
            entity.HasKey(e => e.STYP_VAR);
            entity.Property(e => e.STYP_VAR).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9200>(entity =>
        {
            entity.ToTable("TABLE9200", "INSUDB");
            entity.HasKey(e => e.NDATETYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9202>(entity =>
        {
            entity.ToTable("TABLE9202", "INSUDB");
            entity.HasKey(e => e.NCATEGORY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9203>(entity =>
        {
            entity.ToTable("TABLE9203", "INSUDB");
            entity.HasKey(e => e.NTYPELIST);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9204>(entity =>
        {
            entity.ToTable("TABLE9204", "INSUDB");
            entity.HasKey(e => e.NSEVERITYPEP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9205>(entity =>
        {
            entity.ToTable("TABLE9205", "INSUDB");
            entity.HasKey(e => e.NCITY_AXE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9207>(entity =>
        {
            entity.ToTable("TABLE9207", "INSUDB");
            entity.HasKey(e => e.NDISSUR_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9208>(entity =>
        {
            entity.ToTable("TABLE9208", "INSUDB");
            entity.HasKey(e => e.NTYPEXP);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9210>(entity =>
        {
            entity.ToTable("TABLE9210", "INSUDB");
            entity.HasKey(e => e.NTEMPASSI);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9211>(entity =>
        {
            entity.ToTable("TABLE9211", "INSUDB");
            entity.HasKey(e => e.NRETENTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9212>(entity =>
        {
            entity.ToTable("TABLE9212", "INSUDB");
            entity.HasKey(e => e.NCLAIMANTTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9213>(entity =>
        {
            entity.ToTable("TABLE9213", "INSUDB");
            entity.HasKey(e => e.NPOSITION_CLI);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9214>(entity =>
        {
            entity.ToTable("TABLE9214", "INSUDB");
            entity.HasKey(e => e.NGEOGRAPHAREA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9215>(entity =>
        {
            entity.ToTable("TABLE9215", "INSUDB");
            entity.HasKey(e => e.NATTENSYSTEM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9216>(entity =>
        {
            entity.ToTable("TABLE9216", "INSUDB");
            entity.HasKey(e => e.NMEDICALSTAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9217>(entity =>
        {
            entity.ToTable("TABLE9217", "INSUDB");
            entity.HasKey(e => e.NDOC_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9218>(entity =>
        {
            entity.ToTable("TABLE9218", "INSUDB");
            entity.HasKey(e => e.NIDSTATPRECLAIM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9219>(entity =>
        {
            entity.ToTable("TABLE9219", "INSUDB");
            entity.HasKey(e => e.NCLASS_DOC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9220>(entity =>
        {
            entity.ToTable("TABLE9220", "INSUDB");
            entity.HasKey(e => e.NINDPRINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9221>(entity =>
        {
            entity.ToTable("TABLE9221", "INSUDB");
            entity.HasKey(e => e.NTYPEEXHAUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9222>(entity =>
        {
            entity.ToTable("TABLE9222", "INSUDB");
            entity.HasKey(e => e.NBENEFCATEG);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9223>(entity =>
        {
            entity.ToTable("TABLE9223", "INSUDB");
            entity.HasKey(e => e.NCLASSIFICATION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9224>(entity =>
        {
            entity.ToTable("TABLE9224", "INSUDB");
            entity.HasKey(e => e.NNULLCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9229>(entity =>
        {
            entity.ToTable("TABLE9229", "INSUDB");
            entity.HasKey(e => e.NPAY_ID);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9232>(entity =>
        {
            entity.ToTable("TABLE9232", "INSUDB");
            entity.HasKey(e => e.NTYPE_EV_ENDOR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9233>(entity =>
        {
            entity.ToTable("TABLE9233", "INSUDB");
            entity.HasKey(e => e.STYPCALC_FLATPREM);
            entity.Property(e => e.STYPCALC_FLATPREM).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9234>(entity =>
        {
            entity.ToTable("TABLE9234", "INSUDB");
            entity.HasKey(e => e.NTYP_SECTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9235>(entity =>
        {
            entity.ToTable("TABLE9235", "INSUDB");
            entity.HasKey(e => e.STYPDIS_PAYPERCEN);
            entity.Property(e => e.STYPDIS_PAYPERCEN).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9236>(entity =>
        {
            entity.ToTable("TABLE9236", "INSUDB");
            entity.HasKey(e => e.NTYPE_ID);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(50);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9237>(entity =>
        {
            entity.ToTable("TABLE9237", "INSUDB");
            entity.HasKey(e => e.NATTENTCHANNEL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9238>(entity =>
        {
            entity.ToTable("TABLE9238", "INSUDB");
            entity.HasKey(e => e.NORDERTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9239>(entity =>
        {
            entity.ToTable("TABLE9239", "INSUDB");
            entity.HasKey(e => e.NREJECT_CAUSE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9241>(entity =>
        {
            entity.ToTable("TABLE9241", "INSUDB");
            entity.HasKey(e => e.NSTATUS_ORDER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9242>(entity =>
        {
            entity.ToTable("TABLE9242", "INSUDB");
            entity.HasKey(e => e.NTYPEDOC_PAY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9243>(entity =>
        {
            entity.ToTable("TABLE9243", "INSUDB");
            entity.HasKey(e => e.NMOVEMENT_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9244>(entity =>
        {
            entity.ToTable("TABLE9244", "INSUDB");
            entity.HasKey(e => e.NACTIONCLAIM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.SSTATREG).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9245>(entity =>
        {
            entity.ToTable("TABLE9245", "INSUDB");
            entity.HasKey(e => e.NACTIONTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREG).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9246>(entity =>
        {
            entity.ToTable("TABLE9246", "INSUDB");
            entity.HasKey(e => e.NCOD_REJECT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9247>(entity =>
        {
            entity.ToTable("TABLE9247", "INSUDB");
            entity.HasKey(e => e.NFOREIGNDOCTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9248>(entity =>
        {
            entity.ToTable("TABLE9248", "INSUDB");
            entity.HasKey(e => e.NSTATUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9249>(entity =>
        {
            entity.ToTable("TABLE9249", "INSUDB");
            entity.HasKey(e => e.NSETTLEMENT_CONC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9250>(entity =>
        {
            entity.ToTable("TABLE9250", "INSUDB");
            entity.HasKey(e => e.NSETTLEMENT_STAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9251>(entity =>
        {
            entity.ToTable("TABLE9251", "INSUDB");
            entity.HasKey(e => e.NPAYEE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9252>(entity =>
        {
            entity.ToTable("TABLE9252", "INSUDB");
            entity.HasKey(e => e.NPAYMENT_METHOD);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9253>(entity =>
        {
            entity.ToTable("TABLE9253", "INSUDB");
            entity.HasKey(e => e.NCLASS_PROV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9254>(entity =>
        {
            entity.ToTable("TABLE9254", "INSUDB");
            entity.HasKey(e => e.NTYPEDISC_PROV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9255>(entity =>
        {
            entity.ToTable("TABLE9255", "INSUDB");
            entity.HasKey(e => e.NCOD_INSTEDUC);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(90);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9256>(entity =>
        {
            entity.ToTable("TABLE9256", "INSUDB");
            entity.HasKey(e => e.NCOD_MEDCOLLEGE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9257>(entity =>
        {
            entity.ToTable("TABLE9257", "INSUDB");
            entity.HasKey(e => e.NTYPE_SERV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9258>(entity =>
        {
            entity.ToTable("TABLE9258", "INSUDB");
            entity.HasKey(e => e.NSERV_ESTRUCT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9259>(entity =>
        {
            entity.ToTable("TABLE9259", "INSUDB");
            entity.HasKey(e => e.NCATEG_PROV);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9260>(entity =>
        {
            entity.ToTable("TABLE9260", "INSUDB");
            entity.HasKey(e => e.NPROCTYPEREN);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9261>(entity =>
        {
            entity.ToTable("TABLE9261", "INSUDB");
            entity.HasKey(e => e.NORD_PROCEDURE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9262>(entity =>
        {
            entity.ToTable("TABLE9262", "INSUDB");
            entity.HasKey(e => e.NCLAIM_ENTITY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9263>(entity =>
        {
            entity.ToTable("TABLE9263", "INSUDB");
            entity.HasKey(e => e.NNULLCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9264>(entity =>
        {
            entity.ToTable("TABLE9264", "INSUDB");
            entity.HasKey(e => e.NSTATORDER_MAST);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9265>(entity =>
        {
            entity.ToTable("TABLE9265", "INSUDB");
            entity.HasKey(e => e.NMASTERORDERTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9266>(entity =>
        {
            entity.ToTable("TABLE9266", "INSUDB");
            entity.HasKey(e => e.NMOVEMENT_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9267>(entity =>
        {
            entity.ToTable("TABLE9267", "INSUDB");
            entity.HasKey(e => e.NOPERTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9268>(entity =>
        {
            entity.ToTable("TABLE9268", "INSUDB");
            entity.HasKey(e => e.NREPTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9269>(entity =>
        {
            entity.ToTable("TABLE9269", "INSUDB");
            entity.HasKey(e => e.NORDERBY);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9270>(entity =>
        {
            entity.ToTable("TABLE9270", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9271>(entity =>
        {
            entity.ToTable("TABLE9271", "INSUDB");
            entity.HasKey(e => e.NCAUSEREOPENCL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9272>(entity =>
        {
            entity.ToTable("TABLE9272", "INSUDB");
            entity.HasKey(e => e.NACCCRITERION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9274>(entity =>
        {
            entity.ToTable("TABLE9274", "INSUDB");
            entity.HasKey(e => e.NNULLCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9275>(entity =>
        {
            entity.ToTable("TABLE9275", "INSUDB");
            entity.HasKey(e => e.NSTATUS);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9276>(entity =>
        {
            entity.ToTable("TABLE9276", "INSUDB");
            entity.HasKey(e => e.NMOVEMENT_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9277>(entity =>
        {
            entity.ToTable("TABLE9277", "INSUDB");
            entity.HasKey(e => e.NNULLCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9278>(entity =>
        {
            entity.ToTable("TABLE9278", "INSUDB");
            entity.HasKey(e => e.NSUM_INSURED_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9279>(entity =>
        {
            entity.ToTable("TABLE9279", "INSUDB");
            entity.HasKey(e => e.NSUBLIMIT_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9280>(entity =>
        {
            entity.ToTable("TABLE9280", "INSUDB");
            entity.HasKey(e => e.NCOINS_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9281>(entity =>
        {
            entity.ToTable("TABLE9281", "INSUDB");
            entity.HasKey(e => e.NSERVICE_TYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE93>(entity =>
        {
            entity.ToTable("TABLE93", "INSUDB");
            entity.HasKey(e => e.NTIME_UNIT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9300>(entity =>
        {
            entity.ToTable("TABLE9300", "INSUDB");
            entity.HasKey(e => e.NPROMISSORYNOTE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9301>(entity =>
        {
            entity.ToTable("TABLE9301", "INSUDB");
            entity.HasKey(e => e.NPROMISSORYSTAT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE95>(entity =>
        {
            entity.ToTable("TABLE95", "INSUDB");
            entity.HasKey(e => e.NNULLCODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE950>(entity =>
        {
            entity.ToTable("TABLE950", "INSUDB");
            entity.HasKey(e => e.NTYP_PROFITWORKER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE96>(entity =>
        {
            entity.ToTable("TABLE96", "INSUDB");
            entity.HasKey(e => e.NCODIGINT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE97>(entity =>
        {
            entity.ToTable("TABLE97", "INSUDB");
            entity.HasKey(e => e.NTYPE_PER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE9781>(entity =>
        {
            entity.ToTable("TABLE9781", "INSUDB");
            entity.HasKey(e => e.NSYSTEM);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE98>(entity =>
        {
            entity.ToTable("TABLE98", "INSUDB");
            entity.HasKey(e => e.NTYPE_REPORT);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE99>(entity =>
        {
            entity.ToTable("TABLE99", "INSUDB");
            entity.HasKey(e => e.NTYPE_LETTER);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(8);
            entity.Property(e => e.SSTATREGT).HasMaxLength(8);
        });

        modelBuilder.Entity<TABLE994>(entity =>
        {
            entity.ToTable("TABLE994", "INSUDB");
            entity.HasKey(e => e.NACTION);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE996>(entity =>
        {
            entity.ToTable("TABLE996", "INSUDB");
            entity.HasKey(e => e.NSECUR_CIA);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE997>(entity =>
        {
            entity.ToTable("TABLE997", "INSUDB");
            entity.HasKey(e => e.NMODULE_ERR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE998>(entity =>
        {
            entity.ToTable("TABLE998", "INSUDB");
            entity.HasKey(e => e.NCOMPTYPE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TABLE999>(entity =>
        {
            entity.ToTable("TABLE999", "INSUDB");
            entity.HasKey(e => e.SSTAT_ERROR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SSTAT_ERROR).HasMaxLength(2);
        });

        modelBuilder.Entity<TAB_LIFCOV>(entity =>
        {
            entity.ToTable("TAB_LIFCOV", "INSUDB");
            entity.HasKey(e => e.NCOVERGEN);
            entity.Property(e => e.SCACALFRI).HasMaxLength(1);
            entity.Property(e => e.SCAPIPREM).HasMaxLength(1);
            entity.Property(e => e.SCLACCIDI).HasMaxLength(12);
            entity.Property(e => e.SCLDEATHI).HasMaxLength(12);
            entity.Property(e => e.SCLINCAPI).HasMaxLength(12);
            entity.Property(e => e.SCLINVALI).HasMaxLength(12);
            entity.Property(e => e.SCLSURVII).HasMaxLength(12);
            entity.Property(e => e.SCLVEHACI).HasMaxLength(12);
            entity.Property(e => e.SCOVERUSE).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(120);
            entity.Property(e => e.SIDURAAGE).HasMaxLength(1);
            entity.Property(e => e.SIDURAYEAR).HasMaxLength(1);
            entity.Property(e => e.SIDUROPEI).HasMaxLength(1);
            entity.Property(e => e.SINSURINI).HasMaxLength(1);
            entity.Property(e => e.SPDURAAGE).HasMaxLength(1);
            entity.Property(e => e.SREVINDEX).HasMaxLength(1);
            entity.Property(e => e.SPDUROPEI).HasMaxLength(1);
            entity.Property(e => e.SPDURYEAR).HasMaxLength(1);
            entity.Property(e => e.SPREMCAPI).HasMaxLength(1);
            entity.Property(e => e.SRECHAPRI).HasMaxLength(1);
            entity.Property(e => e.SRENEWALI).HasMaxLength(1);
            entity.Property(e => e.SROUCHACA).HasMaxLength(12);
            entity.Property(e => e.SROUCHAPR).HasMaxLength(12);
            entity.Property(e => e.SROUPRCAL).HasMaxLength(12);
            entity.Property(e => e.SROURESER).HasMaxLength(12);
            entity.Property(e => e.SROUSURRE).HasMaxLength(12);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(30);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCLILLNESS).HasMaxLength(12);
            entity.Property(e => e.SCONDSVS).HasMaxLength(30);
            entity.Property(e => e.SINFORPROV).HasMaxLength(1);
            entity.Property(e => e.SPROVIDER).HasMaxLength(14);
            entity.Property(e => e.SDESCOVER).HasMaxLength(120);
            entity.Property(e => e.STAXHEREDITY).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_LOCAT>(entity =>
        {
            entity.ToTable("TAB_LOCAT", "INSUDB");
            entity.HasKey(e => e.NLOCAL);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SLEGAL_LOC).HasMaxLength(6);
        });

        modelBuilder.Entity<TAB_MATRIX_RH>(entity =>
        {
            entity.ToTable("TAB_MATRIX_RH", "INSUDB");
            entity.HasKey(e => new { e.NTYPE_MOVE, e.NORIGIN, e.NTYP_PROFITWORKER });
        });

        modelBuilder.Entity<TAB_MEDBENEFITS>(entity =>
        {
            entity.ToTable("TAB_MEDBENEFITS", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NCERTIF, e.NID, e.NMODULEC, e.NCOVER, e.DEFFECDATE, e.SCLIENT, e.NGROUP_INSU });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCAREN_TYPE).HasMaxLength(1);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SILLNESS).HasMaxLength(8);
            entity.Property(e => e.SCLARIFICACT).HasMaxLength(300);
            entity.Property(e => e.SBENEFCATEG_CODE).HasMaxLength(10);
            entity.Property(e => e.SPRINT_DES).HasMaxLength(60);
        });

        modelBuilder.Entity<TAB_MEDBENEFITS_CO>(entity =>
        {
            entity.ToTable("TAB_MEDBENEFITS_CO", "INSUDB");
            entity.HasKey(e => new { e.SCERTYPE, e.NBRANCH, e.NPRODUCT, e.NPOLICY, e.NMODULEC, e.DEFFECDATE, e.NCOVER, e.NGROUP, e.NIDMEDBENEF });
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCHANALLO).HasMaxLength(1);
            entity.Property(e => e.SCAREN_TYPE).HasMaxLength(1);
            entity.Property(e => e.SSEXCLIEN).HasMaxLength(1);
            entity.Property(e => e.SILLNESS).HasMaxLength(8);
            entity.Property(e => e.SCLARIFICACT).HasMaxLength(300);
            entity.Property(e => e.SBENEFCATEG_CODE).HasMaxLength(10);
            entity.Property(e => e.SPRINT_DES).HasMaxLength(60);
        });

        modelBuilder.Entity<TAB_MEDICALFEES>(entity =>
        {
            entity.ToTable("TAB_MEDICALFEES", "INSUDB");
            entity.HasKey(e => new { e.NIDMEDICALFEE, e.NOFFICE, e.NPROVIDER, e.NCENTPROVIDER });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_MODCLI>(entity =>
        {
            entity.ToTable("TAB_MODCLI", "INSUDB");
            entity.HasKey(e => new { e.SITEM, e.STABNAME });
            entity.Property(e => e.SITEM).HasMaxLength(20);
            entity.Property(e => e.STABNAME).HasMaxLength(20);
            entity.Property(e => e.SINDPK).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_MODUL>(entity =>
        {
            entity.ToTable("TAB_MODUL", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NMODULEC, e.NPRODUCT, e.DEFFECDATE });
            entity.Property(e => e.SCHANALLO).HasMaxLength(1);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SCONDSVS).HasMaxLength(30);
            entity.Property(e => e.SROUTINE).HasMaxLength(12);
            entity.Property(e => e.SCHANGETYP).HasMaxLength(1);
            entity.Property(e => e.STYP_RAT).HasMaxLength(1);
            entity.Property(e => e.SVIGEN).HasMaxLength(1);
            entity.Property(e => e.SDEPEND).HasMaxLength(1);
            entity.Property(e => e.SCLAIMMANDATORYFIELDS).HasMaxLength(120);
        });

        modelBuilder.Entity<TAB_NAME_B>(entity =>
        {
            entity.ToTable("TAB_NAME_B", "INSUDB");
            entity.HasKey(e => e.NBRANCH);
            entity.Property(e => e.STABNAME).HasMaxLength(15);
        });

        modelBuilder.Entity<TAB_PROV_BKACCOUNT>(entity =>
        {
            entity.ToTable("TAB_PROV_BKACCOUNT", "INSUDB");
            entity.HasKey(e => new { e.NPROVIDER, e.NBANKEXT, e.SACCOUNT });
            entity.Property(e => e.SACCOUNT).HasMaxLength(100);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SDEPOSIT).HasMaxLength(1);
            entity.Property(e => e.SCLIENTR).HasMaxLength(14);
        });

        modelBuilder.Entity<TAB_PROV_CONTACT>(entity =>
        {
            entity.ToTable("TAB_PROV_CONTACT", "INSUDB");
            entity.HasKey(e => new { e.NPROVIDER, e.NSEQ, e.DEFFECDATE });
            entity.Property(e => e.SNAME_CONTACT).HasMaxLength(63);
            entity.Property(e => e.SE_MAIL).HasMaxLength(60);
            entity.Property(e => e.SPHONE_CONTACT).HasMaxLength(50);
        });

        modelBuilder.Entity<TAB_PROV_FEES>(entity =>
        {
            entity.ToTable("TAB_PROV_FEES", "INSUDB");
            entity.HasKey(e => new { e.NPROVIDER, e.NZONE, e.STYPEBENEFIT, e.SBENEFITCLAS, e.DEFFECDATE });
            entity.Property(e => e.STYPEBENEFIT).HasMaxLength(5);
            entity.Property(e => e.SBENEFITCLAS).HasMaxLength(5);
        });

        modelBuilder.Entity<TAB_PROV_GROUP>(entity =>
        {
            entity.ToTable("TAB_PROV_GROUP", "INSUDB");
            entity.HasKey(e => new { e.NPROVIDER, e.NPROV_GROUP });
        });

        modelBuilder.Entity<TAB_PROVIDER>(entity =>
        {
            entity.ToTable("TAB_PROVIDER", "INSUDB");
            entity.HasKey(e => e.NPROVIDER);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCONCESIONARY).HasMaxLength(1);
            entity.Property(e => e.SAGENCYDESC).HasMaxLength(30);
            entity.Property(e => e.SINTERNATIONALPROVIDER).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_PROV_MEDSPEC>(entity =>
        {
            entity.ToTable("TAB_PROV_MEDSPEC", "INSUDB");
            entity.HasKey(e => new { e.NPROVIDER, e.SMEDSPECIALIALTY });
            entity.Property(e => e.SMEDSPECIALIALTY).HasMaxLength(5);
            entity.Property(e => e.SREG_MEDICALPROF).HasMaxLength(18);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_PROV_STAFF>(entity =>
        {
            entity.ToTable("TAB_PROV_STAFF", "INSUDB");
            entity.HasKey(e => new { e.NPROVIDER, e.SCLIENT, e.DEFFECDATE });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<TAB_PROV_SUBTYPES>(entity =>
        {
            entity.ToTable("TAB_PROV_SUBTYPES", "INSUDB");
            entity.HasKey(e => new { e.NTYPEPROV, e.NSUBTYPEPROV });
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(20);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_PROV_ZONE>(entity =>
        {
            entity.ToTable("TAB_PROV_ZONE", "INSUDB");
            entity.HasKey(e => new { e.NPROVIDER, e.NZONE });
        });

        modelBuilder.Entity<TAB_RELAT>(entity =>
        {
            entity.ToTable("TAB_RELAT", "INSUDB");
            entity.HasKey(e => e.NRELASHIP);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_ROUTINE>(entity =>
        {
            entity.ToTable("TAB_ROUTINE", "INSUDB");
            entity.HasKey(e => new { e.SROUTINE, e.NROUTINETYPE });
            entity.Property(e => e.SROUTINE).HasMaxLength(17);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(63);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_SHORT_G>(entity =>
        {
            entity.ToTable("TAB_SHORT_G", "INSUDB");
            entity.HasKey(e => new { e.NMONTHMAX, e.NDAYSMAX, e.DEFFECDATE });
        });

        modelBuilder.Entity<TAB_STATE_SAAPV>(entity =>
        {
            entity.ToTable("TAB_STATE_SAAPV", "INSUDB");
            entity.HasKey(e => new { e.NTYPE_SAAPV, e.NTYPE_STATE_ORIGI, e.NTYPE_STATE_END });
        });

        modelBuilder.Entity<TAB_SYS_EXE>(entity =>
        {
            entity.ToTable("TAB_SYS_EXE", "INSUDB");
            entity.HasKey(e => e.NEXE_CODE);
            entity.Property(e => e.SEXE_NAME).HasMaxLength(20);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SFOLDERNAME).HasMaxLength(20);
        });

        modelBuilder.Entity<TAB_TABLES>(entity =>
        {
            entity.ToTable("TAB_TABLES", "INSUDB");
            entity.HasKey(e => e.STAB_CODE);
            entity.Property(e => e.STAB_CODE).HasMaxLength(20);
            entity.Property(e => e.SCODE_ITEM).HasMaxLength(20);
            entity.Property(e => e.SDESC_ITEM).HasMaxLength(12);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SDS_SELECT).HasMaxLength(250);
            entity.Property(e => e.SQ_VALUE).HasMaxLength(1);
            entity.Property(e => e.SSHOWNUM).HasMaxLength(1);
            entity.Property(e => e.SINITQUERY).HasMaxLength(1);
            entity.Property(e => e.SINDSP).HasMaxLength(1);
            entity.Property(e => e.SKEY).HasMaxLength(20);
        });

        modelBuilder.Entity<TAB_TYPERR>(entity =>
        {
            entity.ToTable("TAB_TYPERR", "INSUDB");
            entity.HasKey(e => e.NTYPE_ERR);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.STRANSITI).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_WAITPO>(entity =>
        {
            entity.ToTable("TAB_WAITPO", "INSUDB");
            entity.HasKey(e => e.NWAIT_CODE);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SCONVERT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_WINCLA>(entity =>
        {
            entity.ToTable("TAB_WINCLA", "INSUDB");
            entity.HasKey(e => new { e.NTRATYPEC, e.SBRANCHT, e.SBUSSITYP, e.NSEQUENCE });
            entity.Property(e => e.SBRANCHT).HasMaxLength(1);
            entity.Property(e => e.SBUSSITYP).HasMaxLength(1);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_WINCLI>(entity =>
        {
            entity.ToTable("TAB_WINCLI", "INSUDB");
            entity.HasKey(e => new { e.STYPE_CLIE, e.STYPE_SEQ, e.NSEQUENCE });
            entity.Property(e => e.STYPE_CLIE).HasMaxLength(1);
            entity.Property(e => e.STYPE_SEQ).HasMaxLength(3);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_WINFIN>(entity =>
        {
            entity.ToTable("TAB_WINFIN", "INSUDB");
            entity.HasKey(e => new { e.NTRATYPEC, e.NSEQUENCE });
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_WINPOL>(entity =>
        {
            entity.ToTable("TAB_WINPOL", "INSUDB");
            entity.HasKey(e => new { e.SBUSSITYP, e.SPOLITYPE, e.SCOMPON, e.NTRATYPEP, e.SCODISPL, e.NTYPE_AMEND, e.SBRANCHT });
            entity.Property(e => e.SBUSSITYP).HasMaxLength(1);
            entity.Property(e => e.SPOLITYPE).HasMaxLength(1);
            entity.Property(e => e.SCOMPON).HasMaxLength(1);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SDEFAULTI).HasMaxLength(1);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
            entity.Property(e => e.SAUTOMATIC).HasMaxLength(1);
            entity.Property(e => e.SBRANCHT).HasMaxLength(1);
        });

        modelBuilder.Entity<TAB_WINPRO>(entity =>
        {
            entity.ToTable("TAB_WINPRO", "INSUDB");
            entity.HasKey(e => new { e.SBRANCHT, e.NSEQUENCE });
            entity.Property(e => e.SBRANCHT).HasMaxLength(1);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SREQUIRE).HasMaxLength(1);
        });

        modelBuilder.Entity<TAR_HEALT_PREM>(entity =>
        {
            entity.ToTable("TAR_HEALT_PREM", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.DEFFECDATE, e.NROLE, e.NMODULEC, e.NCOVER, e.NGEOGRAPHAREA, e.NATTENSYSTEM, e.NOFFICE, e.NCAPITAL_INIT, e.NCAPITAL_END, e.NPOLICY_YEAR_INIT, e.NPOLICY_YEAR_END, e.NCURRENCY, e.NAGE_INIT, e.NAGE_END });
        });

        modelBuilder.Entity<TARIF_COLUMN>(entity =>
        {
            entity.ToTable("TARIF_COLUMN", "INSUDB");
            entity.HasKey(e => e.NID_COLUMN);
            entity.Property(e => e.STABLE).HasMaxLength(30);
            entity.Property(e => e.SCOLUMN).HasMaxLength(30);
            entity.Property(e => e.SNAME_COL).HasMaxLength(30);
            entity.Property(e => e.STABLEFK).HasMaxLength(30);
        });

        modelBuilder.Entity<TAX_FIXVAL>(entity =>
        {
            entity.ToTable("TAX_FIXVAL", "INSUDB");
            entity.HasKey(e => new { e.NCODE, e.STYPETAX, e.DEFFECDATE });
            entity.Property(e => e.STYPETAX).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

        modelBuilder.Entity<T_BANK_MOV>(entity =>
        {
            entity.ToTable("T_BANK_MOV", "INSUDB");
            entity.HasKey(e => new { e.NBORDEREAUX, e.NSEQUENCE });
            entity.Property(e => e.SDEP_NUMBER).HasMaxLength(256);
            entity.Property(e => e.SNULL_MOVEM).HasMaxLength(1);
            entity.Property(e => e.SNULL_RECOR).HasMaxLength(1);
            entity.Property(e => e.SDOCNUMBE).HasMaxLength(30);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SNUMFORM).HasMaxLength(12);
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
            entity.Property(e => e.SACTION).HasMaxLength(1);
        });

        modelBuilder.Entity<T_BANK_TRANS>(entity =>
        {
            entity.ToTable("T_BANK_TRANS", "INSUDB");
            entity.HasKey(e => new { e.NBORDEREAUX, e.NSEQUENCE });
            entity.Property(e => e.SACCO_NUM).HasMaxLength(100);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SACTION).HasMaxLength(1);
        });

        modelBuilder.Entity<T_CASH_MOV>(entity =>
        {
            entity.ToTable("T_CASH_MOV", "INSUDB");
            entity.HasKey(e => new { e.NBORDEREAUX, e.NSEQUENCE });
            entity.Property(e => e.SCARD_NUM).HasMaxLength(100);
            entity.Property(e => e.SDOCNUMBE).HasMaxLength(30);
            entity.Property(e => e.SDEP_NUMBER).HasMaxLength(12);
            entity.Property(e => e.SNULL_MOVEM).HasMaxLength(1);
            entity.Property(e => e.SNULL_RECOR).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SNUMFORM).HasMaxLength(12);
            entity.Property(e => e.SINTER_PAY).HasMaxLength(14);
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SPROCESS).HasMaxLength(1);
            entity.Property(e => e.SR_DEPNUM).HasMaxLength(12);
            entity.Property(e => e.SACTION).HasMaxLength(1);
        });

        modelBuilder.Entity<T_CHEQUES>(entity =>
        {
            entity.ToTable("T_CHEQUES", "INSUDB");
            entity.HasKey(e => new { e.NBORDEREAUX, e.NSEQUENCE });
            entity.Property(e => e.SCHEQUE).HasMaxLength(10);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SREQUEST_TY).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SPAY_FREQ).HasMaxLength(1);
            entity.Property(e => e.SINTER_PAY).HasMaxLength(14);
            entity.Property(e => e.SFILE_FIN700).HasMaxLength(12);
            entity.Property(e => e.SACTION).HasMaxLength(1);
        });

        modelBuilder.Entity<T_CONCEPTS>(entity =>
        {
            entity.ToTable("T_CONCEPTS", "INSUDB");
            entity.HasKey(e => new { e.NBORDEREAUX, e.NTRANSAC });
            entity.Property(e => e.SSEL).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SACTION).HasMaxLength(1);
            entity.Property(e => e.STYPE_BANKAGREE).HasMaxLength(1);
        });

        modelBuilder.Entity<TCONVERTIONS>(entity =>
        {
            entity.ToTable("TCONVERTIONS", "INSUDB");
            entity.HasKey(e => new { e.SKEY, e.NINDEX });
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SPEN_DOC).HasMaxLength(1);
            entity.Property(e => e.SOBSERV).HasMaxLength(1);
            entity.Property(e => e.SPREM_CHE).HasMaxLength(1);
            entity.Property(e => e.SPAY_ORDER).HasMaxLength(1);
            entity.Property(e => e.SDEVOLUT).HasMaxLength(1);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SAPPLYCOSTFP).HasMaxLength(1);
            entity.Property(e => e.SPENSTATUS_POL).HasMaxLength(1);
        });

        modelBuilder.Entity<T_DOCTYP>(entity =>
        {
            entity.ToTable("T_DOCTYP", "INSUDB");
            entity.HasKey(e => new { e.NBORDEREAUX, e.NSEQUENCE });
            entity.Property(e => e.SSEL).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SMANAUTI).HasMaxLength(1);
            entity.Property(e => e.STYPE_DETAI).HasMaxLength(1);
            entity.Property(e => e.SNEWRECEIPT).HasMaxLength(1);
            entity.Property(e => e.SFOLIONUMBER).HasMaxLength(10);
            entity.Property(e => e.SBILLADVANCE).HasMaxLength(1);
        });

        modelBuilder.Entity<T_ERR_INTERFACE>(entity =>
        {
            entity.ToTable("T_ERR_INTERFACE", "INSUDB");
            entity.HasKey(e => new { e.SKEY, e.NSEQ, e.NROW });
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(1000);
            entity.Property(e => e.SCERTYPE).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
        });

        modelBuilder.Entity<TIMEGLOBALS>(entity =>
        {
            entity.ToTable("TIMEGLOBALS", "INSUDB");
            entity.HasKey(e => e.SCODE);
            entity.Property(e => e.SCODE).HasMaxLength(15);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

        modelBuilder.Entity<T_INTERFACE>(entity =>
        {
            entity.ToTable("T_INTERFACE", "INSUDB");
            entity.HasKey(e => new { e.SKEY, e.NROW, e.NCOLUMN, e.STABLE });
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SVALUE).HasMaxLength(4000);
            entity.Property(e => e.STABLE).HasMaxLength(40);
            entity.Property(e => e.SPROCESS).HasMaxLength(1);
            entity.Property(e => e.SVALUE_HOMO).HasMaxLength(4000);
            entity.Property(e => e.SFIELDDESC).HasMaxLength(30);
        });

        modelBuilder.Entity<TLEDAUTREJECTM>(entity =>
        {
            entity.ToTable("TLEDAUTREJECTM", "INSUDB");
            entity.HasKey(e => new { e.NAREA_LED, e.NID });
            entity.Property(e => e.SERRDETAIL).HasMaxLength(100);
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SCHEQUE).HasMaxLength(10);
            entity.Property(e => e.SCOLUMN).HasMaxLength(1);
        });

        modelBuilder.Entity<T_MASIVECHARGE>(entity =>
        {
            entity.ToTable("T_MASIVECHARGE", "INSUDB");
            entity.HasKey(e => new { e.SKEY, e.NROWS, e.NCOLUMNS });
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SFIELD).HasMaxLength(40);
            entity.Property(e => e.SVALUE).HasMaxLength(300);
            entity.Property(e => e.STABLE).HasMaxLength(40);
            entity.Property(e => e.SVALUESLIST).HasMaxLength(30);
        });

        modelBuilder.Entity<T_MOVE_ACC>(entity =>
        {
            entity.ToTable("T_MOVE_ACC", "INSUDB");
            entity.HasKey(e => new { e.NBORDEREAUX, e.NSEQUENCE });
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SAUTORIZA).HasMaxLength(1);
            entity.Property(e => e.SNUMFORM).HasMaxLength(12);
            entity.Property(e => e.STYPE_ACC).HasMaxLength(1);
            entity.Property(e => e.SCHEQUE).HasMaxLength(10);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SMANUALMOV).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SPROCESS).HasMaxLength(1);
            entity.Property(e => e.SNULL_RECOR).HasMaxLength(1);
            entity.Property(e => e.SPROCESS_IND).HasMaxLength(1);
            entity.Property(e => e.SACTION).HasMaxLength(1);
        });

        modelBuilder.Entity<T_PARAM_INTERFACE>(entity =>
        {
            entity.ToTable("T_PARAM_INTERFACE", "INSUDB");
            entity.HasKey(e => new { e.SKEY, e.NFIELD });
            entity.Property(e => e.SKEY).HasMaxLength(20);
            entity.Property(e => e.SVALUE).HasMaxLength(100);
        });

        modelBuilder.Entity<TRACKING>(entity =>
        {
            entity.ToTable("TRACKING", "INSUDB");
            entity.HasKey(e => e.ID);
            entity.Property(e => e.HOSTSOURCE).HasMaxLength(124);
            entity.Property(e => e.FORMPATH).HasMaxLength(512);
            entity.Property(e => e.URLREFERRER).HasMaxLength(512);
            entity.Property(e => e.USERAGENT).HasMaxLength(512);
            entity.Property(e => e.FORMID).HasMaxLength(36);
            entity.Property(e => e.REMARK).HasMaxLength(80);
            entity.Property(e => e.CALLEDFROMID).HasMaxLength(36);
        });

        modelBuilder.Entity<TRELDOC>(entity =>
        {
            entity.ToTable("TRELDOC", "INSUDB");
            entity.HasKey(e => new { e.NBORDEREAUX, e.NSEQUENCE, e.NCOLLECDOCTYP });
            entity.Property(e => e.SFOLIONUMBER).HasMaxLength(10);
        });

        modelBuilder.Entity<TYPE_AMEND>(entity =>
        {
            entity.ToTable("TYPE_AMEND", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NTYPE_AMEND, e.DEFFECDATE });
            entity.Property(e => e.SIND_ORDER_SERV).HasMaxLength(1);
            entity.Property(e => e.SRETARIF).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
            entity.Property(e => e.SRESOLUTION).HasMaxLength(25);
            entity.Property(e => e.SGOVAPRNAME).HasMaxLength(100);
            entity.Property(e => e.SCONDSVS).HasMaxLength(30);
            entity.Property(e => e.SSHOWSTATUS).HasMaxLength(1);
        });

        modelBuilder.Entity<TYPEPERGROUP>(entity =>
        {
            entity.ToTable("TYPEPERGROUP", "INSUDB");
            entity.HasKey(e => new { e.NBUSINESSTY, e.NCOMMERGRP });
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<TYPESUBTYPE_RELATIONSHIP>(entity =>
        {
            entity.ToTable("TYPESUBTYPE_RELATIONSHIP", "INSUDB");
            entity.HasKey(e => new { e.STYPECARE, e.SCARECLASS });
            entity.Property(e => e.STYPECARE).HasMaxLength(10);
            entity.Property(e => e.SCARECLASS).HasMaxLength(10);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<UL_LEGAL_TERMS>(entity =>
        {
            entity.ToTable("UL_LEGAL_TERMS", "INSUDB");
            entity.HasKey(e => new { e.NTYPE_SAAPV, e.DEFFECDATE });
        });

        modelBuilder.Entity<USER_CASHNUM>(entity =>
        {
            entity.ToTable("USER_CASHNUM", "INSUDB");
            entity.HasKey(e => e.NCASHNUM);
            entity.Property(e => e.SSTATUS).HasMaxLength(1);
        });

        modelBuilder.Entity<USER_OFFICE>(entity =>
        {
            entity.ToTable("USER_OFFICE", "INSUDB");
            entity.HasKey(e => new { e.NUSER, e.NOFFICEAGEN });
        });

        modelBuilder.Entity<USERS>(entity =>
        {
            entity.ToTable("USERS", "INSUDB");
            entity.HasKey(e => e.NUSERCODE);
            entity.Property(e => e.SACCESSWO).HasMaxLength(12);
            entity.Property(e => e.SCLIENT).HasMaxLength(14);
            entity.Property(e => e.SINITIALS).HasMaxLength(50);
            entity.Property(e => e.SSCHE_CODE).HasMaxLength(6);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.STYPE).HasMaxLength(1);
            entity.Property(e => e.SMENU).HasMaxLength(8);
            entity.Property(e => e.SCHNEXTLOGON).HasMaxLength(1);
            entity.Property(e => e.SNEVERCHANGE).HasMaxLength(1);
            entity.Property(e => e.SNEVEREXPIRES).HasMaxLength(1);
            entity.Property(e => e.SLOCKEDOUT).HasMaxLength(1);
        });

        modelBuilder.Entity<WAY_PAY_PROD>(entity =>
        {
            entity.ToTable("WAY_PAY_PROD", "INSUDB");
            entity.HasKey(e => new { e.NBRANCH, e.NPRODUCT, e.NWAY_PAY, e.DEFFECDATE });
            entity.Property(e => e.SPREM_FIRST).HasMaxLength(1);
            entity.Property(e => e.SIND_PREISSU).HasMaxLength(1);
            entity.Property(e => e.SIND_PREREF).HasMaxLength(1);
            entity.Property(e => e.SONERECEIPT).HasMaxLength(1);
            entity.Property(e => e.SLASTRECEIPT).HasMaxLength(1);
            entity.Property(e => e.SCOLLECTION).HasMaxLength(1);
            entity.Property(e => e.SIND_PREREFMAX).HasMaxLength(1);
            entity.Property(e => e.SPRFIRST_EXPR).HasMaxLength(1);
        });

        modelBuilder.Entity<WIN_ACTIONS>(entity =>
        {
            entity.ToTable("WIN_ACTIONS", "INSUDB");
            entity.HasKey(e => new { e.SCODISPL, e.NSEQUENCE });
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
        });

        modelBuilder.Entity<WINDOWS>(entity =>
        {
            entity.ToTable("WINDOWS", "INSUDB");
            entity.HasKey(e => e.SCODISPL);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SCODISP).HasMaxLength(8);
            entity.Property(e => e.SCODMEN).HasMaxLength(8);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(60);
            entity.Property(e => e.SDIRECTGO).HasMaxLength(1);
            entity.Property(e => e.SPSEUDO).HasMaxLength(12);
            entity.Property(e => e.SSHORT_DES).HasMaxLength(12);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
            entity.Property(e => e.SHELPPATH).HasMaxLength(30);
            entity.Property(e => e.SAUTOREP).HasMaxLength(1);
            entity.Property(e => e.SQUOTE).HasMaxLength(1);
            entity.Property(e => e.SINDLETTER).HasMaxLength(1);
            entity.Property(e => e.SFILEPATH).HasMaxLength(60);
            entity.Property(e => e.SWINDOWURL).HasMaxLength(4000);
        });

        modelBuilder.Entity<WIN_FILE_G>(entity =>
        {
            entity.ToTable("WIN_FILE_G", "INSUDB");
            entity.HasKey(e => e.SCODISPL);
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.STABNAME).HasMaxLength(15);
        });

        modelBuilder.Entity<WIN_HOUR>(entity =>
        {
            entity.ToTable("WIN_HOUR", "INSUDB");
            entity.HasKey(e => new { e.SCODISPL, e.SHOUR_START });
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SHOUR_START).HasMaxLength(5);
            entity.Property(e => e.SHOUR_END).HasMaxLength(5);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<WIN_MESSAG>(entity =>
        {
            entity.ToTable("WIN_MESSAG", "INSUDB");
            entity.HasKey(e => new { e.SCODISPL, e.NERRORNUM });
            entity.Property(e => e.SCODISPL).HasMaxLength(8);
            entity.Property(e => e.SACTION_ERR).HasMaxLength(80);
            entity.Property(e => e.SERRORTYP).HasMaxLength(1);
            entity.Property(e => e.SSTATREGT).HasMaxLength(1);
        });

        modelBuilder.Entity<WORKSHEET>(entity =>
        {
            entity.ToTable("WORKSHEET", "INSUDB");
            entity.HasKey(e => e.NID);
            entity.Property(e => e.SVALUESLIST).HasMaxLength(1);
            entity.Property(e => e.SDESCRIPT).HasMaxLength(30);
        });

    }
}
