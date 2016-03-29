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

public class TagData : NodeData {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TagData(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.TagData_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TagData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TagData() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_TagData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual bool Draw(BaseTag tag, BaseObject op, BaseDraw bd, BaseDrawHelp bh) {
    bool ret = C4dApiPINVOKE.TagData_Draw(swigCPtr, BaseTag.getCPtr(tag), BaseObject.getCPtr(op), BaseDraw.getCPtr(bd), BaseDrawHelp.getCPtr(bh));
    return ret;
  }

  public virtual EXECUTIONRESULT Execute(BaseTag tag, BaseDocument doc, BaseObject op, BaseThread bt, int priority, EXECUTIONFLAGS flags) {
    EXECUTIONRESULT ret = (EXECUTIONRESULT)C4dApiPINVOKE.TagData_Execute(swigCPtr, BaseTag.getCPtr(tag), BaseDocument.getCPtr(doc), BaseObject.getCPtr(op), BaseThread.getCPtr(bt), priority, (int)flags);
    return ret;
  }

  public virtual bool AddToExecution(BaseTag tag, PriorityList list) {
    bool ret = C4dApiPINVOKE.TagData_AddToExecution(swigCPtr, BaseTag.getCPtr(tag), PriorityList.getCPtr(list));
    return ret;
  }

  public virtual bool GetModifiedObjects(BaseTag tag, BaseDocument doc, SWIGTYPE_p_p_BaseObject op, SWIGTYPE_p_Bool pluginownedop, ref Fusee.Math.Core.double4x4 /* constMatrix&_cstype */ op_mg, double lod, int flags, BaseThread thread) {
    double[] adbl_op_mg;
    unsafe {adbl_op_mg = Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(op_mg);    fixed (double *pdbl_op_mg = adbl_op_mg) {
    /* constMatrix&_csin_pre */
    try {
      bool ret = C4dApiPINVOKE.TagData_GetModifiedObjects(swigCPtr, BaseTag.getCPtr(tag), BaseDocument.getCPtr(doc), SWIGTYPE_p_p_BaseObject.getCPtr(op), SWIGTYPE_p_Bool.getCPtr(pluginownedop), (global::System.IntPtr) pdbl_op_mg /* constMatrix&_csin */, lod, flags, BaseThread.getCPtr(thread));
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
        // NOP op_mg = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(pdbl_op_mg);
        /* constMatrix&_csin_post */
    }
} } /* constMatrix&_csin_terminator */
  }

  public TagData() : this(C4dApiPINVOKE.new_TagData(), true) {
  }

}

}
