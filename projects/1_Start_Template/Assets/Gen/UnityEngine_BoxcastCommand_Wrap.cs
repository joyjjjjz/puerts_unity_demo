#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_BoxcastCommand_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))

                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector3 arg3 = argobj3 != null ? (UnityEngine.Vector3)argobj3 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        var result = new UnityEngine.BoxcastCommand(arg0, arg1, arg2, arg3, arg4, arg5);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.BoxcastCommand), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.PhysicsScene), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5))

                    {
                        UnityEngine.PhysicsScene arg0 = argobj0 != null ? (UnityEngine.PhysicsScene)argobj0 : StaticTranslate<UnityEngine.PhysicsScene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector3 arg2 = argobj2 != null ? (UnityEngine.Vector3)argobj2 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Quaternion arg3 = argobj3 != null ? (UnityEngine.Quaternion)argobj3 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.Vector3 arg4 = argobj4 != null ? (UnityEngine.Vector3)argobj4 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        var result = new UnityEngine.BoxcastCommand(arg0, arg1, arg2, arg3, arg4, arg5);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.BoxcastCommand), result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4))

                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector3 arg3 = argobj3 != null ? (UnityEngine.Vector3)argobj3 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        var result = new UnityEngine.BoxcastCommand(arg0, arg1, arg2, arg3, arg4);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.BoxcastCommand), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.PhysicsScene), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value4, ref argobj4, ref argType4))

                    {
                        UnityEngine.PhysicsScene arg0 = argobj0 != null ? (UnityEngine.PhysicsScene)argobj0 : StaticTranslate<UnityEngine.PhysicsScene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector3 arg2 = argobj2 != null ? (UnityEngine.Vector3)argobj2 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Quaternion arg3 = argobj3 != null ? (UnityEngine.Quaternion)argobj3 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.Vector3 arg4 = argobj4 != null ? (UnityEngine.Vector3)argobj4 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        var result = new UnityEngine.BoxcastCommand(arg0, arg1, arg2, arg3, arg4);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.BoxcastCommand), result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value3, ref argobj3, ref argType3))

                    {
                        UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Quaternion arg2 = argobj2 != null ? (UnityEngine.Quaternion)argobj2 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector3 arg3 = argobj3 != null ? (UnityEngine.Vector3)argobj3 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        var result = new UnityEngine.BoxcastCommand(arg0, arg1, arg2, arg3);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.BoxcastCommand), result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.PhysicsScene), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Quaternion), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector3), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6))

                    {
                        UnityEngine.PhysicsScene arg0 = argobj0 != null ? (UnityEngine.PhysicsScene)argobj0 : StaticTranslate<UnityEngine.PhysicsScene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.Vector3 arg1 = argobj1 != null ? (UnityEngine.Vector3)argobj1 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector3 arg2 = argobj2 != null ? (UnityEngine.Vector3)argobj2 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Quaternion arg3 = argobj3 != null ? (UnityEngine.Quaternion)argobj3 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        UnityEngine.Vector3 arg4 = argobj4 != null ? (UnityEngine.Vector3)argobj4 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false);;
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        var result = new UnityEngine.BoxcastCommand(arg0, arg1, arg2, arg3, arg4, arg5, arg6);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.BoxcastCommand), result);
                    }
                }
                if (paramLen == 0)
                {

                    {
                        var result = new UnityEngine.BoxcastCommand();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.BoxcastCommand), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.BoxcastCommand).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_ScheduleBatch(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Collections.NativeArray<UnityEngine.RaycastHit>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Jobs.JobHandle), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> arg0 = argobj0 != null ? (Unity.Collections.NativeArray<UnityEngine.BoxcastCommand>)argobj0 : StaticTranslate<Unity.Collections.NativeArray<UnityEngine.BoxcastCommand>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Unity.Collections.NativeArray<UnityEngine.RaycastHit> arg1 = argobj1 != null ? (Unity.Collections.NativeArray<UnityEngine.RaycastHit>)argobj1 : StaticTranslate<Unity.Collections.NativeArray<UnityEngine.RaycastHit>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        Unity.Jobs.JobHandle arg3 = argobj3 != null ? (Unity.Jobs.JobHandle)argobj3 : StaticTranslate<Unity.Jobs.JobHandle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        var result = UnityEngine.BoxcastCommand.ScheduleBatch (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Collections.NativeArray<UnityEngine.RaycastHit>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> arg0 = argobj0 != null ? (Unity.Collections.NativeArray<UnityEngine.BoxcastCommand>)argobj0 : StaticTranslate<Unity.Collections.NativeArray<UnityEngine.BoxcastCommand>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Unity.Collections.NativeArray<UnityEngine.RaycastHit> arg1 = argobj1 != null ? (Unity.Collections.NativeArray<UnityEngine.RaycastHit>)argobj1 : StaticTranslate<Unity.Collections.NativeArray<UnityEngine.RaycastHit>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.BoxcastCommand.ScheduleBatch (arg0, arg1, arg2, default(Unity.Jobs.JobHandle));

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to ScheduleBatch");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_center(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.center;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_center(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.center = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_halfExtents(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.halfExtents;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_halfExtents(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.halfExtents = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_orientation(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.orientation;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_orientation(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Quaternion arg0 = argobj0 != null ? (UnityEngine.Quaternion)argobj0 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.orientation = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_direction(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.direction;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_direction(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.Vector3 arg0 = argobj0 != null ? (UnityEngine.Vector3)argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.direction = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_distance(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.distance;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_distance(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                obj.distance = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_layerMask(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.layerMask;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_layerMask(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                obj.layerMask = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_physicsScene(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.physicsScene;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_physicsScene(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.BoxcastCommand)Puerts.Utils.GetSelf((int)data, self);
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                object argobj0 = null;
                UnityEngine.PhysicsScene arg0 = argobj0 != null ? (UnityEngine.PhysicsScene)argobj0 : StaticTranslate<UnityEngine.PhysicsScene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                obj.physicsScene = arg0;
                Puerts.Utils.SetSelf((int)data, self, obj);
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
