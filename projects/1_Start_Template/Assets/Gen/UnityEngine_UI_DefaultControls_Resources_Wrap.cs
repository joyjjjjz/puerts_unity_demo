#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_UI_DefaultControls_Resources_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.UI.DefaultControls.Resources();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.UI.DefaultControls.Resources), result);
                    }
                }

            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_standard(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.standard;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_standard(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Sprite arg0 = argobj0 != null ? (UnityEngine.Sprite)argobj0 : StaticTranslate<UnityEngine.Sprite>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.standard = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_background(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.background;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_background(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Sprite arg0 = argobj0 != null ? (UnityEngine.Sprite)argobj0 : StaticTranslate<UnityEngine.Sprite>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.background = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_inputField(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.inputField;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_inputField(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Sprite arg0 = argobj0 != null ? (UnityEngine.Sprite)argobj0 : StaticTranslate<UnityEngine.Sprite>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.inputField = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_knob(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.knob;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_knob(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Sprite arg0 = argobj0 != null ? (UnityEngine.Sprite)argobj0 : StaticTranslate<UnityEngine.Sprite>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.knob = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_checkmark(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.checkmark;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_checkmark(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Sprite arg0 = argobj0 != null ? (UnityEngine.Sprite)argobj0 : StaticTranslate<UnityEngine.Sprite>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.checkmark = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_dropdown(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.dropdown;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_dropdown(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Sprite arg0 = argobj0 != null ? (UnityEngine.Sprite)argobj0 : StaticTranslate<UnityEngine.Sprite>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.dropdown = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_mask(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.mask;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_mask(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.DefaultControls.Resources)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Sprite arg0 = argobj0 != null ? (UnityEngine.Sprite)argobj0 : StaticTranslate<UnityEngine.Sprite>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.mask = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
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
