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

public class ToolAskMsgData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ToolAskMsgData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ToolAskMsgData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ToolAskMsgData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_ToolAskMsgData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int version {
    set {
      C4dApiPINVOKE.ToolAskMsgData_version_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.ToolAskMsgData_version_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_EditorWindow bw {
    set {
      C4dApiPINVOKE.ToolAskMsgData_bw_set(swigCPtr, SWIGTYPE_p_EditorWindow.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ToolAskMsgData_bw_get(swigCPtr);
      SWIGTYPE_p_EditorWindow ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_EditorWindow(cPtr, false);
      return ret;
    } 
  }

  public BaseDocument doc {
    set {
      C4dApiPINVOKE.ToolAskMsgData_doc_set(swigCPtr, BaseDocument.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ToolAskMsgData_doc_get(swigCPtr);
      BaseDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
      return ret;
    } 
  }

  public int x {
    set {
      C4dApiPINVOKE.ToolAskMsgData_x_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.ToolAskMsgData_x_get(swigCPtr);
      return ret;
    } 
  }

  public int y {
    set {
      C4dApiPINVOKE.ToolAskMsgData_y_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.ToolAskMsgData_y_get(swigCPtr);
      return ret;
    } 
  }

  public int button {
    set {
      C4dApiPINVOKE.ToolAskMsgData_button_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.ToolAskMsgData_button_get(swigCPtr);
      return ret;
    } 
  }

  public BaseContainer msg {
    set {
      C4dApiPINVOKE.ToolAskMsgData_msg_set(swigCPtr, BaseContainer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ToolAskMsgData_msg_get(swigCPtr);
      BaseContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
      return ret;
    } 
  }

  public BaseDraw bd {
    set {
      C4dApiPINVOKE.ToolAskMsgData_bd_set(swigCPtr, BaseDraw.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ToolAskMsgData_bd_get(swigCPtr);
      BaseDraw ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseDraw(cPtr, false);
      return ret;
    } 
  }

  public bool popup_exit {
    set {
      C4dApiPINVOKE.ToolAskMsgData_popup_exit_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.ToolAskMsgData_popup_exit_get(swigCPtr);
      return ret;
    } 
  }

  public bool popup_allowed {
    set {
      C4dApiPINVOKE.ToolAskMsgData_popup_allowed_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.ToolAskMsgData_popup_allowed_get(swigCPtr);
      return ret;
    } 
  }

  public int popup_menuid {
    set {
      C4dApiPINVOKE.ToolAskMsgData_popup_menuid_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.ToolAskMsgData_popup_menuid_get(swigCPtr);
      return ret;
    } 
  }

  public bool use_middlemouse {
    set {
      C4dApiPINVOKE.ToolAskMsgData_use_middlemouse_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.ToolAskMsgData_use_middlemouse_get(swigCPtr);
      return ret;
    } 
  }

  public bool use_rightmouse {
    set {
      C4dApiPINVOKE.ToolAskMsgData_use_rightmouse_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.ToolAskMsgData_use_rightmouse_get(swigCPtr);
      return ret;
    } 
  }

  public bool resize_allowed {
    set {
      C4dApiPINVOKE.ToolAskMsgData_resize_allowed_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.ToolAskMsgData_resize_allowed_get(swigCPtr);
      return ret;
    } 
  }

  public bool use_singleclick {
    set {
      C4dApiPINVOKE.ToolAskMsgData_use_singleclick_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.ToolAskMsgData_use_singleclick_get(swigCPtr);
      return ret;
    } 
  }

  public ToolAskMsgData() : this(C4dApiPINVOKE.new_ToolAskMsgData(), true) {
  }

}

}
