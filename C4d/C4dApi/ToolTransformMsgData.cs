//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class ToolTransformMsgData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ToolTransformMsgData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ToolTransformMsgData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ToolTransformMsgData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_ToolTransformMsgData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double scl {
    set {
      C4dApiPINVOKE.ToolTransformMsgData_scl_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.ToolTransformMsgData_scl_get(swigCPtr);
      return ret;
    } 
  }

  public Fusee.Math.Core.double4x4 /* Matrix_cstype */ tm {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.ToolTransformMsgData_tm_set(swigCPtr, (global::System.IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.ToolTransformMsgData_tm_get(swigCPtr);
	  Fusee.Math.Core.double4x4 ret;
	  unsafe {ret = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public Fusee.Math.Core.double4x4 /* Matrix_cstype */ mm {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.ToolTransformMsgData_mm_set(swigCPtr, (global::System.IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.ToolTransformMsgData_mm_get(swigCPtr);
	  Fusee.Math.Core.double4x4 ret;
	  unsafe {ret = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public Fusee.Math.Core.double4x4 /* Matrix_cstype */ up {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.ToolTransformMsgData_up_set(swigCPtr, (global::System.IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.ToolTransformMsgData_up_get(swigCPtr);
	  Fusee.Math.Core.double4x4 ret;
	  unsafe {ret = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public bool children {
    set {
      C4dApiPINVOKE.ToolTransformMsgData_children_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.ToolTransformMsgData_children_get(swigCPtr);
      return ret;
    } 
  }

  public BaseObject undo {
    set {
      C4dApiPINVOKE.ToolTransformMsgData_undo_set(swigCPtr, BaseObject.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ToolTransformMsgData_undo_get(swigCPtr);
      BaseObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseObject(cPtr, false);
      return ret;
    } 
  }

  public TOOLTRANSFORM_FLAG flags {
    set {
      C4dApiPINVOKE.ToolTransformMsgData_flags_set(swigCPtr, (int)value);
    } 
    get {
      TOOLTRANSFORM_FLAG ret = (TOOLTRANSFORM_FLAG)C4dApiPINVOKE.ToolTransformMsgData_flags_get(swigCPtr);
      return ret;
    } 
  }

  public ToolTransformMsgData() : this(C4dApiPINVOKE.new_ToolTransformMsgData(), true) {
  }

}

}
