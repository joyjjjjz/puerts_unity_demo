#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_UI_VertexHelper_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                if (paramLen == 0)
                {

                    {
                        var result = new UnityEngine.UI.VertexHelper();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.UI.VertexHelper), result);
                    }
                }
                if (paramLen == 1)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        var result = new UnityEngine.UI.VertexHelper(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.UI.VertexHelper), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.UI.VertexHelper).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Dispose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
                {
            
                    {

                        obj.Dispose ();

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
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
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
        internal static void M_PopulateUIVertex(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        UnityEngine.UIVertex arg0 = argobj0 != null ? (UnityEngine.UIVertex)argobj0 : StaticTranslate<UnityEngine.UIVertex>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        obj.PopulateUIVertex (ref arg0, arg1);

                        StaticTranslate<UnityEngine.UIVertex>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetUIVertex(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        UnityEngine.UIVertex arg0 = argobj0 != null ? (UnityEngine.UIVertex)argobj0 : StaticTranslate<UnityEngine.UIVertex>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        obj.SetUIVertex (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_FillMesh(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.FillMesh (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_AddVert(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Color32), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector4), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector4), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector4), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector4), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector4), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Color32 arg1 = argobj1 != null ? (UnityEngine.Color32)argobj1 : StaticTranslate<UnityEngine.Color32>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector4 arg2 = argobj2 != null ? (UnityEngine.Vector4)argobj2 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector4 arg3 = argobj3 != null ? (UnityEngine.Vector4)argobj3 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.Vector4 arg4 = argobj4 != null ? (UnityEngine.Vector4)argobj4 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        UnityEngine.Vector4 arg5 = argobj5 != null ? (UnityEngine.Vector4)argobj5 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;
                        UnityEngine.Vector3 arg6 = argobj6 != null ? (UnityEngine.Vector3)argobj6 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;
                        UnityEngine.Vector4 arg7 = argobj7 != null ? (UnityEngine.Vector4)argobj7 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false);;

                        obj.AddVert (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Color32), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector4), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector4), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector4), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Color32 arg1 = argobj1 != null ? (UnityEngine.Color32)argobj1 : StaticTranslate<UnityEngine.Color32>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector4 arg2 = argobj2 != null ? (UnityEngine.Vector4)argobj2 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector4 arg3 = argobj3 != null ? (UnityEngine.Vector4)argobj3 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.Vector3 arg4 = argobj4 != null ? (UnityEngine.Vector3)argobj4 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        UnityEngine.Vector4 arg5 = argobj5 != null ? (UnityEngine.Vector4)argobj5 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false);;

                        obj.AddVert (arg0, arg1, arg2, arg3, arg4, arg5);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Color32), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector4), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Color32 arg1 = argobj1 != null ? (UnityEngine.Color32)argobj1 : StaticTranslate<UnityEngine.Color32>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector4 arg2 = argobj2 != null ? (UnityEngine.Vector4)argobj2 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.AddVert (arg0, arg1, arg2);

                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.UIVertex), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.UIVertex arg0 = argobj0 != null ? (UnityEngine.UIVertex)argobj0 : StaticTranslate<UnityEngine.UIVertex>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.AddVert (arg0);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to AddVert");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_AddTriangle(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    ;
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        obj.AddTriangle (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_AddUIVertexQuad(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.UIVertex[] arg0 = argobj0 != null ? (UnityEngine.UIVertex[])argobj0 : StaticTranslate<UnityEngine.UIVertex[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.AddUIVertexQuad (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_AddUIVertexStream(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        System.Collections.Generic.List<UnityEngine.UIVertex> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.UIVertex>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UIVertex>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        System.Collections.Generic.List<int> arg1 = argobj1 != null ? (System.Collections.Generic.List<int>)argobj1 : StaticTranslate<System.Collections.Generic.List<int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        obj.AddUIVertexStream (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_AddUIVertexTriangleStream(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        System.Collections.Generic.List<UnityEngine.UIVertex> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.UIVertex>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UIVertex>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.AddUIVertexTriangleStream (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetUIVertexStream(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        System.Collections.Generic.List<UnityEngine.UIVertex> arg0 = argobj0 != null ? (System.Collections.Generic.List<UnityEngine.UIVertex>)argobj0 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UIVertex>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.GetUIVertexStream (arg0);

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
        internal static void G_currentVertCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
                var result = obj.currentVertCount;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_currentIndexCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UI.VertexHelper;
                var result = obj.currentIndexCount;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
