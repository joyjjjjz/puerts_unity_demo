#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_Gizmos_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.Gizmos();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.Gizmos), result);
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
        internal static void F_DrawLine(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Gizmos.DrawLine (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawWireSphere(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        UnityEngine.Gizmos.DrawWireSphere (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawSphere(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        UnityEngine.Gizmos.DrawSphere (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawWireCube(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Gizmos.DrawWireCube (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawCube(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Gizmos.DrawCube (arg0, arg1);

                    }
                }
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Vector3 arg2 = argobj2 != null ? (UnityEngine.Vector3)argobj2 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Quaternion arg3 = argobj3 != null ? (UnityEngine.Quaternion)argobj3 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.Vector3 arg4 = argobj4 != null ? (UnityEngine.Vector3)argobj4 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEngine.Gizmos.DrawMesh (arg0, arg1, arg2, arg3, arg4);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Gizmos.DrawMesh (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Vector3 arg2 = argobj2 != null ? (UnityEngine.Vector3)argobj2 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Gizmos.DrawMesh (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Gizmos.DrawMesh (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        UnityEngine.Gizmos.DrawMesh (arg0, arg1);

                        return;
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

                        UnityEngine.Gizmos.DrawMesh (arg0);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector3 arg3 = argobj3 != null ? (UnityEngine.Vector3)argobj3 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Gizmos.DrawMesh (arg0, arg1, arg2, arg3);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Vector3 arg2 = argobj2 != null ? (UnityEngine.Vector3)argobj2 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Quaternion arg3 = argobj3 != null ? (UnityEngine.Quaternion)argobj3 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Gizmos.DrawMesh (arg0, arg1, arg2, arg3);

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
        internal static void F_DrawWireMesh(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Vector3 arg2 = argobj2 != null ? (UnityEngine.Vector3)argobj2 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Quaternion arg3 = argobj3 != null ? (UnityEngine.Quaternion)argobj3 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.Vector3 arg4 = argobj4 != null ? (UnityEngine.Vector3)argobj4 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEngine.Gizmos.DrawWireMesh (arg0, arg1, arg2, arg3, arg4);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Gizmos.DrawWireMesh (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Vector3 arg2 = argobj2 != null ? (UnityEngine.Vector3)argobj2 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEngine.Gizmos.DrawWireMesh (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Gizmos.DrawWireMesh (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        UnityEngine.Gizmos.DrawWireMesh (arg0, arg1);

                        return;
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

                        UnityEngine.Gizmos.DrawWireMesh (arg0);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector3 arg3 = argobj3 != null ? (UnityEngine.Vector3)argobj3 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Gizmos.DrawWireMesh (arg0, arg1, arg2, arg3);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Mesh), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Mesh arg0 = argobj0 != null ? (UnityEngine.Mesh)argobj0 : StaticTranslate<UnityEngine.Mesh>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.Vector3 arg2 = argobj2 != null ? (UnityEngine.Vector3)argobj2 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Quaternion arg3 = argobj3 != null ? (UnityEngine.Quaternion)argobj3 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Gizmos.DrawWireMesh (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawWireMesh");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawIcon(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);

                        UnityEngine.Gizmos.DrawIcon (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Color), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        UnityEngine.Color arg3 = argobj3 != null ? (UnityEngine.Color)argobj3 : StaticTranslate<UnityEngine.Color>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEngine.Gizmos.DrawIcon (arg0, arg1, arg2, arg3);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);

                        UnityEngine.Gizmos.DrawIcon (arg0, arg1);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawIcon");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawGUITexture(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Material), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        UnityEngine.Rect arg0 = argobj0 != null ? (UnityEngine.Rect)argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Texture arg1 = argobj1 != null ? (UnityEngine.Texture)argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        UnityEngine.Material arg6 = argobj6 != null ? (UnityEngine.Material)argobj6 : StaticTranslate<UnityEngine.Material>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false);;

                        UnityEngine.Gizmos.DrawGUITexture (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

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

                        UnityEngine.Gizmos.DrawGUITexture (arg0, arg1);

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

                        UnityEngine.Gizmos.DrawGUITexture (arg0, arg1, arg2);

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

                        UnityEngine.Gizmos.DrawGUITexture (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawGUITexture");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawFrustum(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    ;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    ;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    ;
                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        UnityEngine.Gizmos.DrawFrustum (arg0, arg1, arg2, arg3, arg4);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DrawRay(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Ray), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.Ray arg0 = argobj0 != null ? (UnityEngine.Ray)argobj0 : StaticTranslate<UnityEngine.Ray>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        UnityEngine.Gizmos.DrawRay (arg0);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.Gizmos.DrawRay (arg0, arg1);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawRay");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_color(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Gizmos.color;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_color(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Color arg0 = argobj0 != null ? (UnityEngine.Color)argobj0 : StaticTranslate<UnityEngine.Color>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.Gizmos.color = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_matrix(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Gizmos.matrix;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_matrix(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Matrix4x4 arg0 = argobj0 != null ? (UnityEngine.Matrix4x4)argobj0 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.Gizmos.matrix = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_exposure(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Gizmos.exposure;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_exposure(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Texture arg0 = argobj0 != null ? (UnityEngine.Texture)argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                UnityEngine.Gizmos.exposure = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_probeSize(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.Gizmos.probeSize;
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
