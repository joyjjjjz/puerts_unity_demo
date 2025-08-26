#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_SubsystemManager_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.SubsystemManager).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_GetAllSubsystemDescriptors(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        System.Collections.Generic.List<UnityEngine.ISubsystemDescriptor> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.ISubsystemDescriptor>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.ISubsystemDescriptor>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        UnityEngine.SubsystemManager.GetAllSubsystemDescriptors (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
    // ==================== properties end ====================
    // ==================== array item get/set start ====================
    
    
    // ==================== array item get/set end ====================
    // ==================== operator start ====================
    // ==================== operator end ====================
    // ==================== events start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_beforeReloadSubsystems(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action arg0 = argobj0 != null ? (System.Action)argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.SubsystemManager.beforeReloadSubsystems += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_beforeReloadSubsystems(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action arg0 = argobj0 != null ? (System.Action)argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.SubsystemManager.beforeReloadSubsystems -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_afterReloadSubsystems(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action arg0 = argobj0 != null ? (System.Action)argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.SubsystemManager.afterReloadSubsystems += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_afterReloadSubsystems(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action arg0 = argobj0 != null ? (System.Action)argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.SubsystemManager.afterReloadSubsystems -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_reloadSubsytemsStarted(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action arg0 = argobj0 != null ? (System.Action)argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.SubsystemManager.reloadSubsytemsStarted += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_reloadSubsytemsStarted(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action arg0 = argobj0 != null ? (System.Action)argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.SubsystemManager.reloadSubsytemsStarted -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_reloadSubsytemsCompleted(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action arg0 = argobj0 != null ? (System.Action)argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.SubsystemManager.reloadSubsytemsCompleted += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_reloadSubsytemsCompleted(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action arg0 = argobj0 != null ? (System.Action)argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.SubsystemManager.reloadSubsytemsCompleted -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
