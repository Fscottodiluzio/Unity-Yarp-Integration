//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class BufferedPortImageRgbFloat : Contactable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BufferedPortImageRgbFloat(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.BufferedPortImageRgbFloat_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BufferedPortImageRgbFloat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BufferedPortImageRgbFloat() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_BufferedPortImageRgbFloat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new void onRead(ImageRgbFloat datum, TypedReaderImageRgbFloat reader) {
    yarpPINVOKE.BufferedPortImageRgbFloat_onRead__SWIG_0_0(swigCPtr, ImageRgbFloat.getCPtr(datum), TypedReaderImageRgbFloat.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public BufferedPortImageRgbFloat() : this(yarpPINVOKE.new_BufferedPortImageRgbFloat__SWIG_0(), true) {
  }

  public BufferedPortImageRgbFloat(Port port) : this(yarpPINVOKE.new_BufferedPortImageRgbFloat__SWIG_1(Port.getCPtr(port)), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool addOutput(string name) {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_addOutput__SWIG_0(swigCPtr, name);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool addOutput(string name, string carrier) {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_addOutput__SWIG_1(swigCPtr, name, carrier);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool addOutput(Contact contact) {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_addOutput__SWIG_2(swigCPtr, Contact.getCPtr(contact));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void close() {
    yarpPINVOKE.BufferedPortImageRgbFloat_close(swigCPtr);
  }

  public override void interrupt() {
    yarpPINVOKE.BufferedPortImageRgbFloat_interrupt(swigCPtr);
  }

  public override void resume() {
    yarpPINVOKE.BufferedPortImageRgbFloat_resume(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.BufferedPortImageRgbFloat_getPendingReads(swigCPtr);
    return ret;
  }

  public override Contact where() {
    Contact ret = new Contact(yarpPINVOKE.BufferedPortImageRgbFloat_where(swigCPtr), true);
    return ret;
  }

  public override string getName() {
    string ret = yarpPINVOKE.BufferedPortImageRgbFloat_getName(swigCPtr);
    return ret;
  }

  public ImageRgbFloat prepare() {
    ImageRgbFloat ret = new ImageRgbFloat(yarpPINVOKE.BufferedPortImageRgbFloat_prepare(swigCPtr), false);
    return ret;
  }

  public bool unprepare() {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_unprepare(swigCPtr);
    return ret;
  }

  public new void write(bool forceStrict) {
    yarpPINVOKE.BufferedPortImageRgbFloat_write__SWIG_0(swigCPtr, forceStrict);
  }

  public new void write() {
    yarpPINVOKE.BufferedPortImageRgbFloat_write__SWIG_1(swigCPtr);
  }

  public void writeStrict() {
    yarpPINVOKE.BufferedPortImageRgbFloat_writeStrict(swigCPtr);
  }

  public void waitForWrite() {
    yarpPINVOKE.BufferedPortImageRgbFloat_waitForWrite(swigCPtr);
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.BufferedPortImageRgbFloat_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.BufferedPortImageRgbFloat_setStrict__SWIG_1(swigCPtr);
  }

  public new ImageRgbFloat read(bool shouldWait) {
    global::System.IntPtr cPtr = yarpPINVOKE.BufferedPortImageRgbFloat_read__SWIG_0(swigCPtr, shouldWait);
    ImageRgbFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageRgbFloat(cPtr, false);
    return ret;
  }

  public new ImageRgbFloat read() {
    global::System.IntPtr cPtr = yarpPINVOKE.BufferedPortImageRgbFloat_read__SWIG_1(swigCPtr);
    ImageRgbFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageRgbFloat(cPtr, false);
    return ret;
  }

  public new ImageRgbFloat lastRead() {
    global::System.IntPtr cPtr = yarpPINVOKE.BufferedPortImageRgbFloat_lastRead(swigCPtr);
    ImageRgbFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageRgbFloat(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_isClosed(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.BufferedPortImageRgbFloat_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReader(PortReader reader) {
    yarpPINVOKE.BufferedPortImageRgbFloat_setReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setAdminReader(PortReader reader) {
    yarpPINVOKE.BufferedPortImageRgbFloat_setAdminReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(ImageRgbFloat datum) {
    yarpPINVOKE.BufferedPortImageRgbFloat_onRead__SWIG_1(swigCPtr, ImageRgbFloat.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback(TypedReaderCallbackImageRgbFloat callback) {
    yarpPINVOKE.BufferedPortImageRgbFloat_useCallback__SWIG_0(swigCPtr, TypedReaderCallbackImageRgbFloat.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback() {
    yarpPINVOKE.BufferedPortImageRgbFloat_useCallback__SWIG_1(swigCPtr);
  }

  public virtual void disableCallback() {
    yarpPINVOKE.BufferedPortImageRgbFloat_disableCallback(swigCPtr);
  }

  public override bool setEnvelope(PortWriter envelope) {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_setEnvelope(swigCPtr, PortWriter.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool getEnvelope(PortReader envelope) {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_getEnvelope(swigCPtr, PortReader.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getInputCount() {
    int ret = yarpPINVOKE.BufferedPortImageRgbFloat_getInputCount(swigCPtr);
    return ret;
  }

  public override int getOutputCount() {
    int ret = yarpPINVOKE.BufferedPortImageRgbFloat_getOutputCount(swigCPtr);
    return ret;
  }

  public override bool isWriting() {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_isWriting(swigCPtr);
    return ret;
  }

  public override void getReport(PortReport reporter) {
    yarpPINVOKE.BufferedPortImageRgbFloat_getReport(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReporter(PortReport reporter) {
    yarpPINVOKE.BufferedPortImageRgbFloat_setReporter(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual System.IntPtr acquire() { return yarpPINVOKE.BufferedPortImageRgbFloat_acquire(swigCPtr); }

  public virtual void release(System.IntPtr handle) {
    yarpPINVOKE.BufferedPortImageRgbFloat_release(swigCPtr, handle);
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.BufferedPortImageRgbFloat_setTargetPeriod(swigCPtr, period);
  }

  public override SWIGTYPE_p_Type getType() {
    SWIGTYPE_p_Type ret = new SWIGTYPE_p_Type(yarpPINVOKE.BufferedPortImageRgbFloat_getType(swigCPtr), true);
    return ret;
  }

  public override void promiseType(SWIGTYPE_p_Type typ) {
    yarpPINVOKE.BufferedPortImageRgbFloat_promiseType(swigCPtr, SWIGTYPE_p_Type.getCPtr(typ));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setInputMode(bool expectInput) {
    yarpPINVOKE.BufferedPortImageRgbFloat_setInputMode(swigCPtr, expectInput);
  }

  public override void setOutputMode(bool expectOutput) {
    yarpPINVOKE.BufferedPortImageRgbFloat_setOutputMode(swigCPtr, expectOutput);
  }

  public override void setRpcMode(bool expectRpc) {
    yarpPINVOKE.BufferedPortImageRgbFloat_setRpcMode(swigCPtr, expectRpc);
  }

  public override Property acquireProperties(bool readOnly) {
    global::System.IntPtr cPtr = yarpPINVOKE.BufferedPortImageRgbFloat_acquireProperties(swigCPtr, readOnly);
    Property ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public override void releaseProperties(Property prop) {
    yarpPINVOKE.BufferedPortImageRgbFloat_releaseProperties(swigCPtr, Property.getCPtr(prop));
  }

  public override void includeNodeInName(bool flag) {
    yarpPINVOKE.BufferedPortImageRgbFloat_includeNodeInName(swigCPtr, flag);
  }

  public override bool setCallbackLock(SWIGTYPE_p_yarp__os__Mutex mutex) {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_setCallbackLock(swigCPtr, SWIGTYPE_p_yarp__os__Mutex.getCPtr(mutex));
    return ret;
  }

  public override bool removeCallbackLock() {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_removeCallbackLock(swigCPtr);
    return ret;
  }

  public override bool lockCallback() {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_lockCallback(swigCPtr);
    return ret;
  }

  public override bool tryLockCallback() {
    bool ret = yarpPINVOKE.BufferedPortImageRgbFloat_tryLockCallback(swigCPtr);
    return ret;
  }

  public override void unlockCallback() {
    yarpPINVOKE.BufferedPortImageRgbFloat_unlockCallback(swigCPtr);
  }

}
