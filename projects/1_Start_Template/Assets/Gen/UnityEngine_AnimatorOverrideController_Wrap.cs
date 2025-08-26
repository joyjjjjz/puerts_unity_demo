#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_AnimatorOverrideController_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                if (paramLen == 0)
                {

                    {
                        var result = new UnityEngine.AnimatorOverrideController();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.AnimatorOverrideController), result);
                    }
                }
                if (paramLen == 1)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RuntimeAnimatorController), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        UnityEngine.RuntimeAnimatorController arg0 = argobj0 != null ? (UnityEngine.RuntimeAnimatorController)argobj0 : StaticTranslate<UnityEngine.RuntimeAnimatorController>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        var result = new UnityEngine.AnimatorOverrideController(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.AnimatorOverrideController), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.AnimatorOverrideController).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetOverrides(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AnimatorOverrideController;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> arg0 = argobj0 != null ? (System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)argobj0 : StaticTranslate<System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.GetOverrides (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_ApplyOverrides(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AnimatorOverrideController;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> arg0 = argobj0 != null ? (System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)argobj0 : StaticTranslate<System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.ApplyOverrides (arg0);

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
        internal static void G_runtimeAnimatorController(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AnimatorOverrideController;
                var result = obj.runtimeAnimatorController;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_runtimeAnimatorController(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AnimatorOverrideController;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.RuntimeAnimatorController arg0 = argobj0 != null ? (UnityEngine.RuntimeAnimatorController)argobj0 : StaticTranslate<UnityEngine.RuntimeAnimatorController>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.runtimeAnimatorController = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_overridesCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AnimatorOverrideController;
                var result = obj.overridesCount;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== properties end ====================
    // ==================== array item get/set start ====================
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void GetItem(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AnimatorOverrideController;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                JsValueType argType0 = JsValueType.Invalid;
                if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))
                {
                    string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                    var result = obj[arg0];
                    Puerts.ResultHelper.Set((int)data, isolate, info, result);
                    return;
                }
                if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.AnimationClip), false, false, v8Value0, ref argobj0, ref argType0))
                {
                    UnityEngine.AnimationClip arg0 = argobj0 != null ? (UnityEngine.AnimationClip)argobj0 : StaticTranslate<UnityEngine.AnimationClip>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                    var result = obj[arg0];
                    Puerts.ResultHelper.Set((int)data, isolate, info, result);
                    return;
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void SetItem(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.AnimatorOverrideController;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                JsValueType argType0 = JsValueType.Invalid;

                if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))
                {
                    string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    UnityEngine.AnimationClip arg1 = argobj1 != null ? (UnityEngine.AnimationClip)argobj1 : StaticTranslate<UnityEngine.AnimationClip>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                    obj[arg0] = arg1;
                    return;
                }
                if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.AnimationClip), false, false, v8Value0, ref argobj0, ref argType0))
                {
                    UnityEngine.AnimationClip arg0 = argobj0 != null ? (UnityEngine.AnimationClip)argobj0 : StaticTranslate<UnityEngine.AnimationClip>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    UnityEngine.AnimationClip arg1 = argobj1 != null ? (UnityEngine.AnimationClip)argobj1 : StaticTranslate<UnityEngine.AnimationClip>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                    obj[arg0] = arg1;
                    return;
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        
    // ==================== array item get/set end ====================
    // ==================== operator start ====================
    // ==================== operator end ====================
    // ==================== events start ====================
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
