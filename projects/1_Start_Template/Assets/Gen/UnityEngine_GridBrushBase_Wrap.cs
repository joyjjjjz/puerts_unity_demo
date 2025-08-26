#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class UnityEngine_GridBrushBase_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.GridBrushBase).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Paint(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector3Int arg2 = argobj2 != null ? (UnityEngine.Vector3Int)argobj2 : StaticTranslate<UnityEngine.Vector3Int>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.Paint (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Erase(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector3Int arg2 = argobj2 != null ? (UnityEngine.Vector3Int)argobj2 : StaticTranslate<UnityEngine.Vector3Int>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.Erase (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_BoxFill(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.BoundsInt arg2 = argobj2 != null ? (UnityEngine.BoundsInt)argobj2 : StaticTranslate<UnityEngine.BoundsInt>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.BoxFill (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_BoxErase(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.BoundsInt arg2 = argobj2 != null ? (UnityEngine.BoundsInt)argobj2 : StaticTranslate<UnityEngine.BoundsInt>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.BoxErase (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Select(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.BoundsInt arg2 = argobj2 != null ? (UnityEngine.BoundsInt)argobj2 : StaticTranslate<UnityEngine.BoundsInt>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.Select (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_FloodFill(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.Vector3Int arg2 = argobj2 != null ? (UnityEngine.Vector3Int)argobj2 : StaticTranslate<UnityEngine.Vector3Int>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.FloodFill (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Rotate(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        UnityEngine.GridBrushBase.RotationDirection arg0 = (UnityEngine.GridBrushBase.RotationDirection)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GridLayout.CellLayout arg1 = (UnityEngine.GridLayout.CellLayout)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        obj.Rotate (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Flip(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        UnityEngine.GridBrushBase.FlipAxis arg0 = (UnityEngine.GridBrushBase.FlipAxis)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        UnityEngine.GridLayout.CellLayout arg1 = (UnityEngine.GridLayout.CellLayout)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        obj.Flip (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Pick(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.BoundsInt arg2 = argobj2 != null ? (UnityEngine.BoundsInt)argobj2 : StaticTranslate<UnityEngine.BoundsInt>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.Vector3Int arg3 = argobj3 != null ? (UnityEngine.Vector3Int)argobj3 : StaticTranslate<UnityEngine.Vector3Int>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        obj.Pick (arg0, arg1, arg2, arg3);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Move(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.BoundsInt arg2 = argobj2 != null ? (UnityEngine.BoundsInt)argobj2 : StaticTranslate<UnityEngine.BoundsInt>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        UnityEngine.BoundsInt arg3 = argobj3 != null ? (UnityEngine.BoundsInt)argobj3 : StaticTranslate<UnityEngine.BoundsInt>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        obj.Move (arg0, arg1, arg2, arg3);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_MoveStart(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.BoundsInt arg2 = argobj2 != null ? (UnityEngine.BoundsInt)argobj2 : StaticTranslate<UnityEngine.BoundsInt>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.MoveStart (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_MoveEnd(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
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
                        UnityEngine.GridLayout arg0 = argobj0 != null ? (UnityEngine.GridLayout)argobj0 : StaticTranslate<UnityEngine.GridLayout>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        UnityEngine.GameObject arg1 = argobj1 != null ? (UnityEngine.GameObject)argobj1 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        UnityEngine.BoundsInt arg2 = argobj2 != null ? (UnityEngine.BoundsInt)argobj2 : StaticTranslate<UnityEngine.BoundsInt>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.MoveEnd (arg0, arg1, arg2);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_ChangeZPosition(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        obj.ChangeZPosition (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_ResetZPosition(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.GridBrushBase;
        
                {
            
                    {

                        obj.ResetZPosition ();

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
