//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class GazeEventVariables : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GazeEventVariables(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GazeEventVariables obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GazeEventVariables() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_GazeEventVariables(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string type {
    set {
      yarpPINVOKE.GazeEventVariables_type_set(swigCPtr, value);
      if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = yarpPINVOKE.GazeEventVariables_type_get(swigCPtr);
      if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double time {
    set {
      yarpPINVOKE.GazeEventVariables_time_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.GazeEventVariables_time_get(swigCPtr);
      return ret;
    } 
  }

  public double motionOngoingCheckPoint {
    set {
      yarpPINVOKE.GazeEventVariables_motionOngoingCheckPoint_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.GazeEventVariables_motionOngoingCheckPoint_get(swigCPtr);
      return ret;
    } 
  }

  public GazeEventVariables() : this(yarpPINVOKE.new_GazeEventVariables(), true) {
  }

}
