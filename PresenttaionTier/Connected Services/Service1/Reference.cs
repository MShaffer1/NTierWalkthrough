﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresenttaionTier.Service1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/DataService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        PresenttaionTier.Service1.CompositeType GetDataUsingDataContract(PresenttaionTier.Service1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<PresenttaionTier.Service1.CompositeType> GetDataUsingDataContractAsync(PresenttaionTier.Service1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        DataEntityTier.NorthwindDataSet.CustomersDataTable GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.CustomersDataTable> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrders", ReplyAction="http://tempuri.org/IService1/GetOrdersResponse")]
        DataEntityTier.NorthwindDataSet.OrdersDataTable GetOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrders", ReplyAction="http://tempuri.org/IService1/GetOrdersResponse")]
        System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.OrdersDataTable> GetOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSuppliersData", ReplyAction="http://tempuri.org/IService1/GetSuppliersDataResponse")]
        DataEntityTier.NorthwindDataSet.SuppliersDataTable GetSuppliersData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSuppliersData", ReplyAction="http://tempuri.org/IService1/GetSuppliersDataResponse")]
        System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.SuppliersDataTable> GetSuppliersDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProducts", ReplyAction="http://tempuri.org/IService1/GetProductsResponse")]
        DataEntityTier.NorthwindDataSet.ProductsDataTable GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProducts", ReplyAction="http://tempuri.org/IService1/GetProductsResponse")]
        System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.ProductsDataTable> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrderDetails", ReplyAction="http://tempuri.org/IService1/GetOrderDetailsResponse")]
        DataEntityTier.NorthwindDataSet.Order_DetailsDataTable GetOrderDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrderDetails", ReplyAction="http://tempuri.org/IService1/GetOrderDetailsResponse")]
        System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.Order_DetailsDataTable> GetOrderDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCategories", ReplyAction="http://tempuri.org/IService1/GetCategoriesResponse")]
        DataEntityTier.NorthwindDataSet.CategoriesDataTable GetCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCategories", ReplyAction="http://tempuri.org/IService1/GetCategoriesResponse")]
        System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.CategoriesDataTable> GetCategoriesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : PresenttaionTier.Service1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<PresenttaionTier.Service1.IService1>, PresenttaionTier.Service1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public PresenttaionTier.Service1.CompositeType GetDataUsingDataContract(PresenttaionTier.Service1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<PresenttaionTier.Service1.CompositeType> GetDataUsingDataContractAsync(PresenttaionTier.Service1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public DataEntityTier.NorthwindDataSet.CustomersDataTable GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.CustomersDataTable> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public DataEntityTier.NorthwindDataSet.OrdersDataTable GetOrders() {
            return base.Channel.GetOrders();
        }
        
        public System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.OrdersDataTable> GetOrdersAsync() {
            return base.Channel.GetOrdersAsync();
        }
        
        public DataEntityTier.NorthwindDataSet.SuppliersDataTable GetSuppliersData() {
            return base.Channel.GetSuppliersData();
        }
        
        public System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.SuppliersDataTable> GetSuppliersDataAsync() {
            return base.Channel.GetSuppliersDataAsync();
        }
        
        public DataEntityTier.NorthwindDataSet.ProductsDataTable GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.ProductsDataTable> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public DataEntityTier.NorthwindDataSet.Order_DetailsDataTable GetOrderDetails() {
            return base.Channel.GetOrderDetails();
        }
        
        public System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.Order_DetailsDataTable> GetOrderDetailsAsync() {
            return base.Channel.GetOrderDetailsAsync();
        }
        
        public DataEntityTier.NorthwindDataSet.CategoriesDataTable GetCategories() {
            return base.Channel.GetCategories();
        }
        
        public System.Threading.Tasks.Task<DataEntityTier.NorthwindDataSet.CategoriesDataTable> GetCategoriesAsync() {
            return base.Channel.GetCategoriesAsync();
        }
    }
}
