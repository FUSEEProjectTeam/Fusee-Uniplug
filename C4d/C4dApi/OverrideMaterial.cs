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

public class OverrideMaterial : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OverrideMaterial(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OverrideMaterial obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OverrideMaterial() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_OverrideMaterial(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public OverrideMaterial(BaseDocument doc, BaseContainer renderDataBc) : this(C4dApiPINVOKE.new_OverrideMaterial__SWIG_0(BaseDocument.getCPtr(doc), BaseContainer.getCPtr(renderDataBc)), true) {
  }

  public OverrideMaterial(BaseDocument doc) : this(C4dApiPINVOKE.new_OverrideMaterial__SWIG_1(BaseDocument.getCPtr(doc)), true) {
  }

  public OverrideMaterial() : this(C4dApiPINVOKE.new_OverrideMaterial__SWIG_2(), true) {
  }

  public BaseDocument _doc {
    set {
      C4dApiPINVOKE.OverrideMaterial__doc_set(swigCPtr, BaseDocument.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.OverrideMaterial__doc_get(swigCPtr);
      BaseDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
      return ret;
    } 
  }

  public BaseContainer _renderDataBc {
    set {
      C4dApiPINVOKE.OverrideMaterial__renderDataBc_set(swigCPtr, BaseContainer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.OverrideMaterial__renderDataBc_get(swigCPtr);
      BaseContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
      return ret;
    } 
  }

  public BaseList2D _resultMaterial {
    set {
      C4dApiPINVOKE.OverrideMaterial__resultMaterial_set(swigCPtr, BaseList2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.OverrideMaterial__resultMaterial_get(swigCPtr);
      BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
      return ret;
    } 
  }

}

}
