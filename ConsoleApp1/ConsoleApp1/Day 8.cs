using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day8
    {
        private string _input = "LRRLLRLLRRLRRLLRRLLRLRRRLLRRLRRRLRRLRRRLLRRLLRLLRRLRLRRRLRRLLRRRLRLRRLRRLRLRLRLLRLRRRLLRLLRRLRRRLRLRLRRRLRRLLRRRLRLRRLRRLLRRLRRRLRRLRRLRRLLRLRLRRLLRLLRRRLRRLRRLRRRLRLLRRRLRRRLRRLLRRRLRRRLRLLRLRRLRLLRRLLLRRLRRLRRLRLRRRLRRLLRLRRRLRRLRLLLRRLRRLRRRLLLRLLLLRRLRLLLRLRRRLRRRLRLRRRLLLLRLRRRLRLLLRRLRLRRLRRLRRRLRRRR\r\n\r\nLHF = (QTF, KKT)\r\nVRQ = (MDV, RCX)\r\nNDF = (CHQ, FJM)\r\nXXG = (NJP, GPX)\r\nGDG = (JCJ, BDD)\r\nPHF = (RMF, MHK)\r\nLQX = (NMG, RSJ)\r\nRPG = (VRH, BVV)\r\nGFT = (MJK, KKN)\r\nHHK = (GVN, XJH)\r\nCQF = (BRS, VCC)\r\nQJS = (XLL, VTX)\r\nXGL = (PKM, CND)\r\nCHZ = (JLQ, KPQ)\r\nFGP = (HNL, NBQ)\r\nLND = (SGB, DXR)\r\nTXQ = (RKL, LDV)\r\nJBC = (DRP, KFT)\r\nQSL = (KFS, LDC)\r\nSXJ = (JFQ, JFQ)\r\nTDN = (XDB, DSC)\r\nCFF = (BBB, BBB)\r\nHTS = (FHM, XLD)\r\nKCF = (RMN, XXG)\r\nMNG = (HCB, RMQ)\r\nBMX = (LVJ, MNF)\r\nNXC = (HKD, DDM)\r\nJCV = (KDL, KBR)\r\nSLM = (PGL, VCG)\r\nCDB = (GBQ, BQC)\r\nCJH = (TXM, QCK)\r\nRQH = (LDB, DRM)\r\nMMV = (XSP, FGD)\r\nDKM = (BXT, LXG)\r\nLLJ = (RXS, VRQ)\r\nBXN = (KFX, JCL)\r\nRNC = (XKR, RPG)\r\nBVV = (PFG, TFP)\r\nMXL = (KGT, KGT)\r\nHKV = (SMM, GFM)\r\nXTC = (BPV, RND)\r\nGBQ = (JPD, JQL)\r\nKTL = (BVL, BFH)\r\nXFF = (CJQ, DKH)\r\nKGH = (PSF, RVB)\r\nGBF = (HLR, HKV)\r\nDXK = (KGS, JFJ)\r\nJMJ = (FNB, XCC)\r\nKXD = (VXB, TRL)\r\nLJQ = (JBC, JRV)\r\nVFK = (HMK, KQB)\r\nDXM = (GBF, VDV)\r\nJTN = (TCS, HGP)\r\nRHH = (RXC, LGB)\r\nMXR = (PBC, XQN)\r\nGVK = (MSQ, SHN)\r\nRBX = (XTX, GNJ)\r\nMVX = (PFQ, DVH)\r\nVLK = (QBQ, DLN)\r\nSBQ = (MMQ, FTP)\r\nJMG = (MJV, MJV)\r\nBVB = (SJB, KBQ)\r\nLTF = (THJ, TVN)\r\nGGX = (PVB, TCP)\r\nXLS = (PGL, VCG)\r\nMMP = (LDB, DRM)\r\nNVD = (HKF, CKX)\r\nGDT = (TJT, KNK)\r\nGNJ = (HTS, KDH)\r\nMJK = (QJF, PQQ)\r\nXDL = (NXC, MTB)\r\nQDK = (HBD, NRK)\r\nCRQ = (NDF, HQQ)\r\nGBN = (GMC, QQB)\r\nFJM = (SVF, KQV)\r\nDTF = (XKR, RPG)\r\nCRG = (JNN, PKP)\r\nBKL = (GCL, CHZ)\r\nLDF = (CTN, VDH)\r\nMMQ = (MJC, MMV)\r\nTMR = (KQM, MNL)\r\nQXL = (XLS, SLM)\r\nPBC = (DVJ, XLX)\r\nXQZ = (TRL, VXB)\r\nKHG = (JPJ, TRX)\r\nDVH = (HMB, VJB)\r\nCBN = (CQF, VTK)\r\nQBC = (CVJ, PHF)\r\nXSV = (QTF, KKT)\r\nRDV = (RXQ, NHJ)\r\nDVT = (JPJ, TRX)\r\nVRX = (FPX, LTF)\r\nTLX = (FRC, XFH)\r\nHTK = (TXJ, KQH)\r\nKGT = (CFK, CFK)\r\nNBS = (VKK, HTQ)\r\nBBV = (FVQ, GPF)\r\nFNP = (MXQ, MHX)\r\nLQN = (BKB, GKN)\r\nFHJ = (TXM, QCK)\r\nPKL = (PFL, TKG)\r\nFXX = (NXL, HJB)\r\nQPG = (BLM, RRH)\r\nQTD = (VBR, HQT)\r\nVKK = (PMX, XDJ)\r\nBQH = (DDL, NXT)\r\nKBQ = (SHV, JGB)\r\nBND = (RGX, KQJ)\r\nDCL = (QXL, LRV)\r\nTCS = (FKJ, NQN)\r\nTCN = (BXH, QHS)\r\nHKD = (HPD, CTP)\r\nBKR = (GTT, GTT)\r\nGFV = (FLC, CVX)\r\nDFQ = (BXK, CDB)\r\nCNJ = (GCX, XXJ)\r\nCST = (PLK, GMF)\r\nBXA = (VXB, TRL)\r\nCND = (GFT, QMC)\r\nXDB = (XTC, JVF)\r\nHJN = (VMT, MCP)\r\nRSJ = (TCB, DCL)\r\nQHS = (SSN, QBF)\r\nJVV = (DXR, SGB)\r\nFHG = (FLK, CQB)\r\nHSR = (BDP, GCD)\r\nKTQ = (LXG, BXT)\r\nQVT = (QSQ, BQH)\r\nHPP = (XKQ, HSR)\r\nNHB = (BVH, CBN)\r\nPKG = (RCK, CHT)\r\nKKN = (QJF, PQQ)\r\nVCV = (JQQ, RSX)\r\nHXC = (RQH, MMP)\r\nMCP = (MMD, PFN)\r\nLQH = (PHK, JFB)\r\nPFF = (CLF, BLQ)\r\nQSQ = (NXT, DDL)\r\nNRJ = (HCB, RMQ)\r\nJQQ = (QJR, PMK)\r\nPHK = (PLP, LCQ)\r\nJDK = (GTM, SHR)\r\nJFJ = (VFK, HSM)\r\nTDD = (PBS, DBG)\r\nJHM = (TSR, BKL)\r\nRSX = (PMK, QJR)\r\nTJF = (BMX, VLS)\r\nHLR = (GFM, SMM)\r\nQRJ = (RBH, QPL)\r\nGGP = (TLQ, FJD)\r\nKNV = (KGX, MLN)\r\nXQN = (DVJ, XLX)\r\nVDV = (HKV, HLR)\r\nQTF = (TRR, NQS)\r\nVHL = (TDN, LHG)\r\nXHJ = (PLM, TVB)\r\nRJN = (XXJ, GCX)\r\nBTQ = (BFH, BVL)\r\nGDF = (GGP, RJD)\r\nMTB = (HKD, DDM)\r\nTPJ = (FHJ, CJH)\r\nTSR = (GCL, GCL)\r\nQPQ = (CQB, FLK)\r\nGVS = (GBC, SPX)\r\nMGF = (XPN, GGX)\r\nGTT = (GQX, GNQ)\r\nFFJ = (RLM, FTQ)\r\nBXH = (SSN, QBF)\r\nJQN = (CHT, RCK)\r\nJMH = (PNS, DGS)\r\nQTB = (SHM, LRP)\r\nNTJ = (SJN, BQB)\r\nGCD = (TDB, HPS)\r\nLSX = (XMQ, QTD)\r\nHJQ = (VGX, NBH)\r\nGFM = (LNT, CBD)\r\nPFN = (KGH, CSM)\r\nQCJ = (CVX, FLC)\r\nSHN = (CBG, XHJ)\r\nBSX = (CDQ, MBF)\r\nCXV = (MTB, NXC)\r\nSJB = (JGB, SHV)\r\nVRH = (TFP, PFG)\r\nHMB = (KTL, BTQ)\r\nDDM = (CTP, HPD)\r\nDCT = (HNJ, PMT)\r\nNXF = (NBX, XDC)\r\nBTF = (BVB, TBX)\r\nCQX = (KGX, MLN)\r\nMLN = (HRK, HKN)\r\nKBA = (XPQ, PSS)\r\nNXT = (PJH, VVM)\r\nRXQ = (DST, CRG)\r\nRDG = (BKB, GKN)\r\nLTR = (PPN, JTN)\r\nDXJ = (BKR, DBT)\r\nPLM = (DNJ, QTB)\r\nRGS = (VHL, HMF)\r\nSGS = (CQX, KNV)\r\nJRG = (NBQ, HNL)\r\nBKB = (FHN, XFF)\r\nRJD = (FJD, TLQ)\r\nFXG = (LCN, MHV)\r\nRMN = (GPX, NJP)\r\nVCG = (BDV, DNF)\r\nTXX = (BQH, QSQ)\r\nPHL = (XPN, GGX)\r\nXCC = (FGP, JRG)\r\nRXF = (XXR, NLS)\r\nBRS = (MGF, PHL)\r\nNLS = (LQH, JMR)\r\nGTM = (NJS, HCT)\r\nGDJ = (XCC, FNB)\r\nQBQ = (DQH, QJS)\r\nTRL = (MFK, TDM)\r\nFTP = (MMV, MJC)\r\nTXT = (NNC, NHR)\r\nSNN = (XJR, KMG)\r\nPMN = (KTQ, DKM)\r\nHQQ = (FJM, CHQ)\r\nLNT = (PBP, PMN)\r\nPGN = (XCR, NBR)\r\nNJS = (CNJ, RJN)\r\nBDM = (SGS, VMF)\r\nMJS = (LQX, RHT)\r\nNBL = (MXL, MXL)\r\nLCQ = (TFM, GVK)\r\nMLL = (CND, PKM)\r\nJKJ = (TBX, BVB)\r\nDGS = (QBC, GKJ)\r\nBFH = (CPX, GMD)\r\nJSX = (JBC, JRV)\r\nNKK = (RPV, SNG)\r\nBJN = (SXJ, RKH)\r\nDKH = (HLH, RBX)\r\nFJD = (FPL, LSP)\r\nJLQ = (TXQ, KKV)\r\nKNK = (GVS, LRX)\r\nRXC = (NMF, MKK)\r\nTGP = (QPG, VXM)\r\nCPX = (HFM, KCF)\r\nQCG = (XFH, FRC)\r\nLGB = (MKK, NMF)\r\nGMP = (QVT, TXX)\r\nRHM = (RCR, NGF)\r\nDNJ = (SHM, LRP)\r\nSXB = (XJJ, HGX)\r\nTVB = (QTB, DNJ)\r\nMHV = (MNG, NRJ)\r\nRPJ = (MSF, JRC)\r\nHQT = (TRD, KDG)\r\nTBP = (HCG, KMZ)\r\nBNK = (JCL, KFX)\r\nCDQ = (HHR, VCB)\r\nBLM = (CFF, SQK)\r\nFHP = (RGS, TLV)\r\nFNB = (FGP, JRG)\r\nGPF = (FTL, HJQ)\r\nDRF = (FTQ, RLM)\r\nGFL = (LND, JVV)\r\nHMK = (QCG, TLX)\r\nHSM = (HMK, KQB)\r\nXXR = (LQH, JMR)\r\nPKT = (NPS, QXV)\r\nBKJ = (KHC, KMJ)\r\nBVL = (GMD, CPX)\r\nMMR = (RJD, GGP)\r\nVXM = (BLM, RRH)\r\nJDM = (XKS, HPP)\r\nRKL = (PKG, JQN)\r\nGCL = (KPQ, JLQ)\r\nNHR = (FXX, GCH)\r\nSMR = (LTD, NVD)\r\nRKH = (JFQ, DXJ)\r\nSHR = (NJS, HCT)\r\nCVJ = (MHK, RMF)\r\nJRV = (DRP, KFT)\r\nPBS = (QDK, HNP)\r\nSGB = (QRN, MBP)\r\nFVD = (QTD, XMQ)\r\nTDP = (DHR, LGQ)\r\nCQB = (RHH, MLC)\r\nJRC = (NKK, QQM)\r\nRMF = (MHR, HHK)\r\nQXJ = (SML, TMR)\r\nHMF = (LHG, TDN)\r\nTVG = (DPN, MKT)\r\nRRL = (RCR, NGF)\r\nJLJ = (XKS, HPP)\r\nKKT = (NQS, TRR)\r\nKBM = (JMJ, GDJ)\r\nTCP = (QNK, LDF)\r\nXMQ = (VBR, HQT)\r\nMKT = (PDG, SMR)\r\nXGQ = (KDL, KBR)\r\nJFV = (FFB, TKX)\r\nNBX = (QSL, RFG)\r\nDPN = (PDG, SMR)\r\nLRP = (LDM, HXC)\r\nPSS = (RGM, VKL)\r\nKFX = (VRX, HDM)\r\nFRC = (TCN, XSK)\r\nRND = (JCQ, PNL)\r\nMLC = (RXC, LGB)\r\nPPN = (TCS, HGP)\r\nPVT = (SXJ, RKH)\r\nHDT = (MLL, XGL)\r\nKRV = (BVH, CBN)\r\nJGB = (GFV, QCJ)\r\nTKX = (KBM, FLS)\r\nLMP = (DBG, PBS)\r\nDDL = (VVM, PJH)\r\nRGX = (HBG, BPQ)\r\nMHX = (DFQ, VPN)\r\nNGT = (MJS, FGN)\r\nVVG = (LGQ, DHR)\r\nKDG = (SSD, MXR)\r\nZZZ = (GNQ, GQX)\r\nJPJ = (TVG, PPV)\r\nMBF = (HHR, VCB)\r\nFQL = (KGS, JFJ)\r\nGDK = (KGT, MLF)\r\nHLH = (GNJ, XTX)\r\nHNL = (JQD, LGK)\r\nMNL = (MLV, DBK)\r\nKHC = (BDM, SSB)\r\nJJL = (QTH, VHG)\r\nQDX = (RXS, VRQ)\r\nPMX = (DMK, FNP)\r\nVTA = (MJS, FGN)\r\nGNQ = (KJJ, CLM)\r\nMNC = (BLQ, CLF)\r\nHNJ = (KKS, VDQ)\r\nLVJ = (JCV, XGQ)\r\nJQD = (CDX, GVC)\r\nDLN = (QJS, DQH)\r\nKNN = (HDT, QKH)\r\nJJR = (JDM, JLJ)\r\nKDH = (FHM, XLD)\r\nNRK = (MXB, JJR)\r\nNXP = (DGS, PNS)\r\nDRP = (MXN, KLT)\r\nQTH = (GJX, CRQ)\r\nQXV = (JMH, NXP)\r\nRFG = (LDC, KFS)\r\nHJB = (JSX, LJQ)\r\nLSZ = (QPQ, FHG)\r\nCGJ = (RGX, KQJ)\r\nXCR = (FMQ, JHK)\r\nCJR = (XDL, CXV)\r\nNHJ = (CRG, DST)\r\nJVR = (PLK, GMF)\r\nJCJ = (JKP, JKP)\r\nVLS = (LVJ, MNF)\r\nTRX = (TVG, PPV)\r\nJNN = (NBL, BTM)\r\nKQH = (RHB, KTR)\r\nKQM = (DBK, MLV)\r\nSSN = (GMP, QPC)\r\nTFP = (XSV, LHF)\r\nSHM = (HXC, LDM)\r\nXJJ = (NTJ, FBG)\r\nQCK = (VDR, QXJ)\r\nPGL = (DNF, BDV)\r\nXFH = (XSK, TCN)\r\nVGJ = (SHR, GTM)\r\nVXB = (MFK, TDM)\r\nRQD = (VLS, BMX)\r\nRCX = (PVT, BJN)\r\nSJN = (FFJ, DRF)\r\nAAA = (GQX, GNQ)\r\nFPL = (FDS, VDF)\r\nVTK = (VCC, BRS)\r\nHGX = (FBG, NTJ)\r\nPLK = (HCN, NXF)\r\nFHN = (CJQ, DKH)\r\nVGX = (LPH, FHP)\r\nXSK = (BXH, QHS)\r\nBSV = (GPF, FVQ)\r\nQNG = (VHQ, VHQ)\r\nKQB = (TLX, QCG)\r\nPPV = (DPN, MKT)\r\nSML = (KQM, MNL)\r\nFKJ = (QQX, BGF)\r\nQKH = (MLL, XGL)\r\nJKP = (NMB, NMB)\r\nNQS = (GHQ, GSQ)\r\nGCH = (HJB, NXL)\r\nXSP = (CGJ, BND)\r\nHBD = (JJR, MXB)\r\nDPB = (BKJ, TNX)\r\nJMR = (JFB, PHK)\r\nKTR = (BBV, BSV)\r\nCDK = (XDL, CXV)\r\nHVG = (MNC, PFF)\r\nXPJ = (VHQ, TBP)\r\nGXL = (DDR, DCT)\r\nGHQ = (BNK, BXN)\r\nJQL = (LMP, TDD)\r\nVVM = (VCV, DFP)\r\nNPR = (VLK, JGS)\r\nPMT = (KKS, VDQ)\r\nGBR = (VHG, QTH)\r\nTRR = (GHQ, GSQ)\r\nXJR = (DXM, SCF)\r\nBGF = (TPJ, MKG)\r\nVDH = (SXB, HQK)\r\nGJX = (HQQ, NDF)\r\nCBD = (PBP, PMN)\r\nVMF = (CQX, KNV)\r\nHNP = (HBD, NRK)\r\nDSC = (XTC, JVF)\r\nHCB = (PKL, FGM)\r\nBTM = (MXL, GDK)\r\nDBT = (GTT, ZZZ)\r\nFGN = (RHT, LQX)\r\nFSP = (KXD, KXD)\r\nJFQ = (BKR, BKR)\r\nNJN = (RPJ, MLK)\r\nTVN = (HPV, MKX)\r\nXKS = (XKQ, HSR)\r\nPDG = (NVD, LTD)\r\nXLL = (CVT, GDG)\r\nGVN = (SNN, FQD)\r\nCDX = (VVG, TDP)\r\nTMS = (JMG, CQP)\r\nQNK = (VDH, CTN)\r\nMSQ = (XHJ, CBG)\r\nJHK = (HQV, NJN)\r\nMKX = (FVD, LSX)\r\nKQJ = (HBG, BPQ)\r\nNMF = (DNR, PKT)\r\nVCB = (KDB, RDV)\r\nMRM = (SHB, QPN)\r\nHVK = (HTQ, VKK)\r\nKMS = (HFV, GXL)\r\nMNF = (XGQ, JCV)\r\nHPV = (FVD, LSX)\r\nLXG = (GFL, CRT)\r\nTFM = (SHN, MSQ)\r\nPKM = (QMC, GFT)\r\nKFT = (KLT, MXN)\r\nRHT = (NMG, RSJ)\r\nHRK = (LPP, DGB)\r\nBXT = (GFL, CRT)\r\nXLX = (JVR, CST)\r\nGQX = (KJJ, CLM)\r\nTLQ = (FPL, LSP)\r\nLHG = (XDB, DSC)\r\nGKJ = (CVJ, PHF)\r\nCRT = (JVV, LND)\r\nKDN = (VLK, JGS)\r\nQNN = (PFQ, DVH)\r\nRXS = (MDV, RCX)\r\nJCQ = (JDK, VGJ)\r\nHTQ = (XDJ, PMX)\r\nCHQ = (SVF, KQV)\r\nKFS = (DRS, HGD)\r\nGQP = (SHB, QPN)\r\nMJV = (TSR, TSR)\r\nKPQ = (KKV, TXQ)\r\nRBH = (NHB, KRV)\r\nSNG = (GDT, BTV)\r\nCFK = (FHG, QPQ)\r\nRPV = (BTV, GDT)\r\nMMD = (CSM, KGH)\r\nPJH = (DFP, VCV)\r\nLGK = (CDX, GVC)\r\nDBK = (CJR, CDK)\r\nLCN = (MNG, NRJ)\r\nRVB = (GBR, JJL)\r\nTCB = (LRV, QXL)\r\nXTX = (HTS, KDH)\r\nVDN = (BKJ, TNX)\r\nCLF = (LQN, RDG)\r\nCJQ = (RBX, HLH)\r\nJPD = (LMP, TDD)\r\nMGV = (PPN, JTN)\r\nRSH = (TGP, LST)\r\nBPV = (PNL, JCQ)\r\nSRN = (NLS, XXR)\r\nFTQ = (FXG, DMP)\r\nFVQ = (FTL, HJQ)\r\nGBC = (KDN, NPR)\r\nVTX = (CVT, GDG)\r\nKGS = (VFK, HSM)\r\nMHK = (HHK, MHR)\r\nKLT = (QRJ, XCQ)\r\nLPP = (DXK, FQL)\r\nDNF = (KLS, TXT)\r\nHMA = (KPQ, JLQ)\r\nDVR = (HVK, NBS)\r\nNPS = (JMH, NXP)\r\nPVB = (LDF, QNK)\r\nDMK = (MHX, MXQ)\r\nCTP = (XNV, KMS)\r\nKGX = (HRK, HKN)\r\nRMQ = (FGM, PKL)\r\nQQX = (MKG, TPJ)\r\nDPD = (QSM, GXS)\r\nGXS = (FSD, KNN)\r\nRGM = (VDN, DPB)\r\nHPD = (KMS, XNV)\r\nHBG = (RXF, SRN)\r\nGKN = (FHN, XFF)\r\nPNS = (QBC, GKJ)\r\nFDS = (RQD, TJF)\r\nQPN = (BTF, JKJ)\r\nDQH = (VTX, XLL)\r\nXCQ = (RBH, QPL)\r\nTJT = (LRX, GVS)\r\nMVT = (NGT, KRZ)\r\nHKF = (JFV, JJN)\r\nXJH = (FQD, SNN)\r\nRCK = (RRL, RHM)\r\nMSF = (QQM, NKK)\r\nCLM = (SNM, FHB)\r\nVHG = (CRQ, GJX)\r\nQBF = (GMP, QPC)\r\nSVF = (DGD, TMS)\r\nNBH = (LPH, FHP)\r\nJCL = (HDM, VRX)\r\nVDR = (SML, TMR)\r\nSMM = (LNT, CBD)\r\nBPQ = (SRN, RXF)\r\nVTN = (FSP, DTG)\r\nPNL = (VGJ, JDK)\r\nBTV = (TJT, KNK)\r\nMLF = (CFK, LSZ)\r\nXKR = (BVV, VRH)\r\nBMJ = (HVK, NBS)\r\nPLP = (TFM, GVK)\r\nKDL = (XJL, THC)\r\nJVF = (BPV, RND)\r\nFLK = (RHH, MLC)\r\nDGB = (FQL, DXK)\r\nDBG = (QDK, HNP)\r\nLDC = (HGD, DRS)\r\nDGD = (JMG, CQP)\r\nLPH = (TLV, RGS)\r\nDTG = (KXD, XQZ)\r\nGVC = (TDP, VVG)\r\nTLV = (HMF, VHL)\r\nNMG = (TCB, DCL)\r\nXDC = (RFG, QSL)\r\nMFK = (LTR, MGV)\r\nSHB = (BTF, JKJ)\r\nTDM = (LTR, MGV)\r\nRCR = (THB, KBX)\r\nKDB = (RXQ, NHJ)\r\nPFG = (LHF, XSV)\r\nHDM = (FPX, LTF)\r\nSSB = (VMF, SGS)\r\nFHM = (GBN, VRK)\r\nSQK = (BBB, VTN)\r\nBVH = (VTK, CQF)\r\nTXM = (VDR, QXJ)\r\nTDB = (DVT, KHG)\r\nXXJ = (DPD, FXN)\r\nVKL = (DPB, VDN)\r\nNNC = (FXX, GCH)\r\nXLD = (VRK, GBN)\r\nFGM = (PFL, TKG)\r\nMJC = (FGD, XSP)\r\nHPS = (KHG, DVT)\r\nDHR = (QNN, MVX)\r\nVHQ = (HCG, HCG)\r\nMLV = (CJR, CDK)\r\nLTD = (CKX, HKF)\r\nQPL = (KRV, NHB)\r\nMDV = (PVT, BJN)\r\nMXB = (JLJ, JDM)\r\nKMZ = (PSS, XPQ)\r\nQPC = (QVT, TXX)\r\nBBB = (FSP, FSP)\r\nNQN = (QQX, BGF)\r\nVDQ = (MMR, GDF)\r\nHQK = (XJJ, HGX)\r\nVRK = (GMC, QQB)\r\nHCT = (CNJ, RJN)\r\nVDF = (TJF, RQD)\r\nXKQ = (GCD, BDP)\r\nXJL = (RSH, DSD)\r\nBLQ = (LQN, RDG)\r\nQRN = (DTF, RNC)\r\nKKS = (GDF, MMR)\r\nHKN = (DGB, LPP)\r\nSCF = (GBF, VDV)\r\nVPN = (BXK, CDB)\r\nBDV = (KLS, TXT)\r\nTBX = (SJB, KBQ)\r\nMLK = (JRC, MSF)\r\nVJB = (BTQ, KTL)\r\nXNV = (GXL, HFV)\r\nQQM = (SNG, RPV)\r\nVMT = (MMD, PFN)\r\nMXQ = (VPN, DFQ)\r\nTXJ = (KTR, RHB)\r\nLSP = (VDF, FDS)\r\nKKV = (LDV, RKL)\r\nKMG = (SCF, DXM)\r\nMBP = (DTF, RNC)\r\nTRD = (SSD, MXR)\r\nCTT = (DVR, BMJ)\r\nPMK = (MRM, GQP)\r\nNMB = (NGT, NGT)\r\nHQV = (MLK, RPJ)\r\nTHJ = (HPV, MKX)\r\nNXL = (JSX, LJQ)\r\nXPQ = (VKL, RGM)\r\nCTN = (SXB, HQK)\r\nDDR = (PMT, HNJ)\r\nBQB = (FFJ, DRF)\r\nSHV = (QCJ, GFV)\r\nKLS = (NNC, NHR)\r\nLST = (VXM, QPG)\r\nVCC = (PHL, MGF)\r\nFQD = (XJR, KMG)\r\nKJJ = (FHB, SNM)\r\nLDM = (RQH, MMP)\r\nGMD = (KCF, HFM)\r\nCKX = (JJN, JFV)\r\nNBQ = (JQD, LGK)\r\nQJR = (MRM, GQP)\r\nHRF = (TXJ, KQH)\r\nFLC = (HVG, QGM)\r\nDRS = (BSX, XQD)\r\nDRM = (QNG, XPJ)\r\nPFL = (PGN, XCF)\r\nMKG = (FHJ, CJH)\r\nNBR = (JHK, FMQ)\r\nPFQ = (HMB, VJB)\r\nCQP = (MJV, JHM)\r\nHHR = (KDB, RDV)\r\nTKG = (XCF, PGN)\r\nKMJ = (SSB, BDM)\r\nHGP = (NQN, FKJ)\r\nQSM = (KNN, FSD)\r\nQGM = (MNC, PFF)\r\nLNK = (NMB, MVT)\r\nDNR = (QXV, NPS)\r\nRRH = (CFF, SQK)\r\nVBR = (TRD, KDG)\r\nCHT = (RHM, RRL)\r\nHFV = (DDR, DCT)\r\nXQD = (MBF, CDQ)\r\nHGD = (BSX, XQD)\r\nFTL = (VGX, NBH)\r\nSSD = (XQN, PBC)\r\nFSD = (HDT, QKH)\r\nPSF = (JJL, GBR)\r\nCSM = (RVB, PSF)\r\nPQQ = (TRN, HJN)\r\nBXK = (BQC, GBQ)\r\nQJF = (HJN, TRN)\r\nNJP = (LLJ, QDX)\r\nDSD = (LST, TGP)\r\nBDD = (JKP, LNK)\r\nSPX = (NPR, KDN)\r\nPFP = (BMJ, DVR)\r\nKRZ = (FGN, MJS)\r\nLGQ = (QNN, MVX)\r\nDMP = (MHV, LCN)\r\nDVJ = (JVR, CST)\r\nCVX = (HVG, QGM)\r\nCVT = (JCJ, BDD)\r\nLRX = (SPX, GBC)\r\nTNX = (KMJ, KHC)\r\nDST = (JNN, PKP)\r\nJFB = (LCQ, PLP)\r\nGPX = (QDX, LLJ)\r\nCBG = (TVB, PLM)\r\nBDP = (HPS, TDB)\r\nJJN = (TKX, FFB)\r\nHCN = (XDC, NBX)\r\nXDJ = (FNP, DMK)\r\nLDV = (PKG, JQN)\r\nXCF = (XCR, NBR)\r\nMXN = (QRJ, XCQ)\r\nXPN = (PVB, TCP)\r\nMKK = (PKT, DNR)\r\nPBP = (DKM, KTQ)\r\nNGF = (KBX, THB)\r\nRLM = (DMP, FXG)\r\nFFB = (FLS, KBM)\r\nFLS = (JMJ, GDJ)\r\nQMC = (MJK, KKN)\r\nQQB = (LQQ, SBQ)\r\nHFM = (RMN, XXG)\r\nBQC = (JQL, JPD)\r\nGMF = (HCN, NXF)\r\nFMQ = (HQV, NJN)\r\nKBR = (THC, XJL)\r\nDXR = (QRN, MBP)\r\nFGD = (BND, CGJ)\r\nTHC = (RSH, DSD)\r\nLRV = (SLM, XLS)\r\nJGS = (QBQ, DLN)\r\nGMC = (LQQ, SBQ)\r\nLDB = (QNG, QNG)\r\nLQQ = (MMQ, FTP)\r\nGSQ = (BXN, BNK)\r\nMHR = (GVN, XJH)\r\nTHB = (HTK, HRF)\r\nSNM = (PFP, CTT)\r\nFBG = (BQB, SJN)\r\nKBX = (HRF, HTK)\r\nTRN = (MCP, VMT)\r\nKQV = (DGD, TMS)\r\nHCG = (XPQ, PSS)\r\nPKP = (NBL, BTM)\r\nFPX = (TVN, THJ)\r\nGCX = (DPD, FXN)\r\nFHB = (PFP, CTT)\r\nFXN = (QSM, GXS)\r\nDFP = (JQQ, RSX)\r\nHLA = (FHG, QPQ)\r\nRHB = (BBV, BSV)";

        private Dictionary<string, (string, string)> BuildMap(IEnumerable<string> lines)
        {
            var map = new Dictionary<string, (string, string)>();

            foreach (var line in lines.Skip(1))
            {
                var x = line.Split('=', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

                var key = x[0];

                var y = x[1].Replace("(", "").Replace(")", "").Split(new char[] { ',', }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                var left = y[0];
                var right = y[1];

                map.Add(key, (left, right));
            }
            return map;
        }

        internal void Part1()
        {
            var lines = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var output = 0;

            var instructions = lines.First();

            var map = BuildMap(lines);

            var currentNode = "AAA";

            while (currentNode != "ZZZ")
            {
                var instructionIndex = output % instructions.Length;
                var instruction = instructions[instructionIndex];

                var currentMap = map[currentNode];

                currentNode = instruction switch
                {
                    'L' => currentMap.Item1,
                    'R' => currentMap.Item2,
                    _ => throw new Exception()
                };

                output++;
            }

            Console.WriteLine(output);
        }

        internal async void Part2()
        {
            //_input = "LR\r\n\r\n11A = (11B, XXX)\r\n11B = (XXX, 11Z)\r\n11Z = (11B, XXX)\r\n22A = (22B, XXX)\r\n22B = (22C, 22C)\r\n22C = (22Z, 22Z)\r\n22Z = (22B, 22B)\r\nXXX = (XXX, XXX)";

            var lines = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            long output = 0;

            var instructions = lines.First();

            var map = BuildMap(lines)
                .Where(x => x.Value.Item2 != x.Value.Item2)
                .ToImmutableSortedDictionary(x => x.Key, x => x.Value);

            var currentNodes = map.Keys
                .Where(k => k.EndsWith('A'))
                .ToArray();

            var nodeCount = currentNodes.Count();
            var startTime = Stopwatch.GetTimestamp();
            while (!currentNodes.All(c => c.EndsWith('Z')))
            {
                var instructionIndex = output % instructions.Length;
                if(instructionIndex > instructions.Length || instructionIndex < 0)
                {
                    throw new Exception($"output: {output}, instructions: {instructions.Count()}, instructionIndex: {instructionIndex}");
                }
                var instruction = instructions[(int)instructionIndex];

                var currentResult = new ConcurrentDictionary<int, string>();

                //Parallel.For(0, nodeCount, i =>
                //{
                //    var currentNode = currentNodes[i];

                //    var currentMap = map[currentNode];

                //    currentNode = instruction switch
                //    {
                //        'L' => currentMap.Item1,
                //        'R' => currentMap.Item2,
                //        _ => throw new Exception()
                //    };

                //    currentResult[i] = currentNode;
                //});

                for (var i = 0; i < nodeCount; i++)
                {
                    var currentNode = currentNodes[i];

                    var currentMap = map[currentNode];

                    currentNode = instruction switch
                    {
                        'L' => currentMap.Item1,
                        'R' => currentMap.Item2,
                        _ => throw new Exception()
                    };

                    currentNodes[i] = currentNode;

                }
                output++;

                if(output % 100_000_000 == 0)
                {
                    Console.WriteLine($"{output} took {Stopwatch.GetElapsedTime(startTime)}");
                    startTime = Stopwatch.GetTimestamp();
                }

                var zs = currentNodes.Where(x => x.EndsWith('Z')).Count();
                if(zs > 3)
                {
                    Console.WriteLine($"After {output} iterations we have {zs} Zs: {string.Join(';', currentNodes)}");
                }
            }

            Console.WriteLine(output);
        }
    }
}
