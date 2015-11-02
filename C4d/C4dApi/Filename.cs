/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class Filename : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Filename(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Filename obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Filename() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_Filename(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Filename() : this(C4dApiPINVOKE.new_Filename__SWIG_0(), true) {
  }

  public Filename(SWIGTYPE_p_Char arg0) : this(C4dApiPINVOKE.new_Filename__SWIG_1(SWIGTYPE_p_Char.getCPtr(arg0)), true) {
  }

  public Filename(string /* constString&_cstype */ arg0) : this(C4dApiPINVOKE.new_Filename__SWIG_2(arg0), true) {
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public Filename(Filename src) : this(C4dApiPINVOKE.new_Filename__SWIG_3(Filename.getCPtr(src)), true) {
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Content() {
    bool ret = C4dApiPINVOKE.Filename_Content(swigCPtr);
    return ret;
  }

  public string /* String_cstype */ GetString()  {  /* <String_csout> */
      string ret = C4dApiPINVOKE.Filename_GetString(swigCPtr);
      return ret;
   } /* </String_csout> */ 

  public void SetString(string /* constString&_cstype */ str) {
    C4dApiPINVOKE.Filename_SetString(swigCPtr, str);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public Filename GetDirectory() {
    Filename ret = new Filename(C4dApiPINVOKE.Filename_GetDirectory(swigCPtr), true);
    return ret;
  }

  public void SetDirectory(Filename str) {
    C4dApiPINVOKE.Filename_SetDirectory(swigCPtr, Filename.getCPtr(str));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public Filename GetFile() {
    Filename ret = new Filename(C4dApiPINVOKE.Filename_GetFile(swigCPtr), true);
    return ret;
  }

  public void SetFile(Filename str) {
    C4dApiPINVOKE.Filename_SetFile(swigCPtr, Filename.getCPtr(str));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public string /* String_cstype */ GetFileString()  {  /* <String_csout> */
      string ret = C4dApiPINVOKE.Filename_GetFileString(swigCPtr);
      return ret;
   } /* </String_csout> */ 

  public string /* String_cstype */ GetSuffix()  {  /* <String_csout> */
      string ret = C4dApiPINVOKE.Filename_GetSuffix(swigCPtr);
      return ret;
   } /* </String_csout> */ 

  public void SetSuffix(string /* constString&_cstype */ str) {
    C4dApiPINVOKE.Filename_SetSuffix(swigCPtr, str);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearSuffix() {
    C4dApiPINVOKE.Filename_ClearSuffix(swigCPtr);
  }

  public void ClearSuffixComplete() {
    C4dApiPINVOKE.Filename_ClearSuffixComplete(swigCPtr);
  }

  public bool CheckSuffix(string /* constString&_cstype */ str) {
    bool ret = C4dApiPINVOKE.Filename_CheckSuffix(swigCPtr, str);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMemoryReadMode(SWIGTYPE_p_void adr, int size, bool transferOwnership) {
    C4dApiPINVOKE.Filename_SetMemoryReadMode__SWIG_0(swigCPtr, SWIGTYPE_p_void.getCPtr(adr), size, transferOwnership);
  }

  public void SetMemoryReadMode(SWIGTYPE_p_void adr, int size) {
    C4dApiPINVOKE.Filename_SetMemoryReadMode__SWIG_1(swigCPtr, SWIGTYPE_p_void.getCPtr(adr), size);
  }

  public void SetMemoryReadMode(SWIGTYPE_p_void adr) {
    C4dApiPINVOKE.Filename_SetMemoryReadMode__SWIG_2(swigCPtr, SWIGTYPE_p_void.getCPtr(adr));
  }

  public void SetMemoryWriteMode(MemoryFileStruct mfs) {
    C4dApiPINVOKE.Filename_SetMemoryWriteMode(swigCPtr, MemoryFileStruct.getCPtr(mfs));
  }

  public void CopyTo(Filename dst) {
    C4dApiPINVOKE.Filename_CopyTo(swigCPtr, Filename.getCPtr(dst));
  }

  public bool IsBrowserUrl() {
    bool ret = C4dApiPINVOKE.Filename_IsBrowserUrl(swigCPtr);
    return ret;
  }

  public bool FileSelect(FILESELECTTYPE type, FILESELECT flags, string /* constString&_cstype */ title, string /* constString&_cstype */ force_suffix) {
    bool ret = C4dApiPINVOKE.Filename_FileSelect__SWIG_0(swigCPtr, (int)type, (int)flags, title, force_suffix);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool FileSelect(FILESELECTTYPE type, FILESELECT flags, string /* constString&_cstype */ title) {
    bool ret = C4dApiPINVOKE.Filename_FileSelect__SWIG_1(swigCPtr, (int)type, (int)flags, title);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MemoryFileStruct GetMemoryModeI() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.Filename_GetMemoryModeI(swigCPtr);
    MemoryFileStruct ret = (cPtr == global::System.IntPtr.Zero) ? null : new MemoryFileStruct(cPtr, false);
    return ret;
  }

}

}
