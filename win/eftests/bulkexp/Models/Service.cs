using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Service
    {
        public Service()
        {
            AppointmentServiceRequests = new HashSet<AppointmentServiceRequest>();
            Checklists = new HashSet<Checklist>();
            LobbyServiceProvideds = new HashSet<LobbyServiceProvided>();
            LobbyServiceRequests = new HashSet<LobbyServiceRequest>();
            LocationServices = new HashSet<LocationService>();
            UserServices = new HashSet<UserService>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDisplayName { get; set; }
        public string ServiceDescription { get; set; }
        public bool ShowInMemberLeft { get; set; }
        public bool ShowInWrapUp { get; set; }
        public bool ShowInPhoneCenter { get; set; }
        public bool ShowInKiosk { get; set; }
        public int FkProductCategoryId { get; set; }
        public int FkServiceTypeId { get; set; }
        public bool ShowInWidget { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }
        public string ServiceCode { get; set; }
        public double ServiceTimeStandard { get; set; }
        public int Duration { get; set; }
        public byte ActiveStatus { get; set; }
        public string CheckList { get; set; }
        public bool PhoneOnlyApptsEnabled { get; set; }
        public bool RequireCustomerComments { get; set; }
        public string Prompts { get; set; }
        public bool? AddToAllUsers { get; set; }
        public int DisplaySortPosition { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual ProductCategory FkProductCategory { get; set; }
        public virtual ServiceType FkServiceType { get; set; }
        public virtual ICollection<AppointmentServiceRequest> AppointmentServiceRequests { get; set; }
        public virtual ICollection<Checklist> Checklists { get; set; }
        public virtual ICollection<LobbyServiceProvided> LobbyServiceProvideds { get; set; }
        public virtual ICollection<LobbyServiceRequest> LobbyServiceRequests { get; set; }
        public virtual ICollection<LocationService> LocationServices { get; set; }
        public virtual ICollection<UserService> UserServices { get; set; }
    }
}
