#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_Graphics_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.Graphics();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.Graphics), result);
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
        internal static void F_ClearRandomWriteTargets(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    {

                        UnityEngine.Graphics.ClearRandomWriteTargets ();

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_ExecuteCommandBuffer(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Rendering.CommandBuffer arg0 = argobj0 != null ? (UnityEngine.Rendering.CommandBuffer)argobj0 : StaticTranslate<UnityEngine.Rendering.CommandBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        UnityEngine.Graphics.ExecuteCommandBuffer (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_ExecuteCommandBufferAsync(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Rendering.CommandBuffer arg0 = argobj0 != null ? (UnityEngine.Rendering.CommandBuffer)argobj0 : StaticTranslate<UnityEngine.Rendering.CommandBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Rendering.ComputeQueueType arg1 = (UnityEngine.Rendering.ComputeQueueType)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        UnityEngine.Graphics.ExecuteCommandBufferAsync (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_SetRenderTarget(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CubemapFace), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.RenderTexture arg0 = argobj0 != null ? (UnityEngine.RenderTexture)argobj0 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.CubemapFace arg2 = (UnityEngine.CubemapFace)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.SetRenderTarget (arg0, arg1, arg2, arg3);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CubemapFace), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.RenderBuffer arg0 = argobj0 != null ? (UnityEngine.RenderBuffer)argobj0 : StaticTranslate<UnityEngine.RenderBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderBuffer arg1 = argobj1 != null ? (UnityEngine.RenderBuffer)argobj1 : StaticTranslate<UnityEngine.RenderBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.CubemapFace arg3 = (UnityEngine.CubemapFace)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);

                        UnityEngine.Graphics.SetRenderTarget (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CubemapFace), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.RenderBuffer arg0 = argobj0 != null ? (UnityEngine.RenderBuffer)argobj0 : StaticTranslate<UnityEngine.RenderBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderBuffer arg1 = argobj1 != null ? (UnityEngine.RenderBuffer)argobj1 : StaticTranslate<UnityEngine.RenderBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.CubemapFace arg3 = (UnityEngine.CubemapFace)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.SetRenderTarget (arg0, arg1, arg2, arg3, arg4);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer[]), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.RenderBuffer[] arg0 = argobj0 != null ? (UnityEngine.RenderBuffer[])argobj0 : StaticTranslate<UnityEngine.RenderBuffer[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderBuffer arg1 = argobj1 != null ? (UnityEngine.RenderBuffer)argobj1 : StaticTranslate<UnityEngine.RenderBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.SetRenderTarget (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.RenderTexture arg0 = argobj0 != null ? (UnityEngine.RenderTexture)argobj0 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        UnityEngine.Graphics.SetRenderTarget (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.RenderBuffer arg0 = argobj0 != null ? (UnityEngine.RenderBuffer)argobj0 : StaticTranslate<UnityEngine.RenderBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderBuffer arg1 = argobj1 != null ? (UnityEngine.RenderBuffer)argobj1 : StaticTranslate<UnityEngine.RenderBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.SetRenderTarget (arg0, arg1);

                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTargetSetup), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.RenderTargetSetup arg0 = argobj0 != null ? (UnityEngine.RenderTargetSetup)argobj0 : StaticTranslate<UnityEngine.RenderTargetSetup>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        UnityEngine.Graphics.SetRenderTarget (arg0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.RenderTexture arg0 = argobj0 != null ? (UnityEngine.RenderTexture)argobj0 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        UnityEngine.Graphics.SetRenderTarget (arg0);

                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CubemapFace), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.RenderTexture arg0 = argobj0 != null ? (UnityEngine.RenderTexture)argobj0 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.CubemapFace arg2 = (UnityEngine.CubemapFace)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);

                        UnityEngine.Graphics.SetRenderTarget (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.RenderBuffer arg0 = argobj0 != null ? (UnityEngine.RenderBuffer)argobj0 : StaticTranslate<UnityEngine.RenderBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderBuffer arg1 = argobj1 != null ? (UnityEngine.RenderBuffer)argobj1 : StaticTranslate<UnityEngine.RenderBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.SetRenderTarget (arg0, arg1, arg2);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to SetRenderTarget");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_SetRandomWriteTarget(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.SetRandomWriteTarget (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        UnityEngine.ComputeBuffer arg1 = argobj1 != null ? (UnityEngine.ComputeBuffer)argobj1 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.SetRandomWriteTarget (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.SetRandomWriteTarget (arg0, arg1);

                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        UnityEngine.ComputeBuffer arg1 = argobj1 != null ? (UnityEngine.ComputeBuffer)argobj1 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.SetRandomWriteTarget (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.SetRandomWriteTarget (arg0, arg1, arg2);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to SetRandomWriteTarget");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CopyTexture(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.CopyTexture (arg0, arg1);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Texture arg2 = argobj2 != null ? (UnityEngine.Texture)argobj2 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.CopyTexture (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.Texture arg3 = argobj3 != null ? (UnityEngine.Texture)argobj3 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.CopyTexture (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                }
                if (paramLen == 12)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    IntPtr v8Value11 = PuertsDLL.GetArgumentValue(isolate, info, 11);
                    object argobj11 = null;
                    JsValueType argType11 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value10, ref argobj10, ref argType10) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value11, ref argobj11, ref argType11))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.Texture arg7 = argobj7 != null ? (UnityEngine.Texture)argobj7 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);
                        int arg10 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value10, false);
                        int arg11 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value11, false);

                        UnityEngine.Graphics.CopyTexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CopyTexture");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_ConvertTexture(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        var result = UnityEngine.Graphics.ConvertTexture (arg0, arg1);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Texture arg2 = argobj2 != null ? (UnityEngine.Texture)argobj2 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = UnityEngine.Graphics.ConvertTexture (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to ConvertTexture");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CreateAsyncGraphicsFence(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.SynchronisationStage), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.Rendering.SynchronisationStage arg0 = (UnityEngine.Rendering.SynchronisationStage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);

                        var result = UnityEngine.Graphics.CreateAsyncGraphicsFence (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 0)
                {
            
                    {

                        var result = UnityEngine.Graphics.CreateAsyncGraphicsFence ();

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CreateAsyncGraphicsFence");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CreateGraphicsFence(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Rendering.GraphicsFenceType arg0 = (UnityEngine.Rendering.GraphicsFenceType)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.Rendering.SynchronisationStageFlags arg1 = (UnityEngine.Rendering.SynchronisationStageFlags)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        var result = UnityEngine.Graphics.CreateGraphicsFence (arg0, arg1);

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
        internal static void F_WaitOnAsyncGraphicsFence(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rendering.GraphicsFence), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.Rendering.GraphicsFence arg0 = argobj0 != null ? (UnityEngine.Rendering.GraphicsFence)argobj0 : StaticTranslate<UnityEngine.Rendering.GraphicsFence>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        UnityEngine.Graphics.WaitOnAsyncGraphicsFence (arg0);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rendering.GraphicsFence), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.SynchronisationStage), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Rendering.GraphicsFence arg0 = argobj0 != null ? (UnityEngine.Rendering.GraphicsFence)argobj0 : StaticTranslate<UnityEngine.Rendering.GraphicsFence>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Rendering.SynchronisationStage arg1 = (UnityEngine.Rendering.SynchronisationStage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        UnityEngine.Graphics.WaitOnAsyncGraphicsFence (arg0, arg1);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to WaitOnAsyncGraphicsFence");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CopyBuffer(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.GraphicsBuffer arg0 = argobj0 != null ? (UnityEngine.GraphicsBuffer)argobj0 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.CopyBuffer (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawTexture(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 10)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Color), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Rect arg2 = argobj2 != null ? (UnityEngine.Rect)argobj2 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.Color arg7 = argobj7 != null ? (UnityEngine.Color)argobj7 : StaticTranslate<UnityEngine.Color>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Material arg8 = argobj8 != null ? (UnityEngine.Material)argobj8 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value8, false);;
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                }
                if (paramLen == 9)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Rect arg2 = argobj2 != null ? (UnityEngine.Rect)argobj2 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.Material arg7 = argobj7 != null ? (UnityEngine.Material)argobj7 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Color), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Rect arg2 = argobj2 != null ? (UnityEngine.Rect)argobj2 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.Color arg7 = argobj7 != null ? (UnityEngine.Color)argobj7 : StaticTranslate<UnityEngine.Color>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Material arg8 = argobj8 != null ? (UnityEngine.Material)argobj8 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value8, false);;

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

                        return;
                    }
                }
                if (paramLen == 8)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Material arg6 = argobj6 != null ? (UnityEngine.Material)argobj6 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        int arg7 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value7, false);

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Color), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Rect arg2 = argobj2 != null ? (UnityEngine.Rect)argobj2 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.Color arg7 = argobj7 != null ? (UnityEngine.Color)argobj7 : StaticTranslate<UnityEngine.Color>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Rect arg2 = argobj2 != null ? (UnityEngine.Rect)argobj2 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.Material arg7 = argobj7 != null ? (UnityEngine.Material)argobj7 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                if (paramLen == 7)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Rect arg2 = argobj2 != null ? (UnityEngine.Rect)argobj2 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Material arg6 = argobj6 != null ? (UnityEngine.Material)argobj6 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        return;
                    }
                }
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Graphics.DrawTexture (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.DrawTexture (arg0, arg1);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawTexture");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RenderMesh(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Matrix4x4>), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Mesh arg1 = argobj1 != null ? (UnityEngine.Mesh)argobj1 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.Matrix4x4 arg3 = argobj3 != null ? (UnityEngine.Matrix4x4)argobj3 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        System.Nullable<UnityEngine.Matrix4x4> arg4 = argobj4 != null ? (System.Nullable<UnityEngine.Matrix4x4>)argobj4 : StaticTranslate<System.Nullable<UnityEngine.Matrix4x4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEngine.Graphics.RenderMesh (in arg0, arg1, arg2, arg3, arg4);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Mesh arg1 = argobj1 != null ? (UnityEngine.Mesh)argobj1 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.Matrix4x4 arg3 = argobj3 != null ? (UnityEngine.Matrix4x4)argobj3 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Graphics.RenderMesh (in arg0, arg1, arg2, arg3, default(System.Nullable<UnityEngine.Matrix4x4>));

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to RenderMesh");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RenderMeshIndirect(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Mesh arg1 = argobj1 != null ? (UnityEngine.Mesh)argobj1 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.RenderMeshIndirect (in arg0, arg1, arg2, arg3, arg4);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Mesh arg1 = argobj1 != null ? (UnityEngine.Mesh)argobj1 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.RenderMeshIndirect (in arg0, arg1, arg2, arg3, 0);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Mesh arg1 = argobj1 != null ? (UnityEngine.Mesh)argobj1 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Graphics.RenderMeshIndirect (in arg0, arg1, arg2, 1, 0);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to RenderMeshIndirect");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RenderMeshPrimitives(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Mesh arg1 = argobj1 != null ? (UnityEngine.Mesh)argobj1 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.RenderMeshPrimitives (in arg0, arg1, arg2, arg3);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.Mesh arg1 = argobj1 != null ? (UnityEngine.Mesh)argobj1 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.RenderMeshPrimitives (in arg0, arg1, arg2, 1);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to RenderMeshPrimitives");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RenderPrimitives(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.RenderPrimitives (in arg0, arg1, arg2, arg3);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.RenderPrimitives (in arg0, arg1, arg2, 1);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to RenderPrimitives");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RenderPrimitivesIndexed(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.RenderPrimitivesIndexed (in arg0, arg1, arg2, arg3, arg4, arg5);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.RenderPrimitivesIndexed (in arg0, arg1, arg2, arg3, arg4, 1);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.RenderPrimitivesIndexed (in arg0, arg1, arg2, arg3, 0, 1);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to RenderPrimitivesIndexed");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RenderPrimitivesIndirect(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.RenderPrimitivesIndirect (in arg0, arg1, arg2, arg3, arg4);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.RenderPrimitivesIndirect (in arg0, arg1, arg2, arg3, 0);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Graphics.RenderPrimitivesIndirect (in arg0, arg1, arg2, 1, 0);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to RenderPrimitivesIndirect");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RenderPrimitivesIndexedIndirect(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.RenderPrimitivesIndexedIndirect (in arg0, arg1, arg2, arg3, arg4, arg5);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.RenderPrimitivesIndexedIndirect (in arg0, arg1, arg2, arg3, arg4, 0);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderParams), true, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.RenderParams arg0 = argobj0 != null ? (UnityEngine.RenderParams)argobj0 : StaticTranslate<UnityEngine.RenderParams>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        UnityEngine.MeshTopology arg1 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Graphics.RenderPrimitivesIndexedIndirect (in arg0, arg1, arg2, arg3, 1, 0);

                        StaticTranslate<UnityEngine.RenderParams>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to RenderPrimitivesIndexedIndirect");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawMeshNow(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.DrawMeshNow (arg0, arg1, arg2, arg3);

                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.DrawMeshNow (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Graphics.DrawMeshNow (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.DrawMeshNow (arg0, arg1);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawMeshNow");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawMesh(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 11)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);
                        bool arg10 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value10, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);
                        UnityEngine.Transform arg10 = argobj10 != null ? (UnityEngine.Transform)argobj10 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value10, false);;

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        UnityEngine.Transform arg9 = argobj9 != null ? (UnityEngine.Transform)argobj9 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;
                        bool arg10 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value10, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        UnityEngine.Transform arg9 = argobj9 != null ? (UnityEngine.Transform)argobj9 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;
                        UnityEngine.Rendering.LightProbeUsage arg10 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value10, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                        return;
                    }
                }
                if (paramLen == 12)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    IntPtr v8Value11 = PuertsDLL.GetArgumentValue(isolate, info, 11);
                    object argobj11 = null;
                    JsValueType argType11 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value10, ref argobj10, ref argType10) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value11, ref argobj11, ref argType11))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);
                        UnityEngine.Transform arg10 = argobj10 != null ? (UnityEngine.Transform)argobj10 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value10, false);;
                        bool arg11 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value11, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value10, ref argobj10, ref argType10) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.LightProbeProxyVolume), false, false, v8Value11, ref argobj11, ref argType11))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        UnityEngine.Transform arg9 = argobj9 != null ? (UnityEngine.Transform)argobj9 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;
                        UnityEngine.Rendering.LightProbeUsage arg10 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value10, false);
                        UnityEngine.LightProbeProxyVolume arg11 = argobj11 != null ? (UnityEngine.LightProbeProxyVolume)argobj11 : StaticTranslate<UnityEngine.LightProbeProxyVolume>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value11, false);;

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

                        return;
                    }
                }
                if (paramLen == 10)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        UnityEngine.Transform arg9 = argobj9 != null ? (UnityEngine.Transform)argobj9 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4);

                        return;
                    }
                }
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                }
                if (paramLen == 7)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        return;
                    }
                }
                if (paramLen == 8)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                }
                if (paramLen == 9)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Material arg3 = argobj3 != null ? (UnityEngine.Material)argobj3 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Camera arg4 = argobj4 != null ? (UnityEngine.Camera)argobj4 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Matrix4x4 arg1 = argobj1 != null ? (UnityEngine.Matrix4x4)argobj1 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.DrawMesh (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawMesh");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawMeshInstanced(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 12)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    IntPtr v8Value11 = PuertsDLL.GetArgumentValue(isolate, info, 11);
                    object argobj11 = null;
                    JsValueType argType11 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value10, ref argobj10, ref argType10) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.LightProbeProxyVolume), false, false, v8Value11, ref argobj11, ref argType11))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Matrix4x4[] arg3 = argobj3 != null ? (UnityEngine.Matrix4x4[])argobj3 : StaticTranslate<UnityEngine.Matrix4x4[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);
                        UnityEngine.Camera arg9 = argobj9 != null ? (UnityEngine.Camera)argobj9 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;
                        UnityEngine.Rendering.LightProbeUsage arg10 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value10, false);
                        UnityEngine.LightProbeProxyVolume arg11 = argobj11 != null ? (UnityEngine.LightProbeProxyVolume)argobj11 : StaticTranslate<UnityEngine.LightProbeProxyVolume>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value11, false);;

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

                        return;
                    }
                }
                if (paramLen == 11)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.LightProbeProxyVolume), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Matrix4x4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Matrix4x4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Matrix4x4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.MaterialPropertyBlock arg4 = argobj4 != null ? (UnityEngine.MaterialPropertyBlock)argobj4 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg5 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value5, false);
                        bool arg6 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value6, false);
                        int arg7 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value7, false);
                        UnityEngine.Camera arg8 = argobj8 != null ? (UnityEngine.Camera)argobj8 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value8, false);;
                        UnityEngine.Rendering.LightProbeUsage arg9 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value9, false);
                        UnityEngine.LightProbeProxyVolume arg10 = argobj10 != null ? (UnityEngine.LightProbeProxyVolume)argobj10 : StaticTranslate<UnityEngine.LightProbeProxyVolume>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value10, false);;

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Matrix4x4[] arg3 = argobj3 != null ? (UnityEngine.Matrix4x4[])argobj3 : StaticTranslate<UnityEngine.Matrix4x4[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);
                        UnityEngine.Camera arg9 = argobj9 != null ? (UnityEngine.Camera)argobj9 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;
                        UnityEngine.Rendering.LightProbeUsage arg10 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value10, false);

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4[]), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Matrix4x4[] arg3 = argobj3 != null ? (UnityEngine.Matrix4x4[])argobj3 : StaticTranslate<UnityEngine.Matrix4x4[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Matrix4x4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Matrix4x4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Matrix4x4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Matrix4x4[] arg3 = argobj3 != null ? (UnityEngine.Matrix4x4[])argobj3 : StaticTranslate<UnityEngine.Matrix4x4[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Matrix4x4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Matrix4x4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Matrix4x4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.MaterialPropertyBlock arg4 = argobj4 != null ? (UnityEngine.MaterialPropertyBlock)argobj4 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4);

                        return;
                    }
                }
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Matrix4x4[] arg3 = argobj3 != null ? (UnityEngine.Matrix4x4[])argobj3 : StaticTranslate<UnityEngine.Matrix4x4[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Matrix4x4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Matrix4x4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Matrix4x4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.MaterialPropertyBlock arg4 = argobj4 != null ? (UnityEngine.MaterialPropertyBlock)argobj4 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg5 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value5, false);

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                }
                if (paramLen == 7)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Matrix4x4[] arg3 = argobj3 != null ? (UnityEngine.Matrix4x4[])argobj3 : StaticTranslate<UnityEngine.Matrix4x4[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Matrix4x4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Matrix4x4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Matrix4x4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.MaterialPropertyBlock arg4 = argobj4 != null ? (UnityEngine.MaterialPropertyBlock)argobj4 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg5 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value5, false);
                        bool arg6 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value6, false);

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        return;
                    }
                }
                if (paramLen == 8)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Matrix4x4[] arg3 = argobj3 != null ? (UnityEngine.Matrix4x4[])argobj3 : StaticTranslate<UnityEngine.Matrix4x4[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Matrix4x4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Matrix4x4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Matrix4x4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.MaterialPropertyBlock arg4 = argobj4 != null ? (UnityEngine.MaterialPropertyBlock)argobj4 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg5 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value5, false);
                        bool arg6 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value6, false);
                        int arg7 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value7, false);

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                }
                if (paramLen == 9)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Matrix4x4[] arg3 = argobj3 != null ? (UnityEngine.Matrix4x4[])argobj3 : StaticTranslate<UnityEngine.Matrix4x4[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Matrix4x4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Matrix4x4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Matrix4x4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.MaterialPropertyBlock arg4 = argobj4 != null ? (UnityEngine.MaterialPropertyBlock)argobj4 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg5 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value5, false);
                        bool arg6 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value6, false);
                        int arg7 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value7, false);
                        UnityEngine.Camera arg8 = argobj8 != null ? (UnityEngine.Camera)argobj8 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value8, false);;

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

                        return;
                    }
                }
                if (paramLen == 10)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Matrix4x4[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Matrix4x4[] arg3 = argobj3 != null ? (UnityEngine.Matrix4x4[])argobj3 : StaticTranslate<UnityEngine.Matrix4x4[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);
                        UnityEngine.Camera arg9 = argobj9 != null ? (UnityEngine.Camera)argobj9 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Matrix4x4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Matrix4x4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Matrix4x4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.MaterialPropertyBlock arg4 = argobj4 != null ? (UnityEngine.MaterialPropertyBlock)argobj4 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg5 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value5, false);
                        bool arg6 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value6, false);
                        int arg7 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value7, false);
                        UnityEngine.Camera arg8 = argobj8 != null ? (UnityEngine.Camera)argobj8 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value8, false);;
                        UnityEngine.Rendering.LightProbeUsage arg9 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value9, false);

                        UnityEngine.Graphics.DrawMeshInstanced (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawMeshInstanced");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawMeshInstancedProcedural(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 12)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    IntPtr v8Value11 = PuertsDLL.GetArgumentValue(isolate, info, 11);
                    object argobj11 = null;
                    JsValueType argType11 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value10, ref argobj10, ref argType10) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.LightProbeProxyVolume), false, false, v8Value11, ref argobj11, ref argType11))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);
                        UnityEngine.Camera arg9 = argobj9 != null ? (UnityEngine.Camera)argobj9 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;
                        UnityEngine.Rendering.LightProbeUsage arg10 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value10, false);
                        UnityEngine.LightProbeProxyVolume arg11 = argobj11 != null ? (UnityEngine.LightProbeProxyVolume)argobj11 : StaticTranslate<UnityEngine.LightProbeProxyVolume>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value11, false);;

                        UnityEngine.Graphics.DrawMeshInstancedProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

                        return;
                    }
                }
                if (paramLen == 11)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);
                        UnityEngine.Camera arg9 = argobj9 != null ? (UnityEngine.Camera)argobj9 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;
                        UnityEngine.Rendering.LightProbeUsage arg10 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value10, false);

                        UnityEngine.Graphics.DrawMeshInstancedProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, default(UnityEngine.LightProbeProxyVolume));

                        return;
                    }
                }
                if (paramLen == 10)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);
                        UnityEngine.Camera arg9 = argobj9 != null ? (UnityEngine.Camera)argobj9 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;

                        UnityEngine.Graphics.DrawMeshInstancedProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, (UnityEngine.Rendering.LightProbeUsage)(1), default(UnityEngine.LightProbeProxyVolume));

                        return;
                    }
                }
                if (paramLen == 9)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);
                        int arg8 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawMeshInstancedProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1), default(UnityEngine.LightProbeProxyVolume));

                        return;
                    }
                }
                if (paramLen == 8)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);

                        UnityEngine.Graphics.DrawMeshInstancedProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1), default(UnityEngine.LightProbeProxyVolume));

                        return;
                    }
                }
                if (paramLen == 7)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg6 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value6, false);

                        UnityEngine.Graphics.DrawMeshInstancedProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1), default(UnityEngine.LightProbeProxyVolume));

                        return;
                    }
                }
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.MaterialPropertyBlock arg5 = argobj5 != null ? (UnityEngine.MaterialPropertyBlock)argobj5 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;

                        UnityEngine.Graphics.DrawMeshInstancedProcedural (arg0, arg1, arg2, arg3, arg4, arg5, (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1), default(UnityEngine.LightProbeProxyVolume));

                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.DrawMeshInstancedProcedural (arg0, arg1, arg2, arg3, arg4, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1), default(UnityEngine.LightProbeProxyVolume));

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawMeshInstancedProcedural");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawMeshInstancedIndirect(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 13)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    IntPtr v8Value11 = PuertsDLL.GetArgumentValue(isolate, info, 11);
                    object argobj11 = null;
                    JsValueType argType11 = JsValueType.Invalid;
                    IntPtr v8Value12 = PuertsDLL.GetArgumentValue(isolate, info, 12);
                    object argobj12 = null;
                    JsValueType argType12 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value10, ref argobj10, ref argType10) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value11, ref argobj11, ref argType11) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.LightProbeProxyVolume), false, false, v8Value12, ref argobj12, ref argType12))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);
                        UnityEngine.Camera arg10 = argobj10 != null ? (UnityEngine.Camera)argobj10 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value10, false);;
                        UnityEngine.Rendering.LightProbeUsage arg11 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value11, false);
                        UnityEngine.LightProbeProxyVolume arg12 = argobj12 != null ? (UnityEngine.LightProbeProxyVolume)argobj12 : StaticTranslate<UnityEngine.LightProbeProxyVolume>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value12, false);;

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value10, ref argobj10, ref argType10) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value11, ref argobj11, ref argType11) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.LightProbeProxyVolume), false, false, v8Value12, ref argobj12, ref argType12))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);
                        UnityEngine.Camera arg10 = argobj10 != null ? (UnityEngine.Camera)argobj10 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value10, false);;
                        UnityEngine.Rendering.LightProbeUsage arg11 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value11, false);
                        UnityEngine.LightProbeProxyVolume arg12 = argobj12 != null ? (UnityEngine.LightProbeProxyVolume)argobj12 : StaticTranslate<UnityEngine.LightProbeProxyVolume>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value12, false);;

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

                        return;
                    }
                }
                if (paramLen == 12)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    IntPtr v8Value11 = PuertsDLL.GetArgumentValue(isolate, info, 11);
                    object argobj11 = null;
                    JsValueType argType11 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value10, ref argobj10, ref argType10) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value11, ref argobj11, ref argType11))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);
                        UnityEngine.Camera arg10 = argobj10 != null ? (UnityEngine.Camera)argobj10 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value10, false);;
                        UnityEngine.Rendering.LightProbeUsage arg11 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value11, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value10, ref argobj10, ref argType10) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.LightProbeUsage), false, false, v8Value11, ref argobj11, ref argType11))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);
                        UnityEngine.Camera arg10 = argobj10 != null ? (UnityEngine.Camera)argobj10 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value10, false);;
                        UnityEngine.Rendering.LightProbeUsage arg11 = (UnityEngine.Rendering.LightProbeUsage)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value11, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

                        return;
                    }
                }
                if (paramLen == 11)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);
                        UnityEngine.Camera arg10 = argobj10 != null ? (UnityEngine.Camera)argobj10 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value10, false);;

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);
                        UnityEngine.Camera arg10 = argobj10 != null ? (UnityEngine.Camera)argobj10 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value10, false);;

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                }
                if (paramLen == 10)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                }
                if (paramLen == 9)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                }
                if (paramLen == 8)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                }
                if (paramLen == 7)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                }
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, arg5, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, 0, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Bounds arg3 = argobj3 != null ? (UnityEngine.Bounds)argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEngine.Graphics.DrawMeshInstancedIndirect (arg0, arg1, arg2, arg3, arg4, 0, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0, default(UnityEngine.Camera), (UnityEngine.Rendering.LightProbeUsage)(1));

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawMeshInstancedIndirect");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawProceduralNow(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.DrawProceduralNow (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.DrawProceduralNow (arg0, arg1, arg2, 1);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        UnityEngine.Graphics.DrawProceduralNow (arg0, arg1, 1);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.DrawProceduralNow (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawProceduralNow");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawProceduralIndirectNow(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.ComputeBuffer arg1 = argobj1 != null ? (UnityEngine.ComputeBuffer)argobj1 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.DrawProceduralIndirectNow (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.ComputeBuffer arg2 = argobj2 != null ? (UnityEngine.ComputeBuffer)argobj2 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Graphics.DrawProceduralIndirectNow (arg0, arg1, arg2, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.DrawProceduralIndirectNow (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Graphics.DrawProceduralIndirectNow (arg0, arg1, arg2, 0);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.ComputeBuffer arg1 = argobj1 != null ? (UnityEngine.ComputeBuffer)argobj1 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.DrawProceduralIndirectNow (arg0, arg1, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.DrawProceduralIndirectNow (arg0, arg1, 0);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.ComputeBuffer arg2 = argobj2 != null ? (UnityEngine.ComputeBuffer)argobj2 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.DrawProceduralIndirectNow (arg0, arg1, arg2, arg3);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.MeshTopology arg0 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GraphicsBuffer arg1 = argobj1 != null ? (UnityEngine.GraphicsBuffer)argobj1 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.GraphicsBuffer arg2 = argobj2 != null ? (UnityEngine.GraphicsBuffer)argobj2 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.DrawProceduralIndirectNow (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawProceduralIndirectNow");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawProcedural(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 10)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, 0);

                        return;
                    }
                }
                if (paramLen == 9)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, true, 0);

                        return;
                    }
                }
                if (paramLen == 8)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 7)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, 1, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, 1, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 11)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);
                        int arg10 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value10, false);

                        UnityEngine.Graphics.DrawProcedural (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawProcedural");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawProceduralIndirect(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 10)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.ComputeBuffer arg3 = argobj3 != null ? (UnityEngine.ComputeBuffer)argobj3 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);
                        int arg9 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, 0);

                        return;
                    }
                }
                if (paramLen == 9)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.ComputeBuffer arg3 = argobj3 != null ? (UnityEngine.ComputeBuffer)argobj3 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);
                        bool arg8 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value8, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, true, 0);

                        return;
                    }
                }
                if (paramLen == 8)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.ComputeBuffer arg3 = argobj3 != null ? (UnityEngine.ComputeBuffer)argobj3 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg7 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value7, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 7)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.ComputeBuffer arg3 = argobj3 != null ? (UnityEngine.ComputeBuffer)argobj3 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.MaterialPropertyBlock arg6 = argobj6 != null ? (UnityEngine.MaterialPropertyBlock)argobj6 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.ComputeBuffer arg3 = argobj3 != null ? (UnityEngine.ComputeBuffer)argobj3 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        UnityEngine.Camera arg5 = argobj5 != null ? (UnityEngine.Camera)argobj5 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.ComputeBuffer arg3 = argobj3 != null ? (UnityEngine.ComputeBuffer)argobj3 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, 0, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, 0, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.ComputeBuffer arg3 = argobj3 != null ? (UnityEngine.ComputeBuffer)argobj3 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, 0, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, 0, default(UnityEngine.Camera), default(UnityEngine.MaterialPropertyBlock), (UnityEngine.Rendering.ShadowCastingMode)(1), true, 0);

                        return;
                    }
                }
                if (paramLen == 11)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(isolate, info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(isolate, info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(isolate, info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(isolate, info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(isolate, info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ComputeBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.ComputeBuffer arg4 = argobj4 != null ? (UnityEngine.ComputeBuffer)argobj4 : StaticTranslate<UnityEngine.ComputeBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);
                        int arg10 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value10, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.MeshTopology), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GraphicsBuffer), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Camera), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.MaterialPropertyBlock), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.Rendering.ShadowCastingMode), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value10, ref argobj10, ref argType10))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Bounds arg1 = argobj1 != null ? (UnityEngine.Bounds)argobj1 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.MeshTopology arg2 = (UnityEngine.MeshTopology)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        UnityEngine.GraphicsBuffer arg3 = argobj3 != null ? (UnityEngine.GraphicsBuffer)argobj3 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.GraphicsBuffer arg4 = argobj4 != null ? (UnityEngine.GraphicsBuffer)argobj4 : StaticTranslate<UnityEngine.GraphicsBuffer>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Camera arg6 = argobj6 != null ? (UnityEngine.Camera)argobj6 : StaticTranslate<UnityEngine.Camera>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.MaterialPropertyBlock arg7 = argobj7 != null ? (UnityEngine.MaterialPropertyBlock)argobj7 : StaticTranslate<UnityEngine.MaterialPropertyBlock>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        UnityEngine.Rendering.ShadowCastingMode arg8 = (UnityEngine.Rendering.ShadowCastingMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value8, false);
                        bool arg9 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value9, false);
                        int arg10 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value10, false);

                        UnityEngine.Graphics.DrawProceduralIndirect (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawProceduralIndirect");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Blit(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.Blit (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Material arg1 = argobj1 != null ? (UnityEngine.Material)argobj1 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Graphics.Blit (arg0, arg1);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.Blit (arg0, arg1, arg2, arg3);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector2 arg2 = argobj2 != null ? (UnityEngine.Vector2)argobj2 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector2 arg3 = argobj3 != null ? (UnityEngine.Vector2)argobj3 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Graphics.Blit (arg0, arg1, arg2, arg3);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.Blit (arg0, arg1, arg2, arg3);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Material arg1 = argobj1 != null ? (UnityEngine.Material)argobj1 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.Blit (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                if (paramLen == 6)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector2 arg2 = argobj2 != null ? (UnityEngine.Vector2)argobj2 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector2 arg3 = argobj3 != null ? (UnityEngine.Vector2)argobj3 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        UnityEngine.Graphics.Blit (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Graphics.Blit (arg0, arg1, arg2, arg3, arg4);

                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Graphics.Blit (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Material arg1 = argobj1 != null ? (UnityEngine.Material)argobj1 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        UnityEngine.Graphics.Blit (arg0, arg1, arg2);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Blit");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_BlitMultiTap(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 3)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector2[] arg3 = ArgHelper.GetParams<UnityEngine.Vector2>((int)data, isolate, info, 3, paramLen, v8Value3);

                        UnityEngine.Graphics.BlitMultiTap (arg0, arg1, arg2, arg3);

                        return;
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Graphics.BlitMultiTap (arg0, arg1, arg2, System.Array.Empty<UnityEngine.Vector2>());

                        return;
                    }
                }
                if (paramLen >= 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.Vector2[] arg4 = ArgHelper.GetParams<UnityEngine.Vector2>((int)data, isolate, info, 4, paramLen, v8Value4);

                        UnityEngine.Graphics.BlitMultiTap (arg0, arg1, arg2, arg3, arg4);

                        return;
                    }
                }
                if (paramLen == 4)
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
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RenderTexture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.RenderTexture arg1 = argobj1 != null ? (UnityEngine.RenderTexture)argobj1 : StaticTranslate<UnityEngine.RenderTexture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Material arg2 = argobj2 != null ? (UnityEngine.Material)argobj2 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        UnityEngine.Graphics.BlitMultiTap (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.Vector2>());

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to BlitMultiTap");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_activeColorGamut(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Graphics.activeColorGamut;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_activeTier(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Graphics.activeTier;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_activeTier(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Rendering.GraphicsTier arg0 = (UnityEngine.Rendering.GraphicsTier)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                UnityEngine.Graphics.activeTier = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_preserveFramebufferAlpha(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Graphics.preserveFramebufferAlpha;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_minOpenGLESVersion(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Graphics.minOpenGLESVersion;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_activeColorBuffer(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Graphics.activeColorBuffer;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_activeDepthBuffer(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Graphics.activeDepthBuffer;
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
