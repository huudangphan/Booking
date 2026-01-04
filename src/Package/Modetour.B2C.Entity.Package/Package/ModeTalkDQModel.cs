using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    /// <summary>
    /// 모두톡 발송
    /// </summary>     
    public class ModeTalkDQModel
    {

        /// <summary>
        /// 메시지 타입
        /// </summary>       
        public string Type { set; get; }

        /// <summary>
        /// 메시지 종류
        /// </summary>       
        public string Kind { set; get; }


        /// <summary>
        /// 발송자번호
        /// </summary>       
        public Int32 SendPtid { set; get; }

        /// <summary>
        /// 발송자타입
        /// </summary>       
        public string SendType { set; get; }

        /// <summary>
        /// 수신자
        /// </summary>       
        public string ReceiverPtid { set; get; }


        /// <summary>
        /// 메세지내용
        /// </summary>       
        public string MsgContents { set; get; }

        /// <summary>
        /// 등록자
        /// </summary>       
        public Int32 RegPtid { set; get; }
    }
}
