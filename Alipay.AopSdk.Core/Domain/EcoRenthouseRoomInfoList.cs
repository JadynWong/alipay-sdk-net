using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoRenthouseRoomInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class EcoRenthouseRoomInfoList : AopObject
    {
        /// <summary>
        /// 房间参与免押金的到期日期YYYY-MM-dd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deposit_end_time")]
        public string DepositEndTime { get; set; }

        /// <summary>
        /// KA内部存储的房房间ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ka_room_id")]
        public string KaRoomId { get; set; }

        /// <summary>
        /// KA内部存储的房源编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_code")]
        public string RoomCode { get; set; }

        /// <summary>
        /// KA内部存储的房房间号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_num")]
        public string RoomNum { get; set; }
    }
}
