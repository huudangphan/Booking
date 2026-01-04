using Modetour.B2C.Commons.Model;
using Modetour.B2C.Entity.Package;
using Modetour.B2C.Entity.Package.Package;
using ModetourB2C.Dac.Model.MODEWARE3;
using Newtonsoft.Json;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;
using System.Collections;

namespace Modetour.B2C.Commons
{
    public class Functions
    {
        public static DateTime ParseDateTimes(object obj, string format = "")
        {
            try
            {
                if (!string.IsNullOrEmpty(format))
                {
                    return DateTime.ParseExact(obj.ToString(), format, CultureInfo.InvariantCulture);
                }
                DateTime result;
                if (obj == null) return DateTime.Now.Date;
                if (DateTime.TryParse(obj.ToString(), out result))
                    return result;
                return DateTime.Now.Date;
            }
            catch (Exception)
            {
                return DateTime.Now.Date;
            }
        }

        /// <summary>
        /// hàm parse object to string
        /// exception return ""
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToString(object obj)
        {
            try
            {
                if (obj == null) return string.Empty;
                return obj.ToString().Trim();
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// parse object to int
        /// exception return 0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ParseInt(object obj)
        {
            try
            {
                int result;
                if (obj == null) return 0;
                if (int.TryParse(obj.ToString(), out result))
                    return result;
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static double ParseDouble(object obj)
        {
            try
            {
                double result;
                if (obj == null) return 0;
                if (double.TryParse(obj.ToString(), out result))
                {
                    if (!Double.IsInfinity(result) && !Double.IsNaN(result))
                    {
                        return result;
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static double ParseDouble(object obj, NumberFormatInfo provider)
        {
            try
            {
                double result;
                if (obj == null) return 0;
                if (double.TryParse(obj.ToString(), NumberStyles.Any, provider, out result))
                    if (!Double.IsInfinity(result) && !Double.IsNaN(result))
                    {
                        return result;
                    }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static float ParseFloat(object obj)
        {
            try
            {
                float result;
                if (obj == null) return 0;
                if (float.TryParse(obj.ToString(), out result))
                    return result;
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static decimal ParseDecimal(object obj)
        {
            try
            {
                decimal result;
                if (obj == null) return 0;
                var value = obj.ToString();
                if (decimal.TryParse(value, out result))
                    return result;
                if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
                    return result;
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// hàm parrse object to datetime
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime? ParseDateTime(object obj, string format = "")
        {
            try
            {
                if (obj == null) return null;
                if (!string.IsNullOrEmpty(format))
                {
                    return DateTime.ParseExact(obj.ToString(), format, CultureInfo.InvariantCulture);
                }
                DateTime result;
                if (DateTime.TryParse(obj.ToString(), out result))
                    return result;
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static int GetMaxDataLength()
        {
            if (Constants.RSA.fOAEP)
                return ((Constants.RSA.KEY_SIZE - 384) / 8) + 7;
            return ((Constants.RSA.KEY_SIZE - 384) / 8) + 37;
        }

        private static bool IsKeySizeValid()
        {
            return Constants.RSA.KEY_SIZE >= 384 &&
                   Constants.RSA.KEY_SIZE <= 16384 &&
                   Constants.RSA.KEY_SIZE % 8 == 0;
        }

        public static string Encrypt(string plainText, string publickey = "")
        {
            if (string.IsNullOrEmpty(publickey))
            {
                publickey = Constants.RSA.PublicKey;
            }
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentException("Can not encryt data");

            var maxLength = GetMaxDataLength();
            if (Encoding.Unicode.GetBytes(plainText).Length > maxLength)
                throw new ArgumentException("Can not encryt data");

            if (!IsKeySizeValid())
                throw new ArgumentException("Can not encryt data");

            if (string.IsNullOrWhiteSpace(publickey))
                throw new ArgumentException("Can not encryt data");

            string encryptedText;

            try
            {
                using (var rsaProvider = RSA.Create())
                {
                    rsaProvider.FromXmlString(publickey);
                    var plainBytes = Encoding.Unicode.GetBytes(plainText);
                    var encryptedBytes = rsaProvider.Encrypt(plainBytes, RSAEncryptionPadding.Pkcs1);
                    encryptedText = Convert.ToBase64String(encryptedBytes);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not encryt data!");
            }
            return encryptedText;
        }

        public static string ParseToCitizenNumber(string birthDay, string gender)
        {
            string result = "";
            if (!string.IsNullOrEmpty(birthDay) && !string.IsNullOrEmpty(gender))
            {
                string parsedDate = DateTime.ParseExact(birthDay, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyMMdd");
                //YYMMDD + gender
                return parsedDate + gender;
                // return String.Format("{0:yyMMdd}{1}" ,birthDay,gender);
            }
            return result;
        }

        public static string HashCR64Link(string url)
        {
            Regex urlRegex = new Regex(@"(http(s)?:\/\/)?\w+\.\w+(\.\w+)([:\d]*)+", RegexOptions.IgnoreCase);
            url = urlRegex.Replace(url, "").ToString();
            string[] URLSplit = url.Split('?');
            url = URLSplit[0].ToLower();
            if (URLSplit.Length > 1)
            {
                url += "?";
                string Gubun = "";
                foreach (string Param in URLSplit[1].Split('&'))
                {
                    string[] param = Param.Split('=');
                    if (param.Length == 2)
                    {
                        url += Gubun + param[0].ToUpper() + "=" + param[1];
                        Gubun = "&";
                    }
                }
            }
            return Secret.CRC64Hash(url);
        }

        public static string Decrypt(string encryptedText, string privatekey = "")
        {
            var plainText = "";

            if (string.IsNullOrEmpty(privatekey))
            {
                privatekey = Constants.RSA.PrivateKey;
            }

            if (string.IsNullOrWhiteSpace(encryptedText))
                throw new ArgumentException("Can not Decrypt data");

            if (!IsKeySizeValid())
                throw new ArgumentException("Can not Decrypt data");

            if (string.IsNullOrWhiteSpace(privatekey))
                throw new ArgumentException("Can not Decrypt data");

            try
            {
                using (var rsaProvider = RSA.Create())
                {
                    rsaProvider.FromXmlString(privatekey);
                    var encryptedBytes = Convert.FromBase64String(encryptedText);
                    var plainBytes = rsaProvider.Decrypt(encryptedBytes, RSAEncryptionPadding.Pkcs1);
                    plainText = Encoding.Unicode.GetString(plainBytes);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not Decrypt data");
            }
            return plainText;
        }

        public static string ConvertString(object obj)
        {
            string result = string.Empty;
            try
            {
                if (obj.GetType() == typeof(string))
                {
                    result = obj.ToString();
                }
                else
                {
                    result = JsonConvert.SerializeObject(obj);
                }
            }
            catch { result = "\"\""; }

            return result;
        }

        public static string SetHideShow(object Which)
        {
            string RetVal = "";
            if (Which != null)
            {
                if (Which.GetType() == typeof(string))
                {
                    RetVal = (!string.IsNullOrEmpty(Convert.ToString(Which).Replace("\n", "").Replace("\t", "").Replace("&nbsp;", "").Replace("<BR>", "").Replace("<br>", "")) ? "" : "style=\"display:none;\"");
                }
                else if (Which.GetType() == typeof(StringBuilder))
                {
                    RetVal = (!string.IsNullOrEmpty(Convert.ToString(Which).Replace("\n", "").Replace("\t", "").Replace("&nbsp;", "").Replace("<BR>", "").Replace("<br>", "")) ? "" : "style=\"display:none;\"");
                }
                else if (Which.GetType() == typeof(int))
                {
                    RetVal = (Convert.ToInt32(Which) > 0 ? "" : "style=\"display:none;\"");
                }
                else if (Which.GetType() == typeof(bool))
                {
                    RetVal = (Convert.ToBoolean(Which) ? "" : "style=\"display:none;\"");
                }
            }
            else
            {
                RetVal = "style=\"display:none;\"";
            }
            return RetVal;
        }

        public static string SettingPriceTable(WSP_S_ScheduleTable.Result1 tourProductModel)
        {
            string PriceCount = "";

            if (tourProductModel.SellingPrice_Adult > 0)
            {
                PriceCount += "A";
            }
            if (tourProductModel.SellingPrice_Kid_N > 0)
            {
                PriceCount += "N";
            }
            if (tourProductModel.SellingPrice_Kid_E > 0)
            {
                PriceCount += "E";
            }
            if (tourProductModel.SellingPrice_Toddler > 0)
            {
                PriceCount += "C";
            }
            return PriceCount;
        }

        public static bool MailSend(
            string MailFromAddr, string MailFromName, string MailToAddrList, string MailTitle, string MailContent)
        {
            string Data = "";
            MailFromAddr = MailFromAddr ?? Constants.MailConfig.MAIL_SENDER;
            MailFromName = MailFromName ?? "sender modetour";

            List<string> ListMailTo = MailToAddrList.Split(new char[] { ',' }).ToList();
            if (ListMailTo != null && ListMailTo.Count() > 0)
            {
                foreach (var mailTo in ListMailTo)
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.MailConfig.MAIL_SEVER);
                    string tempContent = MailContent.Replace("{{MailToName}}", mailTo);
                    MailForm form = new MailForm()
                    {
                        from = MailFromAddr,
                        fromname = MailFromName,
                        to = mailTo,
                        subject = MailTitle,
                        body = tempContent
                    };
                    Data = Functions.ConvertString(form);
                    try
                    {
                        string resultData = string.Empty;
                        string contentType = string.Empty;

                        request.UserAgent = "Mozilla/5.0";
                        request.KeepAlive = false;

                        WebHeaderCollection myWebHeaderCollection = request.Headers;
                        myWebHeaderCollection.Add("APIkey", Constants.MailConfig.MAIL_API_KEY);
                        request.Accept = "application/json";

                        request.ContentType = string.Format("{0} charset={1};", "application/json;", "utf-8");
                        request.Method = "POST";
                        request.UseDefaultCredentials = false;

                        Encoding encoding = Encoding.GetEncoding("utf-8");
                        byte[] data = encoding.GetBytes(Data);
                        request.ContentLength = data.Length;

                        Stream stream = request.GetRequestStream();
                        stream.Write(data, 0, data.Length);
                        stream.Close();

                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                        resultData = reader.ReadToEnd().Trim();
                    }
                    catch (WebException e)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static int ReqeustInt(string reqNum)
        {
            int reValue = 0;
            if (!String.IsNullOrEmpty(reqNum))
            {
                reqNum = reqNum.Replace(",", "");
                int.TryParse(reqNum, out reValue);
            }
            return reValue;
        }

        public static string SetLocation(string _location, string _type = null)
        {
            string retName = _type == null ? "인천/서울출발" : "68";

            switch (_location)
            {
                case "ICN":
                    retName = _type == null ? "인천/서울출발" : "88";
                    break;

                case "PUS":
                    retName = "부산출발";
                    break;

                case "TAE":
                    retName = "대구출발";
                    break;

                case "KWJ":
                    retName = "광주출발";
                    break;

                case "CJJ":
                    retName = "청주출발";
                    break;

                case "JEU":
                    retName = "제주출발";
                    break;

                case "YNY":
                    retName = "양양출발";
                    break;

                default:
                    break;
            }
            return retName;
        }

        public static string RemoveHtmlTag(string strData)
        {
            return Regex.Replace(strData, "<[A-z|/]+[^<>]*>", "");
        }

        public static List<PlaceImageModel> ComputeProductImage(string representativeImagePack, List<WSP_S_ScheduleTable.Result4> ProductPlace)
        {
            var arrFaceImg = new List<string>();
            arrFaceImg = representativeImagePack.Split(new string[] { ",!" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<PlaceImageModel> RetVal = new List<PlaceImageModel>();
            /* 이미지 노출 순서 정렬 */
            // 특전 or 강조 이미지 -> 일자 -> 순서
            ProductPlace = ProductPlace.OrderByDescending(p => p.SpecialEventOrNot)
                .ThenByDescending(p => p.TimelineDisplayOrNot)
                .ThenBy(p => p.TimelineDisplayOrNot)
                .ThenBy(p => p.Order).ToList();
            /* 이미지 노출 순서 정렬 */

            /* 대표이미지 있으면 최초이미지로 */
            if (arrFaceImg.Count > 0)
            {
                foreach (string each in arrFaceImg)
                {
                    string[] FaceImgTemp = each.Split(new string[] { "/" }, StringSplitOptions.None);
                    int tempplaceno;
                    if (Int32.TryParse(FaceImgTemp[3], out tempplaceno))
                    {
                        RetVal.Add(new PlaceImageModel() { PlaceNo = Convert.ToInt32(FaceImgTemp[3]), FileName = FaceImgTemp[5] });
                    }
                }
            }
            /* 대표이미지 있으면 최초이미지로 */
            /* 관광 장소이미지들 첫 1장씩 추가 (호텔의 경우는 특전일 경우만) */
            List<int> arrOverlapPlace_First = new List<int>();
            foreach (WSP_S_ScheduleTable.Result4 each in ProductPlace.Where(p => p.ServiceTypeCode == "SSCSPT" || p.ServiceTypeCode == "SSCSPO" || p.ServiceTypeCode == "SSCSPJ" || p.ServiceTypeCode == "SSCGLP" || p.ServiceTypeCode == "SSCACT"
                     || p.ServiceTypeCode == "SSCSEL" || p.ServiceTypeCode == "SSCSTK" || p.ServiceTypeCode == "SSCRDT" || (p.ServiceTypeCode == "SSC0RM" && p.SpecialEventOrNot == true)))
            {
                if (!arrOverlapPlace_First.Contains(each.PlaceNumber))
                {
                    arrOverlapPlace_First.Add(each.PlaceNumber);
                }
            }
            /* 관광 장소이미지들 첫 1장씩 추가 (호텔의 경우는 특전일 경우만) */
            /* 관광 장소이미지들 나머지 채우기 */
            List<int> arrOverlapPlace = new List<int>();
            foreach (WSP_S_ScheduleTable.Result4 each in ProductPlace.Where(p => p.ServiceTypeCode == "SSCSPT" || p.ServiceTypeCode == "SSCSPO" || p.ServiceTypeCode == "SSCSPJ" || p.ServiceTypeCode == "SSCGLP" || p.ServiceTypeCode == "SSCACT"
                     || p.ServiceTypeCode == "SSCSEL" || p.ServiceTypeCode == "SSCSTK" || p.ServiceTypeCode == "SSCRDT"))
            {
                if (!arrOverlapPlace.Contains(each.PlaceNumber))
                {
                    arrOverlapPlace.Add(each.PlaceNumber);
                }
            }
            /* 관광 장소이미지들 나머지 채우기 */

            /* 호텔 장소이미지들 중복 피하고 쭈욱 */
            List<int> arrOverlapHotel = new List<int>();
            foreach (WSP_S_ScheduleTable.Result4 each in ProductPlace.Where(p => p.ServiceTypeCode == "SSC0RM"))
            {
                if (!arrOverlapHotel.Contains(each.PlaceNumber))
                {
                    arrOverlapHotel.Add(each.PlaceNumber);
                }
            }
            /* 호텔 장소이미지들 중복 피하고 쭈욱 */

            // 최종 이미지 순서 : 대표이미지 -> 특전 or 강조이미지 각 1장 -> 관광지 이미지 일자, 순서 정렬 각 1장 -> 호텔 이미지

            return RetVal;
        }

        public static string WeekFormat(int WeekNum, int Gubun)
        {
            string[,] WeekText = new string[7, 3] { { "일", "日", "Sun" }, { "월", "月", "Mon" }, { "화", "火", "Tue" }, { "수", "水", "Wed" }, { "목", "木", "Thu" }, { "금", "金", "Fri" }, { "토", "土", "Sat" } };
            return WeekText[WeekNum, Gubun];
        }

        public static string SplitString(string pString, int pStrLen, string pOption)
        {
            return SplitString2(pString, pStrLen, pOption);
        }

        public static string SplitString2(string pString, int pStrLen, string pOption)
        {
            int len = 0;
            int ForIdx, ForEnd;
            string _return;

            ForEnd = pString.Length;
            _return = pString;

            for (ForIdx = 0; ForIdx < ForEnd; ForIdx++)
            {
                if ((ConvertASC(pString.Substring(ForIdx, 1)) > 255) || (ConvertASC(pString.Substring(ForIdx, 1)) < 0))
                    len += 2;
                else
                    len += 1;

                if (pStrLen < len)
                {
                    if (pOption == "1")
                    {
                        _return = pString.Substring(0, ForIdx - 2);
                        _return = _return + "...";
                    }
                    else
                        _return = pString.Substring(0, ForIdx);

                    break;
                }
            }
            return _return;
        }

        public static int ConvertASC(string Txt)
        {
            return Txt.ToCharArray()[0];
        }

        public static bool IsDate(string Txt)
        {
            bool _return = true;
            try
            {
                DateTime _Date;
                if (String.IsNullOrEmpty(Txt))
                    _return = false;
                else
                    _Date = DateTime.Parse(Txt);
            }
            catch (Exception)
            {
                _return = false;
            }

            return _return;
        }

        public static string RequestDateTime(string reqDate, string format)
        {
            string reValue = "";
            DateTime reDate;

            if (!String.IsNullOrEmpty(reqDate))
            {
                if (reqDate.IndexOf("-") == -1 && reqDate.Length == 8)
                    reqDate = reqDate.Substring(0, 4) + "-" + reqDate.Substring(4, 2) + "-" + reqDate.Substring(6, 2);

                if (DateTime.TryParse(reqDate, out reDate))
                    reValue = reDate.ToString(format);
            }
            return reValue;
        }

        public static string GetMeetingMap(string MeetingPlaceCode)
        {
            string MeetSrc = "";
            switch (MeetingPlaceCode)
            {
                case "30":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/support/img_meetplace_gimpo1.gif";  //김포공항
                    break;

                case "04":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap3.gif";  //김해공항
                    break;

                case "55":
                    MeetSrc += "http://img.modetour.com/ModeLiveBooking/mobile/popup_191227/pc_gimhae_facilities_popup.jpg";  //김해공항
                    break;

                case "11":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap6.gif";  //대구공항
                    break;

                case "D1":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap8.gif";  //대구공항 2층
                    break;

                case "15":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/support/img_meetplace_cheongju1.gif";  //청주공항
                    break;

                case "29":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/support/img_meetplace_muan.gif";  //무안공항
                    break;

                case "50":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/support/img_meetplace_jeju.gif";  //제주공항
                    break;

                case "40":
                //case "34": MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap2.gif";  //인천공항 A카운터
                case "34":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap10.gif";  //인천공항 동편
                    break;

                case "41":
                //case "35": MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap1.gif";  //인천공항 M카운터
                case "35":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap9.gif";  //인천공항 서편
                    break;

                case "33":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap7.gif";  //인천공항 중앙 카운터

                    break;

                case "37":
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap2_new.gif";  //인천공항 2터미널 add by 2017.12.22(신지영)
                    break;

                default:
                    MeetSrc += "http://img.modetour.co.kr/mode2010/modetour/product/img_meetingmap.gif";    //존재하지 않음
                    break;
            }
            return MeetSrc;
        }

        public static List<PlaceImageModel> ComputeProductImage(List<string> arrFaceImg, List<PlaceModel.Result> ProductPlace)
        {
            List<PlaceImageModel> RetVal = new List<PlaceImageModel>();

            /* 이미지 노출 순서 정렬 */
            // 특전 or 강조 이미지 -> 일자 -> 순서
            ProductPlace = ProductPlace.OrderByDescending(p => p.ItiBenefit)
                .ThenByDescending(p => p.ItiHighlight)
                .ThenBy(p => p.ItiDays)
                .ThenBy(p => p.ItiSeq).ToList();
            /* 이미지 노출 순서 정렬 */

            /* 대표이미지 있으면 최초이미지로 */
            if (arrFaceImg.Count > 0)
            {
                foreach (string each in arrFaceImg)
                {
                    string[] FaceImgTemp = each.Split(new string[] { "/" }, StringSplitOptions.None);
                    int tempplaceno;
                    if (Int32.TryParse(FaceImgTemp[3], out tempplaceno))
                    {
                        RetVal.Add(new PlaceImageModel() { PlaceNo = Convert.ToInt32(FaceImgTemp[3]), FileName = FaceImgTemp[5] });
                    }
                }
            }
            /* 대표이미지 있으면 최초이미지로 */

            /* 관광 장소이미지들 첫 1장씩 추가 (호텔의 경우는 특전일 경우만) */
            List<int> arrOverlapPlace_First = new List<int>();
            foreach (PlaceModel.Result each in ProductPlace.Where(p => p.ItiServiceCode == "SSCSPT" || p.ItiServiceCode == "SSCSPO" || p.ItiServiceCode == "SSCSPJ" || p.ItiServiceCode == "SSCGLP" || p.ItiServiceCode == "SSCACT"
                || p.ItiServiceCode == "SSCSEL" || p.ItiServiceCode == "SSCSTK" || p.ItiServiceCode == "SSCRDT" || (p.ItiServiceCode == "SSC0RM" && p.ItiBenefit == 1)))
            {
                if (!arrOverlapPlace_First.Contains(each.PlaceNo))
                {
                    arrOverlapPlace_First.Add(each.PlaceNo);

                    if (each.arrPlaceImge.Count > 0)
                    {
                        RetVal.Add(each.arrPlaceImge[0]);
                    }
                }
            }
            /* 관광 장소이미지들 첫 1장씩 추가 (호텔의 경우는 특전일 경우만) */
            /* 관광 장소이미지들 나머지 채우기 */
            List<int> arrOverlapPlace = new List<int>();
            foreach (PlaceModel.Result each in ProductPlace.Where(p => p.ItiServiceCode == "SSCSPT" || p.ItiServiceCode == "SSCSPO" || p.ItiServiceCode == "SSCSPJ" || p.ItiServiceCode == "SSCGLP" || p.ItiServiceCode == "SSCACT"
                || p.ItiServiceCode == "SSCSEL" || p.ItiServiceCode == "SSCSTK" || p.ItiServiceCode == "SSCRDT"))
            {
                if (!arrOverlapPlace.Contains(each.PlaceNo))
                {
                    arrOverlapPlace.Add(each.PlaceNo);
                    foreach (PlaceImageModel ieach in each.arrPlaceImge.Skip(1))
                    {
                        RetVal.Add(ieach);
                    }
                }
            }
            /* 관광 장소이미지들 나머지 채우기 */

            /* 호텔 장소이미지들 중복 피하고 쭈욱 */
            List<int> arrOverlapHotel = new List<int>();
            foreach (PlaceModel.Result each in ProductPlace.Where(p => p.ItiServiceCode == "SSC0RM"))
            {
                if (!arrOverlapHotel.Contains(each.PlaceNo))
                {
                    arrOverlapHotel.Add(each.PlaceNo);

                    foreach (PlaceImageModel ieach in each.arrPlaceImge)
                    {
                        RetVal.Add(ieach);
                    }
                }
            }
            /* 호텔 장소이미지들 중복 피하고 쭈욱 */

            // 최종 이미지 순서 : 대표이미지 -> 특전 or 강조이미지 각 1장 -> 관광지 이미지 일자, 순서 정렬 각 1장 -> 호텔 이미지

            return RetVal;
        }

        public static void ParseJsonArrPlace(ref Ext_PlaceExternalLinkModel ELM, ref Ext_PlaceReviewModel PRM, ref ExtG_GoogleExternalLinkModel GLM, string ExternalLinkData_TA, string ExternalLinkData_GG)
        {
            if (!string.IsNullOrEmpty(ExternalLinkData_TA))
            {
                ELM = JsonConvert.DeserializeObject<Ext_PlaceExternalLinkModel>(ExternalLinkData_TA);
                if (ELM.header == null || ELM.response == null)
                {
                    ELM.Validity = -1;
                }
                else
                {
                    /* 묶인데이터 해체 Init require data */
                    ELM.response.arrroomAmenities = (!string.IsNullOrEmpty(ELM.response.roomAmenities) ? ELM.response.roomAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
                    ELM.response.arrbathRoomAmenities = (!string.IsNullOrEmpty(ELM.response.bathRoomAmenities) ? ELM.response.bathRoomAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
                    ELM.response.arrinterNetAmenities = (!string.IsNullOrEmpty(ELM.response.interNetAmenities) ? ELM.response.interNetAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
                    ELM.response.arrpoolAmenities = (!string.IsNullOrEmpty(ELM.response.poolAmenities) ? ELM.response.poolAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
                    ELM.response.arrrestrantAmenities = (!string.IsNullOrEmpty(ELM.response.restrantAmenities) ? ELM.response.restrantAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
                    ELM.response.arrfacilityAmenities = (!string.IsNullOrEmpty(ELM.response.facilityAmenities) ? ELM.response.facilityAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
                    ELM.response.arrdefaultAmenities = (!string.IsNullOrEmpty(ELM.response.defaultAmenities) ? ELM.response.defaultAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
                    ELM.response.arrparkingAmenities = (!string.IsNullOrEmpty(ELM.response.parkingAmenities) ? ELM.response.parkingAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
                    ELM.response.arrsuttleAmenities = (!string.IsNullOrEmpty(ELM.response.suttleAmenities) ? ELM.response.suttleAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
                    ELM.response.arrcreditAmenities = (!string.IsNullOrEmpty(ELM.response.creditAmenities) ? ELM.response.creditAmenities.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());

                    // 이미지가 없어서 파싱시 초기화되지 않은 오브젝트면 초기화
                    if (ELM.response.hotelImage == null)
                    {
                        ELM.response.hotelImage = new Ext_ImageModel();
                        ELM.response.hotelImage.image = new List<string>();
                    }

                    ELM.response.hotelImage.sImage = new List<string>();
                    ELM.response.hotelImage.bImage = new List<string>();
                    ELM.response.hotelImage.ImageType = new List<string>();

                    for (int i = 0; i < ELM.response.hotelImage.image.Count; i++)
                    {
                        string[] Splitted = ELM.response.hotelImage.image[i].Split(new string[] { "|" }, StringSplitOptions.None);

                        ELM.response.hotelImage.sImage.Add(Splitted[0]);
                        ELM.response.hotelImage.bImage.Add(Splitted[1]);
                        ELM.response.hotelImage.ImageType.Add(Splitted[2]);
                    }
                    /* 묶인데이터 해체 */

                    /* 리뷰내용 ApiCall */
                    // 임시막음 -> 한번에 쭉 호출에서 dlg별 각개 호출로 수정됨
                    string ELMreview = "";
                    // 임시푸름 임시막음 주석해제시 삭제되야함
                    ELM.Validity = 1;
                    if (!string.IsNullOrEmpty(ELMreview))
                    {
                        //임시막음
                        //ELM.Validity = 1;
                        //JsonConvert.DeserializeObject<ext_PlaceExternalLinkModel>(ExternalLinkData_TA);
                        PRM = JsonConvert.DeserializeObject<Ext_PlaceReviewModel>(ELMreview);

                        // 리뷰 선호도 null 처리
                        if (PRM.response.preferenceTypes == null)
                        {
                            PRM.response.preferenceTypes = new Ext_PlaceReviewPreferenceTypesModel();
                            PRM.response.preferenceTypes.preferenceType = new List<Ext_PlaceReviewPreferenceTypeModel>();
                            for (int x = 0; x < 5; x++)
                            {
                                PRM.response.preferenceTypes.preferenceType.Add(new Ext_PlaceReviewPreferenceTypeModel() { name = "", count = "1" });
                            }
                        }
                    }
                    else
                    {
                        //임시막음
                        //ELM.Validity = -2;
                        PRM = new Ext_PlaceReviewModel();
                    }

                    /* 리뷰내용 ApiCall */
                    if (!string.IsNullOrEmpty(ExternalLinkData_GG))
                    {
                        try
                        {
                            GLM = JsonConvert.DeserializeObject<ExtG_GoogleExternalLinkModel>(ExternalLinkData_GG);
                        }
                        catch (Exception ex)
                        {
                            // 유니코드바차 파싱오류
                            GLM = new ExtG_GoogleExternalLinkModel();
                        }
                    }
                }
            }
            else
            {
                ELM.Validity = 0;
            }
            if (!string.IsNullOrEmpty(ExternalLinkData_GG))
            {
                GLM = JsonConvert.DeserializeObject<ExtG_GoogleExternalLinkModel>(ExternalLinkData_GG);
            }
        }

        public static string GetLeaderStatus(string leaderConfirm, string leaderAccompany, int GuideAccompanyNumberOfPeople)
        {
            string RetVal = "";

            if (leaderConfirm == "Y")
            {
                RetVal = "확정";
            }
            else if (leaderConfirm == "N" && leaderAccompany == "Y")
            {
                RetVal = "예정";
            }
            else if (leaderConfirm == "N" && leaderAccompany == "P")
            {
                RetVal = GuideAccompanyNumberOfPeople + "명이 넘으면 인솔자가 배정될 예정입니다.";
            }
            else if (leaderConfirm == "N" && leaderAccompany == "N")
            {
                RetVal = "인솔자는 동반하지 않습니다.";
            }
            return RetVal;
        }

        public static string ConvDTS(int RetType, DateTime ConvDate)
        {
            string RetVal = "";
            if (ConvDate != null)
            {
                switch (RetType)
                {
                    case 1:
                        RetVal = ConvDate.ToString("yyyy-MM-dd");
                        break;

                    case 2:
                        RetVal = ConvDate.ToString("MM/dd (ddd)");
                        break;

                    case 3:
                        RetVal = ConvDate.ToString("yyyy.MM.dd ddd");
                        break;

                    case 4:
                        RetVal = ConvDate.ToString("yyyy. MM. dd");
                        break;
                }
            }
            return RetVal;
        }

        public static string ConvStar(string Splitter, string Rating)
        {
            string RetVal;

            if (!string.IsNullOrEmpty(Rating))
            {
                int HotelRating1 = Rating.Length - Rating.Replace("★", "").Length;
                // 별 반개는 _5라 *5함 (ex.ico_start3_5)
                int HotelRating2 = (Rating.Length - Rating.Replace("☆", "").Length) * 5;
                string HalfStar = HotelRating2 == 0 ? "" : Splitter + HotelRating2;

                RetVal = HotelRating1 + HalfStar;
            }
            else
            {
                RetVal = "0";
            }
            return RetVal;
        }

        public static List<string> SplitStringToList(string input)
        {
            if (String.IsNullOrEmpty(input))
                return null;
            else
            {
                var arr = input.Split(',').Select(str => str.Trim()).ToArray();
                List<String> result = new List<string>();
                for (int i = 0; i < arr.Length; i++)
                {
                    result.Add(arr[i]);
                }
                return result;
            }
        }

        public static string FromUTF8Base64Decode(string Txt)
        {
            string txt = "";
            try
            {
                txt = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Txt));
            }
            catch
            {
                txt = Txt;
            }
            return txt;
        }

        public static List<ScheduleTableBannerItem> ParseBanner(List<WSP_S_ScheduleTable_Banner.Result> arrBanner, string Cate, string ProductCode, string ProductKeyword, string PrefixName, string PromotionName, DateTime DepartureDate)
        {
            var data = arrBanner.Select(x => new ScheduleTableBannerItem
            {
                BannerManageNumber = x.BannerManageNumber,
                Category = x.Category,
                Condition = x.Condition,
                ConditionKey = x.ConditionKey,
                EventName = x.EventName,
                DisplayPeriod_Start = x.DisplayPeriod_Start,
                DisplayPeriod_End = x.DisplayPeriod_End,
                PC_Tag = x.PC_Tag,
                MO_Tag = x.MO_Tag,
                PC_Link = x.PC_Link,
                MO_Link = x.MO_Link,
                Use = x.Use,
                Registerer_PTID = x.Registerer_PTID,
                RegisterDate = x.RegisterDate,
                IncentiveDisplay = x.IncentiveDisplay,
                DisplayDay = x.DisplayDay,
                Position = x.Position,
                Order = x.Order,
                DepartureDate1 = x.DepartureDate1,
                DepartureDate2 = x.DepartureDate2,
                EventImage = "/promotion/7348/220722/760_7348.jpg",
                ModeTipImage = "/promotion20/12212/1100_12212.jpg"
            });
            List<ScheduleTableBannerItem> RetVal = new List<ScheduleTableBannerItem>();

            if (Cate == "01")
            {
                data = data.Where(b => (b.DepartureDate1 == new DateTime() || b.DepartureDate1 <= DepartureDate) && (b.DepartureDate2 == new DateTime() || b.DepartureDate2 >= DepartureDate)).ToList();
            }
            RetVal.AddRange(data.Where(b => b.Condition == "00").ToList());
            RetVal.AddRange(data.Where(b => b.Condition == "01" && ProductCode.IndexOf(b.ConditionKey) > -1).ToList());
            RetVal.AddRange(data.Where(b => b.Condition == "02" && ProductKeyword.IndexOf(b.ConditionKey) > -1).ToList());
            //RetVal.AddRange(oBN.Where(b => b.Condition == "03" && PrefixName.IndexOf(b.ConditionKey) > -1).ToList());
            //RetVal.AddRange(oBN.Where(b => b.Condition == "04" && PromotionName.IndexOf(b.ConditionKey) > -1).ToList());
            RetVal.AddRange(data.Where(b => b.Condition == "03" && b.ConditionKey.IndexOf(PrefixName) > -1).ToList());
            RetVal.AddRange(data.Where(b => b.Condition == "04" && b.ConditionKey.IndexOf(PromotionName) > -1).ToList());

            return RetVal;
        }

        public static string RemoveSpecialChars(string str)
        {
            // Create  a string array and add the special characters you want to remove
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
            //Iterate the number of times based on the String array length.
            for (int i = 0; i < chars.Length; i++)
            {
                if (str.Contains(chars[i]))
                {
                    str = str.Replace(chars[i], "");
                }
            }
            return str;
        }

        public static List<AirRouteItemViewModel> AirRoute(string itiDate, string DnA, WSP_S_ScheduleTable.Result1 tourProduct, bool dlgFlag)
        {
            var model = new List<AirRouteItemViewModel>();
            string DnT = tourProduct.DirectFlightOrNot;
            /* 출발편 or 귀국편 구분 Departure or Arri */
            if (DnA == "D")
            {
                /* 출발편 직항/경유 구분 Departure Flight direct or Transit */
                if (string.IsNullOrEmpty(tourProduct.DepartureFlight_TransitCityCode))
                {
                    DnT = "Y";
                }
                else
                {
                    DnT = "N";
                }
                /* 출발편 직항/경유 구분 */
            }
            else if (DnA == "A")
            {
                /* 도착편 직항/경유 구분 Return to home land Flight direct or Transit */
                if (string.IsNullOrEmpty(tourProduct.ReturnToHomelandFlight_TransitCityCode))
                {
                    DnT = "Y";
                }
                else
                {
                    DnT = "N";
                }
                /* 도착편 직항/경유 구분  Flight direct or Transit */
            }

            var flightCodeLogo = "https://img.modetour.com/air/logo/"
                + (tourProduct.FlightCode.Length > 2 ? tourProduct.FlightCode.Substring(0, 2) : tourProduct.FlightCode) + ".png";
            var airlineName = tourProduct.AirlineName;

            var D_n_n_n_DIRECT_Item = new AirRouteItemViewModel() { AirlineLogo = flightCodeLogo, AirlineName = airlineName };
            var n_n_n_A_DIRECT_Item = new AirRouteItemViewModel() { AirlineLogo = flightCodeLogo, AirlineName = airlineName };
            var D_n_n_n_THROUGH_Item = new AirRouteItemViewModel() { AirlineLogo = flightCodeLogo, AirlineName = airlineName };
            var T_n_n_n_Item = new AirRouteItemViewModel() { AirlineLogo = flightCodeLogo, AirlineName = airlineName };
            var n_T_n_n_Item = new AirRouteItemViewModel() { AirlineLogo = flightCodeLogo, AirlineName = airlineName };
            var n_n_W_n_Item = new AirRouteItemViewModel() { AirlineLogo = flightCodeLogo, AirlineName = airlineName };
            var n_n_T_n_Item = new AirRouteItemViewModel() { AirlineLogo = flightCodeLogo, AirlineName = airlineName };
            var n_n_n_A_THROUGH_Item = new AirRouteItemViewModel() { AirlineLogo = flightCodeLogo, AirlineName = airlineName };
            var n_n_n_T_Item = new AirRouteItemViewModel() { AirlineLogo = flightCodeLogo, AirlineName = airlineName };

            if (DnT == "Y")
            {
                DateTime DepartureDate = DnA == "D" ? Convert.ToDateTime(tourProduct.DepartureDate) : tourProduct.ReturnToHomelandFlight_DepartureDate;
                string DepartureTime = (DnA == "D" ? tourProduct.DepartureTime : tourProduct.LocalDepartureTime);
                string DepartureCityName = (DnA == "D" ? tourProduct.DepartureCityName : tourProduct.KoreanDepartureCityName);
                string DepartureCity = (DnA == "D" ? tourProduct.DepartureCity : tourProduct.KoreanDepartureCity);
                string DepartureFlight = (DnA == "D" ? tourProduct.DepartureFlight : tourProduct.ArrivalFlight);
                string DepartureFlightDuration = "";
                if (!string.IsNullOrEmpty(tourProduct.DepartureFlightDuration) && !string.IsNullOrEmpty(tourProduct.ArrivalFlightDuration))
                {
                    //Air transport or not
                    if (tourProduct.TransportationMethodCode == "01" || tourProduct.TransportationMethodCode == "02" || tourProduct.TransportationMethodCode == "03" || tourProduct.TransportationMethodCode == "04")
                    {
                        DepartureFlightDuration = DnA == "D" ? tourProduct.DepartureFlightDuration : tourProduct.ArrivalFlightDuration;
                    }
                    else
                    {
                        DepartureFlightDuration = "";
                    }
                }
                DateTime ArrivalDate = DnA == "D" ? tourProduct.DepartureFlight_ArrivalDate : Convert.ToDateTime(tourProduct.ArrivalDate);
                string ArrivalTime = (DnA == "D" ? tourProduct.LocalArrivalTime : tourProduct.ArrivalTime);
                string ArrivalCityName = (DnA == "D" ? tourProduct.ArrivalCityName : tourProduct.KoreanArrivalCityName);
                string ArrivalCity = (DnA == "D" ? tourProduct.ArrivalCity : tourProduct.KoreanArrivalCity);

                D_n_n_n_DIRECT_Item.Name = " D_n_n_n_DIRECT";
                D_n_n_n_DIRECT_Item.DepartureDate = DepartureDate;
                D_n_n_n_DIRECT_Item.DepartureTime = DepartureTime;
                D_n_n_n_DIRECT_Item.DepartureCityName = DepartureCityName;
                D_n_n_n_DIRECT_Item.DepartureCity = DepartureCity;

                n_n_n_A_DIRECT_Item.Name = " n_n_n_A_DIRECT";
                n_n_n_A_DIRECT_Item.ArrivalCity = ArrivalCity;
                n_n_n_A_DIRECT_Item.ArrivalCityName = ArrivalCityName;
                n_n_n_A_DIRECT_Item.ArrivalDate = ArrivalDate;
                n_n_n_A_DIRECT_Item.ArrivalTime = ArrivalTime;
                n_n_n_A_DIRECT_Item.DepartureFlightDuration = DepartureFlightDuration;
                n_n_n_A_DIRECT_Item.DepartureFlight = DepartureFlight;
            }
            else if (DnT == "N")
            {
                DateTime DepartureDate = DnA == "D" ? Convert.ToDateTime(tourProduct.DepartureDate) : tourProduct.ReturnToHomelandFlight_TransitCity_DepartureDate;
                string DepartureTime = (DnA == "D" ? tourProduct.DepartureTime : tourProduct.ReturnToHomelandFlight_TransitCity_DepartureTime);
                string DepartureCityName = (DnA == "D" ? tourProduct.DepartureCityName : tourProduct.ReturnToHomelandFlight_TransitCityName);
                string DepartureCity = (DnA == "D" ? tourProduct.DepartureCity : tourProduct.ReturnToHomelandFlight_TransitCityCode);
                string A_DepartureCity = (DnA == "D" ? tourProduct.DepartureFlight_TransitCityCode : tourProduct.ReturnToHomelandFlight_TransitArrivalCityCode);
                DateTime D_T_DepartureDate = DnA == "D" ? tourProduct.DepartureFlight_TransitCity_DepartureDate : tourProduct.ReturnToHomelandFlight_DepartureDate;
                string D_T_DepartureTime = (DnA == "D" ? tourProduct.DepartureFlight_TransitCity_DepartureTime : tourProduct.LocalDepartureTime);
                string D_ThroughCityName = (DnA == "D" ? tourProduct.DepartureFlight_TransitCityName : tourProduct.KoreanDepartureCityName);
                string A_ThroughCityName = (DnA == "D" ? tourProduct.DepartureFlight_TransitCityName : tourProduct.ReturnToHomelandFlight_TransitArrivalCityName);
                string D_ThroughCity = (DnA == "D" ? tourProduct.DepartureFlight_TransitCityCode : tourProduct.KoreanDepartureCity);
                string DepartureFlight = (DnA == "D" ? tourProduct.DepartureFlight : tourProduct.ReturnToHomelandFlight_TransitCity_FlightName);
                string D_T_DepartureFlightDuration = "";
                string DepartureFlightTime = "";
                if (!string.IsNullOrEmpty(tourProduct.DepartureFlight_TransitCity_TransitFlight_FlightDuration) && !string.IsNullOrEmpty(tourProduct.ReturnToHomelandFlight_TransitCity_TransitFlight_FlightDuration) && !string.IsNullOrEmpty(tourProduct.DepartureFlightDuration) && !string.IsNullOrEmpty(tourProduct.ArrivalFlightDuration))
                {
                    D_T_DepartureFlightDuration = DnA == "D" ? tourProduct.DepartureFlight_TransitCity_TransitFlight_FlightDuration : tourProduct.ReturnToHomelandFlight_TransitCity_TransitFlight_FlightDuration;
                    DepartureFlightTime = (DnA == "D" ? tourProduct.DepartureFlightDuration : tourProduct.ArrivalFlightDuration);
                }
                DateTime D_T_ArrivalDate = DnA == "D" ? tourProduct.DepartureFlight_TransitCity_ArrivalDate : tourProduct.ReturnToHomelandFlight_TransitCity_ArrivalDate;
                string D_T_ArrivalTime = DnA == "D" ? tourProduct.DepartureFlight_TransitCity_ArrivalTime : tourProduct.ReturnToHomelandFlight_TransitCity_ArrivalTime;
                string DepartureDateDiff = "";
                string ThroughDateDiff = "";
                string ArrivalDateDiff = "";
                string D_T_AirFlight = (DnA == "D" ? tourProduct.DepartureFlight_TransitCity_FlightName : tourProduct.ArrivalFlight);
                DateTime ArrivalDate = DnA == "D" ? tourProduct.DepartureFlight_ArrivalDate : Convert.ToDateTime(tourProduct.ArrivalDate);
                string ArrivalTime = (DnA == "D" ? tourProduct.LocalArrivalTime : tourProduct.ArrivalTime);
                string ArrivalCityName = (DnA == "D" ? tourProduct.ArrivalCityName : tourProduct.KoreanArrivalCityName);
                string ArrivalCity = (DnA == "D" ? tourProduct.ArrivalCity : tourProduct.KoreanArrivalCity);

                // 경유대기 시간 Throug time
                DateTime ThroughDate1 = Convert.ToDateTime(Convert.ToDateTime((DnA == "D" ? tourProduct.DepartureFlight_TransitCity_ArrivalTime : tourProduct.ReturnToHomelandFlight_TransitCity_ArrivalDate)).ToShortDateString() + " " + (DnA == "D" ? tourProduct.DepartureFlight_TransitCity_ArrivalTime : tourProduct.ReturnToHomelandFlight_TransitCity_ArrivalTime));
                DateTime ThroughDate2 = Convert.ToDateTime(Convert.ToDateTime((DnA == "D" ? tourProduct.DepartureFlight_TransitCity_DepartureDate : tourProduct.ReturnToHomelandFlight_DepartureDate)).ToShortDateString() + " " + (DnA == "D" ? tourProduct.DepartureFlight_TransitCity_DepartureTime : tourProduct.LocalDepartureTime));

                D_n_n_n_THROUGH_Item.Name = " D_n_n_n_THROUG";
                D_n_n_n_THROUGH_Item.DepartureDate = DepartureDate;
                D_n_n_n_THROUGH_Item.DepartureTime = DepartureTime;
                D_n_n_n_THROUGH_Item.DepartureCityName = DepartureCityName;
                D_n_n_n_THROUGH_Item.DepartureCity = DepartureCity;

                T_n_n_n_Item.Name = " T_n_n_n";
                T_n_n_n_Item.D_T_DepartureDate = D_T_DepartureDate;
                T_n_n_n_Item.D_T_DepartureTime = D_T_DepartureTime;
                T_n_n_n_Item.D_ThroughCityName = D_ThroughCityName;
                T_n_n_n_Item.D_ThroughCity = D_ThroughCity;

                n_T_n_n_Item.Name = " n_T_n_n";
                n_T_n_n_Item.DepartureFlight = DepartureFlight;
                n_T_n_n_Item.D_T_DepartureFlightDuration = D_T_DepartureFlightDuration;
                n_T_n_n_Item.D_T_ArrivalDate = D_T_ArrivalDate;
                n_T_n_n_Item.D_T_ArrivalTime = D_T_ArrivalTime;
                n_T_n_n_Item.DepartureDateDiff = DepartureDateDiff;
                n_T_n_n_Item.A_ThroughCityName = A_ThroughCityName;
                n_T_n_n_Item.A_DepartureCity = A_DepartureCity;

                n_n_W_n_Item.Name = " n_n_W_n";
                n_n_W_n_Item.D_T_DepartureDate = D_T_DepartureDate;
                n_n_W_n_Item.D_T_DepartureTime = D_T_DepartureTime;
                n_n_W_n_Item.ThroughDate2 = ThroughDate2;
                n_n_W_n_Item.ThroughDate1 = ThroughDate1;
                if (n_n_W_n_Item.ThroughDate1.HasValue && n_n_W_n_Item.ThroughDate2.HasValue)
                    n_n_W_n_Item.WaitingTime = (n_n_W_n_Item.ThroughDate2 - n_n_W_n_Item.ThroughDate1)?.Hours.ToString("00")
                        + ":" + (n_n_W_n_Item.ThroughDate2 - n_n_W_n_Item.ThroughDate1)?.Minutes.ToString("00");
                n_n_W_n_Item.D_ThroughCityName = D_ThroughCityName;
                n_n_W_n_Item.D_ThroughCity = D_ThroughCity;

                n_n_T_n_Item.Name = " n_n_T_n";
                n_n_T_n_Item.D_T_DepartureDate = D_T_DepartureDate;
                n_n_T_n_Item.D_T_DepartureTime = D_T_DepartureTime;
                n_n_T_n_Item.D_ThroughCityName = D_ThroughCityName;
                n_n_T_n_Item.D_ThroughCity = D_ThroughCity;

                n_n_n_T_Item.Name = " n_n_n_T";
                n_n_n_T_Item.ThroughDate2 = ThroughDate2;
                n_n_n_T_Item.ThroughDate1 = ThroughDate1;
                if (n_n_n_T_Item.ThroughDate1.HasValue && n_n_n_T_Item.ThroughDate2.HasValue)
                    n_n_n_T_Item.WaitingTime = (n_n_n_T_Item.ThroughDate2 - n_n_W_n_Item.ThroughDate1)?.Hours.ToString("00")
                        + ":" + (n_n_n_T_Item.ThroughDate2 - n_n_n_T_Item.ThroughDate1)?.Minutes.ToString("00");

                n_n_n_T_Item.D_T_ArrivalDate = D_T_ArrivalDate;
                n_n_n_T_Item.D_T_ArrivalTime = D_T_ArrivalTime;
                n_n_n_T_Item.ThroughDateDiff = ThroughDateDiff;
                n_n_n_T_Item.D_ThroughCityName = D_ThroughCityName;
                n_n_n_T_Item.D_ThroughCity = D_ThroughCity;

                n_n_n_A_THROUGH_Item.Name = "n_n_n_A_THROUGH";
                n_n_n_A_THROUGH_Item.D_T_AirFlight = D_T_AirFlight;
                n_n_n_A_THROUGH_Item.DepartureFlightTime = DepartureFlightTime;
                n_n_n_A_THROUGH_Item.ArrivalTime = ArrivalTime;
                n_n_n_A_THROUGH_Item.ArrivalDateDiff = ArrivalDateDiff;
                n_n_n_A_THROUGH_Item.ArrivalDate = ArrivalDate;
                n_n_n_A_THROUGH_Item.ArrivalCityName = ArrivalCityName;
                n_n_n_A_THROUGH_Item.ArrivalCity = ArrivalCity;
            }

            if (!string.IsNullOrEmpty(DnA))
            {
                if (DnT == "Y")
                {
                    model.Add(D_n_n_n_DIRECT_Item);
                    model.Add(n_n_n_A_DIRECT_Item);
                }
                else if (DnT == "N")
                {
                    string DepartureDate = Functions.ConvDTS(1, (DnA == "D" ? Convert.ToDateTime(tourProduct.DepartureDate) : tourProduct.ReturnToHomelandFlight_TransitCity_DepartureDate));
                    string D_T_ArrivalDate = Functions.ConvDTS(1, (DnA == "D" ? tourProduct.DepartureFlight_TransitCity_ArrivalDate : tourProduct.ReturnToHomelandFlight_TransitCity_ArrivalDate));
                    string D_T_DepartureDate = Functions.ConvDTS(1, (DnA == "D" ? tourProduct.DepartureFlight_TransitCity_DepartureDate : tourProduct.ReturnToHomelandFlight_DepartureDate));
                    if (dlgFlag == false)
                    {
                        if (DepartureDate == itiDate && DepartureDate == D_T_DepartureDate && ((DnA == "D" && tourProduct.TransitDepartureScheduleDisplay == "Y") || (DnA == "A" && tourProduct.TransitArrivalScheduleDisplay == "Y")))
                        {
                            model.Add(D_n_n_n_THROUGH_Item);
                            model.Add(n_T_n_n_Item);
                            model.Add(n_n_W_n_Item);
                            model.Add(n_n_n_A_THROUGH_Item);
                        }
                        else if (DepartureDate == itiDate && DepartureDate == D_T_DepartureDate && ((DnA == "D" && tourProduct.TransitDepartureScheduleDisplay == "N") || (DnA == "A" && tourProduct.TransitArrivalScheduleDisplay == "N")))
                        {
                            model.Add(D_n_n_n_THROUGH_Item);
                            model.Add(n_T_n_n_Item);
                            model.Add(n_n_T_n_Item);
                            model.Add(n_n_n_A_THROUGH_Item);
                        }
                        else if (DepartureDate == itiDate && DepartureDate != D_T_DepartureDate)
                        {
                            model.Add(D_n_n_n_THROUGH_Item);
                            model.Add(n_T_n_n_Item);
                            model.Add(n_n_n_T_Item);
                        }
                        else if (D_T_DepartureDate == itiDate && DepartureDate != D_T_DepartureDate)
                        {
                            model.Add(T_n_n_n_Item);
                            model.Add(n_n_n_A_THROUGH_Item);
                        }
                    }
                    else
                    {
                        if (DepartureDate == itiDate && DepartureDate == D_T_DepartureDate && ((DnA == "D" && tourProduct.TransitDepartureScheduleDisplay == "Y") || (DnA == "A" && tourProduct.TransitArrivalScheduleDisplay == "Y")))
                        {
                            model.Add(D_n_n_n_THROUGH_Item);
                            model.Add(n_T_n_n_Item);
                            model.Add(n_n_W_n_Item);
                            model.Add(n_n_n_A_THROUGH_Item);
                        }
                        else if (DepartureDate == itiDate
                            && DepartureDate == D_T_DepartureDate
                            && ((DnA == "D" && tourProduct.TransitDepartureScheduleDisplay == "N") || (DnA == "A" && tourProduct.TransitArrivalScheduleDisplay == "N")))
                        {
                            n_T_n_n_Item.Description = "경유";
                            n_n_T_n_Item.Description = "경유";
                            model.Add(D_n_n_n_THROUGH_Item);
                            model.Add(n_T_n_n_Item);
                            model.Add(n_n_T_n_Item);
                            model.Add(n_n_n_A_THROUGH_Item);
                        }
                        else if (DepartureDate == itiDate && DepartureDate != D_T_DepartureDate && ((DnA == "D" && tourProduct.TransitDepartureScheduleDisplay == "N") || (DnA == "A" && tourProduct.TransitArrivalScheduleDisplay == "N")))
                        {
                            n_T_n_n_Item.Description = "경유";
                            model.Add(D_n_n_n_THROUGH_Item);
                            model.Add(n_T_n_n_Item);
                            model.Add(n_n_T_n_Item);
                            model.Add(n_n_n_A_THROUGH_Item);
                        }
                        else if (DepartureDate == itiDate && DepartureDate != D_T_DepartureDate && ((DnA == "D" && tourProduct.TransitDepartureScheduleDisplay == "Y") || (DnA == "A" && tourProduct.TransitArrivalScheduleDisplay == "Y")))
                        {
                            model.Add(D_n_n_n_THROUGH_Item);
                            model.Add(n_T_n_n_Item);
                            model.Add(n_n_T_n_Item);
                            model.Add(n_n_n_A_THROUGH_Item);
                        }
                    }
                }
            }
            if (model.Count() > 0)
            {
                return model;
            }
            return null;
        }
        public static List<Grade> RemoveDuplicateElement(List<Grade> grades)
        {
            List<Grade> newGrades = new List<Grade>();
            foreach (var item in grades)
            {
                if (newGrades.Where(x => x.Code == item.Code && x.Name == item.Name).Count() > 0)
                    continue;
                else
                    newGrades.Add(item);
            }
            return newGrades;
        }
       
    }
}