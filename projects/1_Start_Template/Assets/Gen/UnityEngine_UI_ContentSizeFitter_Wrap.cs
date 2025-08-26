#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_UI_ContentSizeFitter_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {


                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.UI.ContentSizeFitter).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetLayoutHorizontal(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.ContentSizeFitter;
        
                {
            
                    {

                        obj.SetLayoutHorizontal ();

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetLayoutVertical(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.ContentSizeFitter;
        
                {
            
                    {

                        obj.SetLayoutVertical ();

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
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_horizontalFit(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.ContentSizeFitter;
                var result = obj.horizontalFit;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_horizontalFit(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.ContentSizeFitter;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.UI.ContentSizeFitter.FitMode arg0 = (UnityEngine.UI.ContentSizeFitter.FitMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                obj.horizontalFit = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_verticalFit(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.ContentSizeFitter;
                var result = obj.verticalFit;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_verticalFit(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.ContentSizeFitter;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.UI.ContentSizeFitter.FitMode arg0 = (UnityEngine.UI.ContentSizeFitter.FitMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                obj.verticalFit = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== properties end ====================
    // ==================== array item get/set start ====================
    
    
    // ==================== array item get/set end ====================
    // ==================== operator start ====================
    // ==================== operator end ====================
    // ==================== events start ====================
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
