using Puerts.TypeMapping;
using Puerts;

namespace PuertsStaticWrap
{
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class PuerRegisterInfo_Gen
    {
        
        public static RegisterInfo GetRegisterInfo_UnityEngine_Application_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Application_Wrap.Constructor
#endif
                    }},
                    {"add_lowMemory_static", new MemberRegisterInfo { Name = "add_lowMemory", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_lowMemory
#endif
                    }},
                    {"remove_lowMemory_static", new MemberRegisterInfo { Name = "remove_lowMemory", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_lowMemory
#endif
                    }},
                    {"add_logMessageReceived_static", new MemberRegisterInfo { Name = "add_logMessageReceived", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_logMessageReceived
#endif
                    }},
                    {"remove_logMessageReceived_static", new MemberRegisterInfo { Name = "remove_logMessageReceived", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_logMessageReceived
#endif
                    }},
                    {"add_logMessageReceivedThreaded_static", new MemberRegisterInfo { Name = "add_logMessageReceivedThreaded", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_logMessageReceivedThreaded
#endif
                    }},
                    {"remove_logMessageReceivedThreaded_static", new MemberRegisterInfo { Name = "remove_logMessageReceivedThreaded", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_logMessageReceivedThreaded
#endif
                    }},
                    {"add_onBeforeRender_static", new MemberRegisterInfo { Name = "add_onBeforeRender", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_onBeforeRender
#endif
                    }},
                    {"remove_onBeforeRender_static", new MemberRegisterInfo { Name = "remove_onBeforeRender", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_onBeforeRender
#endif
                    }},
                    {"add_focusChanged_static", new MemberRegisterInfo { Name = "add_focusChanged", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_focusChanged
#endif
                    }},
                    {"remove_focusChanged_static", new MemberRegisterInfo { Name = "remove_focusChanged", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_focusChanged
#endif
                    }},
                    {"add_deepLinkActivated_static", new MemberRegisterInfo { Name = "add_deepLinkActivated", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_deepLinkActivated
#endif
                    }},
                    {"remove_deepLinkActivated_static", new MemberRegisterInfo { Name = "remove_deepLinkActivated", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_deepLinkActivated
#endif
                    }},
                    {"add_wantsToQuit_static", new MemberRegisterInfo { Name = "add_wantsToQuit", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_wantsToQuit
#endif
                    }},
                    {"remove_wantsToQuit_static", new MemberRegisterInfo { Name = "remove_wantsToQuit", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_wantsToQuit
#endif
                    }},
                    {"add_quitting_static", new MemberRegisterInfo { Name = "add_quitting", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_quitting
#endif
                    }},
                    {"remove_quitting_static", new MemberRegisterInfo { Name = "remove_quitting", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_quitting
#endif
                    }},
                    {"add_unloading_static", new MemberRegisterInfo { Name = "add_unloading", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_unloading
#endif
                    }},
                    {"remove_unloading_static", new MemberRegisterInfo { Name = "remove_unloading", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_unloading
#endif
                    }},
                    {"Quit_static", new MemberRegisterInfo { Name = "Quit", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_Quit
#endif
                    }},
                    {"Unload_static", new MemberRegisterInfo { Name = "Unload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_Unload
#endif
                    }},
                    {"CanStreamedLevelBeLoaded_static", new MemberRegisterInfo { Name = "CanStreamedLevelBeLoaded", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_CanStreamedLevelBeLoaded
#endif
                    }},
                    {"IsPlaying_static", new MemberRegisterInfo { Name = "IsPlaying", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_IsPlaying
#endif
                    }},
                    {"GetBuildTags_static", new MemberRegisterInfo { Name = "GetBuildTags", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_GetBuildTags
#endif
                    }},
                    {"SetBuildTags_static", new MemberRegisterInfo { Name = "SetBuildTags", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_SetBuildTags
#endif
                    }},
                    {"HasProLicense_static", new MemberRegisterInfo { Name = "HasProLicense", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_HasProLicense
#endif
                    }},
                    {"RequestAdvertisingIdentifierAsync_static", new MemberRegisterInfo { Name = "RequestAdvertisingIdentifierAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_RequestAdvertisingIdentifierAsync
#endif
                    }},
                    {"OpenURL_static", new MemberRegisterInfo { Name = "OpenURL", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_OpenURL
#endif
                    }},
                    {"GetStackTraceLogType_static", new MemberRegisterInfo { Name = "GetStackTraceLogType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_GetStackTraceLogType
#endif
                    }},
                    {"SetStackTraceLogType_static", new MemberRegisterInfo { Name = "SetStackTraceLogType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_SetStackTraceLogType
#endif
                    }},
                    {"RequestUserAuthorization_static", new MemberRegisterInfo { Name = "RequestUserAuthorization", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_RequestUserAuthorization
#endif
                    }},
                    {"HasUserAuthorization_static", new MemberRegisterInfo { Name = "HasUserAuthorization", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_HasUserAuthorization
#endif
                    }},
                    {"isPlaying_static", new MemberRegisterInfo { Name = "isPlaying", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isPlaying
#endif
                    }},
                    {"isFocused_static", new MemberRegisterInfo { Name = "isFocused", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isFocused
#endif
                    }},
                    {"buildGUID_static", new MemberRegisterInfo { Name = "buildGUID", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_buildGUID
#endif
                    }},
                    {"runInBackground_static", new MemberRegisterInfo { Name = "runInBackground", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_runInBackground, PropertySetter = UnityEngine_Application_Wrap.S_runInBackground
#endif
                    }},
                    {"isBatchMode_static", new MemberRegisterInfo { Name = "isBatchMode", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isBatchMode
#endif
                    }},
                    {"dataPath_static", new MemberRegisterInfo { Name = "dataPath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_dataPath
#endif
                    }},
                    {"streamingAssetsPath_static", new MemberRegisterInfo { Name = "streamingAssetsPath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_streamingAssetsPath
#endif
                    }},
                    {"persistentDataPath_static", new MemberRegisterInfo { Name = "persistentDataPath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_persistentDataPath
#endif
                    }},
                    {"temporaryCachePath_static", new MemberRegisterInfo { Name = "temporaryCachePath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_temporaryCachePath
#endif
                    }},
                    {"absoluteURL_static", new MemberRegisterInfo { Name = "absoluteURL", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_absoluteURL
#endif
                    }},
                    {"unityVersion_static", new MemberRegisterInfo { Name = "unityVersion", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_unityVersion
#endif
                    }},
                    {"version_static", new MemberRegisterInfo { Name = "version", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_version
#endif
                    }},
                    {"installerName_static", new MemberRegisterInfo { Name = "installerName", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_installerName
#endif
                    }},
                    {"identifier_static", new MemberRegisterInfo { Name = "identifier", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_identifier
#endif
                    }},
                    {"installMode_static", new MemberRegisterInfo { Name = "installMode", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_installMode
#endif
                    }},
                    {"sandboxType_static", new MemberRegisterInfo { Name = "sandboxType", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_sandboxType
#endif
                    }},
                    {"productName_static", new MemberRegisterInfo { Name = "productName", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_productName
#endif
                    }},
                    {"companyName_static", new MemberRegisterInfo { Name = "companyName", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_companyName
#endif
                    }},
                    {"cloudProjectId_static", new MemberRegisterInfo { Name = "cloudProjectId", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_cloudProjectId
#endif
                    }},
                    {"targetFrameRate_static", new MemberRegisterInfo { Name = "targetFrameRate", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_targetFrameRate, PropertySetter = UnityEngine_Application_Wrap.S_targetFrameRate
#endif
                    }},
                    {"consoleLogPath_static", new MemberRegisterInfo { Name = "consoleLogPath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_consoleLogPath
#endif
                    }},
                    {"backgroundLoadingPriority_static", new MemberRegisterInfo { Name = "backgroundLoadingPriority", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_backgroundLoadingPriority, PropertySetter = UnityEngine_Application_Wrap.S_backgroundLoadingPriority
#endif
                    }},
                    {"genuine_static", new MemberRegisterInfo { Name = "genuine", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_genuine
#endif
                    }},
                    {"genuineCheckAvailable_static", new MemberRegisterInfo { Name = "genuineCheckAvailable", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_genuineCheckAvailable
#endif
                    }},
                    {"platform_static", new MemberRegisterInfo { Name = "platform", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_platform
#endif
                    }},
                    {"isMobilePlatform_static", new MemberRegisterInfo { Name = "isMobilePlatform", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isMobilePlatform
#endif
                    }},
                    {"isConsolePlatform_static", new MemberRegisterInfo { Name = "isConsolePlatform", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isConsolePlatform
#endif
                    }},
                    {"systemLanguage_static", new MemberRegisterInfo { Name = "systemLanguage", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_systemLanguage
#endif
                    }},
                    {"internetReachability_static", new MemberRegisterInfo { Name = "internetReachability", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_internetReachability
#endif
                    }},
                    {"isEditor_static", new MemberRegisterInfo { Name = "isEditor", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isEditor
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Debug_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Debug_Wrap.Constructor
#endif
                    }},
                    {"DrawLine_static", new MemberRegisterInfo { Name = "DrawLine", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_DrawLine
#endif
                    }},
                    {"DrawRay_static", new MemberRegisterInfo { Name = "DrawRay", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_DrawRay
#endif
                    }},
                    {"Break_static", new MemberRegisterInfo { Name = "Break", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_Break
#endif
                    }},
                    {"DebugBreak_static", new MemberRegisterInfo { Name = "DebugBreak", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_DebugBreak
#endif
                    }},
                    {"Log_static", new MemberRegisterInfo { Name = "Log", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_Log
#endif
                    }},
                    {"LogFormat_static", new MemberRegisterInfo { Name = "LogFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogFormat
#endif
                    }},
                    {"LogError_static", new MemberRegisterInfo { Name = "LogError", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogError
#endif
                    }},
                    {"LogErrorFormat_static", new MemberRegisterInfo { Name = "LogErrorFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogErrorFormat
#endif
                    }},
                    {"ClearDeveloperConsole_static", new MemberRegisterInfo { Name = "ClearDeveloperConsole", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_ClearDeveloperConsole
#endif
                    }},
                    {"LogException_static", new MemberRegisterInfo { Name = "LogException", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogException
#endif
                    }},
                    {"LogWarning_static", new MemberRegisterInfo { Name = "LogWarning", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogWarning
#endif
                    }},
                    {"LogWarningFormat_static", new MemberRegisterInfo { Name = "LogWarningFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogWarningFormat
#endif
                    }},
                    {"Assert_static", new MemberRegisterInfo { Name = "Assert", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_Assert
#endif
                    }},
                    {"AssertFormat_static", new MemberRegisterInfo { Name = "AssertFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_AssertFormat
#endif
                    }},
                    {"LogAssertion_static", new MemberRegisterInfo { Name = "LogAssertion", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogAssertion
#endif
                    }},
                    {"LogAssertionFormat_static", new MemberRegisterInfo { Name = "LogAssertionFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogAssertionFormat
#endif
                    }},
                    {"unityLogger_static", new MemberRegisterInfo { Name = "unityLogger", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_unityLogger
#endif
                    }},
                    {"developerConsoleVisible_static", new MemberRegisterInfo { Name = "developerConsoleVisible", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_developerConsoleVisible, PropertySetter = UnityEngine_Debug_Wrap.S_developerConsoleVisible
#endif
                    }},
                    {"isDebugBuild_static", new MemberRegisterInfo { Name = "isDebugBuild", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_isDebugBuild
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_PuertsTest_TestClass_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = PuertsTest_TestClass_Wrap.Constructor
#endif
                    }},
                    {"AddEventCallback1", new MemberRegisterInfo { Name = "AddEventCallback1", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_TestClass_Wrap.M_AddEventCallback1
#endif
                    }},
                    {"RemoveEventCallback1", new MemberRegisterInfo { Name = "RemoveEventCallback1", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_TestClass_Wrap.M_RemoveEventCallback1
#endif
                    }},
                    {"AddEventCallback2", new MemberRegisterInfo { Name = "AddEventCallback2", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_TestClass_Wrap.M_AddEventCallback2
#endif
                    }},
                    {"Trigger", new MemberRegisterInfo { Name = "Trigger", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_TestClass_Wrap.M_Trigger
#endif
                    }},
                    {"Foo", new MemberRegisterInfo { Name = "Foo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_TestClass_Wrap.M_Foo
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Vector3_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Vector3_Wrap.Constructor
#endif
                    }},
                    {"Set", new MemberRegisterInfo { Name = "Set", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_Set
#endif
                    }},
                    {"Scale", new MemberRegisterInfo { Name = "Scale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_Scale
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_GetHashCode
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_Equals
#endif
                    }},
                    {"Normalize", new MemberRegisterInfo { Name = "Normalize", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_Normalize
#endif
                    }},
                    {"op_Addition_static", new MemberRegisterInfo { Name = "op_Addition", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Addition
#endif
                    }},
                    {"op_Subtraction_static", new MemberRegisterInfo { Name = "op_Subtraction", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Subtraction
#endif
                    }},
                    {"op_UnaryNegation_static", new MemberRegisterInfo { Name = "op_UnaryNegation", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_UnaryNegation
#endif
                    }},
                    {"op_Multiply_static", new MemberRegisterInfo { Name = "op_Multiply", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Multiply
#endif
                    }},
                    {"op_Division_static", new MemberRegisterInfo { Name = "op_Division", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Division
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Inequality
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_ToString
#endif
                    }},
                    {"get_Item", new MemberRegisterInfo { Name = "get_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.GetItem
#endif
                    }},
                    {"set_Item", new MemberRegisterInfo { Name = "set_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.SetItem
#endif
                    }},
                    {"normalized", new MemberRegisterInfo { Name = "normalized", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_normalized
#endif
                    }},
                    {"magnitude", new MemberRegisterInfo { Name = "magnitude", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_magnitude
#endif
                    }},
                    {"sqrMagnitude", new MemberRegisterInfo { Name = "sqrMagnitude", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_sqrMagnitude
#endif
                    }},
                    {"x", new MemberRegisterInfo { Name = "x", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_x, PropertySetter = UnityEngine_Vector3_Wrap.S_x
#endif
                    }},
                    {"y", new MemberRegisterInfo { Name = "y", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_y, PropertySetter = UnityEngine_Vector3_Wrap.S_y
#endif
                    }},
                    {"z", new MemberRegisterInfo { Name = "z", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_z, PropertySetter = UnityEngine_Vector3_Wrap.S_z
#endif
                    }},
                    {"Slerp_static", new MemberRegisterInfo { Name = "Slerp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Slerp
#endif
                    }},
                    {"SlerpUnclamped_static", new MemberRegisterInfo { Name = "SlerpUnclamped", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_SlerpUnclamped
#endif
                    }},
                    {"OrthoNormalize_static", new MemberRegisterInfo { Name = "OrthoNormalize", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_OrthoNormalize
#endif
                    }},
                    {"RotateTowards_static", new MemberRegisterInfo { Name = "RotateTowards", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_RotateTowards
#endif
                    }},
                    {"Lerp_static", new MemberRegisterInfo { Name = "Lerp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Lerp
#endif
                    }},
                    {"LerpUnclamped_static", new MemberRegisterInfo { Name = "LerpUnclamped", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_LerpUnclamped
#endif
                    }},
                    {"MoveTowards_static", new MemberRegisterInfo { Name = "MoveTowards", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_MoveTowards
#endif
                    }},
                    {"SmoothDamp_static", new MemberRegisterInfo { Name = "SmoothDamp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_SmoothDamp
#endif
                    }},
                    {"Scale_static", new MemberRegisterInfo { Name = "Scale", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Scale
#endif
                    }},
                    {"Cross_static", new MemberRegisterInfo { Name = "Cross", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Cross
#endif
                    }},
                    {"Reflect_static", new MemberRegisterInfo { Name = "Reflect", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Reflect
#endif
                    }},
                    {"Normalize_static", new MemberRegisterInfo { Name = "Normalize", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Normalize
#endif
                    }},
                    {"Dot_static", new MemberRegisterInfo { Name = "Dot", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Dot
#endif
                    }},
                    {"Project_static", new MemberRegisterInfo { Name = "Project", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Project
#endif
                    }},
                    {"ProjectOnPlane_static", new MemberRegisterInfo { Name = "ProjectOnPlane", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_ProjectOnPlane
#endif
                    }},
                    {"Angle_static", new MemberRegisterInfo { Name = "Angle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Angle
#endif
                    }},
                    {"SignedAngle_static", new MemberRegisterInfo { Name = "SignedAngle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_SignedAngle
#endif
                    }},
                    {"Distance_static", new MemberRegisterInfo { Name = "Distance", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Distance
#endif
                    }},
                    {"ClampMagnitude_static", new MemberRegisterInfo { Name = "ClampMagnitude", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_ClampMagnitude
#endif
                    }},
                    {"Magnitude_static", new MemberRegisterInfo { Name = "Magnitude", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Magnitude
#endif
                    }},
                    {"SqrMagnitude_static", new MemberRegisterInfo { Name = "SqrMagnitude", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_SqrMagnitude
#endif
                    }},
                    {"Min_static", new MemberRegisterInfo { Name = "Min", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Min
#endif
                    }},
                    {"Max_static", new MemberRegisterInfo { Name = "Max", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Max
#endif
                    }},
                    {"zero_static", new MemberRegisterInfo { Name = "zero", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_zero
#endif
                    }},
                    {"one_static", new MemberRegisterInfo { Name = "one", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_one
#endif
                    }},
                    {"forward_static", new MemberRegisterInfo { Name = "forward", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_forward
#endif
                    }},
                    {"back_static", new MemberRegisterInfo { Name = "back", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_back
#endif
                    }},
                    {"up_static", new MemberRegisterInfo { Name = "up", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_up
#endif
                    }},
                    {"down_static", new MemberRegisterInfo { Name = "down", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_down
#endif
                    }},
                    {"left_static", new MemberRegisterInfo { Name = "left", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_left
#endif
                    }},
                    {"right_static", new MemberRegisterInfo { Name = "right", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_right
#endif
                    }},
                    {"positiveInfinity_static", new MemberRegisterInfo { Name = "positiveInfinity", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_positiveInfinity
#endif
                    }},
                    {"negativeInfinity_static", new MemberRegisterInfo { Name = "negativeInfinity", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_negativeInfinity
#endif
                    }},
                    {"kEpsilon_static", new MemberRegisterInfo { Name = "kEpsilon", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_kEpsilon
#endif
                    }},
                    {"kEpsilonNormalSqrt_static", new MemberRegisterInfo { Name = "kEpsilonNormalSqrt", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_kEpsilonNormalSqrt
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_System_Collections_Generic_List_1_System_Int32__Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = System_Collections_Generic_List_1_System_Int32__Wrap.Constructor
#endif
                    }},
                    {"Add", new MemberRegisterInfo { Name = "Add", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_Add
#endif
                    }},
                    {"AddRange", new MemberRegisterInfo { Name = "AddRange", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_AddRange
#endif
                    }},
                    {"AsReadOnly", new MemberRegisterInfo { Name = "AsReadOnly", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_AsReadOnly
#endif
                    }},
                    {"BinarySearch", new MemberRegisterInfo { Name = "BinarySearch", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_BinarySearch
#endif
                    }},
                    {"Clear", new MemberRegisterInfo { Name = "Clear", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_Clear
#endif
                    }},
                    {"Contains", new MemberRegisterInfo { Name = "Contains", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_Contains
#endif
                    }},
                    {"CopyTo", new MemberRegisterInfo { Name = "CopyTo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_CopyTo
#endif
                    }},
                    {"Exists", new MemberRegisterInfo { Name = "Exists", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_Exists
#endif
                    }},
                    {"Find", new MemberRegisterInfo { Name = "Find", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_Find
#endif
                    }},
                    {"FindAll", new MemberRegisterInfo { Name = "FindAll", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_FindAll
#endif
                    }},
                    {"FindIndex", new MemberRegisterInfo { Name = "FindIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_FindIndex
#endif
                    }},
                    {"FindLast", new MemberRegisterInfo { Name = "FindLast", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_FindLast
#endif
                    }},
                    {"FindLastIndex", new MemberRegisterInfo { Name = "FindLastIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_FindLastIndex
#endif
                    }},
                    {"ForEach", new MemberRegisterInfo { Name = "ForEach", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_ForEach
#endif
                    }},
                    {"GetEnumerator", new MemberRegisterInfo { Name = "GetEnumerator", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_GetEnumerator
#endif
                    }},
                    {"GetRange", new MemberRegisterInfo { Name = "GetRange", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_GetRange
#endif
                    }},
                    {"IndexOf", new MemberRegisterInfo { Name = "IndexOf", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_IndexOf
#endif
                    }},
                    {"Insert", new MemberRegisterInfo { Name = "Insert", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_Insert
#endif
                    }},
                    {"InsertRange", new MemberRegisterInfo { Name = "InsertRange", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_InsertRange
#endif
                    }},
                    {"LastIndexOf", new MemberRegisterInfo { Name = "LastIndexOf", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_LastIndexOf
#endif
                    }},
                    {"Remove", new MemberRegisterInfo { Name = "Remove", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_Remove
#endif
                    }},
                    {"RemoveAll", new MemberRegisterInfo { Name = "RemoveAll", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_RemoveAll
#endif
                    }},
                    {"RemoveAt", new MemberRegisterInfo { Name = "RemoveAt", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_RemoveAt
#endif
                    }},
                    {"RemoveRange", new MemberRegisterInfo { Name = "RemoveRange", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_RemoveRange
#endif
                    }},
                    {"Reverse", new MemberRegisterInfo { Name = "Reverse", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_Reverse
#endif
                    }},
                    {"Sort", new MemberRegisterInfo { Name = "Sort", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_Sort
#endif
                    }},
                    {"ToArray", new MemberRegisterInfo { Name = "ToArray", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_ToArray
#endif
                    }},
                    {"TrimExcess", new MemberRegisterInfo { Name = "TrimExcess", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_TrimExcess
#endif
                    }},
                    {"TrueForAll", new MemberRegisterInfo { Name = "TrueForAll", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.M_TrueForAll
#endif
                    }},
                    {"Capacity", new MemberRegisterInfo { Name = "Capacity", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Collections_Generic_List_1_System_Int32__Wrap.G_Capacity, PropertySetter = System_Collections_Generic_List_1_System_Int32__Wrap.S_Capacity
#endif
                    }},
                    {"Count", new MemberRegisterInfo { Name = "Count", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Collections_Generic_List_1_System_Int32__Wrap.G_Count
#endif
                    }},
                    {"get_Item", new MemberRegisterInfo { Name = "get_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.GetItem
#endif
                    }},
                    {"set_Item", new MemberRegisterInfo { Name = "set_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_List_1_System_Int32__Wrap.SetItem
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.Constructor
#endif
                    }},
                    {"Add", new MemberRegisterInfo { Name = "Add", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_Add
#endif
                    }},
                    {"Clear", new MemberRegisterInfo { Name = "Clear", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_Clear
#endif
                    }},
                    {"ContainsKey", new MemberRegisterInfo { Name = "ContainsKey", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_ContainsKey
#endif
                    }},
                    {"ContainsValue", new MemberRegisterInfo { Name = "ContainsValue", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_ContainsValue
#endif
                    }},
                    {"GetEnumerator", new MemberRegisterInfo { Name = "GetEnumerator", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_GetEnumerator
#endif
                    }},
                    {"GetObjectData", new MemberRegisterInfo { Name = "GetObjectData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_GetObjectData
#endif
                    }},
                    {"OnDeserialization", new MemberRegisterInfo { Name = "OnDeserialization", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_OnDeserialization
#endif
                    }},
                    {"Remove", new MemberRegisterInfo { Name = "Remove", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_Remove
#endif
                    }},
                    {"TryGetValue", new MemberRegisterInfo { Name = "TryGetValue", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_TryGetValue
#endif
                    }},
                    {"TryAdd", new MemberRegisterInfo { Name = "TryAdd", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.DontBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    
#endif
                    }},
                    {"EnsureCapacity", new MemberRegisterInfo { Name = "EnsureCapacity", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_EnsureCapacity
#endif
                    }},
                    {"TrimExcess", new MemberRegisterInfo { Name = "TrimExcess", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.M_TrimExcess
#endif
                    }},
                    {"Comparer", new MemberRegisterInfo { Name = "Comparer", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.G_Comparer
#endif
                    }},
                    {"Count", new MemberRegisterInfo { Name = "Count", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.G_Count
#endif
                    }},
                    {"Keys", new MemberRegisterInfo { Name = "Keys", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.G_Keys
#endif
                    }},
                    {"Values", new MemberRegisterInfo { Name = "Values", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.G_Values
#endif
                    }},
                    {"get_Item", new MemberRegisterInfo { Name = "get_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.GetItem
#endif
                    }},
                    {"set_Item", new MemberRegisterInfo { Name = "set_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap.SetItem
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_PuertsTest_BaseClass_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = PuertsTest_BaseClass_Wrap.Constructor
#endif
                    }},
                    {"BMFunc", new MemberRegisterInfo { Name = "BMFunc", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_BaseClass_Wrap.M_BMFunc
#endif
                    }},
                    {"PlainExtension", new MemberRegisterInfo { Name = "PlainExtension", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_BaseClass_Wrap.M_PlainExtension
#endif
                    }},
                    {"Extension1", new MemberRegisterInfo { Name = "Extension1", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_BaseClass_Wrap.M_Extension1
#endif
                    }},
                    {"Extension2", new MemberRegisterInfo { Name = "Extension2", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_BaseClass_Wrap.M_Extension2
#endif
                    }},
                    {"BMF", new MemberRegisterInfo { Name = "BMF", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = PuertsTest_BaseClass_Wrap.G_BMF, PropertySetter = PuertsTest_BaseClass_Wrap.S_BMF
#endif
                    }},
                    {"BSFunc_static", new MemberRegisterInfo { Name = "BSFunc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_BaseClass_Wrap.F_BSFunc
#endif
                    }},
                    {"BSF_static", new MemberRegisterInfo { Name = "BSF", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = PuertsTest_BaseClass_Wrap.G_BSF, PropertySetter = PuertsTest_BaseClass_Wrap.S_BSF
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_PuertsTest_DerivedClass_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = PuertsTest_DerivedClass_Wrap.Constructor
#endif
                    }},
                    {"DMFunc", new MemberRegisterInfo { Name = "DMFunc", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.M_DMFunc
#endif
                    }},
                    {"Trigger", new MemberRegisterInfo { Name = "Trigger", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.M_Trigger
#endif
                    }},
                    {"ParamsFunc", new MemberRegisterInfo { Name = "ParamsFunc", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.M_ParamsFunc
#endif
                    }},
                    {"InOutArgFunc", new MemberRegisterInfo { Name = "InOutArgFunc", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.M_InOutArgFunc
#endif
                    }},
                    {"PrintList", new MemberRegisterInfo { Name = "PrintList", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.M_PrintList
#endif
                    }},
                    {"PrintArray", new MemberRegisterInfo { Name = "PrintArray", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.M_PrintArray
#endif
                    }},
                    {"GetAb", new MemberRegisterInfo { Name = "GetAb", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.M_GetAb
#endif
                    }},
                    {"SumOfAb", new MemberRegisterInfo { Name = "SumOfAb", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.M_SumOfAb
#endif
                    }},
                    {"GetFileLength", new MemberRegisterInfo { Name = "GetFileLength", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.M_GetFileLength
#endif
                    }},
                    {"add_MyEvent", new MemberRegisterInfo { Name = "add_MyEvent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.A_MyEvent
#endif
                    }},
                    {"remove_MyEvent", new MemberRegisterInfo { Name = "remove_MyEvent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.R_MyEvent
#endif
                    }},
                    {"add_MyStaticEvent_static", new MemberRegisterInfo { Name = "add_MyStaticEvent", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.A_MyStaticEvent
#endif
                    }},
                    {"remove_MyStaticEvent_static", new MemberRegisterInfo { Name = "remove_MyStaticEvent", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.R_MyStaticEvent
#endif
                    }},
                    {"DMF", new MemberRegisterInfo { Name = "DMF", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = PuertsTest_DerivedClass_Wrap.G_DMF, PropertySetter = PuertsTest_DerivedClass_Wrap.S_DMF
#endif
                    }},
                    {"MyCallback", new MemberRegisterInfo { Name = "MyCallback", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = PuertsTest_DerivedClass_Wrap.G_MyCallback, PropertySetter = PuertsTest_DerivedClass_Wrap.S_MyCallback
#endif
                    }},
                    {"DSFunc_static", new MemberRegisterInfo { Name = "DSFunc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_DerivedClass_Wrap.F_DSFunc
#endif
                    }},
                    {"DSF_static", new MemberRegisterInfo { Name = "DSF", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = PuertsTest_DerivedClass_Wrap.G_DSF, PropertySetter = PuertsTest_DerivedClass_Wrap.S_DSF
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_PuertsTest_BaseClassExtension_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"PlainExtension_static", new MemberRegisterInfo { Name = "PlainExtension", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_BaseClassExtension_Wrap.F_PlainExtension
#endif
                    }},
                    {"Extension1_static", new MemberRegisterInfo { Name = "Extension1", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_BaseClassExtension_Wrap.F_Extension1
#endif
                    }},
                    {"Extension2_static", new MemberRegisterInfo { Name = "Extension2", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsTest_BaseClassExtension_Wrap.F_Extension2
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Time_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Time_Wrap.Constructor
#endif
                    }},
                    {"time_static", new MemberRegisterInfo { Name = "time", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_time
#endif
                    }},
                    {"timeAsDouble_static", new MemberRegisterInfo { Name = "timeAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_timeAsDouble
#endif
                    }},
                    {"timeSinceLevelLoad_static", new MemberRegisterInfo { Name = "timeSinceLevelLoad", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_timeSinceLevelLoad
#endif
                    }},
                    {"timeSinceLevelLoadAsDouble_static", new MemberRegisterInfo { Name = "timeSinceLevelLoadAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_timeSinceLevelLoadAsDouble
#endif
                    }},
                    {"deltaTime_static", new MemberRegisterInfo { Name = "deltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_deltaTime
#endif
                    }},
                    {"fixedTime_static", new MemberRegisterInfo { Name = "fixedTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedTime
#endif
                    }},
                    {"fixedTimeAsDouble_static", new MemberRegisterInfo { Name = "fixedTimeAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedTimeAsDouble
#endif
                    }},
                    {"unscaledTime_static", new MemberRegisterInfo { Name = "unscaledTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_unscaledTime
#endif
                    }},
                    {"unscaledTimeAsDouble_static", new MemberRegisterInfo { Name = "unscaledTimeAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_unscaledTimeAsDouble
#endif
                    }},
                    {"fixedUnscaledTime_static", new MemberRegisterInfo { Name = "fixedUnscaledTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedUnscaledTime
#endif
                    }},
                    {"fixedUnscaledTimeAsDouble_static", new MemberRegisterInfo { Name = "fixedUnscaledTimeAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedUnscaledTimeAsDouble
#endif
                    }},
                    {"unscaledDeltaTime_static", new MemberRegisterInfo { Name = "unscaledDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_unscaledDeltaTime
#endif
                    }},
                    {"fixedUnscaledDeltaTime_static", new MemberRegisterInfo { Name = "fixedUnscaledDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedUnscaledDeltaTime
#endif
                    }},
                    {"fixedDeltaTime_static", new MemberRegisterInfo { Name = "fixedDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedDeltaTime, PropertySetter = UnityEngine_Time_Wrap.S_fixedDeltaTime
#endif
                    }},
                    {"maximumDeltaTime_static", new MemberRegisterInfo { Name = "maximumDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_maximumDeltaTime, PropertySetter = UnityEngine_Time_Wrap.S_maximumDeltaTime
#endif
                    }},
                    {"smoothDeltaTime_static", new MemberRegisterInfo { Name = "smoothDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_smoothDeltaTime
#endif
                    }},
                    {"maximumParticleDeltaTime_static", new MemberRegisterInfo { Name = "maximumParticleDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_maximumParticleDeltaTime, PropertySetter = UnityEngine_Time_Wrap.S_maximumParticleDeltaTime
#endif
                    }},
                    {"timeScale_static", new MemberRegisterInfo { Name = "timeScale", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_timeScale, PropertySetter = UnityEngine_Time_Wrap.S_timeScale
#endif
                    }},
                    {"frameCount_static", new MemberRegisterInfo { Name = "frameCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_frameCount
#endif
                    }},
                    {"renderedFrameCount_static", new MemberRegisterInfo { Name = "renderedFrameCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_renderedFrameCount
#endif
                    }},
                    {"realtimeSinceStartup_static", new MemberRegisterInfo { Name = "realtimeSinceStartup", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_realtimeSinceStartup
#endif
                    }},
                    {"realtimeSinceStartupAsDouble_static", new MemberRegisterInfo { Name = "realtimeSinceStartupAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_realtimeSinceStartupAsDouble
#endif
                    }},
                    {"captureDeltaTime_static", new MemberRegisterInfo { Name = "captureDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_captureDeltaTime, PropertySetter = UnityEngine_Time_Wrap.S_captureDeltaTime
#endif
                    }},
                    {"captureFramerate_static", new MemberRegisterInfo { Name = "captureFramerate", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_captureFramerate, PropertySetter = UnityEngine_Time_Wrap.S_captureFramerate
#endif
                    }},
                    {"inFixedTimeStep_static", new MemberRegisterInfo { Name = "inFixedTimeStep", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_inFixedTimeStep
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Transform_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"SetParent", new MemberRegisterInfo { Name = "SetParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetParent
#endif
                    }},
                    {"SetPositionAndRotation", new MemberRegisterInfo { Name = "SetPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetPositionAndRotation
#endif
                    }},
                    {"SetLocalPositionAndRotation", new MemberRegisterInfo { Name = "SetLocalPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetLocalPositionAndRotation
#endif
                    }},
                    {"GetPositionAndRotation", new MemberRegisterInfo { Name = "GetPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetPositionAndRotation
#endif
                    }},
                    {"GetLocalPositionAndRotation", new MemberRegisterInfo { Name = "GetLocalPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetLocalPositionAndRotation
#endif
                    }},
                    {"Translate", new MemberRegisterInfo { Name = "Translate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_Translate
#endif
                    }},
                    {"Rotate", new MemberRegisterInfo { Name = "Rotate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_Rotate
#endif
                    }},
                    {"RotateAround", new MemberRegisterInfo { Name = "RotateAround", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_RotateAround
#endif
                    }},
                    {"LookAt", new MemberRegisterInfo { Name = "LookAt", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_LookAt
#endif
                    }},
                    {"TransformDirection", new MemberRegisterInfo { Name = "TransformDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_TransformDirection
#endif
                    }},
                    {"InverseTransformDirection", new MemberRegisterInfo { Name = "InverseTransformDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_InverseTransformDirection
#endif
                    }},
                    {"TransformVector", new MemberRegisterInfo { Name = "TransformVector", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_TransformVector
#endif
                    }},
                    {"InverseTransformVector", new MemberRegisterInfo { Name = "InverseTransformVector", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_InverseTransformVector
#endif
                    }},
                    {"TransformPoint", new MemberRegisterInfo { Name = "TransformPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_TransformPoint
#endif
                    }},
                    {"InverseTransformPoint", new MemberRegisterInfo { Name = "InverseTransformPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_InverseTransformPoint
#endif
                    }},
                    {"DetachChildren", new MemberRegisterInfo { Name = "DetachChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_DetachChildren
#endif
                    }},
                    {"SetAsFirstSibling", new MemberRegisterInfo { Name = "SetAsFirstSibling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetAsFirstSibling
#endif
                    }},
                    {"SetAsLastSibling", new MemberRegisterInfo { Name = "SetAsLastSibling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetAsLastSibling
#endif
                    }},
                    {"SetSiblingIndex", new MemberRegisterInfo { Name = "SetSiblingIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetSiblingIndex
#endif
                    }},
                    {"GetSiblingIndex", new MemberRegisterInfo { Name = "GetSiblingIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetSiblingIndex
#endif
                    }},
                    {"Find", new MemberRegisterInfo { Name = "Find", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_Find
#endif
                    }},
                    {"IsChildOf", new MemberRegisterInfo { Name = "IsChildOf", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_IsChildOf
#endif
                    }},
                    {"GetEnumerator", new MemberRegisterInfo { Name = "GetEnumerator", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetEnumerator
#endif
                    }},
                    {"GetChild", new MemberRegisterInfo { Name = "GetChild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetChild
#endif
                    }},
                    {"position", new MemberRegisterInfo { Name = "position", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_position, PropertySetter = UnityEngine_Transform_Wrap.S_position
#endif
                    }},
                    {"localPosition", new MemberRegisterInfo { Name = "localPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localPosition, PropertySetter = UnityEngine_Transform_Wrap.S_localPosition
#endif
                    }},
                    {"eulerAngles", new MemberRegisterInfo { Name = "eulerAngles", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_eulerAngles, PropertySetter = UnityEngine_Transform_Wrap.S_eulerAngles
#endif
                    }},
                    {"localEulerAngles", new MemberRegisterInfo { Name = "localEulerAngles", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localEulerAngles, PropertySetter = UnityEngine_Transform_Wrap.S_localEulerAngles
#endif
                    }},
                    {"right", new MemberRegisterInfo { Name = "right", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_right, PropertySetter = UnityEngine_Transform_Wrap.S_right
#endif
                    }},
                    {"up", new MemberRegisterInfo { Name = "up", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_up, PropertySetter = UnityEngine_Transform_Wrap.S_up
#endif
                    }},
                    {"forward", new MemberRegisterInfo { Name = "forward", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_forward, PropertySetter = UnityEngine_Transform_Wrap.S_forward
#endif
                    }},
                    {"rotation", new MemberRegisterInfo { Name = "rotation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_rotation, PropertySetter = UnityEngine_Transform_Wrap.S_rotation
#endif
                    }},
                    {"localRotation", new MemberRegisterInfo { Name = "localRotation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localRotation, PropertySetter = UnityEngine_Transform_Wrap.S_localRotation
#endif
                    }},
                    {"localScale", new MemberRegisterInfo { Name = "localScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localScale, PropertySetter = UnityEngine_Transform_Wrap.S_localScale
#endif
                    }},
                    {"parent", new MemberRegisterInfo { Name = "parent", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_parent, PropertySetter = UnityEngine_Transform_Wrap.S_parent
#endif
                    }},
                    {"worldToLocalMatrix", new MemberRegisterInfo { Name = "worldToLocalMatrix", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_worldToLocalMatrix
#endif
                    }},
                    {"localToWorldMatrix", new MemberRegisterInfo { Name = "localToWorldMatrix", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localToWorldMatrix
#endif
                    }},
                    {"root", new MemberRegisterInfo { Name = "root", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_root
#endif
                    }},
                    {"childCount", new MemberRegisterInfo { Name = "childCount", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_childCount
#endif
                    }},
                    {"lossyScale", new MemberRegisterInfo { Name = "lossyScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_lossyScale
#endif
                    }},
                    {"hasChanged", new MemberRegisterInfo { Name = "hasChanged", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_hasChanged, PropertySetter = UnityEngine_Transform_Wrap.S_hasChanged
#endif
                    }},
                    {"hierarchyCapacity", new MemberRegisterInfo { Name = "hierarchyCapacity", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_hierarchyCapacity, PropertySetter = UnityEngine_Transform_Wrap.S_hierarchyCapacity
#endif
                    }},
                    {"hierarchyCount", new MemberRegisterInfo { Name = "hierarchyCount", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_hierarchyCount
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Component_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Component_Wrap.Constructor
#endif
                    }},
                    {"GetComponent", new MemberRegisterInfo { Name = "GetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponent
#endif
                    }},
                    {"TryGetComponent", new MemberRegisterInfo { Name = "TryGetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_TryGetComponent
#endif
                    }},
                    {"GetComponentInChildren", new MemberRegisterInfo { Name = "GetComponentInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponentInChildren
#endif
                    }},
                    {"GetComponentsInChildren", new MemberRegisterInfo { Name = "GetComponentsInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponentsInChildren
#endif
                    }},
                    {"GetComponentInParent", new MemberRegisterInfo { Name = "GetComponentInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponentInParent
#endif
                    }},
                    {"GetComponentsInParent", new MemberRegisterInfo { Name = "GetComponentsInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponentsInParent
#endif
                    }},
                    {"GetComponents", new MemberRegisterInfo { Name = "GetComponents", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponents
#endif
                    }},
                    {"CompareTag", new MemberRegisterInfo { Name = "CompareTag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_CompareTag
#endif
                    }},
                    {"SendMessageUpwards", new MemberRegisterInfo { Name = "SendMessageUpwards", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_SendMessageUpwards
#endif
                    }},
                    {"SendMessage", new MemberRegisterInfo { Name = "SendMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_SendMessage
#endif
                    }},
                    {"BroadcastMessage", new MemberRegisterInfo { Name = "BroadcastMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_BroadcastMessage
#endif
                    }},
                    {"transform", new MemberRegisterInfo { Name = "transform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Component_Wrap.G_transform
#endif
                    }},
                    {"gameObject", new MemberRegisterInfo { Name = "gameObject", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Component_Wrap.G_gameObject
#endif
                    }},
                    {"tag", new MemberRegisterInfo { Name = "tag", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Component_Wrap.G_tag, PropertySetter = UnityEngine_Component_Wrap.S_tag
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_GameObject_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_GameObject_Wrap.Constructor
#endif
                    }},
                    {"GetComponent", new MemberRegisterInfo { Name = "GetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponent
#endif
                    }},
                    {"GetComponentInChildren", new MemberRegisterInfo { Name = "GetComponentInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentInChildren
#endif
                    }},
                    {"GetComponentInParent", new MemberRegisterInfo { Name = "GetComponentInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentInParent
#endif
                    }},
                    {"GetComponents", new MemberRegisterInfo { Name = "GetComponents", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponents
#endif
                    }},
                    {"GetComponentsInChildren", new MemberRegisterInfo { Name = "GetComponentsInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentsInChildren
#endif
                    }},
                    {"GetComponentsInParent", new MemberRegisterInfo { Name = "GetComponentsInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentsInParent
#endif
                    }},
                    {"TryGetComponent", new MemberRegisterInfo { Name = "TryGetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_TryGetComponent
#endif
                    }},
                    {"SendMessageUpwards", new MemberRegisterInfo { Name = "SendMessageUpwards", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_SendMessageUpwards
#endif
                    }},
                    {"SendMessage", new MemberRegisterInfo { Name = "SendMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_SendMessage
#endif
                    }},
                    {"BroadcastMessage", new MemberRegisterInfo { Name = "BroadcastMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_BroadcastMessage
#endif
                    }},
                    {"AddComponent", new MemberRegisterInfo { Name = "AddComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_AddComponent
#endif
                    }},
                    {"SetActive", new MemberRegisterInfo { Name = "SetActive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_SetActive
#endif
                    }},
                    {"CompareTag", new MemberRegisterInfo { Name = "CompareTag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_CompareTag
#endif
                    }},
                    {"transform", new MemberRegisterInfo { Name = "transform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_transform
#endif
                    }},
                    {"layer", new MemberRegisterInfo { Name = "layer", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_layer, PropertySetter = UnityEngine_GameObject_Wrap.S_layer
#endif
                    }},
                    {"activeSelf", new MemberRegisterInfo { Name = "activeSelf", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_activeSelf
#endif
                    }},
                    {"activeInHierarchy", new MemberRegisterInfo { Name = "activeInHierarchy", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_activeInHierarchy
#endif
                    }},
                    {"isStatic", new MemberRegisterInfo { Name = "isStatic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_isStatic, PropertySetter = UnityEngine_GameObject_Wrap.S_isStatic
#endif
                    }},
                    {"tag", new MemberRegisterInfo { Name = "tag", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_tag, PropertySetter = UnityEngine_GameObject_Wrap.S_tag
#endif
                    }},
                    {"scene", new MemberRegisterInfo { Name = "scene", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_scene
#endif
                    }},
                    {"sceneCullingMask", new MemberRegisterInfo { Name = "sceneCullingMask", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_sceneCullingMask
#endif
                    }},
                    {"gameObject", new MemberRegisterInfo { Name = "gameObject", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_gameObject
#endif
                    }},
                    {"CreatePrimitive_static", new MemberRegisterInfo { Name = "CreatePrimitive", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_CreatePrimitive
#endif
                    }},
                    {"FindWithTag_static", new MemberRegisterInfo { Name = "FindWithTag", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_FindWithTag
#endif
                    }},
                    {"FindGameObjectWithTag_static", new MemberRegisterInfo { Name = "FindGameObjectWithTag", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_FindGameObjectWithTag
#endif
                    }},
                    {"FindGameObjectsWithTag_static", new MemberRegisterInfo { Name = "FindGameObjectsWithTag", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_FindGameObjectsWithTag
#endif
                    }},
                    {"Find_static", new MemberRegisterInfo { Name = "Find", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_Find
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Object_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Object_Wrap.Constructor
#endif
                    }},
                    {"GetInstanceID", new MemberRegisterInfo { Name = "GetInstanceID", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.M_GetInstanceID
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.M_GetHashCode
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.M_Equals
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.M_ToString
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.O_op_Inequality
#endif
                    }},
                    {"name", new MemberRegisterInfo { Name = "name", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Object_Wrap.G_name, PropertySetter = UnityEngine_Object_Wrap.S_name
#endif
                    }},
                    {"hideFlags", new MemberRegisterInfo { Name = "hideFlags", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Object_Wrap.G_hideFlags, PropertySetter = UnityEngine_Object_Wrap.S_hideFlags
#endif
                    }},
                    {"Instantiate_static", new MemberRegisterInfo { Name = "Instantiate", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_Instantiate
#endif
                    }},
                    {"Destroy_static", new MemberRegisterInfo { Name = "Destroy", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_Destroy
#endif
                    }},
                    {"DestroyImmediate_static", new MemberRegisterInfo { Name = "DestroyImmediate", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_DestroyImmediate
#endif
                    }},
                    {"FindObjectsOfType_static", new MemberRegisterInfo { Name = "FindObjectsOfType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindObjectsOfType
#endif
                    }},
                    {"FindObjectsByType_static", new MemberRegisterInfo { Name = "FindObjectsByType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindObjectsByType
#endif
                    }},
                    {"DontDestroyOnLoad_static", new MemberRegisterInfo { Name = "DontDestroyOnLoad", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_DontDestroyOnLoad
#endif
                    }},
                    {"FindObjectOfType_static", new MemberRegisterInfo { Name = "FindObjectOfType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindObjectOfType
#endif
                    }},
                    {"FindFirstObjectByType_static", new MemberRegisterInfo { Name = "FindFirstObjectByType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindFirstObjectByType
#endif
                    }},
                    {"FindAnyObjectByType_static", new MemberRegisterInfo { Name = "FindAnyObjectByType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindAnyObjectByType
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_System_Delegate_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"DynamicInvoke", new MemberRegisterInfo { Name = "DynamicInvoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_DynamicInvoke
#endif
                    }},
                    {"Clone", new MemberRegisterInfo { Name = "Clone", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_Clone
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_Equals
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_GetHashCode
#endif
                    }},
                    {"GetObjectData", new MemberRegisterInfo { Name = "GetObjectData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_GetObjectData
#endif
                    }},
                    {"GetInvocationList", new MemberRegisterInfo { Name = "GetInvocationList", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_GetInvocationList
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.O_op_Inequality
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Delegate_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Delegate_Wrap.G_Target
#endif
                    }},
                    {"CreateDelegate_static", new MemberRegisterInfo { Name = "CreateDelegate", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.F_CreateDelegate
#endif
                    }},
                    {"Combine_static", new MemberRegisterInfo { Name = "Combine", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.F_Combine
#endif
                    }},
                    {"Remove_static", new MemberRegisterInfo { Name = "Remove", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.F_Remove
#endif
                    }},
                    {"RemoveAll_static", new MemberRegisterInfo { Name = "RemoveAll", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.F_RemoveAll
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_System_Object_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = System_Object_Wrap.Constructor
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.M_Equals
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.M_GetHashCode
#endif
                    }},
                    {"GetType", new MemberRegisterInfo { Name = "GetType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.M_GetType
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.M_ToString
#endif
                    }},
                    {"Equals_static", new MemberRegisterInfo { Name = "Equals", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.F_Equals
#endif
                    }},
                    {"ReferenceEquals_static", new MemberRegisterInfo { Name = "ReferenceEquals", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.F_ReferenceEquals
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_System_Type_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"IsEnumDefined", new MemberRegisterInfo { Name = "IsEnumDefined", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_IsEnumDefined
#endif
                    }},
                    {"GetEnumName", new MemberRegisterInfo { Name = "GetEnumName", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetEnumName
#endif
                    }},
                    {"GetEnumNames", new MemberRegisterInfo { Name = "GetEnumNames", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetEnumNames
#endif
                    }},
                    {"FindInterfaces", new MemberRegisterInfo { Name = "FindInterfaces", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_FindInterfaces
#endif
                    }},
                    {"FindMembers", new MemberRegisterInfo { Name = "FindMembers", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_FindMembers
#endif
                    }},
                    {"IsSubclassOf", new MemberRegisterInfo { Name = "IsSubclassOf", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_IsSubclassOf
#endif
                    }},
                    {"IsAssignableFrom", new MemberRegisterInfo { Name = "IsAssignableFrom", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_IsAssignableFrom
#endif
                    }},
                    {"GetType", new MemberRegisterInfo { Name = "GetType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetType
#endif
                    }},
                    {"GetElementType", new MemberRegisterInfo { Name = "GetElementType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetElementType
#endif
                    }},
                    {"GetArrayRank", new MemberRegisterInfo { Name = "GetArrayRank", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetArrayRank
#endif
                    }},
                    {"GetGenericTypeDefinition", new MemberRegisterInfo { Name = "GetGenericTypeDefinition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetGenericTypeDefinition
#endif
                    }},
                    {"GetGenericArguments", new MemberRegisterInfo { Name = "GetGenericArguments", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetGenericArguments
#endif
                    }},
                    {"GetGenericParameterConstraints", new MemberRegisterInfo { Name = "GetGenericParameterConstraints", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetGenericParameterConstraints
#endif
                    }},
                    {"GetConstructor", new MemberRegisterInfo { Name = "GetConstructor", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetConstructor
#endif
                    }},
                    {"GetConstructors", new MemberRegisterInfo { Name = "GetConstructors", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetConstructors
#endif
                    }},
                    {"GetEvent", new MemberRegisterInfo { Name = "GetEvent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetEvent
#endif
                    }},
                    {"GetEvents", new MemberRegisterInfo { Name = "GetEvents", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetEvents
#endif
                    }},
                    {"GetField", new MemberRegisterInfo { Name = "GetField", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetField
#endif
                    }},
                    {"GetFields", new MemberRegisterInfo { Name = "GetFields", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetFields
#endif
                    }},
                    {"GetMember", new MemberRegisterInfo { Name = "GetMember", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetMember
#endif
                    }},
                    {"GetMembers", new MemberRegisterInfo { Name = "GetMembers", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetMembers
#endif
                    }},
                    {"GetMethod", new MemberRegisterInfo { Name = "GetMethod", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetMethod
#endif
                    }},
                    {"GetMethods", new MemberRegisterInfo { Name = "GetMethods", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetMethods
#endif
                    }},
                    {"GetNestedType", new MemberRegisterInfo { Name = "GetNestedType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetNestedType
#endif
                    }},
                    {"GetNestedTypes", new MemberRegisterInfo { Name = "GetNestedTypes", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetNestedTypes
#endif
                    }},
                    {"GetProperty", new MemberRegisterInfo { Name = "GetProperty", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetProperty
#endif
                    }},
                    {"GetProperties", new MemberRegisterInfo { Name = "GetProperties", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetProperties
#endif
                    }},
                    {"GetDefaultMembers", new MemberRegisterInfo { Name = "GetDefaultMembers", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetDefaultMembers
#endif
                    }},
                    {"InvokeMember", new MemberRegisterInfo { Name = "InvokeMember", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_InvokeMember
#endif
                    }},
                    {"GetInterface", new MemberRegisterInfo { Name = "GetInterface", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetInterface
#endif
                    }},
                    {"GetInterfaces", new MemberRegisterInfo { Name = "GetInterfaces", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetInterfaces
#endif
                    }},
                    {"GetInterfaceMap", new MemberRegisterInfo { Name = "GetInterfaceMap", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetInterfaceMap
#endif
                    }},
                    {"IsInstanceOfType", new MemberRegisterInfo { Name = "IsInstanceOfType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_IsInstanceOfType
#endif
                    }},
                    {"IsEquivalentTo", new MemberRegisterInfo { Name = "IsEquivalentTo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_IsEquivalentTo
#endif
                    }},
                    {"GetEnumUnderlyingType", new MemberRegisterInfo { Name = "GetEnumUnderlyingType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetEnumUnderlyingType
#endif
                    }},
                    {"GetEnumValues", new MemberRegisterInfo { Name = "GetEnumValues", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetEnumValues
#endif
                    }},
                    {"MakeArrayType", new MemberRegisterInfo { Name = "MakeArrayType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_MakeArrayType
#endif
                    }},
                    {"MakeByRefType", new MemberRegisterInfo { Name = "MakeByRefType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_MakeByRefType
#endif
                    }},
                    {"MakeGenericType", new MemberRegisterInfo { Name = "MakeGenericType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_MakeGenericType
#endif
                    }},
                    {"MakePointerType", new MemberRegisterInfo { Name = "MakePointerType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_MakePointerType
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_ToString
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_Equals
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.M_GetHashCode
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.O_op_Inequality
#endif
                    }},
                    {"IsSerializable", new MemberRegisterInfo { Name = "IsSerializable", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsSerializable
#endif
                    }},
                    {"ContainsGenericParameters", new MemberRegisterInfo { Name = "ContainsGenericParameters", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_ContainsGenericParameters
#endif
                    }},
                    {"IsVisible", new MemberRegisterInfo { Name = "IsVisible", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsVisible
#endif
                    }},
                    {"MemberType", new MemberRegisterInfo { Name = "MemberType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_MemberType
#endif
                    }},
                    {"Namespace", new MemberRegisterInfo { Name = "Namespace", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_Namespace
#endif
                    }},
                    {"AssemblyQualifiedName", new MemberRegisterInfo { Name = "AssemblyQualifiedName", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_AssemblyQualifiedName
#endif
                    }},
                    {"FullName", new MemberRegisterInfo { Name = "FullName", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_FullName
#endif
                    }},
                    {"Assembly", new MemberRegisterInfo { Name = "Assembly", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_Assembly
#endif
                    }},
                    {"Module", new MemberRegisterInfo { Name = "Module", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_Module
#endif
                    }},
                    {"IsNested", new MemberRegisterInfo { Name = "IsNested", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsNested
#endif
                    }},
                    {"DeclaringType", new MemberRegisterInfo { Name = "DeclaringType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_DeclaringType
#endif
                    }},
                    {"DeclaringMethod", new MemberRegisterInfo { Name = "DeclaringMethod", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_DeclaringMethod
#endif
                    }},
                    {"ReflectedType", new MemberRegisterInfo { Name = "ReflectedType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_ReflectedType
#endif
                    }},
                    {"UnderlyingSystemType", new MemberRegisterInfo { Name = "UnderlyingSystemType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_UnderlyingSystemType
#endif
                    }},
                    {"IsTypeDefinition", new MemberRegisterInfo { Name = "IsTypeDefinition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsTypeDefinition
#endif
                    }},
                    {"IsArray", new MemberRegisterInfo { Name = "IsArray", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsArray
#endif
                    }},
                    {"IsByRef", new MemberRegisterInfo { Name = "IsByRef", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsByRef
#endif
                    }},
                    {"IsPointer", new MemberRegisterInfo { Name = "IsPointer", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsPointer
#endif
                    }},
                    {"IsConstructedGenericType", new MemberRegisterInfo { Name = "IsConstructedGenericType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsConstructedGenericType
#endif
                    }},
                    {"IsGenericParameter", new MemberRegisterInfo { Name = "IsGenericParameter", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsGenericParameter
#endif
                    }},
                    {"IsGenericTypeParameter", new MemberRegisterInfo { Name = "IsGenericTypeParameter", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsGenericTypeParameter
#endif
                    }},
                    {"IsGenericMethodParameter", new MemberRegisterInfo { Name = "IsGenericMethodParameter", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsGenericMethodParameter
#endif
                    }},
                    {"IsGenericType", new MemberRegisterInfo { Name = "IsGenericType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsGenericType
#endif
                    }},
                    {"IsGenericTypeDefinition", new MemberRegisterInfo { Name = "IsGenericTypeDefinition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsGenericTypeDefinition
#endif
                    }},
                    {"IsSZArray", new MemberRegisterInfo { Name = "IsSZArray", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.DontBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    
#endif
                    }},
                    {"IsVariableBoundArray", new MemberRegisterInfo { Name = "IsVariableBoundArray", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsVariableBoundArray
#endif
                    }},
                    {"IsByRefLike", new MemberRegisterInfo { Name = "IsByRefLike", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsByRefLike
#endif
                    }},
                    {"HasElementType", new MemberRegisterInfo { Name = "HasElementType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_HasElementType
#endif
                    }},
                    {"GenericTypeArguments", new MemberRegisterInfo { Name = "GenericTypeArguments", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_GenericTypeArguments
#endif
                    }},
                    {"GenericParameterPosition", new MemberRegisterInfo { Name = "GenericParameterPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_GenericParameterPosition
#endif
                    }},
                    {"GenericParameterAttributes", new MemberRegisterInfo { Name = "GenericParameterAttributes", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_GenericParameterAttributes
#endif
                    }},
                    {"Attributes", new MemberRegisterInfo { Name = "Attributes", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_Attributes
#endif
                    }},
                    {"IsAbstract", new MemberRegisterInfo { Name = "IsAbstract", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsAbstract
#endif
                    }},
                    {"IsImport", new MemberRegisterInfo { Name = "IsImport", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsImport
#endif
                    }},
                    {"IsSealed", new MemberRegisterInfo { Name = "IsSealed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsSealed
#endif
                    }},
                    {"IsSpecialName", new MemberRegisterInfo { Name = "IsSpecialName", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsSpecialName
#endif
                    }},
                    {"IsClass", new MemberRegisterInfo { Name = "IsClass", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsClass
#endif
                    }},
                    {"IsNestedAssembly", new MemberRegisterInfo { Name = "IsNestedAssembly", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsNestedAssembly
#endif
                    }},
                    {"IsNestedFamANDAssem", new MemberRegisterInfo { Name = "IsNestedFamANDAssem", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsNestedFamANDAssem
#endif
                    }},
                    {"IsNestedFamily", new MemberRegisterInfo { Name = "IsNestedFamily", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsNestedFamily
#endif
                    }},
                    {"IsNestedFamORAssem", new MemberRegisterInfo { Name = "IsNestedFamORAssem", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsNestedFamORAssem
#endif
                    }},
                    {"IsNestedPrivate", new MemberRegisterInfo { Name = "IsNestedPrivate", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsNestedPrivate
#endif
                    }},
                    {"IsNestedPublic", new MemberRegisterInfo { Name = "IsNestedPublic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsNestedPublic
#endif
                    }},
                    {"IsNotPublic", new MemberRegisterInfo { Name = "IsNotPublic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsNotPublic
#endif
                    }},
                    {"IsPublic", new MemberRegisterInfo { Name = "IsPublic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsPublic
#endif
                    }},
                    {"IsAutoLayout", new MemberRegisterInfo { Name = "IsAutoLayout", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsAutoLayout
#endif
                    }},
                    {"IsExplicitLayout", new MemberRegisterInfo { Name = "IsExplicitLayout", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsExplicitLayout
#endif
                    }},
                    {"IsLayoutSequential", new MemberRegisterInfo { Name = "IsLayoutSequential", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsLayoutSequential
#endif
                    }},
                    {"IsAnsiClass", new MemberRegisterInfo { Name = "IsAnsiClass", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsAnsiClass
#endif
                    }},
                    {"IsAutoClass", new MemberRegisterInfo { Name = "IsAutoClass", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsAutoClass
#endif
                    }},
                    {"IsUnicodeClass", new MemberRegisterInfo { Name = "IsUnicodeClass", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsUnicodeClass
#endif
                    }},
                    {"IsCOMObject", new MemberRegisterInfo { Name = "IsCOMObject", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsCOMObject
#endif
                    }},
                    {"IsContextful", new MemberRegisterInfo { Name = "IsContextful", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsContextful
#endif
                    }},
                    {"IsCollectible", new MemberRegisterInfo { Name = "IsCollectible", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.SlowBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    
#endif
                    }},
                    {"IsEnum", new MemberRegisterInfo { Name = "IsEnum", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsEnum
#endif
                    }},
                    {"IsMarshalByRef", new MemberRegisterInfo { Name = "IsMarshalByRef", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsMarshalByRef
#endif
                    }},
                    {"IsPrimitive", new MemberRegisterInfo { Name = "IsPrimitive", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsPrimitive
#endif
                    }},
                    {"IsValueType", new MemberRegisterInfo { Name = "IsValueType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsValueType
#endif
                    }},
                    {"IsSignatureType", new MemberRegisterInfo { Name = "IsSignatureType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsSignatureType
#endif
                    }},
                    {"IsSecurityCritical", new MemberRegisterInfo { Name = "IsSecurityCritical", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsSecurityCritical
#endif
                    }},
                    {"IsSecuritySafeCritical", new MemberRegisterInfo { Name = "IsSecuritySafeCritical", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsSecuritySafeCritical
#endif
                    }},
                    {"IsSecurityTransparent", new MemberRegisterInfo { Name = "IsSecurityTransparent", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsSecurityTransparent
#endif
                    }},
                    {"StructLayoutAttribute", new MemberRegisterInfo { Name = "StructLayoutAttribute", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_StructLayoutAttribute
#endif
                    }},
                    {"TypeInitializer", new MemberRegisterInfo { Name = "TypeInitializer", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_TypeInitializer
#endif
                    }},
                    {"TypeHandle", new MemberRegisterInfo { Name = "TypeHandle", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_TypeHandle
#endif
                    }},
                    {"GUID", new MemberRegisterInfo { Name = "GUID", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_GUID
#endif
                    }},
                    {"BaseType", new MemberRegisterInfo { Name = "BaseType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_BaseType
#endif
                    }},
                    {"IsInterface", new MemberRegisterInfo { Name = "IsInterface", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_IsInterface
#endif
                    }},
                    {"GetTypeHandle_static", new MemberRegisterInfo { Name = "GetTypeHandle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.F_GetTypeHandle
#endif
                    }},
                    {"GetTypeArray_static", new MemberRegisterInfo { Name = "GetTypeArray", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.F_GetTypeArray
#endif
                    }},
                    {"GetTypeCode_static", new MemberRegisterInfo { Name = "GetTypeCode", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.F_GetTypeCode
#endif
                    }},
                    {"GetTypeFromCLSID_static", new MemberRegisterInfo { Name = "GetTypeFromCLSID", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.F_GetTypeFromCLSID
#endif
                    }},
                    {"GetTypeFromProgID_static", new MemberRegisterInfo { Name = "GetTypeFromProgID", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.F_GetTypeFromProgID
#endif
                    }},
                    {"MakeGenericSignatureType_static", new MemberRegisterInfo { Name = "MakeGenericSignatureType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.SlowBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    
#endif
                    }},
                    {"MakeGenericMethodParameter_static", new MemberRegisterInfo { Name = "MakeGenericMethodParameter", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.F_MakeGenericMethodParameter
#endif
                    }},
                    {"GetTypeFromHandle_static", new MemberRegisterInfo { Name = "GetTypeFromHandle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.F_GetTypeFromHandle
#endif
                    }},
                    {"GetType_static", new MemberRegisterInfo { Name = "GetType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.F_GetType
#endif
                    }},
                    {"ReflectionOnlyGetType_static", new MemberRegisterInfo { Name = "ReflectionOnlyGetType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Type_Wrap.F_ReflectionOnlyGetType
#endif
                    }},
                    {"DefaultBinder_static", new MemberRegisterInfo { Name = "DefaultBinder", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_DefaultBinder
#endif
                    }},
                    {"Delimiter_static", new MemberRegisterInfo { Name = "Delimiter", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_Delimiter
#endif
                    }},
                    {"EmptyTypes_static", new MemberRegisterInfo { Name = "EmptyTypes", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_EmptyTypes
#endif
                    }},
                    {"Missing_static", new MemberRegisterInfo { Name = "Missing", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_Missing
#endif
                    }},
                    {"FilterAttribute_static", new MemberRegisterInfo { Name = "FilterAttribute", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_FilterAttribute
#endif
                    }},
                    {"FilterName_static", new MemberRegisterInfo { Name = "FilterName", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_FilterName
#endif
                    }},
                    {"FilterNameIgnoreCase_static", new MemberRegisterInfo { Name = "FilterNameIgnoreCase", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Type_Wrap.G_FilterNameIgnoreCase
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_ParticleSystem_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_ParticleSystem_Wrap.Constructor
#endif
                    }},
                    {"SetParticles", new MemberRegisterInfo { Name = "SetParticles", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetParticles
#endif
                    }},
                    {"GetParticles", new MemberRegisterInfo { Name = "GetParticles", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetParticles
#endif
                    }},
                    {"SetCustomParticleData", new MemberRegisterInfo { Name = "SetCustomParticleData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetCustomParticleData
#endif
                    }},
                    {"GetCustomParticleData", new MemberRegisterInfo { Name = "GetCustomParticleData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetCustomParticleData
#endif
                    }},
                    {"GetPlaybackState", new MemberRegisterInfo { Name = "GetPlaybackState", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetPlaybackState
#endif
                    }},
                    {"SetPlaybackState", new MemberRegisterInfo { Name = "SetPlaybackState", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetPlaybackState
#endif
                    }},
                    {"GetTrails", new MemberRegisterInfo { Name = "GetTrails", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetTrails
#endif
                    }},
                    {"SetTrails", new MemberRegisterInfo { Name = "SetTrails", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetTrails
#endif
                    }},
                    {"Simulate", new MemberRegisterInfo { Name = "Simulate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Simulate
#endif
                    }},
                    {"Play", new MemberRegisterInfo { Name = "Play", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Play
#endif
                    }},
                    {"Pause", new MemberRegisterInfo { Name = "Pause", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Pause
#endif
                    }},
                    {"Stop", new MemberRegisterInfo { Name = "Stop", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Stop
#endif
                    }},
                    {"Clear", new MemberRegisterInfo { Name = "Clear", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Clear
#endif
                    }},
                    {"IsAlive", new MemberRegisterInfo { Name = "IsAlive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_IsAlive
#endif
                    }},
                    {"Emit", new MemberRegisterInfo { Name = "Emit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Emit
#endif
                    }},
                    {"TriggerSubEmitter", new MemberRegisterInfo { Name = "TriggerSubEmitter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_TriggerSubEmitter
#endif
                    }},
                    {"AllocateAxisOfRotationAttribute", new MemberRegisterInfo { Name = "AllocateAxisOfRotationAttribute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_AllocateAxisOfRotationAttribute
#endif
                    }},
                    {"AllocateMeshIndexAttribute", new MemberRegisterInfo { Name = "AllocateMeshIndexAttribute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_AllocateMeshIndexAttribute
#endif
                    }},
                    {"AllocateCustomDataAttribute", new MemberRegisterInfo { Name = "AllocateCustomDataAttribute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_AllocateCustomDataAttribute
#endif
                    }},
                    {"isPlaying", new MemberRegisterInfo { Name = "isPlaying", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isPlaying
#endif
                    }},
                    {"isEmitting", new MemberRegisterInfo { Name = "isEmitting", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isEmitting
#endif
                    }},
                    {"isStopped", new MemberRegisterInfo { Name = "isStopped", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isStopped
#endif
                    }},
                    {"isPaused", new MemberRegisterInfo { Name = "isPaused", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isPaused
#endif
                    }},
                    {"particleCount", new MemberRegisterInfo { Name = "particleCount", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_particleCount
#endif
                    }},
                    {"time", new MemberRegisterInfo { Name = "time", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_time, PropertySetter = UnityEngine_ParticleSystem_Wrap.S_time
#endif
                    }},
                    {"randomSeed", new MemberRegisterInfo { Name = "randomSeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_randomSeed, PropertySetter = UnityEngine_ParticleSystem_Wrap.S_randomSeed
#endif
                    }},
                    {"useAutoRandomSeed", new MemberRegisterInfo { Name = "useAutoRandomSeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_useAutoRandomSeed, PropertySetter = UnityEngine_ParticleSystem_Wrap.S_useAutoRandomSeed
#endif
                    }},
                    {"proceduralSimulationSupported", new MemberRegisterInfo { Name = "proceduralSimulationSupported", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_proceduralSimulationSupported
#endif
                    }},
                    {"main", new MemberRegisterInfo { Name = "main", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_main
#endif
                    }},
                    {"emission", new MemberRegisterInfo { Name = "emission", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_emission
#endif
                    }},
                    {"shape", new MemberRegisterInfo { Name = "shape", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_shape
#endif
                    }},
                    {"velocityOverLifetime", new MemberRegisterInfo { Name = "velocityOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_velocityOverLifetime
#endif
                    }},
                    {"limitVelocityOverLifetime", new MemberRegisterInfo { Name = "limitVelocityOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_limitVelocityOverLifetime
#endif
                    }},
                    {"inheritVelocity", new MemberRegisterInfo { Name = "inheritVelocity", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_inheritVelocity
#endif
                    }},
                    {"lifetimeByEmitterSpeed", new MemberRegisterInfo { Name = "lifetimeByEmitterSpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_lifetimeByEmitterSpeed
#endif
                    }},
                    {"forceOverLifetime", new MemberRegisterInfo { Name = "forceOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_forceOverLifetime
#endif
                    }},
                    {"colorOverLifetime", new MemberRegisterInfo { Name = "colorOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_colorOverLifetime
#endif
                    }},
                    {"colorBySpeed", new MemberRegisterInfo { Name = "colorBySpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_colorBySpeed
#endif
                    }},
                    {"sizeOverLifetime", new MemberRegisterInfo { Name = "sizeOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_sizeOverLifetime
#endif
                    }},
                    {"sizeBySpeed", new MemberRegisterInfo { Name = "sizeBySpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_sizeBySpeed
#endif
                    }},
                    {"rotationOverLifetime", new MemberRegisterInfo { Name = "rotationOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_rotationOverLifetime
#endif
                    }},
                    {"rotationBySpeed", new MemberRegisterInfo { Name = "rotationBySpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_rotationBySpeed
#endif
                    }},
                    {"externalForces", new MemberRegisterInfo { Name = "externalForces", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_externalForces
#endif
                    }},
                    {"noise", new MemberRegisterInfo { Name = "noise", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_noise
#endif
                    }},
                    {"collision", new MemberRegisterInfo { Name = "collision", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_collision
#endif
                    }},
                    {"trigger", new MemberRegisterInfo { Name = "trigger", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_trigger
#endif
                    }},
                    {"subEmitters", new MemberRegisterInfo { Name = "subEmitters", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_subEmitters
#endif
                    }},
                    {"textureSheetAnimation", new MemberRegisterInfo { Name = "textureSheetAnimation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_textureSheetAnimation
#endif
                    }},
                    {"lights", new MemberRegisterInfo { Name = "lights", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_lights
#endif
                    }},
                    {"trails", new MemberRegisterInfo { Name = "trails", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_trails
#endif
                    }},
                    {"customData", new MemberRegisterInfo { Name = "customData", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_customData
#endif
                    }},
                    {"ResetPreMappedBufferMemory_static", new MemberRegisterInfo { Name = "ResetPreMappedBufferMemory", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.F_ResetPreMappedBufferMemory
#endif
                    }},
                    {"SetMaximumPreMappedBufferCounts_static", new MemberRegisterInfo { Name = "SetMaximumPreMappedBufferCounts", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.F_SetMaximumPreMappedBufferCounts
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Canvas_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Canvas_Wrap.Constructor
#endif
                    }},
                    {"add_preWillRenderCanvases_static", new MemberRegisterInfo { Name = "add_preWillRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.A_preWillRenderCanvases
#endif
                    }},
                    {"remove_preWillRenderCanvases_static", new MemberRegisterInfo { Name = "remove_preWillRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.R_preWillRenderCanvases
#endif
                    }},
                    {"add_willRenderCanvases_static", new MemberRegisterInfo { Name = "add_willRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.A_willRenderCanvases
#endif
                    }},
                    {"remove_willRenderCanvases_static", new MemberRegisterInfo { Name = "remove_willRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.R_willRenderCanvases
#endif
                    }},
                    {"renderMode", new MemberRegisterInfo { Name = "renderMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_renderMode, PropertySetter = UnityEngine_Canvas_Wrap.S_renderMode
#endif
                    }},
                    {"isRootCanvas", new MemberRegisterInfo { Name = "isRootCanvas", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_isRootCanvas
#endif
                    }},
                    {"pixelRect", new MemberRegisterInfo { Name = "pixelRect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_pixelRect
#endif
                    }},
                    {"scaleFactor", new MemberRegisterInfo { Name = "scaleFactor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_scaleFactor, PropertySetter = UnityEngine_Canvas_Wrap.S_scaleFactor
#endif
                    }},
                    {"referencePixelsPerUnit", new MemberRegisterInfo { Name = "referencePixelsPerUnit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_referencePixelsPerUnit, PropertySetter = UnityEngine_Canvas_Wrap.S_referencePixelsPerUnit
#endif
                    }},
                    {"overridePixelPerfect", new MemberRegisterInfo { Name = "overridePixelPerfect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_overridePixelPerfect, PropertySetter = UnityEngine_Canvas_Wrap.S_overridePixelPerfect
#endif
                    }},
                    {"vertexColorAlwaysGammaSpace", new MemberRegisterInfo { Name = "vertexColorAlwaysGammaSpace", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_vertexColorAlwaysGammaSpace, PropertySetter = UnityEngine_Canvas_Wrap.S_vertexColorAlwaysGammaSpace
#endif
                    }},
                    {"pixelPerfect", new MemberRegisterInfo { Name = "pixelPerfect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_pixelPerfect, PropertySetter = UnityEngine_Canvas_Wrap.S_pixelPerfect
#endif
                    }},
                    {"planeDistance", new MemberRegisterInfo { Name = "planeDistance", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_planeDistance, PropertySetter = UnityEngine_Canvas_Wrap.S_planeDistance
#endif
                    }},
                    {"renderOrder", new MemberRegisterInfo { Name = "renderOrder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_renderOrder
#endif
                    }},
                    {"overrideSorting", new MemberRegisterInfo { Name = "overrideSorting", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_overrideSorting, PropertySetter = UnityEngine_Canvas_Wrap.S_overrideSorting
#endif
                    }},
                    {"sortingOrder", new MemberRegisterInfo { Name = "sortingOrder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_sortingOrder, PropertySetter = UnityEngine_Canvas_Wrap.S_sortingOrder
#endif
                    }},
                    {"targetDisplay", new MemberRegisterInfo { Name = "targetDisplay", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_targetDisplay, PropertySetter = UnityEngine_Canvas_Wrap.S_targetDisplay
#endif
                    }},
                    {"sortingLayerID", new MemberRegisterInfo { Name = "sortingLayerID", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_sortingLayerID, PropertySetter = UnityEngine_Canvas_Wrap.S_sortingLayerID
#endif
                    }},
                    {"cachedSortingLayerValue", new MemberRegisterInfo { Name = "cachedSortingLayerValue", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_cachedSortingLayerValue
#endif
                    }},
                    {"additionalShaderChannels", new MemberRegisterInfo { Name = "additionalShaderChannels", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_additionalShaderChannels, PropertySetter = UnityEngine_Canvas_Wrap.S_additionalShaderChannels
#endif
                    }},
                    {"sortingLayerName", new MemberRegisterInfo { Name = "sortingLayerName", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_sortingLayerName, PropertySetter = UnityEngine_Canvas_Wrap.S_sortingLayerName
#endif
                    }},
                    {"rootCanvas", new MemberRegisterInfo { Name = "rootCanvas", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_rootCanvas
#endif
                    }},
                    {"renderingDisplaySize", new MemberRegisterInfo { Name = "renderingDisplaySize", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_renderingDisplaySize
#endif
                    }},
                    {"worldCamera", new MemberRegisterInfo { Name = "worldCamera", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_worldCamera, PropertySetter = UnityEngine_Canvas_Wrap.S_worldCamera
#endif
                    }},
                    {"normalizedSortingGridSize", new MemberRegisterInfo { Name = "normalizedSortingGridSize", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_normalizedSortingGridSize, PropertySetter = UnityEngine_Canvas_Wrap.S_normalizedSortingGridSize
#endif
                    }},
                    {"GetDefaultCanvasMaterial_static", new MemberRegisterInfo { Name = "GetDefaultCanvasMaterial", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.F_GetDefaultCanvasMaterial
#endif
                    }},
                    {"GetETC1SupportedCanvasMaterial_static", new MemberRegisterInfo { Name = "GetETC1SupportedCanvasMaterial", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.F_GetETC1SupportedCanvasMaterial
#endif
                    }},
                    {"ForceUpdateCanvases_static", new MemberRegisterInfo { Name = "ForceUpdateCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.F_ForceUpdateCanvases
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Behaviour_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Behaviour_Wrap.Constructor
#endif
                    }},
                    {"enabled", new MemberRegisterInfo { Name = "enabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Behaviour_Wrap.G_enabled, PropertySetter = UnityEngine_Behaviour_Wrap.S_enabled
#endif
                    }},
                    {"isActiveAndEnabled", new MemberRegisterInfo { Name = "isActiveAndEnabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Behaviour_Wrap.G_isActiveAndEnabled
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_MonoBehaviour_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_MonoBehaviour_Wrap.Constructor
#endif
                    }},
                    {"IsInvoking", new MemberRegisterInfo { Name = "IsInvoking", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_IsInvoking
#endif
                    }},
                    {"CancelInvoke", new MemberRegisterInfo { Name = "CancelInvoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_CancelInvoke
#endif
                    }},
                    {"Invoke", new MemberRegisterInfo { Name = "Invoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_Invoke
#endif
                    }},
                    {"InvokeRepeating", new MemberRegisterInfo { Name = "InvokeRepeating", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_InvokeRepeating
#endif
                    }},
                    {"StartCoroutine", new MemberRegisterInfo { Name = "StartCoroutine", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_StartCoroutine
#endif
                    }},
                    {"StopCoroutine", new MemberRegisterInfo { Name = "StopCoroutine", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_StopCoroutine
#endif
                    }},
                    {"StopAllCoroutines", new MemberRegisterInfo { Name = "StopAllCoroutines", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_StopAllCoroutines
#endif
                    }},
                    {"useGUILayout", new MemberRegisterInfo { Name = "useGUILayout", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_MonoBehaviour_Wrap.G_useGUILayout, PropertySetter = UnityEngine_MonoBehaviour_Wrap.S_useGUILayout
#endif
                    }},
                    {"runInEditMode", new MemberRegisterInfo { Name = "runInEditMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.SlowBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    
#endif
                    }},
                    {"print_static", new MemberRegisterInfo { Name = "print", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_MonoBehaviour_Wrap.F_print
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_System_IO_File_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"OpenText_static", new MemberRegisterInfo { Name = "OpenText", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_OpenText
#endif
                    }},
                    {"CreateText_static", new MemberRegisterInfo { Name = "CreateText", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_CreateText
#endif
                    }},
                    {"AppendText_static", new MemberRegisterInfo { Name = "AppendText", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_AppendText
#endif
                    }},
                    {"Copy_static", new MemberRegisterInfo { Name = "Copy", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_Copy
#endif
                    }},
                    {"Create_static", new MemberRegisterInfo { Name = "Create", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.SlowBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    
#endif
                    }},
                    {"Delete_static", new MemberRegisterInfo { Name = "Delete", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_Delete
#endif
                    }},
                    {"Exists_static", new MemberRegisterInfo { Name = "Exists", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_Exists
#endif
                    }},
                    {"Open_static", new MemberRegisterInfo { Name = "Open", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_Open
#endif
                    }},
                    {"SetCreationTime_static", new MemberRegisterInfo { Name = "SetCreationTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_SetCreationTime
#endif
                    }},
                    {"SetCreationTimeUtc_static", new MemberRegisterInfo { Name = "SetCreationTimeUtc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_SetCreationTimeUtc
#endif
                    }},
                    {"GetCreationTime_static", new MemberRegisterInfo { Name = "GetCreationTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_GetCreationTime
#endif
                    }},
                    {"GetCreationTimeUtc_static", new MemberRegisterInfo { Name = "GetCreationTimeUtc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_GetCreationTimeUtc
#endif
                    }},
                    {"SetLastAccessTime_static", new MemberRegisterInfo { Name = "SetLastAccessTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_SetLastAccessTime
#endif
                    }},
                    {"SetLastAccessTimeUtc_static", new MemberRegisterInfo { Name = "SetLastAccessTimeUtc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_SetLastAccessTimeUtc
#endif
                    }},
                    {"GetLastAccessTime_static", new MemberRegisterInfo { Name = "GetLastAccessTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_GetLastAccessTime
#endif
                    }},
                    {"GetLastAccessTimeUtc_static", new MemberRegisterInfo { Name = "GetLastAccessTimeUtc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_GetLastAccessTimeUtc
#endif
                    }},
                    {"SetLastWriteTime_static", new MemberRegisterInfo { Name = "SetLastWriteTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_SetLastWriteTime
#endif
                    }},
                    {"SetLastWriteTimeUtc_static", new MemberRegisterInfo { Name = "SetLastWriteTimeUtc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_SetLastWriteTimeUtc
#endif
                    }},
                    {"GetLastWriteTime_static", new MemberRegisterInfo { Name = "GetLastWriteTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_GetLastWriteTime
#endif
                    }},
                    {"GetLastWriteTimeUtc_static", new MemberRegisterInfo { Name = "GetLastWriteTimeUtc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_GetLastWriteTimeUtc
#endif
                    }},
                    {"GetAttributes_static", new MemberRegisterInfo { Name = "GetAttributes", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_GetAttributes
#endif
                    }},
                    {"SetAttributes_static", new MemberRegisterInfo { Name = "SetAttributes", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_SetAttributes
#endif
                    }},
                    {"OpenRead_static", new MemberRegisterInfo { Name = "OpenRead", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_OpenRead
#endif
                    }},
                    {"OpenWrite_static", new MemberRegisterInfo { Name = "OpenWrite", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_OpenWrite
#endif
                    }},
                    {"ReadAllText_static", new MemberRegisterInfo { Name = "ReadAllText", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_ReadAllText
#endif
                    }},
                    {"WriteAllText_static", new MemberRegisterInfo { Name = "WriteAllText", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_WriteAllText
#endif
                    }},
                    {"ReadAllBytes_static", new MemberRegisterInfo { Name = "ReadAllBytes", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_ReadAllBytes
#endif
                    }},
                    {"WriteAllBytes_static", new MemberRegisterInfo { Name = "WriteAllBytes", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_WriteAllBytes
#endif
                    }},
                    {"ReadAllLines_static", new MemberRegisterInfo { Name = "ReadAllLines", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_ReadAllLines
#endif
                    }},
                    {"ReadLines_static", new MemberRegisterInfo { Name = "ReadLines", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_ReadLines
#endif
                    }},
                    {"WriteAllLines_static", new MemberRegisterInfo { Name = "WriteAllLines", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_WriteAllLines
#endif
                    }},
                    {"AppendAllText_static", new MemberRegisterInfo { Name = "AppendAllText", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_AppendAllText
#endif
                    }},
                    {"AppendAllLines_static", new MemberRegisterInfo { Name = "AppendAllLines", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_AppendAllLines
#endif
                    }},
                    {"Replace_static", new MemberRegisterInfo { Name = "Replace", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_Replace
#endif
                    }},
                    {"Move_static", new MemberRegisterInfo { Name = "Move", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_Move
#endif
                    }},
                    {"Encrypt_static", new MemberRegisterInfo { Name = "Encrypt", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_Encrypt
#endif
                    }},
                    {"Decrypt_static", new MemberRegisterInfo { Name = "Decrypt", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_Decrypt
#endif
                    }},
                    {"ReadAllTextAsync_static", new MemberRegisterInfo { Name = "ReadAllTextAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_ReadAllTextAsync
#endif
                    }},
                    {"WriteAllTextAsync_static", new MemberRegisterInfo { Name = "WriteAllTextAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_WriteAllTextAsync
#endif
                    }},
                    {"ReadAllBytesAsync_static", new MemberRegisterInfo { Name = "ReadAllBytesAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_ReadAllBytesAsync
#endif
                    }},
                    {"WriteAllBytesAsync_static", new MemberRegisterInfo { Name = "WriteAllBytesAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_WriteAllBytesAsync
#endif
                    }},
                    {"ReadAllLinesAsync_static", new MemberRegisterInfo { Name = "ReadAllLinesAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_ReadAllLinesAsync
#endif
                    }},
                    {"WriteAllLinesAsync_static", new MemberRegisterInfo { Name = "WriteAllLinesAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_WriteAllLinesAsync
#endif
                    }},
                    {"AppendAllTextAsync_static", new MemberRegisterInfo { Name = "AppendAllTextAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_AppendAllTextAsync
#endif
                    }},
                    {"AppendAllLinesAsync_static", new MemberRegisterInfo { Name = "AppendAllLinesAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_IO_File_Wrap.F_AppendAllLinesAsync
#endif
                    }},
                    {"GetAccessControl_static", new MemberRegisterInfo { Name = "GetAccessControl", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.SlowBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    
#endif
                    }},
                    {"SetAccessControl_static", new MemberRegisterInfo { Name = "SetAccessControl", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.SlowBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Networking_UnityWebRequest_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Networking_UnityWebRequest_Wrap.Constructor
#endif
                    }},
                    {"Dispose", new MemberRegisterInfo { Name = "Dispose", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_Dispose
#endif
                    }},
                    {"SendWebRequest", new MemberRegisterInfo { Name = "SendWebRequest", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_SendWebRequest
#endif
                    }},
                    {"Abort", new MemberRegisterInfo { Name = "Abort", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_Abort
#endif
                    }},
                    {"GetRequestHeader", new MemberRegisterInfo { Name = "GetRequestHeader", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_GetRequestHeader
#endif
                    }},
                    {"SetRequestHeader", new MemberRegisterInfo { Name = "SetRequestHeader", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_SetRequestHeader
#endif
                    }},
                    {"GetResponseHeader", new MemberRegisterInfo { Name = "GetResponseHeader", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_GetResponseHeader
#endif
                    }},
                    {"GetResponseHeaders", new MemberRegisterInfo { Name = "GetResponseHeaders", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_GetResponseHeaders
#endif
                    }},
                    {"disposeCertificateHandlerOnDispose", new MemberRegisterInfo { Name = "disposeCertificateHandlerOnDispose", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_disposeCertificateHandlerOnDispose, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_disposeCertificateHandlerOnDispose
#endif
                    }},
                    {"disposeDownloadHandlerOnDispose", new MemberRegisterInfo { Name = "disposeDownloadHandlerOnDispose", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_disposeDownloadHandlerOnDispose, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_disposeDownloadHandlerOnDispose
#endif
                    }},
                    {"disposeUploadHandlerOnDispose", new MemberRegisterInfo { Name = "disposeUploadHandlerOnDispose", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_disposeUploadHandlerOnDispose, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_disposeUploadHandlerOnDispose
#endif
                    }},
                    {"method", new MemberRegisterInfo { Name = "method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_method, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_method
#endif
                    }},
                    {"error", new MemberRegisterInfo { Name = "error", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_error
#endif
                    }},
                    {"useHttpContinue", new MemberRegisterInfo { Name = "useHttpContinue", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_useHttpContinue, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_useHttpContinue
#endif
                    }},
                    {"url", new MemberRegisterInfo { Name = "url", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_url, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_url
#endif
                    }},
                    {"uri", new MemberRegisterInfo { Name = "uri", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_uri, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_uri
#endif
                    }},
                    {"responseCode", new MemberRegisterInfo { Name = "responseCode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_responseCode
#endif
                    }},
                    {"uploadProgress", new MemberRegisterInfo { Name = "uploadProgress", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_uploadProgress
#endif
                    }},
                    {"isModifiable", new MemberRegisterInfo { Name = "isModifiable", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_isModifiable
#endif
                    }},
                    {"isDone", new MemberRegisterInfo { Name = "isDone", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_isDone
#endif
                    }},
                    {"result", new MemberRegisterInfo { Name = "result", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_result
#endif
                    }},
                    {"downloadProgress", new MemberRegisterInfo { Name = "downloadProgress", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_downloadProgress
#endif
                    }},
                    {"uploadedBytes", new MemberRegisterInfo { Name = "uploadedBytes", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_uploadedBytes
#endif
                    }},
                    {"downloadedBytes", new MemberRegisterInfo { Name = "downloadedBytes", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_downloadedBytes
#endif
                    }},
                    {"redirectLimit", new MemberRegisterInfo { Name = "redirectLimit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_redirectLimit, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_redirectLimit
#endif
                    }},
                    {"uploadHandler", new MemberRegisterInfo { Name = "uploadHandler", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_uploadHandler, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_uploadHandler
#endif
                    }},
                    {"downloadHandler", new MemberRegisterInfo { Name = "downloadHandler", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_downloadHandler, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_downloadHandler
#endif
                    }},
                    {"certificateHandler", new MemberRegisterInfo { Name = "certificateHandler", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_certificateHandler, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_certificateHandler
#endif
                    }},
                    {"timeout", new MemberRegisterInfo { Name = "timeout", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_timeout, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_timeout
#endif
                    }},
                    {"ClearCookieCache_static", new MemberRegisterInfo { Name = "ClearCookieCache", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_ClearCookieCache
#endif
                    }},
                    {"Get_static", new MemberRegisterInfo { Name = "Get", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Get
#endif
                    }},
                    {"Delete_static", new MemberRegisterInfo { Name = "Delete", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Delete
#endif
                    }},
                    {"Head_static", new MemberRegisterInfo { Name = "Head", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Head
#endif
                    }},
                    {"Put_static", new MemberRegisterInfo { Name = "Put", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Put
#endif
                    }},
                    {"Post_static", new MemberRegisterInfo { Name = "Post", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Post
#endif
                    }},
                    {"EscapeURL_static", new MemberRegisterInfo { Name = "EscapeURL", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_EscapeURL
#endif
                    }},
                    {"UnEscapeURL_static", new MemberRegisterInfo { Name = "UnEscapeURL", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_UnEscapeURL
#endif
                    }},
                    {"SerializeFormSections_static", new MemberRegisterInfo { Name = "SerializeFormSections", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_SerializeFormSections
#endif
                    }},
                    {"GenerateBoundary_static", new MemberRegisterInfo { Name = "GenerateBoundary", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_GenerateBoundary
#endif
                    }},
                    {"SerializeSimpleForm_static", new MemberRegisterInfo { Name = "SerializeSimpleForm", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_SerializeSimpleForm
#endif
                    }},
                    {"kHttpVerbGET_static", new MemberRegisterInfo { Name = "kHttpVerbGET", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbGET
#endif
                    }},
                    {"kHttpVerbHEAD_static", new MemberRegisterInfo { Name = "kHttpVerbHEAD", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbHEAD
#endif
                    }},
                    {"kHttpVerbPOST_static", new MemberRegisterInfo { Name = "kHttpVerbPOST", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbPOST
#endif
                    }},
                    {"kHttpVerbPUT_static", new MemberRegisterInfo { Name = "kHttpVerbPUT", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbPUT
#endif
                    }},
                    {"kHttpVerbCREATE_static", new MemberRegisterInfo { Name = "kHttpVerbCREATE", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbCREATE
#endif
                    }},
                    {"kHttpVerbDELETE_static", new MemberRegisterInfo { Name = "kHttpVerbDELETE", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbDELETE
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Networking_DownloadHandler_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"Dispose", new MemberRegisterInfo { Name = "Dispose", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_DownloadHandler_Wrap.M_Dispose
#endif
                    }},
                    {"isDone", new MemberRegisterInfo { Name = "isDone", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_isDone
#endif
                    }},
                    {"error", new MemberRegisterInfo { Name = "error", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_error
#endif
                    }},
                    {"nativeData", new MemberRegisterInfo { Name = "nativeData", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_nativeData
#endif
                    }},
                    {"data", new MemberRegisterInfo { Name = "data", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_data
#endif
                    }},
                    {"text", new MemberRegisterInfo { Name = "text", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_text
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_EventSystems_UIBehaviour_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"IsActive", new MemberRegisterInfo { Name = "IsActive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_EventSystems_UIBehaviour_Wrap.M_IsActive
#endif
                    }},
                    {"IsDestroyed", new MemberRegisterInfo { Name = "IsDestroyed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_EventSystems_UIBehaviour_Wrap.M_IsDestroyed
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Selectable_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"IsInteractable", new MemberRegisterInfo { Name = "IsInteractable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_IsInteractable
#endif
                    }},
                    {"FindSelectable", new MemberRegisterInfo { Name = "FindSelectable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectable
#endif
                    }},
                    {"FindSelectableOnLeft", new MemberRegisterInfo { Name = "FindSelectableOnLeft", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnLeft
#endif
                    }},
                    {"FindSelectableOnRight", new MemberRegisterInfo { Name = "FindSelectableOnRight", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnRight
#endif
                    }},
                    {"FindSelectableOnUp", new MemberRegisterInfo { Name = "FindSelectableOnUp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnUp
#endif
                    }},
                    {"FindSelectableOnDown", new MemberRegisterInfo { Name = "FindSelectableOnDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnDown
#endif
                    }},
                    {"OnMove", new MemberRegisterInfo { Name = "OnMove", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnMove
#endif
                    }},
                    {"OnPointerDown", new MemberRegisterInfo { Name = "OnPointerDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerDown
#endif
                    }},
                    {"OnPointerUp", new MemberRegisterInfo { Name = "OnPointerUp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerUp
#endif
                    }},
                    {"OnPointerEnter", new MemberRegisterInfo { Name = "OnPointerEnter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerEnter
#endif
                    }},
                    {"OnPointerExit", new MemberRegisterInfo { Name = "OnPointerExit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerExit
#endif
                    }},
                    {"OnSelect", new MemberRegisterInfo { Name = "OnSelect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnSelect
#endif
                    }},
                    {"OnDeselect", new MemberRegisterInfo { Name = "OnDeselect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnDeselect
#endif
                    }},
                    {"Select", new MemberRegisterInfo { Name = "Select", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_Select
#endif
                    }},
                    {"navigation", new MemberRegisterInfo { Name = "navigation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_navigation, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_navigation
#endif
                    }},
                    {"transition", new MemberRegisterInfo { Name = "transition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_transition, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_transition
#endif
                    }},
                    {"colors", new MemberRegisterInfo { Name = "colors", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_colors, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_colors
#endif
                    }},
                    {"spriteState", new MemberRegisterInfo { Name = "spriteState", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_spriteState, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_spriteState
#endif
                    }},
                    {"animationTriggers", new MemberRegisterInfo { Name = "animationTriggers", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_animationTriggers, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_animationTriggers
#endif
                    }},
                    {"targetGraphic", new MemberRegisterInfo { Name = "targetGraphic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_targetGraphic, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_targetGraphic
#endif
                    }},
                    {"interactable", new MemberRegisterInfo { Name = "interactable", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_interactable, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_interactable
#endif
                    }},
                    {"image", new MemberRegisterInfo { Name = "image", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_image, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_image
#endif
                    }},
                    {"animator", new MemberRegisterInfo { Name = "animator", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_animator
#endif
                    }},
                    {"AllSelectablesNoAlloc_static", new MemberRegisterInfo { Name = "AllSelectablesNoAlloc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.F_AllSelectablesNoAlloc
#endif
                    }},
                    {"allSelectablesArray_static", new MemberRegisterInfo { Name = "allSelectablesArray", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_allSelectablesArray
#endif
                    }},
                    {"allSelectableCount_static", new MemberRegisterInfo { Name = "allSelectableCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_allSelectableCount
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Button_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"OnPointerClick", new MemberRegisterInfo { Name = "OnPointerClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Button_Wrap.M_OnPointerClick
#endif
                    }},
                    {"OnSubmit", new MemberRegisterInfo { Name = "OnSubmit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Button_Wrap.M_OnSubmit
#endif
                    }},
                    {"onClick", new MemberRegisterInfo { Name = "onClick", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Button_Wrap.G_onClick, PropertySetter = UnityEngine_UI_Button_Wrap.S_onClick
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Button_ButtonClickedEvent_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_UI_Button_ButtonClickedEvent_Wrap.Constructor
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Events_UnityEvent_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Events_UnityEvent_Wrap.Constructor
#endif
                    }},
                    {"AddListener", new MemberRegisterInfo { Name = "AddListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_Wrap.M_AddListener
#endif
                    }},
                    {"RemoveListener", new MemberRegisterInfo { Name = "RemoveListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_Wrap.M_RemoveListener
#endif
                    }},
                    {"Invoke", new MemberRegisterInfo { Name = "Invoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_Wrap.M_Invoke
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_InputField_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"SetTextWithoutNotify", new MemberRegisterInfo { Name = "SetTextWithoutNotify", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_SetTextWithoutNotify
#endif
                    }},
                    {"MoveTextEnd", new MemberRegisterInfo { Name = "MoveTextEnd", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_MoveTextEnd
#endif
                    }},
                    {"MoveTextStart", new MemberRegisterInfo { Name = "MoveTextStart", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_MoveTextStart
#endif
                    }},
                    {"OnBeginDrag", new MemberRegisterInfo { Name = "OnBeginDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnBeginDrag
#endif
                    }},
                    {"OnDrag", new MemberRegisterInfo { Name = "OnDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnDrag
#endif
                    }},
                    {"OnEndDrag", new MemberRegisterInfo { Name = "OnEndDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnEndDrag
#endif
                    }},
                    {"OnPointerDown", new MemberRegisterInfo { Name = "OnPointerDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnPointerDown
#endif
                    }},
                    {"ProcessEvent", new MemberRegisterInfo { Name = "ProcessEvent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_ProcessEvent
#endif
                    }},
                    {"OnUpdateSelected", new MemberRegisterInfo { Name = "OnUpdateSelected", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnUpdateSelected
#endif
                    }},
                    {"ForceLabelUpdate", new MemberRegisterInfo { Name = "ForceLabelUpdate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_ForceLabelUpdate
#endif
                    }},
                    {"Rebuild", new MemberRegisterInfo { Name = "Rebuild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_Rebuild
#endif
                    }},
                    {"LayoutComplete", new MemberRegisterInfo { Name = "LayoutComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_LayoutComplete
#endif
                    }},
                    {"GraphicUpdateComplete", new MemberRegisterInfo { Name = "GraphicUpdateComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_GraphicUpdateComplete
#endif
                    }},
                    {"ActivateInputField", new MemberRegisterInfo { Name = "ActivateInputField", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_ActivateInputField
#endif
                    }},
                    {"OnSelect", new MemberRegisterInfo { Name = "OnSelect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnSelect
#endif
                    }},
                    {"OnPointerClick", new MemberRegisterInfo { Name = "OnPointerClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnPointerClick
#endif
                    }},
                    {"DeactivateInputField", new MemberRegisterInfo { Name = "DeactivateInputField", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_DeactivateInputField
#endif
                    }},
                    {"OnDeselect", new MemberRegisterInfo { Name = "OnDeselect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnDeselect
#endif
                    }},
                    {"OnSubmit", new MemberRegisterInfo { Name = "OnSubmit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnSubmit
#endif
                    }},
                    {"CalculateLayoutInputHorizontal", new MemberRegisterInfo { Name = "CalculateLayoutInputHorizontal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_CalculateLayoutInputHorizontal
#endif
                    }},
                    {"CalculateLayoutInputVertical", new MemberRegisterInfo { Name = "CalculateLayoutInputVertical", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_CalculateLayoutInputVertical
#endif
                    }},
                    {"shouldHideMobileInput", new MemberRegisterInfo { Name = "shouldHideMobileInput", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_shouldHideMobileInput, PropertySetter = UnityEngine_UI_InputField_Wrap.S_shouldHideMobileInput
#endif
                    }},
                    {"shouldActivateOnSelect", new MemberRegisterInfo { Name = "shouldActivateOnSelect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_shouldActivateOnSelect, PropertySetter = UnityEngine_UI_InputField_Wrap.S_shouldActivateOnSelect
#endif
                    }},
                    {"text", new MemberRegisterInfo { Name = "text", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_text, PropertySetter = UnityEngine_UI_InputField_Wrap.S_text
#endif
                    }},
                    {"isFocused", new MemberRegisterInfo { Name = "isFocused", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_isFocused
#endif
                    }},
                    {"caretBlinkRate", new MemberRegisterInfo { Name = "caretBlinkRate", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretBlinkRate, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretBlinkRate
#endif
                    }},
                    {"caretWidth", new MemberRegisterInfo { Name = "caretWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretWidth, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretWidth
#endif
                    }},
                    {"textComponent", new MemberRegisterInfo { Name = "textComponent", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_textComponent, PropertySetter = UnityEngine_UI_InputField_Wrap.S_textComponent
#endif
                    }},
                    {"placeholder", new MemberRegisterInfo { Name = "placeholder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_placeholder, PropertySetter = UnityEngine_UI_InputField_Wrap.S_placeholder
#endif
                    }},
                    {"caretColor", new MemberRegisterInfo { Name = "caretColor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretColor, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretColor
#endif
                    }},
                    {"customCaretColor", new MemberRegisterInfo { Name = "customCaretColor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_customCaretColor, PropertySetter = UnityEngine_UI_InputField_Wrap.S_customCaretColor
#endif
                    }},
                    {"selectionColor", new MemberRegisterInfo { Name = "selectionColor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_selectionColor, PropertySetter = UnityEngine_UI_InputField_Wrap.S_selectionColor
#endif
                    }},
                    {"onEndEdit", new MemberRegisterInfo { Name = "onEndEdit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onEndEdit, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onEndEdit
#endif
                    }},
                    {"onSubmit", new MemberRegisterInfo { Name = "onSubmit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onSubmit, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onSubmit
#endif
                    }},
                    {"onValueChanged", new MemberRegisterInfo { Name = "onValueChanged", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onValueChanged, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onValueChanged
#endif
                    }},
                    {"onValidateInput", new MemberRegisterInfo { Name = "onValidateInput", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onValidateInput, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onValidateInput
#endif
                    }},
                    {"characterLimit", new MemberRegisterInfo { Name = "characterLimit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_characterLimit, PropertySetter = UnityEngine_UI_InputField_Wrap.S_characterLimit
#endif
                    }},
                    {"contentType", new MemberRegisterInfo { Name = "contentType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_contentType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_contentType
#endif
                    }},
                    {"lineType", new MemberRegisterInfo { Name = "lineType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_lineType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_lineType
#endif
                    }},
                    {"inputType", new MemberRegisterInfo { Name = "inputType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_inputType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_inputType
#endif
                    }},
                    {"touchScreenKeyboard", new MemberRegisterInfo { Name = "touchScreenKeyboard", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_touchScreenKeyboard
#endif
                    }},
                    {"keyboardType", new MemberRegisterInfo { Name = "keyboardType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_keyboardType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_keyboardType
#endif
                    }},
                    {"characterValidation", new MemberRegisterInfo { Name = "characterValidation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_characterValidation, PropertySetter = UnityEngine_UI_InputField_Wrap.S_characterValidation
#endif
                    }},
                    {"readOnly", new MemberRegisterInfo { Name = "readOnly", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_readOnly, PropertySetter = UnityEngine_UI_InputField_Wrap.S_readOnly
#endif
                    }},
                    {"multiLine", new MemberRegisterInfo { Name = "multiLine", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_multiLine
#endif
                    }},
                    {"asteriskChar", new MemberRegisterInfo { Name = "asteriskChar", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_asteriskChar, PropertySetter = UnityEngine_UI_InputField_Wrap.S_asteriskChar
#endif
                    }},
                    {"wasCanceled", new MemberRegisterInfo { Name = "wasCanceled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_wasCanceled
#endif
                    }},
                    {"caretPosition", new MemberRegisterInfo { Name = "caretPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretPosition, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretPosition
#endif
                    }},
                    {"selectionAnchorPosition", new MemberRegisterInfo { Name = "selectionAnchorPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_selectionAnchorPosition, PropertySetter = UnityEngine_UI_InputField_Wrap.S_selectionAnchorPosition
#endif
                    }},
                    {"selectionFocusPosition", new MemberRegisterInfo { Name = "selectionFocusPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_selectionFocusPosition, PropertySetter = UnityEngine_UI_InputField_Wrap.S_selectionFocusPosition
#endif
                    }},
                    {"minWidth", new MemberRegisterInfo { Name = "minWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_minWidth
#endif
                    }},
                    {"preferredWidth", new MemberRegisterInfo { Name = "preferredWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_preferredWidth
#endif
                    }},
                    {"flexibleWidth", new MemberRegisterInfo { Name = "flexibleWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_flexibleWidth
#endif
                    }},
                    {"minHeight", new MemberRegisterInfo { Name = "minHeight", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_minHeight
#endif
                    }},
                    {"preferredHeight", new MemberRegisterInfo { Name = "preferredHeight", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_preferredHeight
#endif
                    }},
                    {"flexibleHeight", new MemberRegisterInfo { Name = "flexibleHeight", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_flexibleHeight
#endif
                    }},
                    {"layoutPriority", new MemberRegisterInfo { Name = "layoutPriority", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_layoutPriority
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Toggle_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"Rebuild", new MemberRegisterInfo { Name = "Rebuild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_Rebuild
#endif
                    }},
                    {"LayoutComplete", new MemberRegisterInfo { Name = "LayoutComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_LayoutComplete
#endif
                    }},
                    {"GraphicUpdateComplete", new MemberRegisterInfo { Name = "GraphicUpdateComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_GraphicUpdateComplete
#endif
                    }},
                    {"SetIsOnWithoutNotify", new MemberRegisterInfo { Name = "SetIsOnWithoutNotify", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_SetIsOnWithoutNotify
#endif
                    }},
                    {"OnPointerClick", new MemberRegisterInfo { Name = "OnPointerClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_OnPointerClick
#endif
                    }},
                    {"OnSubmit", new MemberRegisterInfo { Name = "OnSubmit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_OnSubmit
#endif
                    }},
                    {"group", new MemberRegisterInfo { Name = "group", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_group, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_group
#endif
                    }},
                    {"isOn", new MemberRegisterInfo { Name = "isOn", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_isOn, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_isOn
#endif
                    }},
                    {"toggleTransition", new MemberRegisterInfo { Name = "toggleTransition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_toggleTransition, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_toggleTransition
#endif
                    }},
                    {"graphic", new MemberRegisterInfo { Name = "graphic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_graphic, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_graphic
#endif
                    }},
                    {"onValueChanged", new MemberRegisterInfo { Name = "onValueChanged", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_onValueChanged, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_onValueChanged
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Toggle_ToggleEvent_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_UI_Toggle_ToggleEvent_Wrap.Constructor
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap.Constructor
#endif
                    }},
                    {"AddListener", new MemberRegisterInfo { Name = "AddListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap.M_AddListener
#endif
                    }},
                    {"RemoveListener", new MemberRegisterInfo { Name = "RemoveListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap.M_RemoveListener
#endif
                    }},
                    {"Invoke", new MemberRegisterInfo { Name = "Invoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap.M_Invoke
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_PuertsDeclareTest_Plants_pumkinPeaShooter_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = PuertsDeclareTest_Plants_pumkinPeaShooter_Wrap.Constructor
#endif
                    }},
                    {"shoot", new MemberRegisterInfo { Name = "shoot", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsDeclareTest_Plants_pumkinPeaShooter_Wrap.M_shoot
#endif
                    }},
                    {"protect", new MemberRegisterInfo { Name = "protect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsDeclareTest_Plants_pumkinPeaShooter_Wrap.M_protect
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_PuertsDeclareTest_Plants_Shootable_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"shoot", new MemberRegisterInfo { Name = "shoot", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsDeclareTest_Plants_Shootable_Wrap.M_shoot
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_PuertsDeclareTest_Zombies_Walkable_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"action", new MemberRegisterInfo { Name = "action", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsDeclareTest_Zombies_Walkable_Wrap.M_action
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_PuertsDeclareTest_Zombies_Flyable_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"action", new MemberRegisterInfo { Name = "action", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = PuertsDeclareTest_Zombies_Flyable_Wrap.M_action
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_PuertsDeclareTest_Zombies_BalloonZombie_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = PuertsDeclareTest_Zombies_BalloonZombie_Wrap.Constructor
#endif
                    }},
                }
            };
        }

        public static void AddRegisterInfoGetterIntoJsEnv(JsEnv jsEnv)
        {
            
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Application), GetRegisterInfo_UnityEngine_Application_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Debug), GetRegisterInfo_UnityEngine_Debug_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(PuertsTest.TestClass), GetRegisterInfo_PuertsTest_TestClass_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Vector3), GetRegisterInfo_UnityEngine_Vector3_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(System.Collections.Generic.List<int>), GetRegisterInfo_System_Collections_Generic_List_1_System_Int32__Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>>), GetRegisterInfo_System_Collections_Generic_Dictionary_2_System_String_System_Collections_Generic_List_1_System_Int32___Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(PuertsTest.BaseClass), GetRegisterInfo_PuertsTest_BaseClass_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(PuertsTest.DerivedClass), GetRegisterInfo_PuertsTest_DerivedClass_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(PuertsTest.BaseClassExtension), GetRegisterInfo_PuertsTest_BaseClassExtension_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Time), GetRegisterInfo_UnityEngine_Time_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Transform), GetRegisterInfo_UnityEngine_Transform_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Component), GetRegisterInfo_UnityEngine_Component_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.GameObject), GetRegisterInfo_UnityEngine_GameObject_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Object), GetRegisterInfo_UnityEngine_Object_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(System.Delegate), GetRegisterInfo_System_Delegate_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(System.Object), GetRegisterInfo_System_Object_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(System.Type), GetRegisterInfo_System_Type_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.ParticleSystem), GetRegisterInfo_UnityEngine_ParticleSystem_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Canvas), GetRegisterInfo_UnityEngine_Canvas_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Behaviour), GetRegisterInfo_UnityEngine_Behaviour_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.MonoBehaviour), GetRegisterInfo_UnityEngine_MonoBehaviour_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(System.IO.File), GetRegisterInfo_System_IO_File_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Networking.UnityWebRequest), GetRegisterInfo_UnityEngine_Networking_UnityWebRequest_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Networking.DownloadHandler), GetRegisterInfo_UnityEngine_Networking_DownloadHandler_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.EventSystems.UIBehaviour), GetRegisterInfo_UnityEngine_EventSystems_UIBehaviour_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Selectable), GetRegisterInfo_UnityEngine_UI_Selectable_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Button), GetRegisterInfo_UnityEngine_UI_Button_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Button.ButtonClickedEvent), GetRegisterInfo_UnityEngine_UI_Button_ButtonClickedEvent_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Events.UnityEvent), GetRegisterInfo_UnityEngine_Events_UnityEvent_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.InputField), GetRegisterInfo_UnityEngine_UI_InputField_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Toggle), GetRegisterInfo_UnityEngine_UI_Toggle_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Toggle.ToggleEvent), GetRegisterInfo_UnityEngine_UI_Toggle_ToggleEvent_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Events.UnityEvent<bool>), GetRegisterInfo_UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(PuertsDeclareTest.Plants.pumkinPeaShooter), GetRegisterInfo_PuertsDeclareTest_Plants_pumkinPeaShooter_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(PuertsDeclareTest.Plants.Shootable), GetRegisterInfo_PuertsDeclareTest_Plants_Shootable_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(PuertsDeclareTest.Zombies.Walkable), GetRegisterInfo_PuertsDeclareTest_Zombies_Walkable_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(PuertsDeclareTest.Zombies.Flyable), GetRegisterInfo_PuertsDeclareTest_Zombies_Flyable_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(PuertsDeclareTest.Zombies.BalloonZombie), GetRegisterInfo_PuertsDeclareTest_Zombies_BalloonZombie_Wrap);
        }
    }
}