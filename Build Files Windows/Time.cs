//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Time : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Time(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Time obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Time() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Time(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static void delay(double seconds) {
    yarpPINVOKE.Time_delay(seconds);
  }

  public static double now() {
    double ret = yarpPINVOKE.Time_now();
    return ret;
  }

  public static void yield() {
    yarpPINVOKE.Time_yield();
  }

  public static void turboBoost() {
    yarpPINVOKE.Time_turboBoost();
  }

  public static void useSystemClock() {
    yarpPINVOKE.Time_useSystemClock();
  }

  public static void useNetworkClock(string clock) {
    yarpPINVOKE.Time_useNetworkClock(clock);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void useCustomClock(SWIGTYPE_p_Clock clock) {
    yarpPINVOKE.Time_useCustomClock(SWIGTYPE_p_Clock.getCPtr(clock));
  }

  public static bool isSystemClock() {
    bool ret = yarpPINVOKE.Time_isSystemClock();
    return ret;
  }

  public static bool isValid() {
    bool ret = yarpPINVOKE.Time_isValid();
    return ret;
  }

  public Time() : this(yarpPINVOKE.new_Time(), true) {
  }

}
