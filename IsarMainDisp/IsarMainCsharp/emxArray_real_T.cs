//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class emxArray_real_T : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal emxArray_real_T(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(emxArray_real_T obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~emxArray_real_T() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          IsarMaincsPINVOKE.delete_emxArray_real_T(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_real_T data {
    set {
      IsarMaincsPINVOKE.emxArray_real_T_data_set(swigCPtr, SWIGTYPE_p_real_T.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = IsarMaincsPINVOKE.emxArray_real_T_data_get(swigCPtr);
      SWIGTYPE_p_real_T ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_real_T(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int32_T size {
    set {
      IsarMaincsPINVOKE.emxArray_real_T_size_set(swigCPtr, SWIGTYPE_p_int32_T.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = IsarMaincsPINVOKE.emxArray_real_T_size_get(swigCPtr);
      SWIGTYPE_p_int32_T ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int32_T(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int32_T allocatedSize {
    set {
      IsarMaincsPINVOKE.emxArray_real_T_allocatedSize_set(swigCPtr, SWIGTYPE_p_int32_T.getCPtr(value));
      if (IsarMaincsPINVOKE.SWIGPendingException.Pending) throw IsarMaincsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_int32_T ret = new SWIGTYPE_p_int32_T(IsarMaincsPINVOKE.emxArray_real_T_allocatedSize_get(swigCPtr), true);
      if (IsarMaincsPINVOKE.SWIGPendingException.Pending) throw IsarMaincsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_int32_T numDimensions {
    set {
      IsarMaincsPINVOKE.emxArray_real_T_numDimensions_set(swigCPtr, SWIGTYPE_p_int32_T.getCPtr(value));
      if (IsarMaincsPINVOKE.SWIGPendingException.Pending) throw IsarMaincsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_int32_T ret = new SWIGTYPE_p_int32_T(IsarMaincsPINVOKE.emxArray_real_T_numDimensions_get(swigCPtr), true);
      if (IsarMaincsPINVOKE.SWIGPendingException.Pending) throw IsarMaincsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_boolean_T canFreeData {
    set {
      IsarMaincsPINVOKE.emxArray_real_T_canFreeData_set(swigCPtr, SWIGTYPE_p_boolean_T.getCPtr(value));
      if (IsarMaincsPINVOKE.SWIGPendingException.Pending) throw IsarMaincsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_boolean_T ret = new SWIGTYPE_p_boolean_T(IsarMaincsPINVOKE.emxArray_real_T_canFreeData_get(swigCPtr), true);
      if (IsarMaincsPINVOKE.SWIGPendingException.Pending) throw IsarMaincsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public emxArray_real_T() : this(IsarMaincsPINVOKE.new_emxArray_real_T(), true) {
  }

}
