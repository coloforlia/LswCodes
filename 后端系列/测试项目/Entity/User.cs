//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string CloudID { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string passwordmd5 { get; set; }
        public string addr { get; set; }
        public string postcode { get; set; }
        public string bank { get; set; }
        public string branch { get; set; }
        public string cardnumber { get; set; }
        public string cardname { get; set; }
        public string weibo { get; set; }
        public string weixin { get; set; }
        public string QQ { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public Nullable<System.DateTime> regdate { get; set; }
        public string idcard { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string gender { get; set; }
        public string memo { get; set; }
        public int id { get; set; }
        public Nullable<int> areaid { get; set; }
        public string openidQQ { get; set; }
        public Nullable<bool> isEnterprise { get; set; }
        public Nullable<bool> closed { get; set; }
        public string UsCardNumber { get; set; }
        public string UsCardName { get; set; }
        public string UsBank { get; set; }
        public string HkCardNumber { get; set; }
        public string HkCardName { get; set; }
        public string HKBank { get; set; }
        public bool CS_FLAG { get; set; }
        public string tracenumber { get; set; }
        public Nullable<bool> IsTemporaryPwd { get; set; }
        public int cardnumberStatus { get; set; }
        public string TemporaryPwd { get; set; }
        public Nullable<int> LivenessScore { get; set; }
        public Nullable<int> IdType { get; set; }
    }
}
