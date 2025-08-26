#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_UI_Navigation_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.UI.Navigation();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.UI.Navigation), result);
                    }
                }

            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Equals(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.UI.Navigation), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.UI.Navigation arg0 = argobj0 != null ? (UnityEngine.UI.Navigation)argobj0 : StaticTranslate<UnityEngine.UI.Navigation>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = obj.Equals (arg0);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        System.Object arg0 = argobj0 != null ? (System.Object)argobj0 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = obj.Equals (arg0);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Equals");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_mode(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.mode;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_mode(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.UI.Navigation.Mode arg0 = (UnityEngine.UI.Navigation.Mode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                obj.mode = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_wrapAround(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.wrapAround;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_wrapAround(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                obj.wrapAround = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_selectOnUp(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.selectOnUp;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_selectOnUp(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.UI.Selectable arg0 = argobj0 != null ? (UnityEngine.UI.Selectable)argobj0 : StaticTranslate<UnityEngine.UI.Selectable>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.selectOnUp = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_selectOnDown(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.selectOnDown;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_selectOnDown(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.UI.Selectable arg0 = argobj0 != null ? (UnityEngine.UI.Selectable)argobj0 : StaticTranslate<UnityEngine.UI.Selectable>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.selectOnDown = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_selectOnLeft(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.selectOnLeft;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_selectOnLeft(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.UI.Selectable arg0 = argobj0 != null ? (UnityEngine.UI.Selectable)argobj0 : StaticTranslate<UnityEngine.UI.Selectable>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.selectOnLeft = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_selectOnRight(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.selectOnRight;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_selectOnRight(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.UI.Navigation)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.UI.Selectable arg0 = argobj0 != null ? (UnityEngine.UI.Selectable)argobj0 : StaticTranslate<UnityEngine.UI.Selectable>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.selectOnRight = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_defaultNavigation(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.UI.Navigation.defaultNavigation;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
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
