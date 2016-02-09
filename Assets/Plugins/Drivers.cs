//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Drivers : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Drivers(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Drivers obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Drivers() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Drivers(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static Drivers factory() {
    Drivers ret = new Drivers(yarpPINVOKE.Drivers_factory(), false);
    return ret;
  }

  public DeviceDriver open(string device) {
    global::System.IntPtr cPtr = yarpPINVOKE.Drivers_open__SWIG_0(swigCPtr, device);
    DeviceDriver ret = (cPtr == global::System.IntPtr.Zero) ? null : new DeviceDriver(cPtr, false);
    return ret;
  }

  public virtual DeviceDriver open(Searchable config) {
    global::System.IntPtr cPtr = yarpPINVOKE.Drivers_open__SWIG_1(swigCPtr, Searchable.getCPtr(config));
    DeviceDriver ret = (cPtr == global::System.IntPtr.Zero) ? null : new DeviceDriver(cPtr, false);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new string toString() {
    string ret = yarpPINVOKE.Drivers_toString(swigCPtr);
    return ret;
  }

  public void add(DriverCreator creator) {
    yarpPINVOKE.Drivers_add(swigCPtr, DriverCreator.getCPtr(creator));
  }

  public new DriverCreator find(string name) {
    global::System.IntPtr cPtr = yarpPINVOKE.Drivers_find(swigCPtr, name);
    DriverCreator ret = (cPtr == global::System.IntPtr.Zero) ? null : new DriverCreator(cPtr, false);
    return ret;
  }

  public bool remove(string name) {
    bool ret = yarpPINVOKE.Drivers_remove(swigCPtr, name);
    return ret;
  }

  public static int yarpdev(int argc, SWIGTYPE_p_p_char argv) {
    int ret = yarpPINVOKE.Drivers_yarpdev(argc, SWIGTYPE_p_p_char.getCPtr(argv));
    return ret;
  }

}
