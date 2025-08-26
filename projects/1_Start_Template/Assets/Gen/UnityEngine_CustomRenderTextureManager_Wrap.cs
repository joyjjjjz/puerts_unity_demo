#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_CustomRenderTextureManager_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.CustomRenderTextureManager).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_GetAllCustomRenderTextures(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        System.Collections.Generic.List<UnityEngine.CustomRenderTexture> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.CustomRenderTexture>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.CustomRenderTexture>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        UnityEngine.CustomRenderTextureManager.GetAllCustomRenderTextures (arg0);

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
        internal static void A_textureLoaded(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action<UnityEngine.CustomRenderTexture> arg0 = argobj0 != null ? (System.Action<UnityEngine.CustomRenderTexture>)argobj0 : StaticTranslate<System.Action<UnityEngine.CustomRenderTexture>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.CustomRenderTextureManager.textureLoaded += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_textureLoaded(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action<UnityEngine.CustomRenderTexture> arg0 = argobj0 != null ? (System.Action<UnityEngine.CustomRenderTexture>)argobj0 : StaticTranslate<System.Action<UnityEngine.CustomRenderTexture>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.CustomRenderTextureManager.textureLoaded -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_textureUnloaded(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action<UnityEngine.CustomRenderTexture> arg0 = argobj0 != null ? (System.Action<UnityEngine.CustomRenderTexture>)argobj0 : StaticTranslate<System.Action<UnityEngine.CustomRenderTexture>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.CustomRenderTextureManager.textureUnloaded += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_textureUnloaded(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action<UnityEngine.CustomRenderTexture> arg0 = argobj0 != null ? (System.Action<UnityEngine.CustomRenderTexture>)argobj0 : StaticTranslate<System.Action<UnityEngine.CustomRenderTexture>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.CustomRenderTextureManager.textureUnloaded -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_updateTriggered(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action<UnityEngine.CustomRenderTexture, int> arg0 = argobj0 != null ? (System.Action<UnityEngine.CustomRenderTexture, int>)argobj0 : StaticTranslate<System.Action<UnityEngine.CustomRenderTexture, int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.CustomRenderTextureManager.updateTriggered += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_updateTriggered(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action<UnityEngine.CustomRenderTexture, int> arg0 = argobj0 != null ? (System.Action<UnityEngine.CustomRenderTexture, int>)argobj0 : StaticTranslate<System.Action<UnityEngine.CustomRenderTexture, int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.CustomRenderTextureManager.updateTriggered -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_initializeTriggered(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action<UnityEngine.CustomRenderTexture> arg0 = argobj0 != null ? (System.Action<UnityEngine.CustomRenderTexture>)argobj0 : StaticTranslate<System.Action<UnityEngine.CustomRenderTexture>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.CustomRenderTextureManager.initializeTriggered += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_initializeTriggered(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                System.Action<UnityEngine.CustomRenderTexture> arg0 = argobj0 != null ? (System.Action<UnityEngine.CustomRenderTexture>)argobj0 : StaticTranslate<System.Action<UnityEngine.CustomRenderTexture>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.CustomRenderTextureManager.initializeTriggered -= arg0;
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
