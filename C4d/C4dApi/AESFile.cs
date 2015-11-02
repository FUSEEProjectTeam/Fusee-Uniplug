/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class AESFile : BaseFile {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AESFile(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.AESFile_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AESFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new static AESFile Alloc() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.AESFile_Alloc();
    AESFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new AESFile(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_AESFile fl) {
    C4dApiPINVOKE.AESFile_Free(SWIGTYPE_p_p_AESFile.getCPtr(fl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Open(Filename name, string key, int keylen, int blocksize, uint aes_flags, FILEOPEN mode, FILEDIALOG error_dialog, BYTEORDER order, int type, int creator) {
    bool ret = C4dApiPINVOKE.AESFile_Open__SWIG_0(swigCPtr, Filename.getCPtr(name), key, keylen, blocksize, aes_flags, (int)mode, (int)error_dialog, (int)order, type, creator);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Open(Filename name, string key, int keylen, int blocksize, uint aes_flags, FILEOPEN mode, FILEDIALOG error_dialog, BYTEORDER order, int type) {
    bool ret = C4dApiPINVOKE.AESFile_Open__SWIG_1(swigCPtr, Filename.getCPtr(name), key, keylen, blocksize, aes_flags, (int)mode, (int)error_dialog, (int)order, type);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Open(Filename name, string key, int keylen, int blocksize, uint aes_flags, FILEOPEN mode, FILEDIALOG error_dialog, BYTEORDER order) {
    bool ret = C4dApiPINVOKE.AESFile_Open__SWIG_2(swigCPtr, Filename.getCPtr(name), key, keylen, blocksize, aes_flags, (int)mode, (int)error_dialog, (int)order);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Open(Filename name, string key, int keylen, int blocksize, uint aes_flags, FILEOPEN mode, FILEDIALOG error_dialog) {
    bool ret = C4dApiPINVOKE.AESFile_Open__SWIG_3(swigCPtr, Filename.getCPtr(name), key, keylen, blocksize, aes_flags, (int)mode, (int)error_dialog);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Open(Filename name, string key, int keylen, int blocksize, uint aes_flags, FILEOPEN mode) {
    bool ret = C4dApiPINVOKE.AESFile_Open__SWIG_4(swigCPtr, Filename.getCPtr(name), key, keylen, blocksize, aes_flags, (int)mode);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Open(Filename name, string key, int keylen, int blocksize, uint aes_flags) {
    bool ret = C4dApiPINVOKE.AESFile_Open__SWIG_5(swigCPtr, Filename.getCPtr(name), key, keylen, blocksize, aes_flags);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool CheckEncryption(Filename encrypt, Filename decrypt, string key, int keylen, int blocksize) {
    bool ret = C4dApiPINVOKE.AESFile_CheckEncryption(Filename.getCPtr(encrypt), Filename.getCPtr(decrypt), key, keylen, blocksize);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
