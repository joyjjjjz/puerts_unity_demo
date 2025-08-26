#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEditor_GUI_DisplayUtility_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEditor.GUI.DisplayUtility();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEditor.GUI.DisplayUtility), result);
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
        internal static void F_PopupCreate(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEditor.GUI.DrawerInfo), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEditor.GUI.DrawerInfo arg0 = argobj0 != null ? (UnityEditor.GUI.DrawerInfo)argobj0 : StaticTranslate<UnityEditor.GUI.DrawerInfo>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        System.Action arg2 = argobj2 != null ? (System.Action)argobj2 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEditor.GUI.DisplayUtility.PopupCreate (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEditor.GUI.DrawerInfo), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEditor.GUI.DrawerInfo arg0 = argobj0 != null ? (UnityEditor.GUI.DrawerInfo)argobj0 : StaticTranslate<UnityEditor.GUI.DrawerInfo>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        UnityEditor.GUI.DisplayUtility.PopupCreate (arg0, arg1, default(System.Action));

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to PopupCreate");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_PopupTypes(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEditor.GUI.DrawerInfo arg0 = argobj0 != null ? (UnityEditor.GUI.DrawerInfo)argobj0 : StaticTranslate<UnityEditor.GUI.DrawerInfo>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEditor.GUI.Element arg1 = argobj1 != null ? (UnityEditor.GUI.Element)argobj1 : StaticTranslate<UnityEditor.GUI.Element>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEditor.GUI.DisplayUtility.PopupTypes (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_PopupComponentsAndTypes(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    {
                        UnityEditor.GUI.DrawerInfo arg0 = argobj0 != null ? (UnityEditor.GUI.DrawerInfo)argobj0 : StaticTranslate<UnityEditor.GUI.DrawerInfo>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEditor.GUI.Element arg1 = argobj1 != null ? (UnityEditor.GUI.Element)argobj1 : StaticTranslate<UnityEditor.GUI.Element>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Object arg2 = argobj2 != null ? (UnityEngine.Object)argobj2 : StaticTranslate<UnityEngine.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Type arg3 = argobj3 != null ? (System.Type)argobj3 : StaticTranslate<System.Type>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEditor.GUI.DisplayUtility.PopupComponentsAndTypes (arg0, arg1, arg2, arg3);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_PopupComponents(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    {
                        UnityEditor.GUI.DrawerInfo arg0 = argobj0 != null ? (UnityEditor.GUI.DrawerInfo)argobj0 : StaticTranslate<UnityEditor.GUI.DrawerInfo>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEditor.SerializedProperty arg1 = argobj1 != null ? (UnityEditor.SerializedProperty)argobj1 : StaticTranslate<UnityEditor.SerializedProperty>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Object arg2 = argobj2 != null ? (UnityEngine.Object)argobj2 : StaticTranslate<UnityEngine.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Type arg3 = argobj3 != null ? (System.Type)argobj3 : StaticTranslate<System.Type>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        UnityEditor.GUI.DisplayUtility.PopupComponents (arg0, arg1, arg2, arg3);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_PopupArrayComponents(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    {
                        UnityEditor.GUI.DrawerInfo arg0 = argobj0 != null ? (UnityEditor.GUI.DrawerInfo)argobj0 : StaticTranslate<UnityEditor.GUI.DrawerInfo>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEditor.SerializedProperty arg1 = argobj1 != null ? (UnityEditor.SerializedProperty)argobj1 : StaticTranslate<UnityEditor.SerializedProperty>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Type arg2 = argobj2 != null ? (System.Type)argobj2 : StaticTranslate<System.Type>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEditor.GUI.DisplayUtility.PopupArrayComponents (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CheckKeyValidity(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        var result = UnityEditor.GUI.DisplayUtility.CheckKeyValidity (arg0);

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
        internal static void F_CheckFields(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        System.Type arg0 = argobj0 != null ? (System.Type)argobj0 : StaticTranslate<System.Type>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = UnityEditor.GUI.DisplayUtility.CheckFields (arg0);

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
        internal static void F_Copy(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEditor.GUI.Element), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEditor.GUI.Element), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        UnityEditor.GUI.Element arg0 = argobj0 != null ? (UnityEditor.GUI.Element)argobj0 : StaticTranslate<UnityEditor.GUI.Element>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEditor.GUI.Element arg1 = argobj1 != null ? (UnityEditor.GUI.Element)argobj1 : StaticTranslate<UnityEditor.GUI.Element>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEditor.GUI.DisplayUtility.Copy (arg0, arg1);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEditor.SerializedProperty), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEditor.SerializedProperty), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Type), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        UnityEditor.SerializedProperty arg0 = argobj0 != null ? (UnityEditor.SerializedProperty)argobj0 : StaticTranslate<UnityEditor.SerializedProperty>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEditor.SerializedProperty arg1 = argobj1 != null ? (UnityEditor.SerializedProperty)argobj1 : StaticTranslate<UnityEditor.SerializedProperty>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Type arg2 = argobj2 != null ? (System.Type)argobj2 : StaticTranslate<System.Type>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        UnityEditor.GUI.DisplayUtility.Copy (arg0, arg1, arg2);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Copy");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CustomMenu(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        string[] arg0 = argobj0 != null ? (string[])argobj0 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        string[] arg1 = argobj1 != null ? (string[])argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int[] arg2 = argobj2 != null ? (int[])argobj2 : StaticTranslate<int[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        int[] arg3 = argobj3 != null ? (int[])argobj3 : StaticTranslate<int[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        System.Action<int> arg4 = argobj4 != null ? (System.Action<int>)argobj4 : StaticTranslate<System.Action<int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;

                        UnityEditor.GUI.DisplayUtility.CustomMenu (arg0, arg1, arg2, arg3, arg4);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_GenCode(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    {
                        TSProperties.ResultPair[] arg0 = argobj0 != null ? (TSProperties.ResultPair[])argobj0 : StaticTranslate<TSProperties.ResultPair[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);

                        var result = UnityEditor.GUI.DisplayUtility.GenCode (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_PraseCode(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEditor.GUI.TSProperties_CustomEditor arg0 = argobj0 != null ? (UnityEditor.GUI.TSProperties_CustomEditor)argobj0 : StaticTranslate<UnityEditor.GUI.TSProperties_CustomEditor>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);

                        UnityEditor.GUI.DisplayUtility.PraseCode (arg0, arg1);

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
