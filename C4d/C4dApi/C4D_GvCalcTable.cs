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

public class C4D_GvCalcTable : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal C4D_GvCalcTable(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(C4D_GvCalcTable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~C4D_GvCalcTable() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_C4D_GvCalcTable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_f_p_GvCalcTable_p_GvRun_p_GvNode__Bool AddNodeToTable {
    set {
      C4dApiPINVOKE.C4D_GvCalcTable_AddNodeToTable_set(swigCPtr, SWIGTYPE_p_f_p_GvCalcTable_p_GvRun_p_GvNode__Bool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.C4D_GvCalcTable_AddNodeToTable_get(swigCPtr);
      SWIGTYPE_p_f_p_GvCalcTable_p_GvRun_p_GvNode__Bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_GvCalcTable_p_GvRun_p_GvNode__Bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_GvCalcTable_p_GvRun__void ResetTable {
    set {
      C4dApiPINVOKE.C4D_GvCalcTable_ResetTable_set(swigCPtr, SWIGTYPE_p_f_p_GvCalcTable_p_GvRun__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.C4D_GvCalcTable_ResetTable_get(swigCPtr);
      SWIGTYPE_p_f_p_GvCalcTable_p_GvRun__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_GvCalcTable_p_GvRun__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_GvCalcTable_p_GvRun__Int32 GetTableCount {
    set {
      C4dApiPINVOKE.C4D_GvCalcTable_GetTableCount_set(swigCPtr, SWIGTYPE_p_f_p_GvCalcTable_p_GvRun__Int32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.C4D_GvCalcTable_GetTableCount_get(swigCPtr);
      SWIGTYPE_p_f_p_GvCalcTable_p_GvRun__Int32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_GvCalcTable_p_GvRun__Int32(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_GvCalcTable_p_GvRun_Int32__p_GvNode GetTableNode {
    set {
      C4dApiPINVOKE.C4D_GvCalcTable_GetTableNode_set(swigCPtr, SWIGTYPE_p_f_p_GvCalcTable_p_GvRun_Int32__p_GvNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.C4D_GvCalcTable_GetTableNode_get(swigCPtr);
      SWIGTYPE_p_f_p_GvCalcTable_p_GvRun_Int32__p_GvNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_GvCalcTable_p_GvRun_Int32__p_GvNode(cPtr, false);
      return ret;
    } 
  }

  public C4D_GvCalcTable() : this(C4dApiPINVOKE.new_C4D_GvCalcTable(), true) {
  }

}

}
