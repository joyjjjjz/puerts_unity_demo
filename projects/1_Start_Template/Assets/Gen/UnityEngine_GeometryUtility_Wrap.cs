#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_GeometryUtility_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.GeometryUtility();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.GeometryUtility), result);
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
        internal static void F_CalculateFrustumPlanes(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.Camera arg0 = argobj0 != null ? (UnityEngine.Camera)argobj0 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = UnityEngine.GeometryUtility.CalculateFrustumPlanes (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.Matrix4x4 arg0 = argobj0 != null ? (UnityEngine.Matrix4x4)argobj0 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = UnityEngine.GeometryUtility.CalculateFrustumPlanes (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Plane[]), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Camera arg0 = argobj0 != null ? (UnityEngine.Camera)argobj0 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Plane[] arg1 = argobj1 != null ? (UnityEngine.Plane[])argobj1 : StaticTranslate<UnityEngine.Plane[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.GeometryUtility.CalculateFrustumPlanes (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Plane[]), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Matrix4x4 arg0 = argobj0 != null ? (UnityEngine.Matrix4x4)argobj0 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Plane[] arg1 = argobj1 != null ? (UnityEngine.Plane[])argobj1 : StaticTranslate<UnityEngine.Plane[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.GeometryUtility.CalculateFrustumPlanes (arg0, arg1);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CalculateFrustumPlanes");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CalculateBounds(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Vector3[] arg0 = argobj0 != null ? (UnityEngine.Vector3[])argobj0 : StaticTranslate<UnityEngine.Vector3[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        var result = UnityEngine.GeometryUtility.CalculateBounds (arg0, arg1);

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
        internal static void F_TryCreatePlaneFromPolygon(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Vector3[] arg0 = argobj0 != null ? (UnityEngine.Vector3[])argobj0 : StaticTranslate<UnityEngine.Vector3[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Plane arg1 = argobj1 != null ? (UnityEngine.Plane)argobj1 : StaticTranslate<UnityEngine.Plane>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true);;

                        var result = UnityEngine.GeometryUtility.TryCreatePlaneFromPolygon (arg0, out arg1);

                        StaticTranslate<UnityEngine.Plane>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_TestPlanesAABB(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Plane[] arg0 = argobj0 != null ? (UnityEngine.Plane[])argobj0 : StaticTranslate<UnityEngine.Plane[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        var result = UnityEngine.GeometryUtility.TestPlanesAABB (arg0, arg1);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
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
