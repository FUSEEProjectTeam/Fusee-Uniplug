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

public class DDescriptionParams : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DDescriptionParams(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DDescriptionParams obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DDescriptionParams() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_DDescriptionParams(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Description Desc {
    set {
      C4dApiPINVOKE.DDescriptionParams_Desc_set(swigCPtr, Description.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.DDescriptionParams_Desc_get(swigCPtr);
      Description ret = (cPtr == global::System.IntPtr.Zero) ? null : new Description(cPtr, false);
      return ret;
    } 
  }

  public DESCFLAGS_DESC Flags {
    set {
      C4dApiPINVOKE.DDescriptionParams_Flags_set(swigCPtr, (int)value);
    } 
    get {
      DESCFLAGS_DESC ret = (DESCFLAGS_DESC)C4dApiPINVOKE.DDescriptionParams_Flags_get(swigCPtr);
      return ret;
    } 
  }

  public DDescriptionParams() : this(C4dApiPINVOKE.new_DDescriptionParams(), true) {
  }

}

}
