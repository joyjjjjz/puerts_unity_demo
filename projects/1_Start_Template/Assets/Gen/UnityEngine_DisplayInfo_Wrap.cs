#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_DisplayInfo_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.DisplayInfo();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.DisplayInfo), result);
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
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.DisplayInfo), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.DisplayInfo arg0 = argobj0 != null ? (UnityEngine.DisplayInfo)argobj0 : StaticTranslate<UnityEngine.DisplayInfo>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

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
        internal static void G_width(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.width;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_width(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                obj.width = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_height(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.height;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_height(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                obj.height = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_refreshRate(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.refreshRate;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_refreshRate(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.RefreshRate arg0 = argobj0 != null ? (UnityEngine.RefreshRate)argobj0 : StaticTranslate<UnityEngine.RefreshRate>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.refreshRate = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_workArea(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.workArea;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_workArea(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.RectInt arg0 = argobj0 != null ? (UnityEngine.RectInt)argobj0 : StaticTranslate<UnityEngine.RectInt>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.workArea = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_name(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.name;
                Puerts.PuertsDLL.ReturnString(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_name(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.DisplayInfo)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                obj.name = arg0;
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
