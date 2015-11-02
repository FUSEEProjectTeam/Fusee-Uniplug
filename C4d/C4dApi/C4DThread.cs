/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class C4DThread : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal C4DThread(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(C4DThread obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~C4DThread() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_C4DThread(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BaseThread Get() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.C4DThread_Get(swigCPtr);
    BaseThread ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseThread(cPtr, false);
    return ret;
  }

  public bool Start(THREADMODE mode, THREADPRIORITY priority) {
    bool ret = C4dApiPINVOKE.C4DThread_Start__SWIG_0(swigCPtr, (int)mode, (int)priority);
    return ret;
  }

  public bool Start(THREADMODE mode) {
    bool ret = C4dApiPINVOKE.C4DThread_Start__SWIG_1(swigCPtr, (int)mode);
    return ret;
  }

  public bool Start() {
    bool ret = C4dApiPINVOKE.C4DThread_Start__SWIG_2(swigCPtr);
    return ret;
  }

  public void End(bool wait) {
    C4dApiPINVOKE.C4DThread_End__SWIG_0(swigCPtr, wait);
  }

  public void End() {
    C4dApiPINVOKE.C4DThread_End__SWIG_1(swigCPtr);
  }

  public bool IsRunning() {
    bool ret = C4dApiPINVOKE.C4DThread_IsRunning(swigCPtr);
    return ret;
  }

  public bool TestBreak() {
    bool ret = C4dApiPINVOKE.C4DThread_TestBreak(swigCPtr);
    return ret;
  }

  public void Wait(bool checkevents) {
    C4dApiPINVOKE.C4DThread_Wait__SWIG_0(swigCPtr, checkevents);
  }

  public void Wait() {
    C4dApiPINVOKE.C4DThread_Wait__SWIG_1(swigCPtr);
  }

  public virtual bool TestDBreak() {
    bool ret = C4dApiPINVOKE.C4DThread_TestDBreak(swigCPtr);
    return ret;
  }

  public virtual void Main() {
    C4dApiPINVOKE.C4DThread_Main(swigCPtr);
  }

  public virtual SWIGTYPE_p_Char GetThreadName() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.C4DThread_GetThreadName(swigCPtr);
    SWIGTYPE_p_Char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Char(cPtr, false);
    return ret;
  }

}

}
