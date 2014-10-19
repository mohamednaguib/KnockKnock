using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace knockknock.readify.net
{
    [DataContract(Namespace = "http://KnockKnock.readify.net")]
    public class ContactDetails
    {
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string EmailAddressField;

        private string FamilyNameField;

        private string GivenNameField;

        private string PhoneNumberField;
        private string BlogField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMember]
        public string EmailAddress
        {
            get
            {
                return this.EmailAddressField;
            }
            set
            {
                this.EmailAddressField = value;
            }
        }

        [DataMember]
        public string FamilyName
        {
            get
            {
                return this.FamilyNameField;
            }
            set
            {
                this.FamilyNameField = value;
            }
        }

        [DataMember]
        public string GivenName
        {
            get
            {
                return this.GivenNameField;
            }
            set
            {
                this.GivenNameField = value;
            }
        }

        [DataMember]
        public string Blog
        {
            get
            {
                return this.BlogField;
            }
            set
            {
                this.BlogField = value;
            }
        }


        [DataMember]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }

    }
}