/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class BrushPixelData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BrushPixelData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BrushPixelData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BrushPixelData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_BrushPixelData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_BrushObjectData m_pObject {
    set {
      C4dApiPINVOKE.BrushPixelData_m_pObject_set(swigCPtr, SWIGTYPE_p_BrushObjectData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BrushPixelData_m_pObject_get(swigCPtr);
      SWIGTYPE_p_BrushObjectData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_BrushObjectData(cPtr, false);
      return ret;
    } 
  }

  public int m_Index {
    set {
      C4dApiPINVOKE.BrushPixelData_m_Index_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BrushPixelData_m_Index_get(swigCPtr);
      return ret;
    } 
  }

  public double m_Z {
    set {
      C4dApiPINVOKE.BrushPixelData_m_Z_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.BrushPixelData_m_Z_get(swigCPtr);
      return ret;
    } 
  }

  public BrushPixelData m_pNext {
    set {
      C4dApiPINVOKE.BrushPixelData_m_pNext_set(swigCPtr, BrushPixelData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BrushPixelData_m_pNext_get(swigCPtr);
      BrushPixelData ret = (cPtr == global::System.IntPtr.Zero) ? null : new BrushPixelData(cPtr, false);
      return ret;
    } 
  }

  public BrushPixelData() : this(C4dApiPINVOKE.new_BrushPixelData(), true) {
  }

}

}
