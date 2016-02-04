/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PolyDriver : DeviceDriver {
  private HandleRef swigCPtr;

  internal PolyDriver(IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.PolyDriver_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PolyDriver obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PolyDriver() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PolyDriver(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PolyDriver() : this(yarpPINVOKE.new_PolyDriver__SWIG_0(), true) {
  }

  public PolyDriver(string txt) : this(yarpPINVOKE.new_PolyDriver__SWIG_1(txt), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public PolyDriver(Searchable config) : this(yarpPINVOKE.new_PolyDriver__SWIG_2(Searchable.getCPtr(config)), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool open_str(string txt) {
    bool ret = yarpPINVOKE.PolyDriver_open_str(swigCPtr, txt);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool open(Searchable config) {
    bool ret = yarpPINVOKE.PolyDriver_open(swigCPtr, Searchable.getCPtr(config));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool link(PolyDriver alt) {
    bool ret = yarpPINVOKE.PolyDriver_link(swigCPtr, PolyDriver.getCPtr(alt));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DeviceDriver take() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_take(swigCPtr);
    DeviceDriver ret = (cPtr == IntPtr.Zero) ? null : new DeviceDriver(cPtr, false);
    return ret;
  }

  public bool give(DeviceDriver dd, bool own) {
    bool ret = yarpPINVOKE.PolyDriver_give(swigCPtr, DeviceDriver.getCPtr(dd), own);
    return ret;
  }

  public override bool close() {
    bool ret = yarpPINVOKE.PolyDriver_close(swigCPtr);
    return ret;
  }

  public bool isValid() {
    bool ret = yarpPINVOKE.PolyDriver_isValid(swigCPtr);
    return ret;
  }

  public Bottle getOptions() {
    Bottle ret = new Bottle(yarpPINVOKE.PolyDriver_getOptions(swigCPtr), true);
    return ret;
  }

  public string getComment(string option) {
    string ret = yarpPINVOKE.PolyDriver_getComment(swigCPtr, option);
    return ret;
  }

  public Value getDefaultValue(string option) {
    Value ret = new Value(yarpPINVOKE.PolyDriver_getDefaultValue(swigCPtr, option), true);
    return ret;
  }

  public Value getValue(string option) {
    Value ret = new Value(yarpPINVOKE.PolyDriver_getValue(swigCPtr, option), true);
    return ret;
  }

  public override DeviceDriver getImplementation() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_getImplementation(swigCPtr);
    DeviceDriver ret = (cPtr == IntPtr.Zero) ? null : new DeviceDriver(cPtr, false);
    return ret;
  }

  public IFrameGrabberImage viewFrameGrabberImage() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewFrameGrabberImage(swigCPtr);
    IFrameGrabberImage ret = (cPtr == IntPtr.Zero) ? null : new IFrameGrabberImage(cPtr, false);
    return ret;
  }

  public IPositionControl viewIPositionControl() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIPositionControl(swigCPtr);
    IPositionControl ret = (cPtr == IntPtr.Zero) ? null : new IPositionControl(cPtr, false);
    return ret;
  }

  public IVelocityControl viewIVelocityControl() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIVelocityControl(swigCPtr);
    IVelocityControl ret = (cPtr == IntPtr.Zero) ? null : new IVelocityControl(cPtr, false);
    return ret;
  }

  public IEncoders viewIEncoders() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIEncoders(swigCPtr);
    IEncoders ret = (cPtr == IntPtr.Zero) ? null : new IEncoders(cPtr, false);
    return ret;
  }

  public IPidControl viewIPidControl() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIPidControl(swigCPtr);
    IPidControl ret = (cPtr == IntPtr.Zero) ? null : new IPidControl(cPtr, false);
    return ret;
  }

  public IAmplifierControl viewIAmplifierControl() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIAmplifierControl(swigCPtr);
    IAmplifierControl ret = (cPtr == IntPtr.Zero) ? null : new IAmplifierControl(cPtr, false);
    return ret;
  }

  public IControlLimits viewIControlLimits() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIControlLimits(swigCPtr);
    IControlLimits ret = (cPtr == IntPtr.Zero) ? null : new IControlLimits(cPtr, false);
    return ret;
  }

  public ICartesianControl viewICartesianControl() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewICartesianControl(swigCPtr);
    ICartesianControl ret = (cPtr == IntPtr.Zero) ? null : new ICartesianControl(cPtr, false);
    return ret;
  }

  public IGazeControl viewIGazeControl() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIGazeControl(swigCPtr);
    IGazeControl ret = (cPtr == IntPtr.Zero) ? null : new IGazeControl(cPtr, false);
    return ret;
  }

  public IImpedanceControl viewIImpedanceControl() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIImpedanceControl(swigCPtr);
    IImpedanceControl ret = (cPtr == IntPtr.Zero) ? null : new IImpedanceControl(cPtr, false);
    return ret;
  }

  public ITorqueControl viewITorqueControl() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewITorqueControl(swigCPtr);
    ITorqueControl ret = (cPtr == IntPtr.Zero) ? null : new ITorqueControl(cPtr, false);
    return ret;
  }

  public IControlMode viewIControlMode() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIControlMode(swigCPtr);
    IControlMode ret = (cPtr == IntPtr.Zero) ? null : new IControlMode(cPtr, false);
    return ret;
  }

  public IOpenLoopControl viewIOpenLoopControl() {
    IntPtr cPtr = yarpPINVOKE.PolyDriver_viewIOpenLoopControl(swigCPtr);
    IOpenLoopControl ret = (cPtr == IntPtr.Zero) ? null : new IOpenLoopControl(cPtr, false);
    return ret;
  }

}
