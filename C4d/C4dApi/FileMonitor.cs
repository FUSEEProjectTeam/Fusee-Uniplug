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

public class FileMonitor : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FileMonitor(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FileMonitor obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FileMonitor() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_FileMonitor(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static bool WatchFolder(Filename folder, SWIGTYPE_p_f_r_q_const__Filename_Int_p_void__Int32 callback, SWIGTYPE_p_void userdata) {
    bool ret = C4dApiPINVOKE.FileMonitor_WatchFolder(Filename.getCPtr(folder), SWIGTYPE_p_f_r_q_const__Filename_Int_p_void__Int32.getCPtr(callback), SWIGTYPE_p_void.getCPtr(userdata));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool DontWatchFolder(Filename folder, SWIGTYPE_p_f_r_q_const__Filename_Int_p_void__Int32 callback, SWIGTYPE_p_void userdata) {
    bool ret = C4dApiPINVOKE.FileMonitor_DontWatchFolder(Filename.getCPtr(folder), SWIGTYPE_p_f_r_q_const__Filename_Int_p_void__Int32.getCPtr(callback), SWIGTYPE_p_void.getCPtr(userdata));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool WatchFile(Filename file, SWIGTYPE_p_f_r_q_const__Filename_Int_p_void__Int32 callback, SWIGTYPE_p_void userdata) {
    bool ret = C4dApiPINVOKE.FileMonitor_WatchFile(Filename.getCPtr(file), SWIGTYPE_p_f_r_q_const__Filename_Int_p_void__Int32.getCPtr(callback), SWIGTYPE_p_void.getCPtr(userdata));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool DontWatchFile(Filename file, SWIGTYPE_p_f_r_q_const__Filename_Int_p_void__Int32 callback, SWIGTYPE_p_void userdata) {
    bool ret = C4dApiPINVOKE.FileMonitor_DontWatchFile(Filename.getCPtr(file), SWIGTYPE_p_f_r_q_const__Filename_Int_p_void__Int32.getCPtr(callback), SWIGTYPE_p_void.getCPtr(userdata));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FileMonitor() : this(C4dApiPINVOKE.new_FileMonitor(), true) {
  }

}

}
