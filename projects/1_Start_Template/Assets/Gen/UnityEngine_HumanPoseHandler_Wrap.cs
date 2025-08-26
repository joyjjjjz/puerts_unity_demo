#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_HumanPoseHandler_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Avatar), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        UnityEngine.Avatar arg0 = argobj0 != null ? (UnityEngine.Avatar)argobj0 : StaticTranslate<UnityEngine.Avatar>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Transform arg1 = argobj1 != null ? (UnityEngine.Transform)argobj1 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        var result = new UnityEngine.HumanPoseHandler(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.HumanPoseHandler), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Avatar), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        UnityEngine.Avatar arg0 = argobj0 != null ? (UnityEngine.Avatar)argobj0 : StaticTranslate<UnityEngine.Avatar>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        string[] arg1 = argobj1 != null ? (string[])argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        var result = new UnityEngine.HumanPoseHandler(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.HumanPoseHandler), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.HumanPoseHandler).GetFriendlyName() + " constructor");
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
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.HumanPoseHandler;
        
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
        internal static void M_GetHumanPose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.HumanPoseHandler;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.HumanPose arg0 = argobj0 != null ? (UnityEngine.HumanPose)argobj0 : StaticTranslate<UnityEngine.HumanPose>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;

                        obj.GetHumanPose (ref arg0);

                        StaticTranslate<UnityEngine.HumanPose>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetHumanPose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.HumanPoseHandler;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.HumanPose arg0 = argobj0 != null ? (UnityEngine.HumanPose)argobj0 : StaticTranslate<UnityEngine.HumanPose>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;

                        obj.SetHumanPose (ref arg0);

                        StaticTranslate<UnityEngine.HumanPose>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetInternalHumanPose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.HumanPoseHandler;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.HumanPose arg0 = argobj0 != null ? (UnityEngine.HumanPose)argobj0 : StaticTranslate<UnityEngine.HumanPose>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;

                        obj.GetInternalHumanPose (ref arg0);

                        StaticTranslate<UnityEngine.HumanPose>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetInternalHumanPose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.HumanPoseHandler;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.HumanPose arg0 = argobj0 != null ? (UnityEngine.HumanPose)argobj0 : StaticTranslate<UnityEngine.HumanPose>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true);;

                        obj.SetInternalHumanPose (ref arg0);

                        StaticTranslate<UnityEngine.HumanPose>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetInternalAvatarPose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.HumanPoseHandler;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        Unity.Collections.NativeArray<float> arg0 = argobj0 != null ? (Unity.Collections.NativeArray<float>)argobj0 : StaticTranslate<Unity.Collections.NativeArray<float>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.GetInternalAvatarPose (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetInternalAvatarPose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.HumanPoseHandler;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        Unity.Collections.NativeArray<float> arg0 = argobj0 != null ? (Unity.Collections.NativeArray<float>)argobj0 : StaticTranslate<Unity.Collections.NativeArray<float>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.SetInternalAvatarPose (arg0);

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
