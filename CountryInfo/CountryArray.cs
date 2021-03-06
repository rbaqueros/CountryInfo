﻿/*
 * Copyright (c) 2015 Rafael Baquero
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Baqsoft.CountryInfo.Resources.Strings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Baqsoft.CountryInfo
{
    public static class CountryArray
    {
        private static Country[] _countryArray = new Country[]
        {
            new Country("AD", CountryNames.AD, ResourceImage.GetEmbeddedBitmapResource("64AD.png")),
            new Country("AE", CountryNames.AE, ResourceImage.GetEmbeddedBitmapResource("64AE.png")),
            new Country("AF", CountryNames.AF, ResourceImage.GetEmbeddedBitmapResource("64AF.png")),
            new Country("AG", CountryNames.AG, ResourceImage.GetEmbeddedBitmapResource("64AG.png")),
            new Country("AI", CountryNames.AI, ResourceImage.GetEmbeddedBitmapResource("64AI.png")),
            new Country("AL", CountryNames.AL, ResourceImage.GetEmbeddedBitmapResource("64AL.png")),
            new Country("AM", CountryNames.AM, ResourceImage.GetEmbeddedBitmapResource("64AM.png")),
            new Country("AO", CountryNames.AO, ResourceImage.GetEmbeddedBitmapResource("64AO.png")),
            new Country("AQ", CountryNames.AQ, ResourceImage.GetEmbeddedBitmapResource("64AQ.png")),
            new Country("AR", CountryNames.AR, ResourceImage.GetEmbeddedBitmapResource("64AR.png")),
            new Country("AS", CountryNames.AS, ResourceImage.GetEmbeddedBitmapResource("64AS.png")),
            new Country("AT", CountryNames.AT, ResourceImage.GetEmbeddedBitmapResource("64AT.png")),
            new Country("AU", CountryNames.AU, ResourceImage.GetEmbeddedBitmapResource("64AU.png")),
            new Country("AW", CountryNames.AW, ResourceImage.GetEmbeddedBitmapResource("64AW.png")),
            new Country("AX", CountryNames.AX, ResourceImage.GetEmbeddedBitmapResource("64AX.png")),
            new Country("AZ", CountryNames.AZ, ResourceImage.GetEmbeddedBitmapResource("64AZ.png")),
            new Country("BA", CountryNames.BA, ResourceImage.GetEmbeddedBitmapResource("64BA.png")),
            new Country("BB", CountryNames.BB, ResourceImage.GetEmbeddedBitmapResource("64BB.png")),
            new Country("BD", CountryNames.BD, ResourceImage.GetEmbeddedBitmapResource("64BD.png")),
            new Country("BE", CountryNames.BE, ResourceImage.GetEmbeddedBitmapResource("64BE.png")),
            new Country("BF", CountryNames.BF, ResourceImage.GetEmbeddedBitmapResource("64BF.png")),
            new Country("BG", CountryNames.BG, ResourceImage.GetEmbeddedBitmapResource("64BG.png")),
            new Country("BH", CountryNames.BH, ResourceImage.GetEmbeddedBitmapResource("64BH.png")),
            new Country("BI", CountryNames.BI, ResourceImage.GetEmbeddedBitmapResource("64BI.png")),
            new Country("BJ", CountryNames.BJ, ResourceImage.GetEmbeddedBitmapResource("64BJ.png")),
            new Country("BL", CountryNames.BL, ResourceImage.GetEmbeddedBitmapResource("64BL.png")),
            new Country("BM", CountryNames.BM, ResourceImage.GetEmbeddedBitmapResource("64BM.png")),
            new Country("BN", CountryNames.BN, ResourceImage.GetEmbeddedBitmapResource("64BN.png")),
            new Country("BO", CountryNames.BO, ResourceImage.GetEmbeddedBitmapResource("64BO.png")),
            new Country("BQ", CountryNames.BQ, ResourceImage.GetEmbeddedBitmapResource("64BQ.png")),
            new Country("BR", CountryNames.BR, ResourceImage.GetEmbeddedBitmapResource("64BR.png")),
            new Country("BS", CountryNames.BS, ResourceImage.GetEmbeddedBitmapResource("64BS.png")),
            new Country("BT", CountryNames.BT, ResourceImage.GetEmbeddedBitmapResource("64BT.png")),
            new Country("BW", CountryNames.BW, ResourceImage.GetEmbeddedBitmapResource("64BW.png")),
            new Country("BY", CountryNames.BY, ResourceImage.GetEmbeddedBitmapResource("64BY.png")),
            new Country("BZ", CountryNames.BZ, ResourceImage.GetEmbeddedBitmapResource("64BZ.png")),
            new Country("CA", CountryNames.CA, ResourceImage.GetEmbeddedBitmapResource("64CA.png")),
            new Country("CC", CountryNames.CC, ResourceImage.GetEmbeddedBitmapResource("64CC.png")),
            new Country("CD", CountryNames.CD, ResourceImage.GetEmbeddedBitmapResource("64CD.png")),
            new Country("CF", CountryNames.CF, ResourceImage.GetEmbeddedBitmapResource("64CF.png")),
            new Country("CG", CountryNames.CG, ResourceImage.GetEmbeddedBitmapResource("64CG.png")),
            new Country("CH", CountryNames.CH, ResourceImage.GetEmbeddedBitmapResource("64CH.png")),
            new Country("CI", CountryNames.CI, ResourceImage.GetEmbeddedBitmapResource("64CI.png")),
            new Country("CK", CountryNames.CK, ResourceImage.GetEmbeddedBitmapResource("64CK.png")),
            new Country("CL", CountryNames.CL, ResourceImage.GetEmbeddedBitmapResource("64CL.png")),
            new Country("CM", CountryNames.CM, ResourceImage.GetEmbeddedBitmapResource("64CM.png")),
            new Country("CN", CountryNames.CN, ResourceImage.GetEmbeddedBitmapResource("64CN.png")),
            new Country("CO", CountryNames.CO, ResourceImage.GetEmbeddedBitmapResource("64CO.png")),
            new Country("CR", CountryNames.CR, ResourceImage.GetEmbeddedBitmapResource("64CR.png")),
            new Country("CU", CountryNames.CU, ResourceImage.GetEmbeddedBitmapResource("64CU.png")),
            new Country("CV", CountryNames.CV, ResourceImage.GetEmbeddedBitmapResource("64CV.png")),
            new Country("CW", CountryNames.CW, ResourceImage.GetEmbeddedBitmapResource("64CW.png")),
            new Country("CX", CountryNames.CX, ResourceImage.GetEmbeddedBitmapResource("64CX.png")),
            new Country("CY", CountryNames.CY, ResourceImage.GetEmbeddedBitmapResource("64CY.png")),
            new Country("CZ", CountryNames.CZ, ResourceImage.GetEmbeddedBitmapResource("64CZ.png")),
            new Country("DE", CountryNames.DE, ResourceImage.GetEmbeddedBitmapResource("64DE.png")),
            new Country("DJ", CountryNames.DJ, ResourceImage.GetEmbeddedBitmapResource("64DJ.png")),
            new Country("DK", CountryNames.DK, ResourceImage.GetEmbeddedBitmapResource("64DK.png")),
            new Country("DM", CountryNames.DM, ResourceImage.GetEmbeddedBitmapResource("64DM.png")),
            new Country("DO", CountryNames.DO, ResourceImage.GetEmbeddedBitmapResource("64DO.png")),
            new Country("DZ", CountryNames.DZ, ResourceImage.GetEmbeddedBitmapResource("64DZ.png")),
            new Country("EC", CountryNames.EC, ResourceImage.GetEmbeddedBitmapResource("64EC.png")),
            new Country("EE", CountryNames.EE, ResourceImage.GetEmbeddedBitmapResource("64EE.png")),
            new Country("EG", CountryNames.EG, ResourceImage.GetEmbeddedBitmapResource("64EG.png")),
            new Country("EH", CountryNames.EH, ResourceImage.GetEmbeddedBitmapResource("64EH.png")),
            new Country("ER", CountryNames.ER, ResourceImage.GetEmbeddedBitmapResource("64ER.png")),
            new Country("ES", CountryNames.ES, ResourceImage.GetEmbeddedBitmapResource("64ES.png")),
            new Country("ET", CountryNames.ET, ResourceImage.GetEmbeddedBitmapResource("64ET.png")),
            new Country("FI", CountryNames.FI, ResourceImage.GetEmbeddedBitmapResource("64FI.png")),
            new Country("FJ", CountryNames.FJ, ResourceImage.GetEmbeddedBitmapResource("64FJ.png")),
            new Country("FK", CountryNames.FK, ResourceImage.GetEmbeddedBitmapResource("64FK.png")),
            new Country("FM", CountryNames.FM, ResourceImage.GetEmbeddedBitmapResource("64FM.png")),
            new Country("FO", CountryNames.FO, ResourceImage.GetEmbeddedBitmapResource("64FO.png")),
            new Country("FR", CountryNames.FR, ResourceImage.GetEmbeddedBitmapResource("64FR.png")),
            new Country("GA", CountryNames.GA, ResourceImage.GetEmbeddedBitmapResource("64GA.png")),
            new Country("GB", CountryNames.GB, ResourceImage.GetEmbeddedBitmapResource("64GB.png")),
            new Country("GD", CountryNames.GD, ResourceImage.GetEmbeddedBitmapResource("64GD.png")),
            new Country("GE", CountryNames.GE, ResourceImage.GetEmbeddedBitmapResource("64GE.png")),
            new Country("GG", CountryNames.GG, ResourceImage.GetEmbeddedBitmapResource("64GG.png")),
            new Country("GH", CountryNames.GH, ResourceImage.GetEmbeddedBitmapResource("64GH.png")),
            new Country("GI", CountryNames.GI, ResourceImage.GetEmbeddedBitmapResource("64GI.png")),
            new Country("GL", CountryNames.GL, ResourceImage.GetEmbeddedBitmapResource("64GL.png")),
            new Country("GM", CountryNames.GM, ResourceImage.GetEmbeddedBitmapResource("64GM.png")),
            new Country("GN", CountryNames.GN, ResourceImage.GetEmbeddedBitmapResource("64GN.png")),
            new Country("GQ", CountryNames.GQ, ResourceImage.GetEmbeddedBitmapResource("64GQ.png")),
            new Country("GR", CountryNames.GR, ResourceImage.GetEmbeddedBitmapResource("64GR.png")),
            new Country("GS", CountryNames.GS, ResourceImage.GetEmbeddedBitmapResource("64GS.png")),
            new Country("GT", CountryNames.GT, ResourceImage.GetEmbeddedBitmapResource("64GT.png")),
            new Country("GU", CountryNames.GU, ResourceImage.GetEmbeddedBitmapResource("64GU.png")),
            new Country("GW", CountryNames.GW, ResourceImage.GetEmbeddedBitmapResource("64GW.png")),
            new Country("GY", CountryNames.GY, ResourceImage.GetEmbeddedBitmapResource("64GY.png")),
            new Country("HK", CountryNames.HK, ResourceImage.GetEmbeddedBitmapResource("64HK.png")),
            new Country("HN", CountryNames.HN, ResourceImage.GetEmbeddedBitmapResource("64HN.png")),
            new Country("HR", CountryNames.HR, ResourceImage.GetEmbeddedBitmapResource("64HR.png")),
            new Country("HT", CountryNames.HT, ResourceImage.GetEmbeddedBitmapResource("64HT.png")),
            new Country("HU", CountryNames.HU, ResourceImage.GetEmbeddedBitmapResource("64HU.png")),
            new Country("ID", CountryNames.ID, ResourceImage.GetEmbeddedBitmapResource("64ID.png")),
            new Country("IE", CountryNames.IE, ResourceImage.GetEmbeddedBitmapResource("64IE.png")),
            new Country("IL", CountryNames.IL, ResourceImage.GetEmbeddedBitmapResource("64IL.png")),
            new Country("IM", CountryNames.IM, ResourceImage.GetEmbeddedBitmapResource("64IM.png")),
            new Country("IN", CountryNames.IN, ResourceImage.GetEmbeddedBitmapResource("64IN.png")),
            new Country("IQ", CountryNames.IQ, ResourceImage.GetEmbeddedBitmapResource("64IQ.png")),
            new Country("IR", CountryNames.IR, ResourceImage.GetEmbeddedBitmapResource("64IR.png")),
            new Country("IS", CountryNames.IS, ResourceImage.GetEmbeddedBitmapResource("64IS.png")),
            new Country("IT", CountryNames.IT, ResourceImage.GetEmbeddedBitmapResource("64IT.png")),
            new Country("JE", CountryNames.JE, ResourceImage.GetEmbeddedBitmapResource("64JE.png")),
            new Country("JM", CountryNames.JM, ResourceImage.GetEmbeddedBitmapResource("64JM.png")),
            new Country("JO", CountryNames.JO, ResourceImage.GetEmbeddedBitmapResource("64JO.png")),
            new Country("JP", CountryNames.JP, ResourceImage.GetEmbeddedBitmapResource("64JP.png")),
            new Country("KE", CountryNames.KE, ResourceImage.GetEmbeddedBitmapResource("64KE.png")),
            new Country("KG", CountryNames.KG, ResourceImage.GetEmbeddedBitmapResource("64KG.png")),
            new Country("KH", CountryNames.KH, ResourceImage.GetEmbeddedBitmapResource("64KH.png")),
            new Country("KI", CountryNames.KI, ResourceImage.GetEmbeddedBitmapResource("64KI.png")),
            new Country("KM", CountryNames.KM, ResourceImage.GetEmbeddedBitmapResource("64KM.png")),
            new Country("KN", CountryNames.KN, ResourceImage.GetEmbeddedBitmapResource("64KN.png")),
            new Country("KP", CountryNames.KP, ResourceImage.GetEmbeddedBitmapResource("64KP.png")),
            new Country("KR", CountryNames.KR, ResourceImage.GetEmbeddedBitmapResource("64KR.png")),
            new Country("KW", CountryNames.KW, ResourceImage.GetEmbeddedBitmapResource("64KW.png")),
            new Country("KY", CountryNames.KY, ResourceImage.GetEmbeddedBitmapResource("64KY.png")),
            new Country("KZ", CountryNames.KZ, ResourceImage.GetEmbeddedBitmapResource("64KZ.png")),
            new Country("LA", CountryNames.LA, ResourceImage.GetEmbeddedBitmapResource("64LA.png")),
            new Country("LB", CountryNames.LB, ResourceImage.GetEmbeddedBitmapResource("64LB.png")),
            new Country("LC", CountryNames.LC, ResourceImage.GetEmbeddedBitmapResource("64LC.png")),
            new Country("LI", CountryNames.LI, ResourceImage.GetEmbeddedBitmapResource("64LI.png")),
            new Country("LK", CountryNames.LK, ResourceImage.GetEmbeddedBitmapResource("64LK.png")),
            new Country("LR", CountryNames.LR, ResourceImage.GetEmbeddedBitmapResource("64LR.png")),
            new Country("LS", CountryNames.LS, ResourceImage.GetEmbeddedBitmapResource("64LS.png")),
            new Country("LT", CountryNames.LT, ResourceImage.GetEmbeddedBitmapResource("64LT.png")),
            new Country("LU", CountryNames.LU, ResourceImage.GetEmbeddedBitmapResource("64LU.png")),
            new Country("LV", CountryNames.LV, ResourceImage.GetEmbeddedBitmapResource("64LV.png")),
            new Country("LY", CountryNames.LY, ResourceImage.GetEmbeddedBitmapResource("64LY.png")),
            new Country("MA", CountryNames.MA, ResourceImage.GetEmbeddedBitmapResource("64MA.png")),
            new Country("MC", CountryNames.MC, ResourceImage.GetEmbeddedBitmapResource("64MC.png")),
            new Country("MD", CountryNames.MD, ResourceImage.GetEmbeddedBitmapResource("64MD.png")),
            new Country("ME", CountryNames.ME, ResourceImage.GetEmbeddedBitmapResource("64ME.png")),
            new Country("MF", CountryNames.MF, ResourceImage.GetEmbeddedBitmapResource("64MF.png")),
            new Country("MG", CountryNames.MG, ResourceImage.GetEmbeddedBitmapResource("64MG.png")),
            new Country("MH", CountryNames.MH, ResourceImage.GetEmbeddedBitmapResource("64MH.png")),
            new Country("MK", CountryNames.MK, ResourceImage.GetEmbeddedBitmapResource("64MK.png")),
            new Country("ML", CountryNames.ML, ResourceImage.GetEmbeddedBitmapResource("64ML.png")),
            new Country("MM", CountryNames.MM, ResourceImage.GetEmbeddedBitmapResource("64MM.png")),
            new Country("MN", CountryNames.MN, ResourceImage.GetEmbeddedBitmapResource("64MN.png")),
            new Country("MO", CountryNames.MO, ResourceImage.GetEmbeddedBitmapResource("64MO.png")),
            new Country("MP", CountryNames.MP, ResourceImage.GetEmbeddedBitmapResource("64MP.png")),
            new Country("MQ", CountryNames.MQ, ResourceImage.GetEmbeddedBitmapResource("64MQ.png")),
            new Country("MR", CountryNames.MR, ResourceImage.GetEmbeddedBitmapResource("64MR.png")),
            new Country("MS", CountryNames.MS, ResourceImage.GetEmbeddedBitmapResource("64MS.png")),
            new Country("MT", CountryNames.MT, ResourceImage.GetEmbeddedBitmapResource("64MT.png")),
            new Country("MU", CountryNames.MU, ResourceImage.GetEmbeddedBitmapResource("64MU.png")),
            new Country("MV", CountryNames.MV, ResourceImage.GetEmbeddedBitmapResource("64MV.png")),
            new Country("MW", CountryNames.MW, ResourceImage.GetEmbeddedBitmapResource("64MW.png")),
            new Country("MX", CountryNames.MX, ResourceImage.GetEmbeddedBitmapResource("64MX.png")),
            new Country("MY", CountryNames.MY, ResourceImage.GetEmbeddedBitmapResource("64MY.png")),
            new Country("MZ", CountryNames.MZ, ResourceImage.GetEmbeddedBitmapResource("64MZ.png")),
            new Country("NA", CountryNames.NA, ResourceImage.GetEmbeddedBitmapResource("64NA.png")),
            new Country("NC", CountryNames.NC, ResourceImage.GetEmbeddedBitmapResource("64NC.png")),
            new Country("NE", CountryNames.NE, ResourceImage.GetEmbeddedBitmapResource("64NE.png")),
            new Country("NF", CountryNames.NF, ResourceImage.GetEmbeddedBitmapResource("64NF.png")),
            new Country("NG", CountryNames.NG, ResourceImage.GetEmbeddedBitmapResource("64NG.png")),
            new Country("NI", CountryNames.NI, ResourceImage.GetEmbeddedBitmapResource("64NI.png")),
            new Country("NL", CountryNames.NL, ResourceImage.GetEmbeddedBitmapResource("64NL.png")),
            new Country("NO", CountryNames.NO, ResourceImage.GetEmbeddedBitmapResource("64NO.png")),
            new Country("NP", CountryNames.NP, ResourceImage.GetEmbeddedBitmapResource("64NP.png")),
            new Country("NR", CountryNames.NR, ResourceImage.GetEmbeddedBitmapResource("64NR.png")),
            new Country("NU", CountryNames.NU, ResourceImage.GetEmbeddedBitmapResource("64NU.png")),
            new Country("NZ", CountryNames.NZ, ResourceImage.GetEmbeddedBitmapResource("64NZ.png")),
            new Country("OM", CountryNames.OM, ResourceImage.GetEmbeddedBitmapResource("64OM.png")),
            new Country("PA", CountryNames.PA, ResourceImage.GetEmbeddedBitmapResource("64PA.png")),
            new Country("PE", CountryNames.PE, ResourceImage.GetEmbeddedBitmapResource("64PE.png")),
            new Country("PF", CountryNames.PF, ResourceImage.GetEmbeddedBitmapResource("64PF.png")),
            new Country("PG", CountryNames.PG, ResourceImage.GetEmbeddedBitmapResource("64PG.png")),
            new Country("PH", CountryNames.PH, ResourceImage.GetEmbeddedBitmapResource("64PH.png")),
            new Country("PK", CountryNames.PK, ResourceImage.GetEmbeddedBitmapResource("64PK.png")),
            new Country("PL", CountryNames.PL, ResourceImage.GetEmbeddedBitmapResource("64PL.png")),
            new Country("PN", CountryNames.PN, ResourceImage.GetEmbeddedBitmapResource("64PN.png")),
            new Country("PR", CountryNames.PR, ResourceImage.GetEmbeddedBitmapResource("64PR.png")),
            new Country("PS", CountryNames.PS, ResourceImage.GetEmbeddedBitmapResource("64PS.png")),
            new Country("PT", CountryNames.PT, ResourceImage.GetEmbeddedBitmapResource("64PT.png")),
            new Country("PW", CountryNames.PW, ResourceImage.GetEmbeddedBitmapResource("64PW.png")),
            new Country("PY", CountryNames.PY, ResourceImage.GetEmbeddedBitmapResource("64PY.png")),
            new Country("QA", CountryNames.QA, ResourceImage.GetEmbeddedBitmapResource("64QA.png")),
            new Country("RO", CountryNames.RO, ResourceImage.GetEmbeddedBitmapResource("64RO.png")),
            new Country("RS", CountryNames.RS, ResourceImage.GetEmbeddedBitmapResource("64RS.png")),
            new Country("RU", CountryNames.RU, ResourceImage.GetEmbeddedBitmapResource("64RU.png")),
            new Country("RW", CountryNames.RW, ResourceImage.GetEmbeddedBitmapResource("64RW.png")),
            new Country("SA", CountryNames.SA, ResourceImage.GetEmbeddedBitmapResource("64SA.png")),
            new Country("SB", CountryNames.SB, ResourceImage.GetEmbeddedBitmapResource("64SB.png")),
            new Country("SC", CountryNames.SC, ResourceImage.GetEmbeddedBitmapResource("64SC.png")),
            new Country("SD", CountryNames.SD, ResourceImage.GetEmbeddedBitmapResource("64SD.png")),
            new Country("SE", CountryNames.SE, ResourceImage.GetEmbeddedBitmapResource("64SE.png")),
            new Country("SG", CountryNames.SG, ResourceImage.GetEmbeddedBitmapResource("64SG.png")),
            new Country("SH", CountryNames.SH, ResourceImage.GetEmbeddedBitmapResource("64SH.png")),
            new Country("SI", CountryNames.SI, ResourceImage.GetEmbeddedBitmapResource("64SI.png")),
            new Country("SK", CountryNames.SK, ResourceImage.GetEmbeddedBitmapResource("64SK.png")),
            new Country("SL", CountryNames.SL, ResourceImage.GetEmbeddedBitmapResource("64SL.png")),
            new Country("SM", CountryNames.SM, ResourceImage.GetEmbeddedBitmapResource("64SM.png")),
            new Country("SN", CountryNames.SN, ResourceImage.GetEmbeddedBitmapResource("64SN.png")),
            new Country("SO", CountryNames.SO, ResourceImage.GetEmbeddedBitmapResource("64SO.png")),
            new Country("SR", CountryNames.SR, ResourceImage.GetEmbeddedBitmapResource("64SR.png")),
            new Country("SS", CountryNames.SS, ResourceImage.GetEmbeddedBitmapResource("64SS.png")),
            new Country("ST", CountryNames.ST, ResourceImage.GetEmbeddedBitmapResource("64ST.png")),
            new Country("SV", CountryNames.SV, ResourceImage.GetEmbeddedBitmapResource("64SV.png")),
            new Country("SY", CountryNames.SY, ResourceImage.GetEmbeddedBitmapResource("64SY.png")),
            new Country("SZ", CountryNames.SZ, ResourceImage.GetEmbeddedBitmapResource("64SZ.png")),
            new Country("TC", CountryNames.TC, ResourceImage.GetEmbeddedBitmapResource("64TC.png")),
            new Country("TD", CountryNames.TD, ResourceImage.GetEmbeddedBitmapResource("64TD.png")),
            new Country("TF", CountryNames.TF, ResourceImage.GetEmbeddedBitmapResource("64TF.png")),
            new Country("TG", CountryNames.TG, ResourceImage.GetEmbeddedBitmapResource("64TG.png")),
            new Country("TH", CountryNames.TH, ResourceImage.GetEmbeddedBitmapResource("64TH.png")),
            new Country("TJ", CountryNames.TJ, ResourceImage.GetEmbeddedBitmapResource("64TJ.png")),
            new Country("TK", CountryNames.TK, ResourceImage.GetEmbeddedBitmapResource("64TK.png")),
            new Country("TL", CountryNames.TL, ResourceImage.GetEmbeddedBitmapResource("64TL.png")),
            new Country("TM", CountryNames.TM, ResourceImage.GetEmbeddedBitmapResource("64TM.png")),
            new Country("TN", CountryNames.TN, ResourceImage.GetEmbeddedBitmapResource("64TN.png")),
            new Country("TO", CountryNames.TO, ResourceImage.GetEmbeddedBitmapResource("64TO.png")),
            new Country("TR", CountryNames.TR, ResourceImage.GetEmbeddedBitmapResource("64TR.png")),
            new Country("TT", CountryNames.TT, ResourceImage.GetEmbeddedBitmapResource("64TT.png")),
            new Country("TV", CountryNames.TV, ResourceImage.GetEmbeddedBitmapResource("64TV.png")),
            new Country("TW", CountryNames.TW, ResourceImage.GetEmbeddedBitmapResource("64TW.png")),
            new Country("TZ", CountryNames.TZ, ResourceImage.GetEmbeddedBitmapResource("64TZ.png")),
            new Country("UA", CountryNames.UA, ResourceImage.GetEmbeddedBitmapResource("64UA.png")),
            new Country("UG", CountryNames.UG, ResourceImage.GetEmbeddedBitmapResource("64UG.png")),
            new Country("US", CountryNames.US, ResourceImage.GetEmbeddedBitmapResource("64US.png")),
            new Country("UY", CountryNames.UY, ResourceImage.GetEmbeddedBitmapResource("64UY.png")),
            new Country("UZ", CountryNames.UZ, ResourceImage.GetEmbeddedBitmapResource("64UZ.png")),
            new Country("VA", CountryNames.VA, ResourceImage.GetEmbeddedBitmapResource("64VA.png")),
            new Country("VC", CountryNames.VC, ResourceImage.GetEmbeddedBitmapResource("64VC.png")),
            new Country("VE", CountryNames.VE, ResourceImage.GetEmbeddedBitmapResource("64VE.png")),
            new Country("VG", CountryNames.VG, ResourceImage.GetEmbeddedBitmapResource("64VG.png")),
            new Country("VI", CountryNames.VI, ResourceImage.GetEmbeddedBitmapResource("64VI.png")),
            new Country("VN", CountryNames.VN, ResourceImage.GetEmbeddedBitmapResource("64VN.png")),
            new Country("VU", CountryNames.VU, ResourceImage.GetEmbeddedBitmapResource("64VU.png")),
            new Country("WF", CountryNames.WF, ResourceImage.GetEmbeddedBitmapResource("64WF.png")),
            new Country("WS", CountryNames.WS, ResourceImage.GetEmbeddedBitmapResource("64WS.png")),
            new Country("YE", CountryNames.YE, ResourceImage.GetEmbeddedBitmapResource("64YE.png")),
            new Country("YT", CountryNames.YT, ResourceImage.GetEmbeddedBitmapResource("64YT.png")),
            new Country("ZA", CountryNames.ZA, ResourceImage.GetEmbeddedBitmapResource("64ZA.png")),
            new Country("ZM", CountryNames.ZM, ResourceImage.GetEmbeddedBitmapResource("64ZM.png")),
            new Country("ZW", CountryNames.ZW, ResourceImage.GetEmbeddedBitmapResource("64ZW.png"))
        };

        public static int Length
        {
            get { return _countryArray.Length; }
        }

        public static Country GetCountry(int position)
        {
            return new Country(_countryArray[position]);
        }

        public static Country GetCountry(string iso2)
        {
            foreach (Country country in _countryArray)
            {
                if(country.Iso2 == iso2)
                {
                    return new Country(country);
                }
            }

            return null;
        }

        public static int GetPosition(string iso2)
        {
            for (int count = 0; count < _countryArray.Length; count++)
            {
                if (_countryArray[count].Iso2 == iso2)
                {
                    return count;
                }
            }

            return -1;
        }
    }
}
