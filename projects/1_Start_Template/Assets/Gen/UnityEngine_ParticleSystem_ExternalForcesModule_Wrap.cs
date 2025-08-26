#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_ParticleSystem_ExternalForcesModule_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.ParticleSystem.ExternalForcesModule();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.ParticleSystem.ExternalForcesModule), result);
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
        internal static void M_IsAffectedBy(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.ParticleSystemForceField arg0 = argobj0 != null ? (UnityEngine.ParticleSystemForceField)argobj0 : StaticTranslate<UnityEngine.ParticleSystemForceField>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = obj.IsAffectedBy (arg0);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_AddInfluence(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        UnityEngine.ParticleSystemForceField arg0 = argobj0 != null ? (UnityEngine.ParticleSystemForceField)argobj0 : StaticTranslate<UnityEngine.ParticleSystemForceField>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.AddInfluence (arg0);

                        Puerts.Utils.SetSelf((int)data, self, obj);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_RemoveInfluence(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        obj.RemoveInfluence (arg0);

                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.ParticleSystemForceField), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.ParticleSystemForceField arg0 = argobj0 != null ? (UnityEngine.ParticleSystemForceField)argobj0 : StaticTranslate<UnityEngine.ParticleSystemForceField>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        obj.RemoveInfluence (arg0);

                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to RemoveInfluence");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_RemoveAllInfluences(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {

                        obj.RemoveAllInfluences ();

                        Puerts.Utils.SetSelf((int)data, self, obj);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_SetInfluence(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        UnityEngine.ParticleSystemForceField arg1 = argobj1 != null ? (UnityEngine.ParticleSystemForceField)argobj1 : StaticTranslate<UnityEngine.ParticleSystemForceField>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        obj.SetInfluence (arg0, arg1);

                        Puerts.Utils.SetSelf((int)data, self, obj);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetInfluence(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = obj.GetInfluence (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
        internal static void G_enabled(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.enabled;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_enabled(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                obj.enabled = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_multiplier(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.multiplier;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_multiplier(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                obj.multiplier = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_multiplierCurve(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.multiplierCurve;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_multiplierCurve(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.ParticleSystem.MinMaxCurve arg0 = argobj0 != null ? (UnityEngine.ParticleSystem.MinMaxCurve)argobj0 : StaticTranslate<UnityEngine.ParticleSystem.MinMaxCurve>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.multiplierCurve = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_influenceFilter(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.influenceFilter;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_influenceFilter(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.ParticleSystemGameObjectFilter arg0 = (UnityEngine.ParticleSystemGameObjectFilter)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                obj.influenceFilter = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_influenceMask(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.influenceMask;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_influenceMask(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.LayerMask arg0 = argobj0 != null ? (UnityEngine.LayerMask)argobj0 : StaticTranslate<UnityEngine.LayerMask>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.influenceMask = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_influenceCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.ParticleSystem.ExternalForcesModule)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.influenceCount;
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
