//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class DescriptionGetObjects : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DescriptionGetObjects(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DescriptionGetObjects obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DescriptionGetObjects() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_DescriptionGetObjects(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BaseContainer bc {
    set {
      C4dApiPINVOKE.DescriptionGetObjects_bc_set(swigCPtr, BaseContainer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.DescriptionGetObjects_bc_get(swigCPtr);
      BaseContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
      return ret;
    } 
  }

  public DescID descid {
    set {
      C4dApiPINVOKE.DescriptionGetObjects_descid_set(swigCPtr, DescID.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.DescriptionGetObjects_descid_get(swigCPtr);
      DescID ret = (cPtr == global::System.IntPtr.Zero) ? null : new DescID(cPtr, false);
      return ret;
    } 
  }

  public DescriptionGetObjects() : this(C4dApiPINVOKE.new_DescriptionGetObjects(), true) {
  }

}

}
