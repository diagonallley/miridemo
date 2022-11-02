﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtlMiriDemo_V1.ProfileRes
    {
    public class TheProfile
        {
        public int Issuer { get; set; }
        public int ProfileId { get; set; }
        public string MiriProfileNumber { get; set; }
        public string ProfileExpireDate { get; set; }
        public string Company { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Biometrics { get; set; }
        public string Misc { get; set; }
        public string NickName { get; set; }
        public string Address1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string AccountEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LookUpData1 { get; set; }
        public string LookUpData2 { get; set; }
        public string ResponseData1 { get; set; }
        public string ResponseData2 { get; set; }
        public string ResponseData3 { get; set; }
        public string UserPhoto { get; set; }
        public string ProfileCreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }

        }
    }
