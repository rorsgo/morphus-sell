using System;
using System.ComponentModel.DataAnnotations;


namespace MSell.CRUDs.Share.src.ENTITY
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdate { get; set; }

    }
}
