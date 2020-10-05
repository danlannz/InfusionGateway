## Dump of internal functions from ibsgateway831.dll using PEExplorer to dissassemble

```c#
//Infusion Business Software Gateway 831
//Version: 1.0
ibsgateway831;
GUID = {E2BBBF77-FBE1-40E3-8F7E-2B05B47AB6CB};

//Infusion Business Software Gateway 831
Dispatch Igateway;
GUID = {2C7AA31E-A91E-433A-B837-212A151470FF};
function QueryInterface(riid: ^GUID; out ppvObj: ^^VOID); stdcall;
function AddRef: UI4; stdcall;
function Release: UI4; stdcall;
function GetTypeInfoCount(out pctinfo: ^UINT); stdcall;
function GetTypeInfo(itinfo: UINT; lcid: UI4; out pptinfo: ^^VOID); stdcall;
function GetIDsOfNames(riid: ^GUID; rgszNames: ^^I1; cNames: UINT; lcid: UI4; out rgdispid: ^I4); stdcall;
function Invoke(dispidMember: I4; riid: ^GUID; lcid: UI4; wFlags: UI2; pdispparams: ^DISPPARAMS; out pvarResult: ^Variant; out pexcepinfo: ^EXCEPINFO; out puArgErr: ^UINT); stdcall;
//Specifies the file name of the user-defined class library that contains the object's class.
property-get ClassLibrary: BSTR; stdcall;
//Specifies the name used to reference an object in code.
property-get Name: BSTR; stdcall;
//Specifies the name used to reference an object in code.
property-put Name(: BSTR); stdcall;
property-get PACCOUNT: Variant; stdcall;
property-put PACCOUNT(: Variant); stdcall;
property-get PADD1: Variant; stdcall;
property-put PADD1(: Variant); stdcall;
property-get PADD2: Variant; stdcall;
property-put PADD2(: Variant); stdcall;
property-get PADD3: Variant; stdcall;
property-put PADD3(: Variant); stdcall;
property-get PADD4: Variant; stdcall;
property-put PADD4(: Variant); stdcall;
property-get PASSETID: Variant; stdcall;
property-put PASSETID(: Variant); stdcall;
property-get PATTNLINK: Variant; stdcall;
property-put PATTNLINK(: Variant); stdcall;
property-get PAUDIT: Variant; stdcall;
property-put PAUDIT(: Variant); stdcall;
property-get PAUTOPRICE: Variant; stdcall;
property-put PAUTOPRICE(: Variant); stdcall;
property-get PBACK: Variant; stdcall;
property-put PBACK(: Variant); stdcall;
property-get PBATCH: Variant; stdcall;
property-put PBATCH(: Variant); stdcall;
property-get PCOSTRATE: Variant; stdcall;
property-put PCOSTRATE(: Variant); stdcall;
property-get PCREDIT: Variant; stdcall;
property-put PCREDIT(: Variant); stdcall;
property-get PCMACCOUNTID: Variant; stdcall;
property-put PCMACCOUNTID(: Variant); stdcall;
property-get PCMSTAFFCODE: Variant; stdcall;
property-put PCMSTAFFCODE(: Variant); stdcall;
property-get PCMID: Variant; stdcall;
property-put PCMID(: Variant); stdcall;
property-get PCMDATETIME: Variant; stdcall;
property-put PCMDATETIME(: Variant); stdcall;
property-get PCMCONTACTID: Variant; stdcall;
property-put PCMCONTACTID(: Variant); stdcall;
property-get PCMCREATEDBYSTAFFID: Variant; stdcall;
property-put PCMCREATEDBYSTAFFID(: Variant); stdcall;
property-get PCMMODULE: Variant; stdcall;
property-put PCMMODULE(: Variant); stdcall;
property-get PCMTYPEID: Variant; stdcall;
property-put PCMTYPEID(: Variant); stdcall;
property-get PCMSTATUS: Variant; stdcall;
property-put PCMSTATUS(: Variant); stdcall;
property-get PCMTITLE: Variant; stdcall;
property-put PCMTITLE(: Variant); stdcall;
property-get PCMNOTES: Variant; stdcall;
property-put PCMNOTES(: Variant); stdcall;
property-get PCMFOLLOWUPID: Variant; stdcall;
property-put PCMFOLLOWUPID(: Variant); stdcall;
property-get PCMFOLLOWUPDATE: Variant; stdcall;
property-put PCMFOLLOWUPDATE(: Variant); stdcall;
property-get PCMFOLLOWUPSTAFFID: Variant; stdcall;
property-put PCMFOLLOWUPSTAFFID(: Variant); stdcall;
property-get PCMPRIORITY: Variant; stdcall;
property-put PCMPRIORITY(: Variant); stdcall;
property-get PCMGROUPID: Variant; stdcall;
property-put PCMGROUPID(: Variant); stdcall;
property-get PCMREFERENCE: Variant; stdcall;
property-put PCMREFERENCE(: Variant); stdcall;
property-get PDADD1: Variant; stdcall;
property-put PDADD1(: Variant); stdcall;
property-get PDADD2: Variant; stdcall;
property-put PDADD2(: Variant); stdcall;
property-get PDADD3: Variant; stdcall;
property-put PDADD3(: Variant); stdcall;
property-get PDADD4: Variant; stdcall;
property-put PDADD4(: Variant); stdcall;
property-get PDATE: Variant; stdcall;
property-put PDATE(: Variant); stdcall;
property-get PDDATE: Variant; stdcall;
property-put PDDATE(: Variant); stdcall;
property-get PDEBIT: Variant; stdcall;
property-put PDEBIT(: Variant); stdcall;
property-get PDELATTNLINK: Variant; stdcall;
property-put PDELATTNLINK(: Variant); stdcall;
property-get PDELSTATUS: Variant; stdcall;
property-put PDELSTATUS(: Variant); stdcall;
property-get PDEPARTMENT: Variant; stdcall;
property-put PDEPARTMENT(: Variant); stdcall;
property-get PDESC: Variant; stdcall;
property-put PDESC(: Variant); stdcall;
property-get PDISCOUNT: Variant; stdcall;
property-put PDISCOUNT(: Variant); stdcall;
property-get PDNAME: Variant; stdcall;
property-put PDNAME(: Variant); stdcall;
property-get PDPOSTCODE: Variant; stdcall;
property-put PDPOSTCODE(: Variant); stdcall;
property-get PDTIME: Variant; stdcall;
property-put PDTIME(: Variant); stdcall;
property-get PDUEDATE: Variant; stdcall;
property-put PDUEDATE(: Variant); stdcall;
property-get PEMAIL: Variant; stdcall;
property-put PEMAIL(: Variant); stdcall;
property-get PENTEREDBY: Variant; stdcall;
property-put PENTEREDBY(: Variant); stdcall;
property-get PEXTEND: Variant; stdcall;
property-put PEXTEND(: Variant); stdcall;
property-get PFAX: Variant; stdcall;
property-put PFAX(: Variant); stdcall;
property-get PFIRSTNAME: Variant; stdcall;
property-put PFIRSTNAME(: Variant); stdcall;
property-get PFREIGHT: Variant; stdcall;
property-put PFREIGHT(: Variant); stdcall;
property-get PFROM: Variant; stdcall;
property-put PFROM(: Variant); stdcall;
property-get PFLAG: Variant; stdcall;
property-put PFLAG(: Variant); stdcall;
property-get PGLID: Variant; stdcall;
property-put PGLID(: Variant); stdcall;
property-get PGST: Variant; stdcall;
property-put PGST(: Variant); stdcall;
property-get PGSTINCLFLAG: Variant; stdcall;
property-put PGSTINCLFLAG(: Variant); stdcall;
property-get PGSTRATE: Variant; stdcall;
property-put PGSTRATE(: Variant); stdcall;
property-get PGSTTYPE: Variant; stdcall;
property-put PGSTTYPE(: Variant); stdcall;
property-get PGSTUNRND: Variant; stdcall;
property-put PGSTUNRND(: Variant); stdcall;
property-get PHDRDATE1: Variant; stdcall;
property-put PHDRDATE1(: Variant); stdcall;
property-get PHDRDATE2: Variant; stdcall;
property-put PHDRDATE2(: Variant); stdcall;
property-get PHDRUSER1: Variant; stdcall;
property-put PHDRUSER1(: Variant); stdcall;
property-get PHDRUSER2: Variant; stdcall;
property-put PHDRUSER2(: Variant); stdcall;
property-get PHDRUSER3: Variant; stdcall;
property-put PHDRUSER3(: Variant); stdcall;
property-get PHDRUSER4: Variant; stdcall;
property-put PHDRUSER4(: Variant); stdcall;
property-get PHDRUSER5: Variant; stdcall;
property-put PHDRUSER5(: Variant); stdcall;
property-get PHDRUSER6: Variant; stdcall;
property-put PHDRUSER6(: Variant); stdcall;
property-get PINVORDNUM: Variant; stdcall;
property-put PINVORDNUM(: Variant); stdcall;
property-get PINVNUMBER: Variant; stdcall;
property-put PINVNUMBER(: Variant); stdcall;
property-get PJOBID: Variant; stdcall;
property-put PJOBID(: Variant); stdcall;
property-get PLINEUSER1: Variant; stdcall;
property-put PLINEUSER1(: Variant); stdcall;
property-get PLINEUSER2: Variant; stdcall;
property-put PLINEUSER2(: Variant); stdcall;
property-get PLINEUSER3: Variant; stdcall;
property-put PLINEUSER3(: Variant); stdcall;
property-get PLINK: Variant; stdcall;
property-put PLINK(: Variant); stdcall;
property-get PLOCATION: Variant; stdcall;
property-put PLOCATION(: Variant); stdcall;
property-get PMOBILE: Variant; stdcall;
property-put PMOBILE(: Variant); stdcall;
property-get PNAME: Variant; stdcall;
property-put PNAME(: Variant); stdcall;
property-get PNOTES: Variant; stdcall;
property-put PNOTES(: Variant); stdcall;
property-get PPAYMENT: Variant; stdcall;
property-put PPAYMENT(: Variant); stdcall;
property-get PPCODE: Variant; stdcall;
property-put PPCODE(: Variant); stdcall;
property-get PPHONE: Variant; stdcall;
property-put PPHONE(: Variant); stdcall;
property-get PPOORDNUM: Variant; stdcall;
property-put PPOORDNUM(: Variant); stdcall;
property-get PPOJOBID: Variant; stdcall;
property-put PPOJOBID(: Variant); stdcall;
property-get PPOJOBLOC: Variant; stdcall;
property-put PPOJOBLOC(: Variant); stdcall;
property-get PPOORDTYPE: Variant; stdcall;
property-put PPOORDTYPE(: Variant); stdcall;
property-get PPODELLOC: Variant; stdcall;
property-put PPODELLOC(: Variant); stdcall;
property-get PPOSITION: Variant; stdcall;
property-put PPOSITION(: Variant); stdcall;
property-get PPOSTCODE: Variant; stdcall;
property-put PPOSTCODE(: Variant); stdcall;
property-get PQTY: Variant; stdcall;
property-put PQTY(: Variant); stdcall;
property-get PQUOTENUMBER: Variant; stdcall;
property-put PQUOTENUMBER(: Variant); stdcall;
property-get PRATE: Variant; stdcall;
property-put PRATE(: Variant); stdcall;
property-get PREF: Variant; stdcall;
property-put PREF(: Variant); stdcall;
property-get PREP: Variant; stdcall;
property-put PREP(: Variant); stdcall;
property-get PROUNDING: Variant; stdcall;
property-put PROUNDING(: Variant); stdcall;
property-get PSERIAL: Variant; stdcall;
property-put PSERIAL(: Variant); stdcall;
property-get PSERVICEID: Variant; stdcall;
property-put PSERVICEID(: Variant); stdcall;
property-get PSORTORD: Variant; stdcall;
property-put PSORTORD(: Variant); stdcall;
property-get PSTOREID: Variant; stdcall;
property-put PSTOREID(: Variant); stdcall;
property-get PSTOREFIELD: Variant; stdcall;
property-put PSTOREFIELD(: Variant); stdcall;
property-get PSTATUS: Variant; stdcall;
property-put PSTATUS(: Variant); stdcall;
property-get PSURNAME: Variant; stdcall;
property-put PSURNAME(: Variant); stdcall;
property-get PTRTYPE: Variant; stdcall;
property-put PTRTYPE(: Variant); stdcall;
property-get PTITLE: Variant; stdcall;
property-put PTITLE(: Variant); stdcall;
property-get PTO: Variant; stdcall;
property-put PTO(: Variant); stdcall;
property-get PTOTAL: Variant; stdcall;
property-put PTOTAL(: Variant); stdcall;
property-get PTRANS: Variant; stdcall;
property-put PTRANS(: Variant); stdcall;
property-get PTRANS2: Variant; stdcall;
property-put PTRANS2(: Variant); stdcall;
property-get PTXNID: Variant; stdcall;
property-put PTXNID(: Variant); stdcall;
property-get PTYPE: Variant; stdcall;
property-put PTYPE(: Variant); stdcall;
property-get PUPDATERATE: Variant; stdcall;
property-put PUPDATERATE(: Variant); stdcall;
property-get PUPDATEDISC: Variant; stdcall;
property-put PUPDATEDISC(: Variant); stdcall;
property-get PUSER1: Variant; stdcall;
property-put PUSER1(: Variant); stdcall;
property-get PUSER2: Variant; stdcall;
property-put PUSER2(: Variant); stdcall;
property-get PVOIP: Variant; stdcall;
property-put PVOIP(: Variant); stdcall;
property-get WHOINID: Variant; stdcall;
property-put WHOINID(: Variant); stdcall;
property-get DATAPATH: Variant; stdcall;
property-put DATAPATH(: Variant); stdcall;
property-get ROOTPATH: Variant; stdcall;
property-put ROOTPATH(: Variant); stdcall;
property-get PDFPATH: Variant; stdcall;
property-put PDFPATH(: Variant); stdcall;
property-get LASTRESULT: Variant; stdcall;
property-put LASTRESULT(: Variant); stdcall;
property-get LASTRESULTMESSAGE: Variant; stdcall;
property-put LASTRESULTMESSAGE(: Variant); stdcall;
property-get LASTERROR: Variant; stdcall;
property-put LASTERROR(: Variant); stdcall;
property-get LASTERRORMESSAGE: Variant; stdcall;
property-put LASTERRORMESSAGE(: Variant); stdcall;
property-get LOGOFFBY: Variant; stdcall;
property-put LOGOFFBY(: Variant); stdcall;
property-get ALLOWON: Variant; stdcall;
property-put ALLOWON(: Variant); stdcall;
property-get ALLUSERSMESSAGELASTMODIFIED: Variant; stdcall;
property-put ALLUSERSMESSAGELASTMODIFIED(: Variant); stdcall;
property-get ADMINMESSAGE: Variant; stdcall;
property-put ADMINMESSAGE(: Variant); stdcall;
property-get SENTBY: Variant; stdcall;
property-put SENTBY(: Variant); stdcall;
property-get FORCEOFF: Variant; stdcall;
property-put FORCEOFF(: Variant); stdcall;
property-get PDATE2: Variant; stdcall;
property-put PDATE2(: Variant); stdcall;
property-get PBUDTYPE: Variant; stdcall;
property-put PBUDTYPE(: Variant); stdcall;
property-get REXPIRINGREWARDS1: Variant; stdcall;
property-put REXPIRINGREWARDS1(: Variant); stdcall;
property-get REXPIRINGREWARDS2: Variant; stdcall;
property-put REXPIRINGREWARDS2(: Variant); stdcall;
property-get RCINVNUMBERS: Variant; stdcall;
property-put RCINVNUMBERS(: Variant); stdcall;
property-get OSCATTER: Variant; stdcall;
property-put OSCATTER(: Variant); stdcall;
//Occurs when an object is created.
function Init(out InitParm1: Variant; out InitParm2: Variant): Variant; stdcall;
function setpath(cPath: BSTR): Variant; stdcall;
function SetRootPath(cRootPath: BSTR): Variant; stdcall;
function CheckLogin: Variant; stdcall;
function login(cProgramName: BSTR): Variant; stdcall;
function Logout: Variant; stdcall;
function Open(cFile: BSTR; cAlias: BSTR): Variant; stdcall;
function Close(cAlias: BSTR): Variant; stdcall;
function FinSumMTDYTD: Variant; stdcall;
function FinSumTB: Variant; stdcall;
function FinSumBMTDYTD: Variant; stdcall;
function deleteRecord(cAlias: BSTR): Variant; stdcall;
function Select(cAlias: BSTR): Variant; stdcall;
function Get(cAliasField: BSTR): Variant; stdcall;
function GetMemoLine(cAliasField: BSTR; nLineNumber: I4): Variant; stdcall;
function Skip(cAlias: BSTR): Variant; stdcall;
function gotop: Variant; stdcall;
function Locate(cLocateString: BSTR): Variant; stdcall;
function gobott: Variant; stdcall;
function Reccount: Variant; stdcall;
function reclock: Variant; stdcall;
function recunlock: Variant; stdcall;
function setorder(cOrder: BSTR): Variant; stdcall;
function nextcust(nEnquiry: R8): Variant; stdcall;
function nextinv(nEnquiry: R8): Variant; stdcall;
function nextquote(nEnquiry: R8): Variant; stdcall;
function nextaudit(nEnquiry: R8): Variant; stdcall;
function nextlink(nEnquiry: R8): Variant; stdcall;
function nextpo(nEnquiry: R8): Variant; stdcall;
function nextsupp(nEnquiry: R8): Variant; stdcall;
function nextjob(nEnquiry: R8): Variant; stdcall;
function varreset: Variant; stdcall;
function setfilter(cFilter: BSTR): Variant; stdcall;
function Append: Variant; stdcall;
function Replace(cFieldName: BSTR; vReplaceValue: Variant): Variant; stdcall;
function replaceStr(cFieldName: BSTR; vReplaceValue: BSTR): Variant; stdcall;
function replaceNum(cFieldName: BSTR; vReplaceValue: R8): Variant; stdcall;
function replaceDate(cFieldName: BSTR; vReplaceValue: Date): Variant; stdcall;
function postjobtxn: Variant; stdcall;
function calcdisc: Variant; stdcall;
function calcqtyb: Variant; stdcall;
function OpenGLJnlFiles: Variant; stdcall;
function CloseGLJnlFiles: Variant; stdcall;
function PostGLTxn: Variant; stdcall;
function UpdateInvHeader(cParameterName: BSTR): Variant; stdcall;
function CreateInvoice: Variant; stdcall;
function totalinvoice: Variant; stdcall;
function InvoiceAddLine: Variant; stdcall;
function InvoiceAddLine2: Variant; stdcall;
function InvoiceDeleteLine(cAlias: BSTR): Variant; stdcall;
function CreateQuote: Variant; stdcall;
function TotalQuote: Variant; stdcall;
function QuoteAddLine: Variant; stdcall;
function QuoteDeleteLine(cAlias: BSTR): Variant; stdcall;
function CreateSupp(nAccount: R8): Variant; stdcall;
function UpdateSupplierSearchPlus(nAccount: R8): Variant; stdcall;
function CreateCust(nAccount: R8): Variant; stdcall;
function CreateJob(nCustomer: R8; cJobID: BSTR; cOpenedBy: BSTR; cJobType: BSTR): Variant; stdcall;
//Occurs when an object is released.
function Destroy: Variant; stdcall;
function calcprice: Variant; stdcall;
function calcrate: Variant; stdcall;
function calcdiscinv: Variant; stdcall;
function calcqtybinv: Variant; stdcall;
function GETDLLVERSION: Variant; stdcall;
function POSTGSTTXN: Variant; stdcall;
function POSTBANKRECTXN: Variant; stdcall;
function GETGSTTYPE: Variant; stdcall;
function POSTPRODTXN: Variant; stdcall;
function createJobOrder(lcJobNumber: BSTR; lnSupplierAccount: R8; lcPONumber: BSTR; lnLocation: I4; llOrdered: Bool; lcProdCode: BSTR; lnQty: R8; lnRate: R8): Variant; stdcall;
function Supp_UpdateInvHeader(cParameterName: BSTR): Variant; stdcall;
function Supp_CreateInvoice: Variant; stdcall;
function Supp_InvoiceAddLine: Variant; stdcall;
function Supp_TotalInvoice: Variant; stdcall;
function sendEmail(nEmailAudit: I4; cUserID: BSTR; cType: BSTR): Variant; stdcall;
function defenv: Variant; stdcall;
function customerPayment_StartTransaction(ldDate: BSTR; lnAccount: I4; lnPaymentMethodID: I4; lcBankGLID: BSTR; lcRefRef: BSTR; lcRefBank: BSTR; lcRefBranch: BSTR): Variant; stdcall;
function customerPayment_AddItem(lnAudit: I4; lnAmountPaid: R8; lnDiscountAmount: R8): Variant; stdcall;
function customerPayment_FinishTransaction: Variant; stdcall;
function safeopen: Variant; stdcall;
function safeclose: Variant; stdcall;
function getAuditFromCustInvNumber(lcInvNum: BSTR): Variant; stdcall;
function isEOF: Variant; stdcall;
function Scatter: Variant; stdcall;
function GetLoyaltyBalance(nAccount: R8): Variant; stdcall;
function PostLoyaltyTransaction(cDate: BSTR; nAccount: R8; cTrans: BSTR; cRef: BSTR; nAmountInclGST: R8; nGSTAmount: R8): Variant; stdcall;
function GetExpiringLoyaltyBalance(nAccount: R8): Variant; stdcall;
function GetPendingLoyaltyBalance(nAccount: R8): Variant; stdcall;
function GetLoyaltyTransactionList(nAccount: R8; cFDate: BSTR; cTDate: BSTR): Variant; stdcall;
function CreateProduct(cProductCode: BSTR; cProductDesc: BSTR): Variant; stdcall;
function AddProductImage(cProductCode: BSTR; cImageDisplayDescription: BSTR; cImageFileName: BSTR; lDefaultImage: Bool): Variant; stdcall;
function UpdateProductImage(cProductCode: BSTR; cImageDisplayDescription: BSTR; cImageFileName: BSTR; lDefaultImage: Bool): Variant; stdcall;
function RemoveProductImage(cProductCode: BSTR; cImageFileName: BSTR): Variant; stdcall;
function ClearCMLogParameters: Variant; stdcall;
function CreateCMLogEntry: Variant; stdcall;
function GetCMTypes(tcCMModule: BSTR): Variant; stdcall;
function GetCMGroups(tcCMModule: BSTR): Variant; stdcall;
function getCMFUTypes(tcCMModule: BSTR): Variant; stdcall;
function GetCMLogEntryList(tnFromAccount: I4; tnToAccount: I4; tcFromStaff: BSTR; tcToStaff: BSTR; tdFromDate: Date; tdToDate: Date; tcCMModule: BSTR): Variant; stdcall;
function GetCMLogEntryByID(tnID: I4): Variant; stdcall;
function UpdateCMLogEntryByID(tnID: I4; tcVarCode: BSTR): Variant; stdcall;
function DeleteCMLogEntry(tnID: I4): Variant; stdcall;
function CreatePurchaseOrder: Variant; stdcall;
function TotalPurchaseOrder: Variant; stdcall;
function PurchaseOrderAddLine: Variant; stdcall;
function setPDFpath(cPath: BSTR): Variant; stdcall;
function CreateCustInvoicePDF(tnInvLink: I4; tcInvFile: BSTR; tcFileWPath: BSTR): Variant; stdcall;
function CreateContact(tcType: BSTR): Variant; stdcall;
function UpdateContact(tnLink: I4; tcType: BSTR; tcField: BSTR): Variant; stdcall;
function DeleteContact(tnLink: I4; tcType: BSTR): Variant; stdcall;
function UpdatePOHeader(tcParameter: BSTR): Variant; stdcall;
function SuppInvPost: Variant; stdcall;
function CustomerBackOrder_Create: Variant; stdcall;
function CustomerBackOrder_Addline: Variant; stdcall;
function PMKR_ProcessOrders(nParameter: I4): Variant; stdcall;
function PMKR_DownloadOrders(nParameter: I4): Variant; stdcall;
function getSetting(nLine: I4; cKey: BSTR): Variant; stdcall;
function PMKR_importPO(nParameter: I4; cFile: BSTR): Variant; stdcall;
function PMKR_checkAvailableStock(nParameter: I4; tcCode: BSTR; tnLocation: I4; tnOrderQty: R8): Variant; stdcall;
function PMKR_startNotification(nParameter: I4): Variant; stdcall;
function PMKR_getNotificationLines(nParameter: I4): Variant; stdcall;
function PMKR_endNotification(nParameter: I4): Variant; stdcall;
function PMKR_sendNotification(nParameter: I4; tcEmailAddress: BSTR): Variant; stdcall;
function PMKR_UploadInvoices(nParameter: I4): Variant; stdcall;
function getProductsNextReceiptDueDateFromPurchaseOrder(cProductCode: BSTR): Variant; stdcall;
function OrderPurchaseOrder: Variant; stdcall;
//Occurs when there is a run-time error in a method.
function Error(out nError: I4; out cMethod: BSTR; out nLine: I4): Variant; stdcall;
//Contains the expression entered for a property value in the property sheet.
function ReadExpression(out cPropertyName: BSTR): Variant; stdcall;
//Returns the text of the specified method.
function ReadMethod(out cMethod: BSTR): Variant; stdcall;
//Resets the property/method to the inherited value.
function ResetToDefault(out cProperty: I4): Variant; stdcall;
//Saves an instance of an object as a class definition in a class library.
function SaveAsClass(out cClassLibName: BSTR; out cClassName: BSTR; out cDescription: BSTR): Variant; stdcall;
//Writes an expression to a property.
function WriteExpression(out cPropertyName: BSTR; out cExpression: BSTR): Variant; stdcall;
//Writes the specified text to the specified method.
function WriteMethod(out cMethodName: BSTR; out cMethodText: BSTR; out lCreateMethod: BSTR; out nVisibility: BSTR; out cDescription: BSTR): Variant; stdcall;
//Adds a new property to an object.
function AddProperty(out cPropertyName: BSTR; out vNewValue: Variant; out nVisibility: BSTR; out cDescription: BSTR): Variant; stdcall;
//Specifies the name of the Visual FoxPro base class on which the referenced object is based.
property-get BaseClass: BSTR; stdcall;
//Returns the name of the class that an object is based on.
property-get Class: BSTR; stdcall;
//Returns the name of the parent class on which the object is based.
property-get ParentClass: BSTR; stdcall;
//References the container object of a control.
property-get Parent: I4; stdcall;
//Stores information about an object.
property-get Comment: BSTR; stdcall;
//Stores information about an object.
property-put Comment(: BSTR); stdcall;
//Stores any extra data needed for your program.
property-get Tag: BSTR; stdcall;
//Stores any extra data needed for your program.
property-put Tag(: BSTR); stdcall;
//Specifies the height of an object on the screen.
property-get Height: I4; stdcall;
//Specifies the height of an object on the screen.
property-put Height(: I4); stdcall;
//Specifies the width of an object.
property-get Width: I4; stdcall;
//Specifies the width of an object.
property-put Width(: I4); stdcall;
//Adds an object to a container object at run time.
function AddObject(out cName: BSTR; out cClass: BSTR; out cOLEClass: BSTR; out aInit1: Variant): Variant; stdcall;
//Adds an object to a container object at run time.
function NewObject(out cName: BSTR; out cClass: BSTR; out cModule: BSTR; out cInApplication: BSTR; out cOLEClass: BSTR; out aInit1: Variant): Variant; stdcall;
//Removes a specified object from a Container object at run time.
function RemoveObject(out cObjectName: BSTR): Variant; stdcall;
//Specifies the graphics file or field to display on the control.
property-get Picture: BSTR; stdcall;
//Specifies the graphics file or field to display on the control.
property-put Pictur
e(: BSTR); stdcall;
//Specifies a context ID for a topic in a Help file to provide context-sensitive Help.
property-get HelpContextID: I4; stdcall;
//Specifies a context ID for a topic in a Help file to provide context-sensitive Help.
property-put HelpContextID(: I4); stdcall;
//Specifies a Help topic context ID to provide What's This help for an object.
property-get WhatsThisHelpID: I4; stdcall;
//Specifies a Help topic context ID to provide What's This help for an object.
property-put WhatsThisHelpID(: I4); stdcall;
//Displays the Help topic specified for an object with the WhatsThisHelpID property.
function ShowWhatsThis: Variant; stdcall;
//An array for accessing the controls in a container object.
property-get Controls: I4; stdcall;
//Specifies the number of controls in a container object.
property-get ControlCount: I4; stdcall;
//An array for accessing the objects in a container object.
property-get Objects: I4; stdcall;

//Infusion Business Software Gateway 831
CoClass Gateway;
GUID = {3604D6B9-4DE3-4E67-85F1-33A28FBD11A3};
```
