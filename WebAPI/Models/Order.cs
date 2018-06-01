using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebAPI.Models
{
    [DataContract]
    public class Order
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public bool Complete { get; set; }
        [DataMember]
        public DateTime CreationTime { get; set; }
    }
}