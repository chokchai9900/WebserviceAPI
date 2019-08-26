using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NSOWaterWebService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WebServiceController : ControllerBase
    {
        /// <summary>
        /// 1)
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsAgriculture()
        {
            var a = "a";
            return a;
        }

        /// <summary>
        /// 2) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsHouseHold()
        {
            var b = "";
            return b;
        }

        /// <summary>
        /// 3) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsHouseHoldGoodPlumbing()
        {
            var c = "";
            return c;
        }

        /// <summary>
        /// 4) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsAgricultureHasIrrigationField()
        {
            var d = "";
            return d;
        }

        /// <summary>
        /// 5) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsHouseHoldHasPlumbingDistrict()
        {
            var e = "";
            return e;
        }

        /// <summary>
        /// 6) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsHouseHoldHasPlumbingCountryside()
        {
            var f = "";
            return f;
        }

        /// <summary>
        /// 7) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsFactorialWaterQuality()
        {
            var g  = "";
            return g;
        }

        /// <summary>
        /// 8) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsCommercialWaterQuality()
        {
            var h = "";
            return h;
        }

        /// <summary>
        /// 9) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> CountGroundWater()
        {
            var i = "";
            return i;
        }

        /// <summary>
        /// 10) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> CountPopulation()
        {
            var j = "";
            return j;
        }

        /// <summary>
        /// 11) 
        /// /// </summary>
        [HttpGet]
        public ActionResult<string> CountWorkingPopulation()
        {
            var k = "";
            return k;
        }

        /// <summary>
        /// 12) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsFactorial()
        {
            var l = "";
            return l;
        }

        /// <summary>
        /// 13) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsFactorialWaterTreatment()
        {
            var m = "";
            return m;
        }

        /// <summary>
        /// 14) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsCommunityWaterManagementHasWaterTreatment()
        {
            var n = "";
            return n;
        }

        /// <summary>
        /// 15) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> FieldCommunity()
        {
            var o = "";
            return o;
        }

        /// <summary>
        /// 16) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> DisasterousInHouseHold()
        {
            var p = "";
            return p;
        }

        /// <summary>
        /// 17) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> TimeDisasterousInHouseHold()
        {
            var q = "";
            return q;
        }

        /// <summary>
        /// 18) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> HasntPlumbing()
        {
            var r = "";
            return r;
        }

        /// <summary>
        /// 19) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsGovernment()
        {
            var s = "";
            return s;
        }

        /// <summary>
        /// 20)
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsGovernmentUsage()
        {
            var t = "";
            return t;
        }

        /// <summary>
        /// 21)
        /// </summary>
        [HttpGet]
        public ActionResult<string> IsGovernmentWaterQuality()
        {
            var u = "";
            return u;
        }

        /// <summary>
        /// 22) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> CommunityNatureDisaster()
        {
            var v = "";
            return v;
        }

        /// <summary>
        /// 23) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> WaterSources()
        {
            var w = "";
            return w;
        }


        /// <summary>
        /// 24) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> IndustryHasWasteWaterTreatment()
        {
            var x = "";
            return x;
        }

        /// <summary>
        /// 25) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> PeopleInFloodedArea()
        {
            var y = "";
            return y;
        }

        /// <summary>
        /// 26)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterGroundWaterForAgriculture()
        {
            var z = "";
            return z;
        }

        /// <summary>
        /// 27) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterGroundWaterForService()
        {
            var aa = "";
            return aa;
        }

        /// <summary>
        /// 28)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterGroundWaterForProduct()
        {
            var ab = "";
            return ab;
        }


        /// <summary>
        /// 29) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterGroundWaterForDrink()
        {
            var ac = "";
            return ac;
        }


        /// <summary>
        /// 30)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterPlumbingForAgriculture()
        {
            var ad = "";
            return ad;
        }

        /// <summary>
        /// 31)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterPlumbingForService()
        {
            var ae = "";
            return ae;
        }


        /// <summary>
        /// 32) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterPlumbingForProduct()
        {
            var af = "";
            return af;
        }


        /// <summary>
        /// 33)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterPlumbingForDrink()
        {
            var ag = "";
            return ag;
        }

        /// <summary>
        /// 34)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterSurfaceForAgriculture()
        {
            var ah = "";
            return ah;
        }

        /// <summary>
        /// 35) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterSurfaceForService()
        {
            var ai = "";
            return ai;
        }

        /// <summary>
        /// 36) 
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterSurfaceForProduct()
        {
            var aj = "";
            return aj;
        }

        /// <summary>
        /// 37)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterSurfaceForDrink()
        {
            var ak = "";
            return ak;
        }


        /// <summary>
        /// 38)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CubicMeterGroundWaterForUse()
        {
            var al = "";
            return al;
        }

        /// <summary>
        /// 39)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CountCommunity()
        {
            var am = "";
            return am;
        }

        /// <summary>
        /// 40)
        /// </summary>
        [HttpGet]
        public ActionResult<string> CountCommunityHasDisaster()
        {
            var an = "";
           return an;
        }

        /// <summary>
        /// 41)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Counta()
        {
            var ao = "";
           return ao;
        }

        /// <summary>
        /// 42)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Countb()
        {
            var ap = "";
           return ap;
        }

        /// <summary>
        /// 43)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Countc()
        {
            var aq = "";
           return aq;
        }

        /// <summary>
        /// 44)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Countd()
        {
            var ar = "";
           return ar;
        }

        /// <summary>
        /// 45)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Countf()
        {
            var ass = "";
           return ass;
        }

        /// <summary>
        /// 46)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Countg()
        {
            var at = "";
           return at;
        }

        /// <summary>
        /// 47)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Counth()
        {
            var au = "";
           return au;
        }

        /// <summary>
        /// 48)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Counti()
        {
            var av = "";
           return av;
        }

        /// <summary>
        /// 49)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Countj()
        {
            var aw = "";
           return aw;
        }

        /// <summary>
        /// 50)
        /// </summary>
        [HttpGet]
        public ActionResult<string> Countk()
        {
            var ax = "";
           return ax;
        }


    }
}
