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

public class GvNodeMaster : BaseList2D {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal GvNodeMaster(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.GvNodeMaster_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GvNodeMaster obj) {
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

  public GvNode AllocNode(int id) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_AllocNode(swigCPtr, id);
    GvNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvNode(cPtr, false);
    return ret;
  }

  public void FreeNode(ref GvNode /* GvNode_cstype */ node) {
    global::System.IntPtr p_node;
    unsafe { void *pp_node = &p_node;    /* GvNode_csin_pre */
    try {
      C4dApiPINVOKE.GvNodeMaster_FreeNode(swigCPtr, (global::System.IntPtr) pp_node /* GvNode_csin */);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } finally {
        node = new GvNode(p_node, false);
        /* GvNode_csin_post */
    }
} /* GvNode_csin_terminator */
  }

  public GvNode CreateNode(GvNode parent, int id, GvNode insert, int x, int y) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_CreateNode__SWIG_0(swigCPtr, GvNode.getCPtr(parent), id, GvNode.getCPtr(insert), x, y);
    GvNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvNode(cPtr, false);
    return ret;
  }

  public GvNode CreateNode(GvNode parent, int id, GvNode insert, int x) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_CreateNode__SWIG_1(swigCPtr, GvNode.getCPtr(parent), id, GvNode.getCPtr(insert), x);
    GvNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvNode(cPtr, false);
    return ret;
  }

  public GvNode CreateNode(GvNode parent, int id, GvNode insert) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_CreateNode__SWIG_2(swigCPtr, GvNode.getCPtr(parent), id, GvNode.getCPtr(insert));
    GvNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvNode(cPtr, false);
    return ret;
  }

  public GvNode CreateNode(GvNode parent, int id) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_CreateNode__SWIG_3(swigCPtr, GvNode.getCPtr(parent), id);
    GvNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvNode(cPtr, false);
    return ret;
  }

  public GvNode GetRoot() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_GetRoot(swigCPtr);
    GvNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvNode(cPtr, false);
    return ret;
  }

  public BaseList2D GetOwner() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_GetOwner(swigCPtr);
    BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public bool IsConnectionValid(GvNode source_node, GvPort source_port, GvNode dest_node, GvPort dest_port, ref GvNode /* GvNode_cstype */ source_node_out, ref GvPort /* GvPort_cstype */ source_port_out, ref GvNode /* GvNode_cstype */ dest_node_out, ref GvPort /* GvPort_cstype */ dest_port_out) {
    global::System.IntPtr p_source_node_out;
    unsafe { void *pp_source_node_out = &p_source_node_out;    /* GvNode_csin_pre */
    global::System.IntPtr p_source_port_out;
    unsafe { void *pp_source_port_out = &p_source_port_out;    /* GvPort_csin_pre */
    global::System.IntPtr p_dest_node_out;
    unsafe { void *pp_dest_node_out = &p_dest_node_out;    /* GvNode_csin_pre */
    global::System.IntPtr p_dest_port_out;
    unsafe { void *pp_dest_port_out = &p_dest_port_out;    /* GvPort_csin_pre */
    try {
      bool ret = C4dApiPINVOKE.GvNodeMaster_IsConnectionValid(swigCPtr, GvNode.getCPtr(source_node), GvPort.getCPtr(source_port), GvNode.getCPtr(dest_node), GvPort.getCPtr(dest_port), (global::System.IntPtr) pp_source_node_out /* GvNode_csin */, (global::System.IntPtr) pp_source_port_out /* GvPort_csin */, (global::System.IntPtr) pp_dest_node_out /* GvNode_csin */, (global::System.IntPtr) pp_dest_port_out /* GvPort_csin */);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
        source_node_out = new GvNode(p_source_node_out, false);
        /* GvNode_csin_post */
        source_port_out = new GvPort(p_source_port_out, false);
        /* GvPort_csin_post */
        dest_node_out = new GvNode(p_dest_node_out, false);
        /* GvNode_csin_post */
        dest_port_out = new GvPort(p_dest_port_out, false);
        /* GvPort_csin_post */
    }
} /* GvPort_csin_terminator */
} /* GvNode_csin_terminator */
} /* GvPort_csin_terminator */
} /* GvNode_csin_terminator */
  }

  public bool InsertFirst(GvNode parent, GvNode node) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_InsertFirst(swigCPtr, GvNode.getCPtr(parent), GvNode.getCPtr(node));
    return ret;
  }

  public bool InsertLast(GvNode parent, GvNode node) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_InsertLast(swigCPtr, GvNode.getCPtr(parent), GvNode.getCPtr(node));
    return ret;
  }

  public bool SetHierarchy(GvNode insert, GvNode node, GvInsertMode mode) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_SetHierarchy__SWIG_0(swigCPtr, GvNode.getCPtr(insert), GvNode.getCPtr(node), (int)mode);
    return ret;
  }

  public bool SetHierarchy(GvNode insert, GvNode node) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_SetHierarchy__SWIG_1(swigCPtr, GvNode.getCPtr(insert), GvNode.getCPtr(node));
    return ret;
  }

  public GvError QueryCalculation(GvQuery query, BaseThread thread) {
    GvError ret = (GvError)C4dApiPINVOKE.GvNodeMaster_QueryCalculation(swigCPtr, GvQuery.getCPtr(query), BaseThread.getCPtr(thread));
    return ret;
  }

  public GvError InitCalculation(GvInit init, BaseThread thread) {
    GvError ret = (GvError)C4dApiPINVOKE.GvNodeMaster_InitCalculation(swigCPtr, GvInit.getCPtr(init), BaseThread.getCPtr(thread));
    return ret;
  }

  public GvError Calculate(int cpu_id) {
    GvError ret = (GvError)C4dApiPINVOKE.GvNodeMaster_Calculate(swigCPtr, cpu_id);
    return ret;
  }

  public GvError Recalculate(GvNodeMaster master, GvNode node, int cpu_id) {
    GvError ret = (GvError)C4dApiPINVOKE.GvNodeMaster_Recalculate(swigCPtr, GvNodeMaster.getCPtr(master), GvNode.getCPtr(node), cpu_id);
    return ret;
  }

  public void FreeCalculation() {
    C4dApiPINVOKE.GvNodeMaster_FreeCalculation(swigCPtr);
  }

  public GvError Execute(BaseThread thread) {
    GvError ret = (GvError)C4dApiPINVOKE.GvNodeMaster_Execute(swigCPtr, BaseThread.getCPtr(thread));
    return ret;
  }

  public new int GetBranchInfo(BranchInfo info, int max, GETBRANCHINFO flags) {
    int ret = C4dApiPINVOKE.GvNodeMaster_GetBranchInfo(swigCPtr, BranchInfo.getCPtr(info), max, (int)flags);
    return ret;
  }

  public GvRun GetRun() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_GetRun(swigCPtr);
    GvRun ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvRun(cPtr, false);
    return ret;
  }

  public GvCalc GetCalc() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_GetCalc(swigCPtr);
    GvCalc ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvCalc(cPtr, false);
    return ret;
  }

  public GvQuery AllocQuery() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_AllocQuery(swigCPtr);
    GvQuery ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvQuery(cPtr, false);
    return ret;
  }

  public void FreeQuery(SWIGTYPE_p_p_GvQuery query) {
    C4dApiPINVOKE.GvNodeMaster_FreeQuery(swigCPtr, SWIGTYPE_p_p_GvQuery.getCPtr(query));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public GvInit AllocInit() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_AllocInit(swigCPtr);
    GvInit ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvInit(cPtr, false);
    return ret;
  }

  public void FreeInit(SWIGTYPE_p_p_GvInit init) {
    C4dApiPINVOKE.GvNodeMaster_FreeInit(swigCPtr, SWIGTYPE_p_p_GvInit.getCPtr(init));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public int RegisterUserData(SWIGTYPE_p_void data) {
    int ret = C4dApiPINVOKE.GvNodeMaster_RegisterUserData__SWIG_0(swigCPtr, SWIGTYPE_p_void.getCPtr(data));
    return ret;
  }

  public int RegisterUserData() {
    int ret = C4dApiPINVOKE.GvNodeMaster_RegisterUserData__SWIG_1(swigCPtr);
    return ret;
  }

  public void SetUserData(int id, SWIGTYPE_p_void data) {
    C4dApiPINVOKE.GvNodeMaster_SetUserData(swigCPtr, id, SWIGTYPE_p_void.getCPtr(data));
  }

  public SWIGTYPE_p_void GetUserData(int id) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_GetUserData(swigCPtr, id);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public GvCalcTable AllocCalculationTable(int cpu_count, bool sort, int nr_of_preallocated_entries, bool iteration) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_AllocCalculationTable__SWIG_0(swigCPtr, cpu_count, sort, nr_of_preallocated_entries, iteration);
    GvCalcTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvCalcTable(cPtr, false);
    return ret;
  }

  public GvCalcTable AllocCalculationTable(int cpu_count, bool sort, int nr_of_preallocated_entries) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_AllocCalculationTable__SWIG_1(swigCPtr, cpu_count, sort, nr_of_preallocated_entries);
    GvCalcTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvCalcTable(cPtr, false);
    return ret;
  }

  public GvCalcTable AllocCalculationTable(int cpu_count, bool sort) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_AllocCalculationTable__SWIG_2(swigCPtr, cpu_count, sort);
    GvCalcTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvCalcTable(cPtr, false);
    return ret;
  }

  public GvCalcTable AllocCalculationTable(int cpu_count) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_AllocCalculationTable__SWIG_3(swigCPtr, cpu_count);
    GvCalcTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvCalcTable(cPtr, false);
    return ret;
  }

  public void FreeCalculationTable(SWIGTYPE_p_p_GvCalcTable table) {
    C4dApiPINVOKE.GvNodeMaster_FreeCalculationTable(swigCPtr, SWIGTYPE_p_p_GvCalcTable.getCPtr(table));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool AddToDrawList(GvNode bn, SWIGTYPE_p_p_void data, int data_size) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_AddToDrawList__SWIG_0(swigCPtr, GvNode.getCPtr(bn), SWIGTYPE_p_p_void.getCPtr(data), data_size);
    return ret;
  }

  public bool AddToDrawList(GvNode bn, SWIGTYPE_p_p_void data) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_AddToDrawList__SWIG_1(swigCPtr, GvNode.getCPtr(bn), SWIGTYPE_p_p_void.getCPtr(data));
    return ret;
  }

  public bool AddToDrawList(GvNode bn) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_AddToDrawList__SWIG_2(swigCPtr, GvNode.getCPtr(bn));
    return ret;
  }

  public SWIGTYPE_p_GvCopyBuffer GetCopyBuffer(GvNode first, bool copy_selected) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_GetCopyBuffer__SWIG_0(swigCPtr, GvNode.getCPtr(first), copy_selected);
    SWIGTYPE_p_GvCopyBuffer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_GvCopyBuffer(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_GvCopyBuffer GetCopyBuffer(GvNode first) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_GetCopyBuffer__SWIG_1(swigCPtr, GvNode.getCPtr(first));
    SWIGTYPE_p_GvCopyBuffer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_GvCopyBuffer(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_GvCopyBuffer GetCopyBuffer() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GvNodeMaster_GetCopyBuffer__SWIG_2(swigCPtr);
    SWIGTYPE_p_GvCopyBuffer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_GvCopyBuffer(cPtr, false);
    return ret;
  }

  public void FreeCopyBuffer(SWIGTYPE_p_p_GvCopyBuffer buffer) {
    C4dApiPINVOKE.GvNodeMaster_FreeCopyBuffer(swigCPtr, SWIGTYPE_p_p_GvCopyBuffer.getCPtr(buffer));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool PasteFromBuffer(SWIGTYPE_p_GvCopyBuffer buffer, GvInsertMode mode, GvNode dest, int x, int y, bool center, SWIGTYPE_p_void info) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_PasteFromBuffer__SWIG_0(swigCPtr, SWIGTYPE_p_GvCopyBuffer.getCPtr(buffer), (int)mode, GvNode.getCPtr(dest), x, y, center, SWIGTYPE_p_void.getCPtr(info));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool PasteFromBuffer(SWIGTYPE_p_GvCopyBuffer buffer, GvInsertMode mode, GvNode dest, int x, int y, bool center) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_PasteFromBuffer__SWIG_1(swigCPtr, SWIGTYPE_p_GvCopyBuffer.getCPtr(buffer), (int)mode, GvNode.getCPtr(dest), x, y, center);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool PasteFromBuffer(SWIGTYPE_p_GvCopyBuffer buffer, GvInsertMode mode, GvNode dest, int x, int y) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_PasteFromBuffer__SWIG_2(swigCPtr, SWIGTYPE_p_GvCopyBuffer.getCPtr(buffer), (int)mode, GvNode.getCPtr(dest), x, y);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool PasteFromBuffer(SWIGTYPE_p_GvCopyBuffer buffer, GvInsertMode mode, GvNode dest, int x) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_PasteFromBuffer__SWIG_3(swigCPtr, SWIGTYPE_p_GvCopyBuffer.getCPtr(buffer), (int)mode, GvNode.getCPtr(dest), x);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool PasteFromBuffer(SWIGTYPE_p_GvCopyBuffer buffer, GvInsertMode mode, GvNode dest) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_PasteFromBuffer__SWIG_4(swigCPtr, SWIGTYPE_p_GvCopyBuffer.getCPtr(buffer), (int)mode, GvNode.getCPtr(dest));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool PasteFromBuffer(SWIGTYPE_p_GvCopyBuffer buffer, GvInsertMode mode) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_PasteFromBuffer__SWIG_5(swigCPtr, SWIGTYPE_p_GvCopyBuffer.getCPtr(buffer), (int)mode);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool PasteFromBuffer(SWIGTYPE_p_GvCopyBuffer buffer) {
    bool ret = C4dApiPINVOKE.GvNodeMaster_PasteFromBuffer__SWIG_6(swigCPtr, SWIGTYPE_p_GvCopyBuffer.getCPtr(buffer));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsEnabled() {
    bool ret = C4dApiPINVOKE.GvNodeMaster_IsEnabled(swigCPtr);
    return ret;
  }

  public void SetPrefs(BaseContainer bc) {
    C4dApiPINVOKE.GvNodeMaster_SetPrefs(swigCPtr, BaseContainer.getCPtr(bc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetPrefs(BaseContainer bc) {
    C4dApiPINVOKE.GvNodeMaster_GetPrefs(swigCPtr, BaseContainer.getCPtr(bc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool AddUndo() {
    bool ret = C4dApiPINVOKE.GvNodeMaster_AddUndo(swigCPtr);
    return ret;
  }

  public GvError Execute2(BaseThread thread, GvCalcFlags flags) {
    GvError ret = (GvError)C4dApiPINVOKE.GvNodeMaster_Execute2(swigCPtr, BaseThread.getCPtr(thread), (int)flags);
    return ret;
  }

}

}
