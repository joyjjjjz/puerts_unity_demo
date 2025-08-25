#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class PuertsTest_BaseClassExtension_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(PuertsTest.BaseClassExtension).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_PlainExtension(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        PuertsTest.BaseClass arg0 = argobj0 != null ? (PuertsTest.BaseClass)argobj0 : StaticTranslate<PuertsTest.BaseClass>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        PuertsTest.BaseClassExtension.PlainExtension (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Extension1(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        PuertsTest.BaseClass arg0 = argobj0 != null ? (PuertsTest.BaseClass)argobj0 : StaticTranslate<PuertsTest.BaseClass>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = PuertsTest.BaseClassExtension.Extension1 (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Extension2(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(PuertsTest.BaseClass), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GameObject), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        PuertsTest.BaseClass arg0 = argobj0 != null ? (PuertsTest.BaseClass)argobj0 : StaticTranslate<PuertsTest.BaseClass>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        var result = PuertsTest.BaseClassExtension.Extension2 (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(PuertsTest.BaseClass), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(PuertsTest.BaseClass1), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        PuertsTest.BaseClass arg0 = argobj0 != null ? (PuertsTest.BaseClass)argobj0 : StaticTranslate<PuertsTest.BaseClass>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        PuertsTest.BaseClass1 arg1 = argobj1 != null ? (PuertsTest.BaseClass1)argobj1 : StaticTranslate<PuertsTest.BaseClass1>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        PuertsTest.BaseClassExtension.Extension2 (arg0, arg1);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Extension2");
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
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
