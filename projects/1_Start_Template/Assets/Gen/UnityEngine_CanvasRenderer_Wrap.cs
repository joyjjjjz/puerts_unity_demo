#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_CanvasRenderer_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.CanvasRenderer();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.CanvasRenderer), result);
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
        internal static void M_SetColor(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Color arg0 = argobj0 != null ? (UnityEngine.Color)argobj0 : StaticTranslate<UnityEngine.Color>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.SetColor (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetColor(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    {

                        var result = obj.GetColor ();

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
        internal static void M_EnableRectClipping(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.EnableRectClipping (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_DisableRectClipping(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    {

                        obj.DisableRectClipping ();

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetMaterial(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        obj.SetMaterial (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        obj.SetMaterial (arg0, arg1);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to SetMaterial");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetMaterial(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = obj.GetMaterial (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 0)
                {
            
                    {

                        var result = obj.GetMaterial ();

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to GetMaterial");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetPopMaterial(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        UnityEngine.Material arg0 = argobj0 != null ? (UnityEngine.Material)argobj0 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        obj.SetPopMaterial (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetPopMaterial(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = obj.GetPopMaterial (arg0);

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
        internal static void M_SetTexture(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.SetTexture (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetAlphaTexture(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.SetAlphaTexture (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetMesh(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.SetMesh (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Clear(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    {

                        obj.Clear ();

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetAlpha(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    {

                        var result = obj.GetAlpha ();

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetAlpha(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        obj.SetAlpha (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetInheritedAlpha(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
        
                {
            
                    {

                        var result = obj.GetInheritedAlpha ();

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_SplitUIVertexStreams(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Color32>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<int>), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        System.Collections.Generic.List<UnityEngine.UIVertex> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.UIVertex>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UIVertex>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg1 = argobj1 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj1 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Collections.Generic.List<UnityEngine.Color32> arg2 = argobj2 != null ? (System.Collections.Generic.List<UnityEngine.Color32>)argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Color32>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg4 = argobj4 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg5 = argobj5 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg6 = argobj6 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj6 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        System.Collections.Generic.List<int> arg7 = argobj7 != null ? (System.Collections.Generic.List<int>)argobj7 : StaticTranslate<System.Collections.Generic.List<int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;

                        UnityEngine.CanvasRenderer.SplitUIVertexStreams (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Color32>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<int>), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        System.Collections.Generic.List<UnityEngine.UIVertex> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.UIVertex>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UIVertex>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg1 = argobj1 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj1 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Collections.Generic.List<UnityEngine.Color32> arg2 = argobj2 != null ? (System.Collections.Generic.List<UnityEngine.Color32>)argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Color32>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg4 = argobj4 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg5 = argobj5 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg6 = argobj6 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj6 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg7 = argobj7 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj7 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg8 = argobj8 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj8 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value8, false);;
                        System.Collections.Generic.List<int> arg9 = argobj9 != null ? (System.Collections.Generic.List<int>)argobj9 : StaticTranslate<System.Collections.Generic.List<int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;

                        UnityEngine.CanvasRenderer.SplitUIVertexStreams (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to SplitUIVertexStreams");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CreateUIVertexStream(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Color32>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<int>), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        System.Collections.Generic.List<UnityEngine.UIVertex> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.UIVertex>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UIVertex>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg1 = argobj1 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj1 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Collections.Generic.List<UnityEngine.Color32> arg2 = argobj2 != null ? (System.Collections.Generic.List<UnityEngine.Color32>)argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Color32>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg4 = argobj4 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg5 = argobj5 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg6 = argobj6 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj6 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        System.Collections.Generic.List<int> arg7 = argobj7 != null ? (System.Collections.Generic.List<int>)argobj7 : StaticTranslate<System.Collections.Generic.List<int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;

                        UnityEngine.CanvasRenderer.CreateUIVertexStream (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Color32>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<int>), false, false, v8Value9, ref argobj9, ref argType9))
                    {
                        System.Collections.Generic.List<UnityEngine.UIVertex> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.UIVertex>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UIVertex>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg1 = argobj1 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj1 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Collections.Generic.List<UnityEngine.Color32> arg2 = argobj2 != null ? (System.Collections.Generic.List<UnityEngine.Color32>)argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Color32>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg4 = argobj4 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg5 = argobj5 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg6 = argobj6 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj6 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg7 = argobj7 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj7 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg8 = argobj8 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj8 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value8, false);;
                        System.Collections.Generic.List<int> arg9 = argobj9 != null ? (System.Collections.Generic.List<int>)argobj9 : StaticTranslate<System.Collections.Generic.List<int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value9, false);;

                        UnityEngine.CanvasRenderer.CreateUIVertexStream (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CreateUIVertexStream");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_AddUIVertexStream(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Color32>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        System.Collections.Generic.List<UnityEngine.UIVertex> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.UIVertex>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UIVertex>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg1 = argobj1 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj1 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Collections.Generic.List<UnityEngine.Color32> arg2 = argobj2 != null ? (System.Collections.Generic.List<UnityEngine.Color32>)argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Color32>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg4 = argobj4 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg5 = argobj5 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg6 = argobj6 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj6 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.CanvasRenderer.AddUIVertexStream (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Color32>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector3>), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Vector4>), false, false, v8Value8, ref argobj8, ref argType8))
                    {
                        System.Collections.Generic.List<UnityEngine.UIVertex> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.UIVertex>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UIVertex>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg1 = argobj1 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj1 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Collections.Generic.List<UnityEngine.Color32> arg2 = argobj2 != null ? (System.Collections.Generic.List<UnityEngine.Color32>)argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Color32>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg3 = argobj3 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg4 = argobj4 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg5 = argobj5 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg6 = argobj6 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj6 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        System.Collections.Generic.List<UnityEngine.Vector3> arg7 = argobj7 != null ? (System.Collections.Generic.List<UnityEngine.Vector3>)argobj7 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;
                        System.Collections.Generic.List<UnityEngine.Vector4> arg8 = argobj8 != null ? (System.Collections.Generic.List<UnityEngine.Vector4>)argobj8 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value8, false);;

                        UnityEngine.CanvasRenderer.AddUIVertexStream (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to AddUIVertexStream");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_hasPopInstruction(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.hasPopInstruction;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_hasPopInstruction(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                obj.hasPopInstruction = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_materialCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.materialCount;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_materialCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                obj.materialCount = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_popMaterialCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.popMaterialCount;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_popMaterialCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                obj.popMaterialCount = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_absoluteDepth(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.absoluteDepth;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_hasMoved(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.hasMoved;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_cullTransparentMesh(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.cullTransparentMesh;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_cullTransparentMesh(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                obj.cullTransparentMesh = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_hasRectClipping(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.hasRectClipping;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_relativeDepth(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.relativeDepth;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_cull(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.cull;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_cull(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                obj.cull = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_clippingSoftness(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                var result = obj.clippingSoftness;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_clippingSoftness(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.CanvasRenderer;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Vector2 arg0 = argobj0 != null ? (UnityEngine.Vector2)argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.clippingSoftness = arg0;
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
