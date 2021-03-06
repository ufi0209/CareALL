﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceTest.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddressWCF", Namespace="http://schemas.datacontract.org/2004/07/ClassLibrary.WCFClasses")]
    [System.SerializableAttribute()]
    public partial class AddressWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HouseNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IsDeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OtherInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SettlementField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipCodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AddressType {
            get {
                return this.AddressTypeField;
            }
            set {
                if ((this.AddressTypeField.Equals(value) != true)) {
                    this.AddressTypeField = value;
                    this.RaisePropertyChanged("AddressType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HouseNumber {
            get {
                return this.HouseNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.HouseNumberField, value) != true)) {
                    this.HouseNumberField = value;
                    this.RaisePropertyChanged("HouseNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IsDeleted {
            get {
                return this.IsDeletedField;
            }
            set {
                if ((this.IsDeletedField.Equals(value) != true)) {
                    this.IsDeletedField = value;
                    this.RaisePropertyChanged("IsDeleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherInformation {
            get {
                return this.OtherInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.OtherInformationField, value) != true)) {
                    this.OtherInformationField = value;
                    this.RaisePropertyChanged("OtherInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Settlement {
            get {
                return this.SettlementField;
            }
            set {
                if ((object.ReferenceEquals(this.SettlementField, value) != true)) {
                    this.SettlementField = value;
                    this.RaisePropertyChanged("Settlement");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipCodeField, value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAddress", ReplyAction="http://tempuri.org/IService1/AddAddressResponse")]
        void AddAddress(ServiceTest.ServiceReference1.AddressWCF address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAddress", ReplyAction="http://tempuri.org/IService1/AddAddressResponse")]
        System.Threading.Tasks.Task AddAddressAsync(ServiceTest.ServiceReference1.AddressWCF address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAddress", ReplyAction="http://tempuri.org/IService1/GetAddressResponse")]
        ServiceTest.ServiceReference1.AddressWCF GetAddress(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAddress", ReplyAction="http://tempuri.org/IService1/GetAddressResponse")]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference1.AddressWCF> GetAddressAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ServiceTest.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceTest.ServiceReference1.IService1>, ServiceTest.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddAddress(ServiceTest.ServiceReference1.AddressWCF address) {
            base.Channel.AddAddress(address);
        }
        
        public System.Threading.Tasks.Task AddAddressAsync(ServiceTest.ServiceReference1.AddressWCF address) {
            return base.Channel.AddAddressAsync(address);
        }
        
        public ServiceTest.ServiceReference1.AddressWCF GetAddress(int ID) {
            return base.Channel.GetAddress(ID);
        }
        
        public System.Threading.Tasks.Task<ServiceTest.ServiceReference1.AddressWCF> GetAddressAsync(int ID) {
            return base.Channel.GetAddressAsync(ID);
        }
    }
}
