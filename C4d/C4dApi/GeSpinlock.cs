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

public class GeSpinlock : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GeSpinlock(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GeSpinlock obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GeSpinlock() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_GeSpinlock(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GeSpinlock() : this(C4dApiPINVOKE.new_GeSpinlock(), true) {
  }

  public int state {
    set {
      C4dApiPINVOKE.GeSpinlock_state_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.GeSpinlock_state_get(swigCPtr);
      return ret;
    } 
  }

  public void Lock() {
    C4dApiPINVOKE.GeSpinlock_Lock(swigCPtr);
  }

  public void Unlock() {
    C4dApiPINVOKE.GeSpinlock_Unlock(swigCPtr);
  }

  public bool AttemptLock() {
    bool ret = C4dApiPINVOKE.GeSpinlock_AttemptLock(swigCPtr);
    return ret;
  }

}

}
