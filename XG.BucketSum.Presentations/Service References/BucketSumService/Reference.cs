﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XG.BucketSum.Presentations.BucketSumService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BucketSumService.IBucketSumService")]
    public interface IBucketSumService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketSumService/GetBucketSumWeb", ReplyAction="http://tempuri.org/IBucketSumService/GetBucketSumWebResponse")]
        int[] GetBucketSumWeb(string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketSumService/GetBucketSumWeb", ReplyAction="http://tempuri.org/IBucketSumService/GetBucketSumWebResponse")]
        System.Threading.Tasks.Task<int[]> GetBucketSumWebAsync(string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketSumService/GetBucketSumConsol", ReplyAction="http://tempuri.org/IBucketSumService/GetBucketSumConsolResponse")]
        int[] GetBucketSumConsol(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketSumService/GetBucketSumConsol", ReplyAction="http://tempuri.org/IBucketSumService/GetBucketSumConsolResponse")]
        System.Threading.Tasks.Task<int[]> GetBucketSumConsolAsync(string path);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBucketSumServiceChannel : XG.BucketSum.Presentations.BucketSumService.IBucketSumService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BucketSumServiceClient : System.ServiceModel.ClientBase<XG.BucketSum.Presentations.BucketSumService.IBucketSumService>, XG.BucketSum.Presentations.BucketSumService.IBucketSumService {
        
        public BucketSumServiceClient() {
        }
        
        public BucketSumServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BucketSumServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BucketSumServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BucketSumServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int[] GetBucketSumWeb(string data) {
            return base.Channel.GetBucketSumWeb(data);
        }
        
        public System.Threading.Tasks.Task<int[]> GetBucketSumWebAsync(string data) {
            return base.Channel.GetBucketSumWebAsync(data);
        }
        
        public int[] GetBucketSumConsol(string path) {
            return base.Channel.GetBucketSumConsol(path);
        }
        
        public System.Threading.Tasks.Task<int[]> GetBucketSumConsolAsync(string path) {
            return base.Channel.GetBucketSumConsolAsync(path);
        }
    }
}
