//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ITorqueControl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ITorqueControl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ITorqueControl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ITorqueControl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ITorqueControl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool getAxes(SWIGTYPE_p_int ax) {
    bool ret = yarpPINVOKE.ITorqueControl_getAxes(swigCPtr, SWIGTYPE_p_int.getCPtr(ax));
    return ret;
  }

  public virtual bool setTorqueMode() {
    bool ret = yarpPINVOKE.ITorqueControl_setTorqueMode(swigCPtr);
    return ret;
  }

  public virtual bool getRefTorques(SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControl_getRefTorques(swigCPtr, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getRefTorque(int j, SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControl_getRefTorque(swigCPtr, j, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool setRefTorques(SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControl_setRefTorques__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool setRefTorque(int j, double t) {
    bool ret = yarpPINVOKE.ITorqueControl_setRefTorque(swigCPtr, j, t);
    return ret;
  }

  public virtual bool setRefTorques(int n_joint, SWIGTYPE_p_int joints, SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControl_setRefTorques__SWIG_1(swigCPtr, n_joint, SWIGTYPE_p_int.getCPtr(joints), SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getBemfParam(int j, SWIGTYPE_p_double bemf) {
    bool ret = yarpPINVOKE.ITorqueControl_getBemfParam(swigCPtr, j, SWIGTYPE_p_double.getCPtr(bemf));
    return ret;
  }

  public virtual bool setBemfParam(int j, double bemf) {
    bool ret = yarpPINVOKE.ITorqueControl_setBemfParam(swigCPtr, j, bemf);
    return ret;
  }

  public virtual bool getMotorTorqueParams(int j, MotorTorqueParameters arg1) {
    bool ret = yarpPINVOKE.ITorqueControl_getMotorTorqueParams(swigCPtr, j, MotorTorqueParameters.getCPtr(arg1));
    return ret;
  }

  public virtual bool setMotorTorqueParams(int j, MotorTorqueParameters arg1) {
    bool ret = yarpPINVOKE.ITorqueControl_setMotorTorqueParams(swigCPtr, j, MotorTorqueParameters.getCPtr(arg1));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool setTorquePid(int j, Pid pid) {
    bool ret = yarpPINVOKE.ITorqueControl_setTorquePid(swigCPtr, j, Pid.getCPtr(pid));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getTorque(int j, SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorque(swigCPtr, j, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getTorques(SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorques(swigCPtr, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getTorqueRange(int j, SWIGTYPE_p_double min, SWIGTYPE_p_double max) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorqueRange(swigCPtr, j, SWIGTYPE_p_double.getCPtr(min), SWIGTYPE_p_double.getCPtr(max));
    return ret;
  }

  public virtual bool getTorqueRanges(SWIGTYPE_p_double min, SWIGTYPE_p_double max) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorqueRanges(swigCPtr, SWIGTYPE_p_double.getCPtr(min), SWIGTYPE_p_double.getCPtr(max));
    return ret;
  }

  public virtual bool setTorquePids(Pid pids) {
    bool ret = yarpPINVOKE.ITorqueControl_setTorquePids(swigCPtr, Pid.getCPtr(pids));
    return ret;
  }

  public virtual bool setTorqueErrorLimit(int j, double limit) {
    bool ret = yarpPINVOKE.ITorqueControl_setTorqueErrorLimit(swigCPtr, j, limit);
    return ret;
  }

  public virtual bool setTorqueErrorLimits(SWIGTYPE_p_double limits) {
    bool ret = yarpPINVOKE.ITorqueControl_setTorqueErrorLimits(swigCPtr, SWIGTYPE_p_double.getCPtr(limits));
    return ret;
  }

  public virtual bool getTorqueError(int j, SWIGTYPE_p_double err) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorqueError(swigCPtr, j, SWIGTYPE_p_double.getCPtr(err));
    return ret;
  }

  public virtual bool getTorqueErrors(SWIGTYPE_p_double errs) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorqueErrors(swigCPtr, SWIGTYPE_p_double.getCPtr(errs));
    return ret;
  }

  public virtual bool getTorquePidOutput(int j, SWIGTYPE_p_double arg1) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorquePidOutput(swigCPtr, j, SWIGTYPE_p_double.getCPtr(arg1));
    return ret;
  }

  public virtual bool getTorquePidOutputs(SWIGTYPE_p_double outs) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorquePidOutputs(swigCPtr, SWIGTYPE_p_double.getCPtr(outs));
    return ret;
  }

  public virtual bool getTorquePid(int j, Pid pid) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorquePid(swigCPtr, j, Pid.getCPtr(pid));
    return ret;
  }

  public virtual bool getTorquePids(Pid pids) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorquePids(swigCPtr, Pid.getCPtr(pids));
    return ret;
  }

  public virtual bool getTorqueErrorLimit(int j, SWIGTYPE_p_double limit) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorqueErrorLimit(swigCPtr, j, SWIGTYPE_p_double.getCPtr(limit));
    return ret;
  }

  public virtual bool getTorqueErrorLimits(SWIGTYPE_p_double limits) {
    bool ret = yarpPINVOKE.ITorqueControl_getTorqueErrorLimits(swigCPtr, SWIGTYPE_p_double.getCPtr(limits));
    return ret;
  }

  public virtual bool resetTorquePid(int j) {
    bool ret = yarpPINVOKE.ITorqueControl_resetTorquePid(swigCPtr, j);
    return ret;
  }

  public virtual bool disableTorquePid(int j) {
    bool ret = yarpPINVOKE.ITorqueControl_disableTorquePid(swigCPtr, j);
    return ret;
  }

  public virtual bool enableTorquePid(int j) {
    bool ret = yarpPINVOKE.ITorqueControl_enableTorquePid(swigCPtr, j);
    return ret;
  }

  public virtual bool setTorqueOffset(int j, double v) {
    bool ret = yarpPINVOKE.ITorqueControl_setTorqueOffset(swigCPtr, j, v);
    return ret;
  }

}
