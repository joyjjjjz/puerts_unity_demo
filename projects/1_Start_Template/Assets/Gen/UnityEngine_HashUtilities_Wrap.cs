#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_HashUtilities_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.HashUtilities).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_AppendHash(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        UnityEngine.Hash128 arg0 = argobj0 != null ? (UnityEngine.Hash128)argobj0 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Hash128 arg1 = argobj1 != null ? (UnityEngine.Hash128)argobj1 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true);;

                        UnityEngine.HashUtilities.AppendHash (ref arg0, ref arg1);

                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_QuantisedMatrixHash(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        UnityEngine.Matrix4x4 arg0 = argobj0 != null ? (UnityEngine.Matrix4x4)argobj0 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Hash128 arg1 = argobj1 != null ? (UnityEngine.Hash128)argobj1 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true);;

                        UnityEngine.HashUtilities.QuantisedMatrixHash (ref arg0, ref arg1);

                        StaticTranslate<UnityEngine.Matrix4x4>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_QuantisedVectorHash(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Hash128 arg1 = argobj1 != null ? (UnityEngine.Hash128)argobj1 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true);;

                        UnityEngine.HashUtilities.QuantisedVectorHash (ref arg0, ref arg1);

                        StaticTranslate<UnityEngine.Vector3>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_ComputeHash128(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        byte[] arg0 = argobj0 != null ? (byte[])argobj0 : StaticTranslate<byte[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Hash128 arg1 = argobj1 != null ? (UnityEngine.Hash128)argobj1 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true);;

                        UnityEngine.HashUtilities.ComputeHash128 (arg0, ref arg1);

                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
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
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
