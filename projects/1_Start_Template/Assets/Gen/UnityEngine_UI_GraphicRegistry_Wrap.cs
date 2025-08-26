#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_UI_GraphicRegistry_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {


                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.UI.GraphicRegistry).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RegisterGraphicForCanvas(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Canvas arg0 = argobj0 != null ? (UnityEngine.Canvas)argobj0 : StaticTranslate<UnityEngine.Canvas>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.UI.Graphic arg1 = argobj1 != null ? (UnityEngine.UI.Graphic)argobj1 : StaticTranslate<UnityEngine.UI.Graphic>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.UI.GraphicRegistry.RegisterGraphicForCanvas (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RegisterRaycastGraphicForCanvas(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Canvas arg0 = argobj0 != null ? (UnityEngine.Canvas)argobj0 : StaticTranslate<UnityEngine.Canvas>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.UI.Graphic arg1 = argobj1 != null ? (UnityEngine.UI.Graphic)argobj1 : StaticTranslate<UnityEngine.UI.Graphic>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.UI.GraphicRegistry.RegisterRaycastGraphicForCanvas (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_UnregisterGraphicForCanvas(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Canvas arg0 = argobj0 != null ? (UnityEngine.Canvas)argobj0 : StaticTranslate<UnityEngine.Canvas>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.UI.Graphic arg1 = argobj1 != null ? (UnityEngine.UI.Graphic)argobj1 : StaticTranslate<UnityEngine.UI.Graphic>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.UI.GraphicRegistry.UnregisterGraphicForCanvas (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_UnregisterRaycastGraphicForCanvas(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Canvas arg0 = argobj0 != null ? (UnityEngine.Canvas)argobj0 : StaticTranslate<UnityEngine.Canvas>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.UI.Graphic arg1 = argobj1 != null ? (UnityEngine.UI.Graphic)argobj1 : StaticTranslate<UnityEngine.UI.Graphic>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.UI.GraphicRegistry.UnregisterRaycastGraphicForCanvas (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DisableGraphicForCanvas(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Canvas arg0 = argobj0 != null ? (UnityEngine.Canvas)argobj0 : StaticTranslate<UnityEngine.Canvas>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.UI.Graphic arg1 = argobj1 != null ? (UnityEngine.UI.Graphic)argobj1 : StaticTranslate<UnityEngine.UI.Graphic>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.UI.GraphicRegistry.DisableGraphicForCanvas (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DisableRaycastGraphicForCanvas(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Canvas arg0 = argobj0 != null ? (UnityEngine.Canvas)argobj0 : StaticTranslate<UnityEngine.Canvas>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.UI.Graphic arg1 = argobj1 != null ? (UnityEngine.UI.Graphic)argobj1 : StaticTranslate<UnityEngine.UI.Graphic>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.UI.GraphicRegistry.DisableRaycastGraphicForCanvas (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_GetGraphicsForCanvas(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Canvas arg0 = argobj0 != null ? (UnityEngine.Canvas)argobj0 : StaticTranslate<UnityEngine.Canvas>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = UnityEngine.UI.GraphicRegistry.GetGraphicsForCanvas (arg0);

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
        internal static void F_GetRaycastableGraphicsForCanvas(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Canvas arg0 = argobj0 != null ? (UnityEngine.Canvas)argobj0 : StaticTranslate<UnityEngine.Canvas>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = UnityEngine.UI.GraphicRegistry.GetRaycastableGraphicsForCanvas (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
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
        internal static void G_instance(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.UI.GraphicRegistry.instance;
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
