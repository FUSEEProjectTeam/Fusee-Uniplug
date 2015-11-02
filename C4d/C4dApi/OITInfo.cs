/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class OITInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OITInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OITInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OITInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_OITInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public OITMODE mode {
    set {
      C4dApiPINVOKE.OITInfo_mode_set(swigCPtr, (int)value);
    } 
    get {
      OITMODE ret = (OITMODE)C4dApiPINVOKE.OITInfo_mode_get(swigCPtr);
      return ret;
    } 
  }

  public int lPass {
    set {
      C4dApiPINVOKE.OITInfo_lPass_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.OITInfo_lPass_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_C4DGLuint nDepthTexture {
    set {
      C4dApiPINVOKE.OITInfo_nDepthTexture_set(swigCPtr, SWIGTYPE_p_C4DGLuint.getCPtr(value));
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_C4DGLuint ret = new SWIGTYPE_p_C4DGLuint(C4dApiPINVOKE.OITInfo_nDepthTexture_get(swigCPtr), true);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_void pData {
    set {
      C4dApiPINVOKE.OITInfo_pData_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.OITInfo_pData_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector4d32 vScaleOff {
    set {
      C4dApiPINVOKE.OITInfo_vScaleOff_set(swigCPtr, SWIGTYPE_p_Vector4d32.getCPtr(value));
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector4d32 ret = new SWIGTYPE_p_Vector4d32(C4dApiPINVOKE.OITInfo_vScaleOff_get(swigCPtr), true);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public OITInfo() : this(C4dApiPINVOKE.new_OITInfo(), true) {
  }

}

}
