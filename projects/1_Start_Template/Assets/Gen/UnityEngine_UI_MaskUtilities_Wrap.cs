#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_UI_MaskUtilities_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.UI.MaskUtilities();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.UI.MaskUtilities), result);
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
        internal static void F_Notify2DMaskStateChanged(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Component arg0 = argobj0 != null ? (UnityEngine.Component)argobj0 : StaticTranslate<UnityEngine.Component>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        UnityEngine.UI.MaskUtilities.Notify2DMaskStateChanged (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_NotifyStencilStateChanged(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Component arg0 = argobj0 != null ? (UnityEngine.Component)argobj0 : StaticTranslate<UnityEngine.Component>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        UnityEngine.UI.MaskUtilities.NotifyStencilStateChanged (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_FindRootSortOverrideCanvas(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.Transform arg0 = argobj0 != null ? (UnityEngine.Transform)argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = UnityEngine.UI.MaskUtilities.FindRootSortOverrideCanvas (arg0);

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
        internal static void F_GetStencilDepth(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Transform arg0 = argobj0 != null ? (UnityEngine.Transform)argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Transform arg1 = argobj1 != null ? (UnityEngine.Transform)argobj1 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        var result = UnityEngine.UI.MaskUtilities.GetStencilDepth (arg0, arg1);

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
        internal static void F_IsDescendantOrSelf(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.Transform arg0 = argobj0 != null ? (UnityEngine.Transform)argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Transform arg1 = argobj1 != null ? (UnityEngine.Transform)argobj1 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        var result = UnityEngine.UI.MaskUtilities.IsDescendantOrSelf (arg0, arg1);

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
        internal static void F_GetRectMaskForClippable(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.UI.IClippable arg0 = argobj0 != null ? (UnityEngine.UI.IClippable)argobj0 : StaticTranslate<UnityEngine.UI.IClippable>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = UnityEngine.UI.MaskUtilities.GetRectMaskForClippable (arg0);

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
        internal static void F_GetRectMasksForClip(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        UnityEngine.UI.RectMask2D arg0 = argobj0 != null ? (UnityEngine.UI.RectMask2D)argobj0 : StaticTranslate<UnityEngine.UI.RectMask2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        System.Collections.Generic.List<UnityEngine.UI.RectMask2D> arg1 = argobj1 != null ? (System.Collections.Generic.List<UnityEngine.UI.RectMask2D>)argobj1 : StaticTranslate<System.Collections.Generic.List<UnityEngine.UI.RectMask2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        UnityEngine.UI.MaskUtilities.GetRectMasksForClip (arg0, arg1);

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
