﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfService.CompositeType GetDataUsingDataContract(WcfService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfService.CompositeType> GetDataUsingDataContractAsync(WcfService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveDB", ReplyAction="http://tempuri.org/IService1/SaveDBResponse")]
        void SaveDB(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveDB", ReplyAction="http://tempuri.org/IService1/SaveDBResponse")]
        System.Threading.Tasks.Task SaveDBAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OpenDB", ReplyAction="http://tempuri.org/IService1/OpenDBResponse")]
        void OpenDB(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OpenDB", ReplyAction="http://tempuri.org/IService1/OpenDBResponse")]
        System.Threading.Tasks.Task OpenDBAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddTable", ReplyAction="http://tempuri.org/IService1/AddTableResponse")]
        bool AddTable(string TableName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddTable", ReplyAction="http://tempuri.org/IService1/AddTableResponse")]
        System.Threading.Tasks.Task<bool> AddTableAsync(string TableName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTable", ReplyAction="http://tempuri.org/IService1/DeleteTableResponse")]
        void DeleteTable(int tind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTable", ReplyAction="http://tempuri.org/IService1/DeleteTableResponse")]
        System.Threading.Tasks.Task DeleteTableAsync(int tind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddColumn", ReplyAction="http://tempuri.org/IService1/AddColumnResponse")]
        bool AddColumn(int TableIndex, string ColumnName, string ColumnType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddColumn", ReplyAction="http://tempuri.org/IService1/AddColumnResponse")]
        System.Threading.Tasks.Task<bool> AddColumnAsync(int TableIndex, string ColumnName, string ColumnType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteColumn", ReplyAction="http://tempuri.org/IService1/DeleteColumnResponse")]
        void DeleteColumn(int tind, int cind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteColumn", ReplyAction="http://tempuri.org/IService1/DeleteColumnResponse")]
        System.Threading.Tasks.Task DeleteColumnAsync(int tind, int cind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RenameColumn", ReplyAction="http://tempuri.org/IService1/RenameColumnResponse")]
        bool RenameColumn(int TableIndex, int ColumnIndex, string newColumnName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RenameColumn", ReplyAction="http://tempuri.org/IService1/RenameColumnResponse")]
        System.Threading.Tasks.Task<bool> RenameColumnAsync(int TableIndex, int ColumnIndex, string newColumnName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddRow", ReplyAction="http://tempuri.org/IService1/AddRowResponse")]
        bool AddRow(int TableIndex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddRow", ReplyAction="http://tempuri.org/IService1/AddRowResponse")]
        System.Threading.Tasks.Task<bool> AddRowAsync(int TableIndex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRow", ReplyAction="http://tempuri.org/IService1/DeleteRowResponse")]
        void DeleteRow(int tind, int rind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRow", ReplyAction="http://tempuri.org/IService1/DeleteRowResponse")]
        System.Threading.Tasks.Task DeleteRowAsync(int tind, int rind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeValue", ReplyAction="http://tempuri.org/IService1/ChangeValueResponse")]
        bool ChangeValue(string newValue, int tind, int cind, int rind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeValue", ReplyAction="http://tempuri.org/IService1/ChangeValueResponse")]
        System.Threading.Tasks.Task<bool> ChangeValueAsync(string newValue, int tind, int cind, int rind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTableNameList", ReplyAction="http://tempuri.org/IService1/GetTableNameListResponse")]
        string[] GetTableNameList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTableNameList", ReplyAction="http://tempuri.org/IService1/GetTableNameListResponse")]
        System.Threading.Tasks.Task<string[]> GetTableNameListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCurrentDBName", ReplyAction="http://tempuri.org/IService1/GetCurrentDBNameResponse")]
        string GetCurrentDBName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCurrentDBName", ReplyAction="http://tempuri.org/IService1/GetCurrentDBNameResponse")]
        System.Threading.Tasks.Task<string> GetCurrentDBNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTable", ReplyAction="http://tempuri.org/IService1/GetTableResponse")]
        WcfService.Table GetTable(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTable", ReplyAction="http://tempuri.org/IService1/GetTableResponse")]
        System.Threading.Tasks.Task<WcfService.Table> GetTableAsync(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateDB", ReplyAction="http://tempuri.org/IService1/CreateDBResponse")]
        bool CreateDB(string DBName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateDB", ReplyAction="http://tempuri.org/IService1/CreateDBResponse")]
        System.Threading.Tasks.Task<bool> CreateDBAsync(string DBName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfClient.ServiceReference1.IService1>, WcfClient.ServiceReference1.IService1 {
        
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
        
        public WcfService.CompositeType GetDataUsingDataContract(WcfService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfService.CompositeType> GetDataUsingDataContractAsync(WcfService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public void SaveDB(string path) {
            base.Channel.SaveDB(path);
        }
        
        public System.Threading.Tasks.Task SaveDBAsync(string path) {
            return base.Channel.SaveDBAsync(path);
        }
        
        public void OpenDB(string path) {
            base.Channel.OpenDB(path);
        }
        
        public System.Threading.Tasks.Task OpenDBAsync(string path) {
            return base.Channel.OpenDBAsync(path);
        }
        
        public bool AddTable(string TableName) {
            return base.Channel.AddTable(TableName);
        }
        
        public System.Threading.Tasks.Task<bool> AddTableAsync(string TableName) {
            return base.Channel.AddTableAsync(TableName);
        }
        
        public void DeleteTable(int tind) {
            base.Channel.DeleteTable(tind);
        }
        
        public System.Threading.Tasks.Task DeleteTableAsync(int tind) {
            return base.Channel.DeleteTableAsync(tind);
        }
        
        public bool AddColumn(int TableIndex, string ColumnName, string ColumnType) {
            return base.Channel.AddColumn(TableIndex, ColumnName, ColumnType);
        }
        
        public System.Threading.Tasks.Task<bool> AddColumnAsync(int TableIndex, string ColumnName, string ColumnType) {
            return base.Channel.AddColumnAsync(TableIndex, ColumnName, ColumnType);
        }
        
        public void DeleteColumn(int tind, int cind) {
            base.Channel.DeleteColumn(tind, cind);
        }
        
        public System.Threading.Tasks.Task DeleteColumnAsync(int tind, int cind) {
            return base.Channel.DeleteColumnAsync(tind, cind);
        }
        
        public bool RenameColumn(int TableIndex, int ColumnIndex, string newColumnName) {
            return base.Channel.RenameColumn(TableIndex, ColumnIndex, newColumnName);
        }
        
        public System.Threading.Tasks.Task<bool> RenameColumnAsync(int TableIndex, int ColumnIndex, string newColumnName) {
            return base.Channel.RenameColumnAsync(TableIndex, ColumnIndex, newColumnName);
        }
        
        public bool AddRow(int TableIndex) {
            return base.Channel.AddRow(TableIndex);
        }
        
        public System.Threading.Tasks.Task<bool> AddRowAsync(int TableIndex) {
            return base.Channel.AddRowAsync(TableIndex);
        }
        
        public void DeleteRow(int tind, int rind) {
            base.Channel.DeleteRow(tind, rind);
        }
        
        public System.Threading.Tasks.Task DeleteRowAsync(int tind, int rind) {
            return base.Channel.DeleteRowAsync(tind, rind);
        }
        
        public bool ChangeValue(string newValue, int tind, int cind, int rind) {
            return base.Channel.ChangeValue(newValue, tind, cind, rind);
        }
        
        public System.Threading.Tasks.Task<bool> ChangeValueAsync(string newValue, int tind, int cind, int rind) {
            return base.Channel.ChangeValueAsync(newValue, tind, cind, rind);
        }
        
        public string[] GetTableNameList() {
            return base.Channel.GetTableNameList();
        }
        
        public System.Threading.Tasks.Task<string[]> GetTableNameListAsync() {
            return base.Channel.GetTableNameListAsync();
        }
        
        public string GetCurrentDBName() {
            return base.Channel.GetCurrentDBName();
        }
        
        public System.Threading.Tasks.Task<string> GetCurrentDBNameAsync() {
            return base.Channel.GetCurrentDBNameAsync();
        }
        
        public WcfService.Table GetTable(int index) {
            return base.Channel.GetTable(index);
        }
        
        public System.Threading.Tasks.Task<WcfService.Table> GetTableAsync(int index) {
            return base.Channel.GetTableAsync(index);
        }
        
        public bool CreateDB(string DBName) {
            return base.Channel.CreateDB(DBName);
        }
        
        public System.Threading.Tasks.Task<bool> CreateDBAsync(string DBName) {
            return base.Channel.CreateDBAsync(DBName);
        }
    }
}
