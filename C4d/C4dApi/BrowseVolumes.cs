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

public class BrowseVolumes : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BrowseVolumes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BrowseVolumes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static BrowseVolumes Alloc() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrowseVolumes_Alloc();
    BrowseVolumes ret = (cPtr == global::System.IntPtr.Zero) ? null : new BrowseVolumes(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_BrowseVolumes bf) {
    C4dApiPINVOKE.BrowseVolumes_Free(SWIGTYPE_p_p_BrowseVolumes.getCPtr(bf));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Init() {
    C4dApiPINVOKE.BrowseVolumes_Init(swigCPtr);
  }

  public bool GetNext() {
    bool ret = C4dApiPINVOKE.BrowseVolumes_GetNext(swigCPtr);
    return ret;
  }

  public Filename GetFilename() {
    Filename ret = new Filename(C4dApiPINVOKE.BrowseVolumes_GetFilename(swigCPtr), true);
    return ret;
  }

  public string /* String_cstype */ GetVolumeName(SWIGTYPE_p_Int32 out_flags)  {  /* <String_csout> */
      string ret = C4dApiPINVOKE.BrowseVolumes_GetVolumeName(swigCPtr, SWIGTYPE_p_Int32.getCPtr(out_flags));
      return ret;
   } /* </String_csout> */ 

}

}
