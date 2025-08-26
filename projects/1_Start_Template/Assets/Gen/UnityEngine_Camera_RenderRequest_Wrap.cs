#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_Camera_RenderRequest_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                if (paramLen == 2)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Camera.RenderRequestMode), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        UnityEngine.Camera.RenderRequestMode arg0 = (UnityEngine.Camera.RenderRequestMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        var result = new UnityEngine.Camera.RenderRequest(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.Camera.RenderRequest), result);
                    }
                }
                if (paramLen == 3)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Camera.RenderRequestMode), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Camera.RenderRequestOutputSpace), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value2, ref argobj2, ref argType2))

                    {
                        UnityEngine.Camera.RenderRequestMode arg0 = (UnityEngine.Camera.RenderRequestMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.Camera.RenderRequestOutputSpace arg1 = (UnityEngine.Camera.RenderRequestOutputSpace)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.RenderTexture arg2 = argobj2 != null ? (UnityEngine.RenderTexture)argobj2 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        var result = new UnityEngine.Camera.RenderRequest(arg0, arg1, arg2);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.Camera.RenderRequest), result);
                    }
                }
                if (paramLen == 0)
                {

                    {
                        var result = new UnityEngine.Camera.RenderRequest();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.Camera.RenderRequest), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.Camera.RenderRequest).GetFriendlyName() + " constructor");
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
        internal static void G_isValid(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.Camera.RenderRequest)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.isValid;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_mode(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.Camera.RenderRequest)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.mode;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_result(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.Camera.RenderRequest)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.result;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_outputSpace(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.Camera.RenderRequest)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.outputSpace;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
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
