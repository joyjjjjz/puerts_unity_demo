#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_CombineInstance_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.CombineInstance();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.CombineInstance), result);
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
        internal static void G_mesh(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.mesh;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_mesh(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.mesh = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_subMeshIndex(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.subMeshIndex;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_subMeshIndex(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                obj.subMeshIndex = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_transform(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.transform;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_transform(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Matrix4x4 arg0 = argobj0 != null ? (UnityEngine.Matrix4x4)argobj0 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.transform = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_lightmapScaleOffset(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.lightmapScaleOffset;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_lightmapScaleOffset(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Vector4 arg0 = argobj0 != null ? (UnityEngine.Vector4)argobj0 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.lightmapScaleOffset = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_realtimeLightmapScaleOffset(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.realtimeLightmapScaleOffset;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_realtimeLightmapScaleOffset(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.CombineInstance)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Vector4 arg0 = argobj0 != null ? (UnityEngine.Vector4)argobj0 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.realtimeLightmapScaleOffset = arg0;
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
