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

public class PolyWeight : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PolyWeight(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PolyWeight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PolyWeight() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_PolyWeight(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float a {
    set {
      C4dApiPINVOKE.PolyWeight_a_set(swigCPtr, value);
    } 
    get {
      float ret = C4dApiPINVOKE.PolyWeight_a_get(swigCPtr);
      return ret;
    } 
  }

  public float b {
    set {
      C4dApiPINVOKE.PolyWeight_b_set(swigCPtr, value);
    } 
    get {
      float ret = C4dApiPINVOKE.PolyWeight_b_get(swigCPtr);
      return ret;
    } 
  }

  public float c {
    set {
      C4dApiPINVOKE.PolyWeight_c_set(swigCPtr, value);
    } 
    get {
      float ret = C4dApiPINVOKE.PolyWeight_c_get(swigCPtr);
      return ret;
    } 
  }

  public float d {
    set {
      C4dApiPINVOKE.PolyWeight_d_set(swigCPtr, value);
    } 
    get {
      float ret = C4dApiPINVOKE.PolyWeight_d_get(swigCPtr);
      return ret;
    } 
  }

  public PolyWeight() : this(C4dApiPINVOKE.new_PolyWeight(), true) {
  }

}

}
