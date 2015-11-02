/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class HNData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HNData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HNData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HNData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_HNData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public HNData() : this(C4dApiPINVOKE.new_HNData(), true) {
  }

  public SWIGTYPE_p_Int32 points {
    set {
      C4dApiPINVOKE.HNData_points_set(swigCPtr, SWIGTYPE_p_Int32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.HNData_points_get(swigCPtr);
      SWIGTYPE_p_Int32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Int32(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Int32 polys {
    set {
      C4dApiPINVOKE.HNData_polys_set(swigCPtr, SWIGTYPE_p_Int32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.HNData_polys_get(swigCPtr);
      SWIGTYPE_p_Int32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Int32(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_Float32 pointweight {
    set {
      C4dApiPINVOKE.HNData_pointweight_set(swigCPtr, SWIGTYPE_p_p_Float32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.HNData_pointweight_get(swigCPtr);
      SWIGTYPE_p_p_Float32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_Float32(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_PolyWeight polyweight {
    set {
      C4dApiPINVOKE.HNData_polyweight_set(swigCPtr, SWIGTYPE_p_p_PolyWeight.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.HNData_polyweight_get(swigCPtr);
      SWIGTYPE_p_p_PolyWeight ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_PolyWeight(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Bool changed {
    set {
      C4dApiPINVOKE.HNData_changed_set(swigCPtr, SWIGTYPE_p_Bool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.HNData_changed_get(swigCPtr);
      SWIGTYPE_p_Bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Bool(cPtr, false);
      return ret;
    } 
  }

}

}
