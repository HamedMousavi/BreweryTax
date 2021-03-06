﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxDataStore.UpdaterService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="ApplicationUpdater", ConfigurationName="UpdaterService.IUpdaterIpcService")]
    public interface IUpdaterIpcService {
        
        [System.ServiceModel.OperationContractAttribute(Action="ApplicationUpdater/IUpdaterIpcService/CheckForUpdates", ReplyAction="ApplicationUpdater/IUpdaterIpcService/CheckForUpdatesResponse")]
        bool CheckForUpdates();
        
        [System.ServiceModel.OperationContractAttribute(Action="ApplicationUpdater/IUpdaterIpcService/DownloadUpdates", ReplyAction="ApplicationUpdater/IUpdaterIpcService/DownloadUpdatesResponse")]
        bool DownloadUpdates();
        
        [System.ServiceModel.OperationContractAttribute(Action="ApplicationUpdater/IUpdaterIpcService/ApplyUpdates", ReplyAction="ApplicationUpdater/IUpdaterIpcService/ApplyUpdatesResponse")]
        bool ApplyUpdates();
        
        [System.ServiceModel.OperationContractAttribute(Action="ApplicationUpdater/IUpdaterIpcService/UpdateExists", ReplyAction="ApplicationUpdater/IUpdaterIpcService/UpdateExistsResponse")]
        bool UpdateExists();
        
        [System.ServiceModel.OperationContractAttribute(Action="ApplicationUpdater/IUpdaterIpcService/IsDownloadComplete", ReplyAction="ApplicationUpdater/IUpdaterIpcService/IsDownloadCompleteResponse")]
        bool IsDownloadComplete();
        
        [System.ServiceModel.OperationContractAttribute(Action="ApplicationUpdater/IUpdaterIpcService/GetStatus", ReplyAction="ApplicationUpdater/IUpdaterIpcService/GetStatusResponse")]
        int GetStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="ApplicationUpdater/IUpdaterIpcService/ReloadSettings", ReplyAction="ApplicationUpdater/IUpdaterIpcService/ReloadSettingsResponse")]
        bool ReloadSettings();
        
        [System.ServiceModel.OperationContractAttribute(Action="ApplicationUpdater/IUpdaterIpcService/GetLastCheckTimestamp", ReplyAction="ApplicationUpdater/IUpdaterIpcService/GetLastCheckTimestampResponse")]
        System.Nullable<System.DateTime> GetLastCheckTimestamp();
        
        [System.ServiceModel.OperationContractAttribute(Action="ApplicationUpdater/IUpdaterIpcService/GetNewVersionDetails", ReplyAction="ApplicationUpdater/IUpdaterIpcService/GetNewVersionDetailsResponse")]
        string GetNewVersionDetails();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUpdaterIpcServiceChannel : TaxDataStore.UpdaterService.IUpdaterIpcService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UpdaterIpcServiceClient : System.ServiceModel.ClientBase<TaxDataStore.UpdaterService.IUpdaterIpcService>, TaxDataStore.UpdaterService.IUpdaterIpcService {
        
        public UpdaterIpcServiceClient() {
        }
        
        public UpdaterIpcServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UpdaterIpcServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UpdaterIpcServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UpdaterIpcServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckForUpdates() {
            return base.Channel.CheckForUpdates();
        }
        
        public bool DownloadUpdates() {
            return base.Channel.DownloadUpdates();
        }
        
        public bool ApplyUpdates() {
            return base.Channel.ApplyUpdates();
        }
        
        public bool UpdateExists() {
            return base.Channel.UpdateExists();
        }
        
        public bool IsDownloadComplete() {
            return base.Channel.IsDownloadComplete();
        }
        
        public int GetStatus() {
            return base.Channel.GetStatus();
        }
        
        public bool ReloadSettings() {
            return base.Channel.ReloadSettings();
        }
        
        public System.Nullable<System.DateTime> GetLastCheckTimestamp() {
            return base.Channel.GetLastCheckTimestamp();
        }
        
        public string GetNewVersionDetails() {
            return base.Channel.GetNewVersionDetails();
        }
    }
}
