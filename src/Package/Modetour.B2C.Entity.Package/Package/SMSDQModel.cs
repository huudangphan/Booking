using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class SMSDQModel
    {
        /// <summary>
        /// @메시지종류  CHAR(2)='00',
        /// </summary>
        public string Kind { set; get; }
        /// <summary>
        /// @발송자   INT=0,
        /// </summary>
        public int SenderPTID { set; get; }
        /// <summary>
        /// @발송자명   VARCHAR(50)='',
        /// </summary>
        public string SenderName { set; get; }
        /// <summary>
        /// @발송자주소  VARCHAR(50)='',
        /// </summary>
        public string SenderAddress { set; get; }
        /// <summary>
        /// @제목    VARCHAR(100)='',
        /// </summary>
        public string Title { set; get; }
        /// <summary>
        /// @내용    VARCHAR(4000)='',
        /// </summary>
        public string Content { set; get; }
        /// <summary>
        /// @수신확인필요여부 CHAR(1)='N',
        /// </summary>
        public char? ReceiptFlag { set; get; }
        /// <summary>
        /// @단체번호   INT=null,
        /// </summary>
        public int PNum { set; get; }
        /// <summary>
        /// @주문번호   INT=0,
        /// </summary>
        public int OrderNo { set; get; }
        /// <summary>
        /// @첨부파일명  VARCHAR(100)='',
        /// </summary>
        public string FileName { set; get; }
        /// <summary>
        /// @수신자   INT=0,
        /// </summary>
        public int ReceiverPTID { set; get; }
        /// <summary>
        /// @수신자명   VARCHAR(50)='',
        /// </summary>
        public string ReceiverName { set; get; }
        /// <summary>
        /// @수신자주소  VARCHAR(50)='',
        /// </summary>
        public string ReceiverAddress { set; get; }
        /// <summary>
        /// @그룹수신가능여부 CHAR(1)='N',
        /// </summary>
        public char? GroupReceiveFlag { set; get; }
        /// <summary>
        /// @그룹번호   INT=0,
        /// </summary>
        public int GroupNo { set; get; }
        ///// <summary>
        ///// @메세지발송번호 INT=NULL OUTPUT,
        ///// </summary>
        //public int? No { set; get; }
        /// <summary>
        /// @LMS종류 CHAR(2) = NULL,
        /// </summary>
        public string LMSKind { set; get; }
        /// <summary>
        /// @발송동의 CHAR(1)=NULL
        /// </summary>
        public char? AgreementFlag { set; get; }
        /// <summary>
        /// @발송일  DATETIME = NULL
        /// </summary>
        public DateTime? SendDate { set; get; }
        /// <summary>
        /// @알림톡템플릿 CHAR(2) = NULL
        /// </summary>
        public string PushTemplates { set; get; }
        /// <summary>
        /// @SMS계정 VARCHAR(30) = NULL
        /// </summary>
        public string SmsAccount { set; get; }
    }
}
